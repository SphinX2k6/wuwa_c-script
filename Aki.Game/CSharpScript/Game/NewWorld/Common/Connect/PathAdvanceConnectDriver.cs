using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Audio;
using AkiClient.Game.Aki.Render.RuntimeBP.PCG.RoadSpline;
using CSharpScript.Game.LevelGamePlay.Common;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Common.Connect
{
	// Token: 0x020061FA RID: 25082
	[NullableContext(1)]
	[Nullable(0)]
	public class PathAdvanceConnectDriver
	{
		// Token: 0x0603C3B1 RID: 246705 RVA: 0x0112805C File Offset: 0x0112625C
		public PathAdvanceConnectDriver(Entity entity, IConnectorPointToPointPathAdvance config, Action<int> onReachEnd, Action<int> onWithdraw)
		{
			this.Entity = entity;
			this.Config = config;
			this.OnReachEnd = onReachEnd;
			this.OnWithdraw = onWithdraw;
		}

		// Token: 0x0603C3B2 RID: 246706 RVA: 0x011280FC File Offset: 0x011262FC
		public bool Start()
		{
			this.Initiator = this.Config.Initiator;
			if (this.Initiator == null)
			{
				return true;
			}
			CreatureDataComponent component = this.Entity.GetComponent<CreatureDataComponent>();
			this.PbDataId = ((component != null) ? component.GetPbDataId() : 0);
			if (this.Initiator.Paths == null || this.Initiator.Paths.Count <= 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Level;
				ELogAuthor author = ELogAuthor.WRY;
				string message = "[PathAdvanceConnectDriver.Start] 发起方配置缺少推进路径";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", this.PbDataId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.Initiator = null;
				return false;
			}
			this.StateComp = this.Entity.GetComponent<SceneItemStateComponent>();
			this.ActiveStateTagId = GameplayTagUtils.GetTagIdByName(this.Initiator.ActiveState);
			this.WaitTargetEntity();
			IConnectorPathAdvanceVasePlantVisual visualConfig = this.Initiator.VisualConfig;
			if (visualConfig != null && visualConfig.Type == EConnectorPathAdvanceVisualType.VasePlant)
			{
				this.RequestScatterClass();
				this.PreloadPathTextures();
			}
			return true;
		}

		// Token: 0x0603C3B3 RID: 246707 RVA: 0x011281F4 File Offset: 0x011263F4
		public void Tick(float delta)
		{
			if (this.Initiator == null || !this.IsDriveReady())
			{
				this.PauseGrowthAudio();
				return;
			}
			if (this.RestorePending)
			{
				this.RestorePending = false;
				if (!this.Reached)
				{
					this.RestoreGrown();
				}
			}
			float deltaSeconds = delta * 0.001f;
			if (this.Withdrawing)
			{
				this.Recede(deltaSeconds);
				if (!this.Started)
				{
					this.Withdrawing = false;
				}
				return;
			}
			if (this.IsActive())
			{
				this.Advance(deltaSeconds);
				return;
			}
			this.NotifyWithdrawOnce();
			this.Recede(deltaSeconds);
		}

		// Token: 0x0603C3B4 RID: 246708 RVA: 0x01128279 File Offset: 0x01126479
		public void Withdraw()
		{
			if (this.Initiator == null || !this.Started)
			{
				return;
			}
			this.RestorePending = false;
			this.PauseGrowthAudio();
			this.NotifyWithdrawOnce();
			this.Withdrawing = true;
		}

		// Token: 0x0603C3B5 RID: 246709 RVA: 0x011282A6 File Offset: 0x011264A6
		public void SetRestorePending(bool restorePending)
		{
			this.RestorePending = restorePending;
		}

		// Token: 0x0603C3B6 RID: 246710 RVA: 0x011282B0 File Offset: 0x011264B0
		public void End()
		{
			WaitEntityTask targetWaitTask = this.TargetWaitTask;
			if (targetWaitTask != null)
			{
				targetWaitTask.Cancel();
			}
			this.TargetWaitTask = null;
			this.StopGrowthAudio();
			foreach (ScatterSegment scatterSegment in this.ScatterSegments)
			{
				if (scatterSegment.Actor != null)
				{
					ActorSystem.Instance.Put("PathAdvanceConnectDriver.End", scatterSegment.Actor, null);
					scatterSegment.Actor = null;
				}
			}
			this.ScatterSegments.Clear();
			foreach (int splineId in this.LoadedSplineIds)
			{
				GameSplineModel instance = GameSplineModel.Instance;
				if (instance != null)
				{
					instance.ReleaseSpline(splineId, (long)this.PbDataId, EIdType.PbDataId);
				}
			}
			this.LoadedSplineIds.Clear();
			this.Spline = null;
			this.ResetActorIgnoreCache(this.SelfActorIgnoreCache);
			this.ResetActorIgnoreCache(this.TargetActorIgnoreCache);
			this.SetConstantTick(false);
			this.Initiator = null;
		}

		// Token: 0x0603C3B7 RID: 246711 RVA: 0x011283D8 File Offset: 0x011265D8
		private void SetConstantTick(bool enabled)
		{
			if (enabled)
			{
				IConnectorPathAdvanceVasePlantVisual visualConfig = this.Initiator.VisualConfig;
				if (visualConfig == null || visualConfig.Type > EConnectorPathAdvanceVisualType.VasePlant)
				{
					return;
				}
			}
			if (this.ConstantTickEnabled == enabled)
			{
				return;
			}
			TsGameBudgetGroupConfig gameBudgetConfig = this.Entity.GameBudgetConfig;
			uint gameBudgetManagedToken = this.Entity.GameBudgetManagedToken;
			if (gameBudgetConfig == null || gameBudgetManagedToken == 0U)
			{
				if (!enabled)
				{
					this.ConstantTickEnabled = false;
				}
				return;
			}
			UKuroGameBudgetAllocatorCSharpInterface.SetConstantTick(gameBudgetConfig.GroupName, gameBudgetManagedToken, enabled, false);
			this.ConstantTickEnabled = enabled;
		}

		// Token: 0x0603C3B8 RID: 246712 RVA: 0x0112844D File Offset: 0x0112664D
		private bool IsActive()
		{
			return this.StateComp != null && this.ActiveStateTagId != 0 && this.StateComp.StateTagId == this.ActiveStateTagId;
		}

		// Token: 0x0603C3B9 RID: 246713 RVA: 0x01128474 File Offset: 0x01126674
		private void WaitTargetEntity()
		{
			if (this.GetTargetEntity() != null)
			{
				this.TargetReady = true;
				return;
			}
			this.TargetWaitTask = WaitEntityTask.CreateWithPbDataId("PathAdvanceConnectDriver.WaitTargetEntity", this.Initiator.TargetEntity, delegate(bool? result)
			{
				this.TargetWaitTask = null;
				this.TargetReady = result.GetValueOrDefault();
			}, -1, false, false);
		}

		// Token: 0x0603C3BA RID: 246714 RVA: 0x011284B0 File Offset: 0x011266B0
		[NullableContext(2)]
		private Entity GetTargetEntity()
		{
			CreatureModel instance = CreatureModel.Instance;
			if (instance == null)
			{
				return null;
			}
			EntityHandle entityByPbDataId = instance.GetEntityByPbDataId(this.Initiator.TargetEntity);
			if (entityByPbDataId == null)
			{
				return null;
			}
			return entityByPbDataId.Entity;
		}

		// Token: 0x0603C3BB RID: 246715 RVA: 0x011284D8 File Offset: 0x011266D8
		private bool IsDriveReady()
		{
			if (!this.TargetReady)
			{
				return false;
			}
			IConnectorPathAdvanceVasePlantVisual visualConfig = this.Initiator.VisualConfig;
			return visualConfig == null || visualConfig.Type > EConnectorPathAdvanceVisualType.VasePlant || this.ScatterClassReady;
		}

		// Token: 0x0603C3BC RID: 246716 RVA: 0x01128508 File Offset: 0x01126708
		private void RestoreGrown()
		{
			this.StopGrowthAudio();
			int num = this.Initiator.Paths.Count - 1;
			for (int i = 0; i < num; i++)
			{
				USplineComponent usplineComponent = this.AcquireSpline(this.Initiator.Paths[i]);
				if (usplineComponent != null && usplineComponent.IsValid())
				{
					this.EnsureScatterActor(i, 1f, usplineComponent);
				}
			}
			this.Started = true;
			this.Reached = true;
			this.EnterPath(num, false);
		}

		// Token: 0x0603C3BD RID: 246717 RVA: 0x01128588 File Offset: 0x01126788
		private unsafe void Advance(float deltaSeconds)
		{
			if (this.Reached)
			{
				return;
			}
			if (!this.Started)
			{
				this.Started = true;
				this.EnterPath(0, true);
			}
			USplineComponent spline = this.Spline;
			if (spline == null || !spline.IsValid())
			{
				this.PauseGrowthAudio();
				if (!this.SplineInvalidLogged)
				{
					this.SplineInvalidLogged = true;
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Level;
					ELogAuthor author = ELogAuthor.WRY;
					string message = "[PathAdvanceConnectDriver.Advance] 样条失效，推进暂停";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.PbDataId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PathIndex", this.PathIndex);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				return;
			}
			this.SplineInvalidLogged = false;
			if (!this.Reached)
			{
				this.SetConstantTick(true);
			}
			ValueTuple<float, string> valueTuple = this.ScanObstacle(deltaSeconds);
			float currentDistance = this.CurrentDistance;
			float num = this.CurrentDistance + this.Initiator.AdvanceSpeed * deltaSeconds;
			float num2 = Math.Min(num, valueTuple.Item1);
			this.CurrentDistance = Math.Clamp(num2, 0f, this.SplineLength);
			bool flag = num2 < num;
			if (flag != this.Blocked)
			{
				this.Blocked = flag;
			}
			float progress = (this.SplineLength > 0f) ? (this.CurrentDistance / this.SplineLength) : 1f;
			if (this.CurrentDistance != currentDistance)
			{
				this.LogProgress(progress);
			}
			this.ApplyProgress(this.PathIndex, progress);
			if (!flag && this.CurrentDistance > currentDistance)
			{
				this.PlayOrResumeGrowthAudio();
			}
			else
			{
				this.PauseGrowthAudio();
			}
			if (this.SplineLength - this.CurrentDistance > 1f)
			{
				return;
			}
			if (this.PathIndex < this.Initiator.Paths.Count - 1)
			{
				this.ApplyProgress(this.PathIndex, 1f);
				this.EnterPath(this.PathIndex + 1, true);
				return;
			}
			if (!this.Reached)
			{
				this.Reached = true;
				this.StopGrowthAudio();
				this.SetConstantTick(false);
				this.OnReachEnd(this.Initiator.TargetEntity);
			}
		}

		// Token: 0x0603C3BE RID: 246718 RVA: 0x0112879E File Offset: 0x0112699E
		private void LogProgress(float progress)
		{
		}

		// Token: 0x0603C3BF RID: 246719 RVA: 0x011287A0 File Offset: 0x011269A0
		private void NotifyWithdrawOnce()
		{
			if (!this.Reached)
			{
				return;
			}
			this.Reached = false;
			this.OnWithdraw(this.Initiator.TargetEntity);
		}

		// Token: 0x0603C3C0 RID: 246720 RVA: 0x011287C8 File Offset: 0x011269C8
		private void Recede(float deltaSeconds)
		{
			this.PauseGrowthAudio();
			if (!this.Started)
			{
				return;
			}
			if (this.PathIndex <= 0 && this.CurrentDistance <= 0f)
			{
				this.Started = false;
				this.StopGrowthAudio();
				this.SetConstantTick(false);
				return;
			}
			USplineComponent spline = this.Spline;
			if (spline == null || !spline.IsValid())
			{
				return;
			}
			this.SetConstantTick(true);
			this.CurrentDistance -= this.Initiator.AdvanceSpeed * deltaSeconds;
			if (this.CurrentDistance > 0f)
			{
				float progress = this.CurrentDistance / this.SplineLength;
				this.LogProgress(progress);
				this.ApplyProgress(this.PathIndex, progress);
				return;
			}
			this.CurrentDistance = 0f;
			this.ApplyProgress(this.PathIndex, 0f);
			if (this.PathIndex > 0)
			{
				this.EnterPath(this.PathIndex - 1, false);
			}
		}

		// Token: 0x0603C3C1 RID: 246721 RVA: 0x011288AC File Offset: 0x01126AAC
		private unsafe void EnterPath(int index, bool forward)
		{
			int num = this.Initiator.Paths[index];
			USplineComponent usplineComponent = this.AcquireSpline(num);
			if (usplineComponent == null || !usplineComponent.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Level;
				ELogAuthor author = ELogAuthor.WRY;
				string message = "[PathAdvanceConnectDriver.EnterPath] 加载样条失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.PbDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SplineEntityId", num);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.PathIndex = index;
			this.Spline = usplineComponent;
			this.SplineLength = usplineComponent.GetSplineLength();
			this.CurrentDistance = (forward ? 0f : this.SplineLength);
			this.Blocked = false;
			this.PointDistances.Clear();
			int numberOfSplinePoints = usplineComponent.GetNumberOfSplinePoints();
			for (int i = 0; i < numberOfSplinePoints; i++)
			{
				this.PointDistances.Add(usplineComponent.GetDistanceAlongSplineAtSplinePoint(i));
			}
			this.EnsureScatterActor(index, !forward, usplineComponent);
			this.UpdateGrowthAudioPosition();
		}

		// Token: 0x0603C3C2 RID: 246722 RVA: 0x011289C8 File Offset: 0x01126BC8
		private void PlayOrResumeGrowthAudio()
		{
			if (!this.EnsureGrowthAudioActor())
			{
				return;
			}
			this.UpdateGrowthAudioPosition();
			if (this.GrowthAudioHandle == 0)
			{
				this.GrowthAudioHandle = AudioSystem.Instance.PostEvent("play_sfx_gp_flower_road", this.GrowthAudioActor.AkComponent, new PostEventArgs?(new PostEventArgs
				{
					StopWhenOwnerDestroyed = new bool?(true)
				}));
				this.GrowthAudioPaused = false;
				return;
			}
			if (!this.GrowthAudioPaused)
			{
				return;
			}
			AudioSystem.Instance.ExecuteAction(this.GrowthAudioHandle, EAudioActionType.Resume, null);
			this.GrowthAudioPaused = false;
		}

		// Token: 0x0603C3C3 RID: 246723 RVA: 0x01128A5C File Offset: 0x01126C5C
		private void PauseGrowthAudio()
		{
			if (this.GrowthAudioHandle == 0 || this.GrowthAudioPaused)
			{
				return;
			}
			AudioSystem.Instance.ExecuteAction(this.GrowthAudioHandle, EAudioActionType.Pause, null);
			this.GrowthAudioPaused = true;
		}

		// Token: 0x0603C3C4 RID: 246724 RVA: 0x01128A9C File Offset: 0x01126C9C
		private void StopGrowthAudio()
		{
			if (this.GrowthAudioHandle != 0)
			{
				AudioSystem.Instance.ExecuteAction(this.GrowthAudioHandle, EAudioActionType.Stop, null);
				this.GrowthAudioHandle = 0;
			}
			this.GrowthAudioPaused = false;
			BP_EffectAudio_C growthAudioActor = this.GrowthAudioActor;
			if (growthAudioActor != null && growthAudioActor.IsValid())
			{
				ActorSystem.Instance.Put("PathAdvanceConnectDriver.StopGrowthAudio", this.GrowthAudioActor, null);
			}
			this.GrowthAudioActor = null;
		}

		// Token: 0x0603C3C5 RID: 246725 RVA: 0x01128B0C File Offset: 0x01126D0C
		private bool EnsureGrowthAudioActor()
		{
			BP_EffectAudio_C growthAudioActor = this.GrowthAudioActor;
			if (growthAudioActor != null && growthAudioActor.IsValid())
			{
				return true;
			}
			if (this.GrowthAudioActor != null)
			{
				this.StopGrowthAudio();
			}
			BP_EffectAudio_C bp_EffectAudio_C = ActorSystem.Instance.Get(BP_EffectAudio_C.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true) as BP_EffectAudio_C;
			UAkComponent uakComponent = (bp_EffectAudio_C != null) ? bp_EffectAudio_C.AkComponent : null;
			if (uakComponent == null || !uakComponent.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Level;
				ELogAuthor author = ELogAuthor.WRY;
				string message = "[PathAdvanceConnectDriver.EnsureGrowthAudioActor] 获取独立音频Actor或AkComponent失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", this.PbDataId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				if (bp_EffectAudio_C != null)
				{
					ActorSystem.Instance.Put("PathAdvanceConnectDriver.EnsureGrowthAudioActor", bp_EffectAudio_C, null);
				}
				return false;
			}
			this.EmptyGrowthAudioLocationOffsets.Empty(true);
			uakComponent.SetLocationOffsets(this.EmptyGrowthAudioLocationOffsets);
			uakComponent.SetComponentTickEnabled(true);
			this.GrowthAudioActor = bp_EffectAudio_C;
			return true;
		}

		// Token: 0x0603C3C6 RID: 246726 RVA: 0x01128BEC File Offset: 0x01126DEC
		private void UpdateGrowthAudioPosition()
		{
			BP_EffectAudio_C growthAudioActor = this.GrowthAudioActor;
			if (growthAudioActor != null && growthAudioActor.IsValid())
			{
				USplineComponent spline = this.Spline;
				if (spline != null && spline.IsValid())
				{
					FVectorDouble newLocation = this.Spline.D_GetLocationAtDistanceAlongSpline(this.CurrentDistance, ESplineCoordinateSpace.World);
					this.GrowthAudioActor.D_K2_SetActorLocation(newLocation, false, ref WorldGlobal.SweepHitResult, true);
					return;
				}
			}
		}

		// Token: 0x0603C3C7 RID: 246727 RVA: 0x01128C4F File Offset: 0x01126E4F
		[NullableContext(2)]
		private USplineComponent AcquireSpline(int splineId)
		{
			GameSplineModel instance = GameSplineModel.Instance;
			USplineComponent usplineComponent = (instance != null) ? instance.LoadAndGetSplineComponent(splineId, this.PbDataId, EIdType.PbDataId) : null;
			if (usplineComponent != null && !this.LoadedSplineIds.Contains(splineId))
			{
				this.LoadedSplineIds.Add(splineId);
			}
			return usplineComponent;
		}

		// Token: 0x0603C3C8 RID: 246728 RVA: 0x01128C87 File Offset: 0x01126E87
		private void RequestScatterClass()
		{
			if (this.ScatterClassRequested)
			{
				return;
			}
			this.ScatterClassRequested = true;
			ResourceSystem.Instance.LoadTypeAsync(EBpTypeName.BP_SplineScatter_C.ToEnumString(), delegate
			{
				this.ScatterClassReady = true;
			}, "js_undefined");
		}

		// Token: 0x0603C3C9 RID: 246729 RVA: 0x01128CBC File Offset: 0x01126EBC
		private unsafe void PreloadPathTextures()
		{
			IConnectorPathAdvanceVasePlantVisual visualConfig = this.Initiator.VisualConfig;
			List<string> list = (visualConfig != null) ? visualConfig.PathRtList : null;
			if (list == null)
			{
				return;
			}
			for (int i = 0; i < list.Count; i++)
			{
				string texturePath = list[i];
				if (!string.IsNullOrEmpty(texturePath))
				{
					int capturedIndex = i;
					ResourceSystem.Instance.LoadAsync<UTexture2D>(texturePath, delegate([Nullable(2)] UTexture2D asset, string _)
					{
						if (asset == null)
						{
							Log instance = Log.Instance;
							ELogModule module = ELogModule.Level;
							ELogAuthor author = ELogAuthor.WRY;
							string message = "[PathAdvanceConnectDriver.PreloadPathTextures] 加载路径贴图失败，流淌表现将失效";
							<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.PbDataId);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PathIndex", capturedIndex);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("TexturePath", texturePath);
							instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
							return;
						}
						this.GetSegment(capturedIndex).Texture = asset;
						this.ApplyPathTexture(capturedIndex);
					}, 100, "js_undefined");
				}
			}
		}

		// Token: 0x0603C3CA RID: 246730 RVA: 0x01128D48 File Offset: 0x01126F48
		private void ApplyPathTexture(int index)
		{
			ScatterSegment scatterSegment = (index < this.ScatterSegments.Count) ? this.ScatterSegments[index] : null;
			if (((scatterSegment != null) ? scatterSegment.Texture : null) != null)
			{
				BP_SplineScatter_C actor = scatterSegment.Actor;
				if (actor != null && actor.IsValid() && !scatterSegment.MaterialReady.GetValueOrDefault())
				{
					scatterSegment.Actor.路径Texture = scatterSegment.Texture;
					scatterSegment.Actor.生成动态材质();
					scatterSegment.Actor.LastGrowthTime = -1f;
					scatterSegment.MaterialReady = new bool?(true);
					return;
				}
			}
		}

		// Token: 0x0603C3CB RID: 246731 RVA: 0x01128DDE File Offset: 0x01126FDE
		private void ResetGrowthTime(BP_SplineScatter_C actor, float progress)
		{
			actor.LastGrowthTime = -1f;
			actor.CustomTime = progress;
		}

		// Token: 0x0603C3CC RID: 246732 RVA: 0x01128DF2 File Offset: 0x01126FF2
		private ScatterSegment GetSegment(int index)
		{
			while (this.ScatterSegments.Count <= index)
			{
				this.ScatterSegments.Add(new ScatterSegment());
			}
			return this.ScatterSegments[index];
		}

		// Token: 0x0603C3CD RID: 246733 RVA: 0x01128E20 File Offset: 0x01127020
		[NullableContext(2)]
		private unsafe void EnsureScatterActor(int index, float initProgress, USplineComponent spline)
		{
			IConnectorPathAdvanceVasePlantVisual visualConfig = this.Initiator.VisualConfig;
			if (visualConfig == null || visualConfig.Type > EConnectorPathAdvanceVisualType.VasePlant)
			{
				return;
			}
			BP_SplineScatter_C bp_SplineScatter_C;
			if (index >= this.ScatterSegments.Count)
			{
				bp_SplineScatter_C = null;
			}
			else
			{
				ScatterSegment scatterSegment = this.ScatterSegments[index];
				bp_SplineScatter_C = ((scatterSegment != null) ? scatterSegment.Actor : null);
			}
			BP_SplineScatter_C bp_SplineScatter_C2 = bp_SplineScatter_C;
			if (bp_SplineScatter_C2 != null && bp_SplineScatter_C2.IsValid())
			{
				this.ResetGrowthTime(bp_SplineScatter_C2, initProgress);
				return;
			}
			if (!this.ScatterClassReady)
			{
				this.RequestScatterClass();
				return;
			}
			UObject loadedType = ResourceSystem.Instance.GetLoadedType(EBpTypeName.BP_SplineScatter_C.ToEnumString());
			if (loadedType == null || !loadedType.IsA(UClass.StaticClass()))
			{
				return;
			}
			BaseActorComponent component = this.Entity.GetComponent<BaseActorComponent>();
			AActor owner = (component != null) ? component.Owner : null;
			bp_SplineScatter_C2 = (ActorSystem.Instance.Spawn(BP_SplineScatter_C.StaticClass(), MathUtils.Instance.DefaultTransformDouble, owner) as BP_SplineScatter_C);
			if (bp_SplineScatter_C2 == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Level;
				ELogAuthor author = ELogAuthor.WRY;
				string message = "[PathAdvanceConnectDriver.EnsureScatterActor] 生成撒点表现Actor失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.PbDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PathIndex", index);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			bp_SplineScatter_C2.SetActorTickEnabled(true);
			bp_SplineScatter_C2.SetActorHiddenInGame(false);
			bp_SplineScatter_C2.Spline = spline;
			bp_SplineScatter_C2.运行时生成 = true;
			this.ResetGrowthTime(bp_SplineScatter_C2, initProgress);
			IConnectorPathAdvanceVasePlantVisual visualConfig2 = this.Initiator.VisualConfig;
			if (visualConfig2 != null && visualConfig2.ScatterWidth != null)
			{
				bp_SplineScatter_C2.生成宽度 = visualConfig2.ScatterWidth.Value;
			}
			if (visualConfig2 != null && visualConfig2.ScatterDensity != null)
			{
				bp_SplineScatter_C2.生成密度 = visualConfig2.ScatterDensity.Value;
			}
			if (visualConfig2 != null && visualConfig2.SnapToSurface != null)
			{
				bp_SplineScatter_C2.向下吸附表面 = visualConfig2.SnapToSurface.Value;
			}
			if (visualConfig2 != null && visualConfig2.Scale != null)
			{
				bp_SplineScatter_C2.缩放 = visualConfig2.Scale.Value;
			}
			bp_SplineScatter_C2.生成撒点();
			ScatterSegment segment = this.GetSegment(index);
			segment.Actor = bp_SplineScatter_C2;
			segment.MaterialReady = new bool?(false);
			this.ApplyPathTexture(index);
		}

		// Token: 0x0603C3CE RID: 246734 RVA: 0x01129054 File Offset: 0x01127254
		private void ApplyProgress(int index, float progress)
		{
			BP_SplineScatter_C bp_SplineScatter_C;
			if (index >= this.ScatterSegments.Count)
			{
				bp_SplineScatter_C = null;
			}
			else
			{
				ScatterSegment scatterSegment = this.ScatterSegments[index];
				bp_SplineScatter_C = ((scatterSegment != null) ? scatterSegment.Actor : null);
			}
			BP_SplineScatter_C bp_SplineScatter_C2 = bp_SplineScatter_C;
			if (bp_SplineScatter_C2 != null && bp_SplineScatter_C2.IsValid())
			{
				bp_SplineScatter_C2.CustomTime = progress;
				return;
			}
			if (index == this.PathIndex)
			{
				this.EnsureScatterActor(index, progress, this.Spline);
			}
		}

		// Token: 0x0603C3CF RID: 246735 RVA: 0x011290B5 File Offset: 0x011272B5
		private void ResetActorIgnoreCache(ActorIgnoreCache cache)
		{
			cache.Entity = null;
			cache.Actors.Clear();
			cache.Ready = false;
		}

		// Token: 0x0603C3D0 RID: 246736 RVA: 0x011290D0 File Offset: 0x011272D0
		private void AddEntityActorsToIgnore(UTraceLineElement element, [Nullable(2)] Entity entity, ActorIgnoreCache cache)
		{
			if (cache.Entity != entity)
			{
				cache.Entity = entity;
				cache.Actors.Clear();
				cache.Ready = false;
			}
			if (entity == null)
			{
				return;
			}
			if (!cache.Ready)
			{
				cache.Actors.Clear();
				SceneItemActorComponent component = entity.GetComponent<SceneItemActorComponent>();
				AActor aactor = (component != null) ? component.Owner : null;
				if (aactor != null)
				{
					cache.Actors.Add(aactor);
				}
				TArray<AActor> tarray = (component != null) ? component.GetAllActorsInSceneInteractionLevel() : null;
				if (tarray != null)
				{
					for (int i = 0; i < tarray.Num(); i++)
					{
						AActor aactor2 = tarray.Get(i);
						if (aactor2 != null)
						{
							cache.Actors.Add(aactor2);
						}
					}
					cache.Ready = true;
				}
			}
			bool flag = false;
			foreach (AActor aactor3 in cache.Actors)
			{
				if (aactor3.IsValid())
				{
					element.ActorsToIgnore.Add(aactor3);
				}
				else
				{
					flag = true;
				}
			}
			if (flag)
			{
				cache.Ready = false;
			}
		}

		// Token: 0x0603C3D1 RID: 246737 RVA: 0x011291E4 File Offset: 0x011273E4
		[return: TupleElementNames(new string[]
		{
			"Dist",
			"HitActorName"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private ValueTuple<float, string> ScanObstacle(float deltaSeconds)
		{
			float num = Math.Max(0f, this.CurrentDistance - 10f);
			float num2 = Math.Min(this.SplineLength, this.CurrentDistance + this.Initiator.AdvanceSpeed * deltaSeconds);
			if (num2 <= num)
			{
				return new ValueTuple<float, string>(float.PositiveInfinity, "");
			}
			List<float> list = new List<float>
			{
				num
			};
			foreach (float num3 in this.PointDistances)
			{
				if (num3 > num && num3 < num2)
				{
					list.Add(num3);
				}
			}
			list.Add(num2);
			UTraceLineElement objectTypeElement = TraceElementModel.Instance.GetObjectTypeElement<UTraceLineElement>(this.ObstacleObjectTypes, GlobalData.World, true, true);
			objectTypeElement.ActorsToIgnore.Empty(true);
			this.AddEntityActorsToIgnore(objectTypeElement, this.Entity, this.SelfActorIgnoreCache);
			this.AddEntityActorsToIgnore(objectTypeElement, this.GetTargetEntity(), this.TargetActorIgnoreCache);
			foreach (ScatterSegment scatterSegment in this.ScatterSegments)
			{
				BP_SplineScatter_C actor = scatterSegment.Actor;
				if (actor != null && actor.IsValid())
				{
					objectTypeElement.ActorsToIgnore.Add(scatterSegment.Actor);
				}
			}
			BP_EffectAudio_C growthAudioActor = this.GrowthAudioActor;
			if (growthAudioActor != null && growthAudioActor.IsValid())
			{
				objectTypeElement.ActorsToIgnore.Add(this.GrowthAudioActor);
			}
			for (int i = 0; i < list.Count - 1; i++)
			{
				float num4 = list[i];
				float num5 = list[i + 1];
				FVectorDouble fvectorDouble = this.Spline.D_GetLocationAtDistanceAlongSpline(num4, ESplineCoordinateSpace.World);
				FVectorDouble fvectorDouble2 = this.Spline.D_GetLocationAtDistanceAlongSpline(num5, ESplineCoordinateSpace.World);
				objectTypeElement.SetStartLocation(fvectorDouble.X, fvectorDouble.Y, fvectorDouble.Z);
				objectTypeElement.SetEndLocation(fvectorDouble2.X, fvectorDouble2.Y, fvectorDouble2.Z);
				if (TraceElementCommon.Instance.LineTrace(objectTypeElement, "PathAdvanceConnectDriver.ScanObstacle"))
				{
					UKuroHitResult hitResult = objectTypeElement.HitResult;
					if (hitResult != null && hitResult.bBlockingHit)
					{
						return new ValueTuple<float, string>(num4 + hitResult.TimeArray.Get(0) * (num5 - num4), hitResult.Actors.Get(0).GetName());
					}
				}
			}
			return new ValueTuple<float, string>(float.PositiveInfinity, "");
		}

		// Token: 0x0401FE42 RID: 130626
		private const float SCAN_BACK_MARGIN = 10f;

		// Token: 0x0401FE43 RID: 130627
		private const float REACH_EPSILON = 1f;

		// Token: 0x0401FE44 RID: 130628
		private const float INVALID_GROWTH_TIME = -1f;

		// Token: 0x0401FE45 RID: 130629
		private const string PROFILE_KEY = "PathAdvanceConnectDriver.ScanObstacle";

		// Token: 0x0401FE46 RID: 130630
		private const string GROWTH_AUDIO_EVENT = "play_sfx_gp_flower_road";

		// Token: 0x0401FE47 RID: 130631
		private readonly EObjectTypeQuery[] ObstacleObjectTypes = new EObjectTypeQuery[]
		{
			KuroObjectTypeQuery.Destructible,
			KuroObjectTypeQuery.HitItem,
			KuroObjectTypeQuery.WorldStatic,
			KuroObjectTypeQuery.WorldDynamic
		};

		// Token: 0x0401FE48 RID: 130632
		private readonly Entity Entity;

		// Token: 0x0401FE49 RID: 130633
		private readonly IConnectorPointToPointPathAdvance Config;

		// Token: 0x0401FE4A RID: 130634
		private readonly Action<int> OnReachEnd;

		// Token: 0x0401FE4B RID: 130635
		private readonly Action<int> OnWithdraw;

		// Token: 0x0401FE4C RID: 130636
		[Nullable(2)]
		private IConnectorPathAdvanceInitiator Initiator;

		// Token: 0x0401FE4D RID: 130637
		[Nullable(2)]
		private SceneItemStateComponent StateComp;

		// Token: 0x0401FE4E RID: 130638
		private int ActiveStateTagId;

		// Token: 0x0401FE4F RID: 130639
		private int PbDataId;

		// Token: 0x0401FE50 RID: 130640
		private int PathIndex;

		// Token: 0x0401FE51 RID: 130641
		private float CurrentDistance;

		// Token: 0x0401FE52 RID: 130642
		private float SplineLength;

		// Token: 0x0401FE53 RID: 130643
		[Nullable(2)]
		private USplineComponent Spline;

		// Token: 0x0401FE54 RID: 130644
		private readonly List<float> PointDistances = new List<float>();

		// Token: 0x0401FE55 RID: 130645
		private readonly List<int> LoadedSplineIds = new List<int>();

		// Token: 0x0401FE56 RID: 130646
		private readonly List<ScatterSegment> ScatterSegments = new List<ScatterSegment>();

		// Token: 0x0401FE57 RID: 130647
		private readonly ActorIgnoreCache SelfActorIgnoreCache = new ActorIgnoreCache();

		// Token: 0x0401FE58 RID: 130648
		private readonly ActorIgnoreCache TargetActorIgnoreCache = new ActorIgnoreCache();

		// Token: 0x0401FE59 RID: 130649
		private bool Started;

		// Token: 0x0401FE5A RID: 130650
		private bool Reached;

		// Token: 0x0401FE5B RID: 130651
		private bool Withdrawing;

		// Token: 0x0401FE5C RID: 130652
		private bool ScatterClassRequested;

		// Token: 0x0401FE5D RID: 130653
		private bool ScatterClassReady;

		// Token: 0x0401FE5E RID: 130654
		private bool RestorePending;

		// Token: 0x0401FE5F RID: 130655
		private bool TargetReady;

		// Token: 0x0401FE60 RID: 130656
		[Nullable(2)]
		private WaitEntityTask TargetWaitTask;

		// Token: 0x0401FE61 RID: 130657
		private bool Blocked;

		// Token: 0x0401FE62 RID: 130658
		private bool SplineInvalidLogged;

		// Token: 0x0401FE63 RID: 130659
		private bool ConstantTickEnabled;

		// Token: 0x0401FE64 RID: 130660
		[Nullable(2)]
		private BP_EffectAudio_C GrowthAudioActor;

		// Token: 0x0401FE65 RID: 130661
		private int GrowthAudioHandle;

		// Token: 0x0401FE66 RID: 130662
		private bool GrowthAudioPaused;

		// Token: 0x0401FE67 RID: 130663
		private readonly TArray<FVector> EmptyGrowthAudioLocationOffsets = new TArray<FVector>();
	}
}
