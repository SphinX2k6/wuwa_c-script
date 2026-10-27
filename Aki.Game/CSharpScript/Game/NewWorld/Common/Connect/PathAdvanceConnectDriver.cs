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
	// Token: 0x02007079 RID: 28793
	[NullableContext(1)]
	[Nullable(0)]
	public class PathAdvanceConnectDriver
	{
		// Token: 0x060461A7 RID: 287143 RVA: 0x0117E840 File Offset: 0x0117CA40
		public PathAdvanceConnectDriver(Entity entity, IConnectorPointToPointPathAdvance config, Action<int> onReachEnd, Action<int> onWithdraw)
		{
			this.Entity = entity;
			this.Config = config;
			this.OnReachEnd = onReachEnd;
			this.OnWithdraw = onWithdraw;
		}

		// Token: 0x060461A8 RID: 287144 RVA: 0x0117E8E0 File Offset: 0x0117CAE0
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

		// Token: 0x060461A9 RID: 287145 RVA: 0x0117E9D8 File Offset: 0x0117CBD8
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

		// Token: 0x060461AA RID: 287146 RVA: 0x0117EA5D File Offset: 0x0117CC5D
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

		// Token: 0x060461AB RID: 287147 RVA: 0x0117EA8A File Offset: 0x0117CC8A
		public void SetRestorePending(bool restorePending)
		{
			this.RestorePending = restorePending;
		}

		// Token: 0x060461AC RID: 287148 RVA: 0x0117EA94 File Offset: 0x0117CC94
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

		// Token: 0x060461AD RID: 287149 RVA: 0x0117EBBC File Offset: 0x0117CDBC
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

		// Token: 0x060461AE RID: 287150 RVA: 0x0117EC31 File Offset: 0x0117CE31
		private bool IsActive()
		{
			return this.StateComp != null && this.ActiveStateTagId != 0 && this.StateComp.StateTagId == this.ActiveStateTagId;
		}

		// Token: 0x060461AF RID: 287151 RVA: 0x0117EC58 File Offset: 0x0117CE58
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

		// Token: 0x060461B0 RID: 287152 RVA: 0x0117EC94 File Offset: 0x0117CE94
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

		// Token: 0x060461B1 RID: 287153 RVA: 0x0117ECBC File Offset: 0x0117CEBC
		private bool IsDriveReady()
		{
			if (!this.TargetReady)
			{
				return false;
			}
			IConnectorPathAdvanceVasePlantVisual visualConfig = this.Initiator.VisualConfig;
			return visualConfig == null || visualConfig.Type > EConnectorPathAdvanceVisualType.VasePlant || this.ScatterClassReady;
		}

		// Token: 0x060461B2 RID: 287154 RVA: 0x0117ECEC File Offset: 0x0117CEEC
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

		// Token: 0x060461B3 RID: 287155 RVA: 0x0117ED6C File Offset: 0x0117CF6C
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

		// Token: 0x060461B4 RID: 287156 RVA: 0x0117EF82 File Offset: 0x0117D182
		private void LogProgress(float progress)
		{
		}

		// Token: 0x060461B5 RID: 287157 RVA: 0x0117EF84 File Offset: 0x0117D184
		private void NotifyWithdrawOnce()
		{
			if (!this.Reached)
			{
				return;
			}
			this.Reached = false;
			this.OnWithdraw(this.Initiator.TargetEntity);
		}

		// Token: 0x060461B6 RID: 287158 RVA: 0x0117EFAC File Offset: 0x0117D1AC
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

		// Token: 0x060461B7 RID: 287159 RVA: 0x0117F090 File Offset: 0x0117D290
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

		// Token: 0x060461B8 RID: 287160 RVA: 0x0117F1AC File Offset: 0x0117D3AC
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

		// Token: 0x060461B9 RID: 287161 RVA: 0x0117F240 File Offset: 0x0117D440
		private void PauseGrowthAudio()
		{
			if (this.GrowthAudioHandle == 0 || this.GrowthAudioPaused)
			{
				return;
			}
			AudioSystem.Instance.ExecuteAction(this.GrowthAudioHandle, EAudioActionType.Pause, null);
			this.GrowthAudioPaused = true;
		}

		// Token: 0x060461BA RID: 287162 RVA: 0x0117F280 File Offset: 0x0117D480
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

		// Token: 0x060461BB RID: 287163 RVA: 0x0117F2F0 File Offset: 0x0117D4F0
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

		// Token: 0x060461BC RID: 287164 RVA: 0x0117F3D0 File Offset: 0x0117D5D0
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

		// Token: 0x060461BD RID: 287165 RVA: 0x0117F433 File Offset: 0x0117D633
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

		// Token: 0x060461BE RID: 287166 RVA: 0x0117F46B File Offset: 0x0117D66B
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

		// Token: 0x060461BF RID: 287167 RVA: 0x0117F4A0 File Offset: 0x0117D6A0
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

		// Token: 0x060461C0 RID: 287168 RVA: 0x0117F52C File Offset: 0x0117D72C
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

		// Token: 0x060461C1 RID: 287169 RVA: 0x0117F5C2 File Offset: 0x0117D7C2
		private void ResetGrowthTime(BP_SplineScatter_C actor, float progress)
		{
			actor.LastGrowthTime = -1f;
			actor.CustomTime = progress;
		}

		// Token: 0x060461C2 RID: 287170 RVA: 0x0117F5D6 File Offset: 0x0117D7D6
		private ScatterSegment GetSegment(int index)
		{
			while (this.ScatterSegments.Count <= index)
			{
				this.ScatterSegments.Add(new ScatterSegment());
			}
			return this.ScatterSegments[index];
		}

		// Token: 0x060461C3 RID: 287171 RVA: 0x0117F604 File Offset: 0x0117D804
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

		// Token: 0x060461C4 RID: 287172 RVA: 0x0117F838 File Offset: 0x0117DA38
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

		// Token: 0x060461C5 RID: 287173 RVA: 0x0117F899 File Offset: 0x0117DA99
		private void ResetActorIgnoreCache(ActorIgnoreCache cache)
		{
			cache.Entity = null;
			cache.Actors.Clear();
			cache.Ready = false;
		}

		// Token: 0x060461C6 RID: 287174 RVA: 0x0117F8B4 File Offset: 0x0117DAB4
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

		// Token: 0x060461C7 RID: 287175 RVA: 0x0117F9C8 File Offset: 0x0117DBC8
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

		// Token: 0x04024B87 RID: 150407
		private const float SCAN_BACK_MARGIN = 10f;

		// Token: 0x04024B88 RID: 150408
		private const float REACH_EPSILON = 1f;

		// Token: 0x04024B89 RID: 150409
		private const float INVALID_GROWTH_TIME = -1f;

		// Token: 0x04024B8A RID: 150410
		private const string PROFILE_KEY = "PathAdvanceConnectDriver.ScanObstacle";

		// Token: 0x04024B8B RID: 150411
		private const string GROWTH_AUDIO_EVENT = "play_sfx_gp_flower_road";

		// Token: 0x04024B8C RID: 150412
		private readonly EObjectTypeQuery[] ObstacleObjectTypes = new EObjectTypeQuery[]
		{
			KuroObjectTypeQuery.Destructible,
			KuroObjectTypeQuery.HitItem,
			KuroObjectTypeQuery.WorldStatic,
			KuroObjectTypeQuery.WorldDynamic
		};

		// Token: 0x04024B8D RID: 150413
		private readonly Entity Entity;

		// Token: 0x04024B8E RID: 150414
		private readonly IConnectorPointToPointPathAdvance Config;

		// Token: 0x04024B8F RID: 150415
		private readonly Action<int> OnReachEnd;

		// Token: 0x04024B90 RID: 150416
		private readonly Action<int> OnWithdraw;

		// Token: 0x04024B91 RID: 150417
		[Nullable(2)]
		private IConnectorPathAdvanceInitiator Initiator;

		// Token: 0x04024B92 RID: 150418
		[Nullable(2)]
		private SceneItemStateComponent StateComp;

		// Token: 0x04024B93 RID: 150419
		private int ActiveStateTagId;

		// Token: 0x04024B94 RID: 150420
		private int PbDataId;

		// Token: 0x04024B95 RID: 150421
		private int PathIndex;

		// Token: 0x04024B96 RID: 150422
		private float CurrentDistance;

		// Token: 0x04024B97 RID: 150423
		private float SplineLength;

		// Token: 0x04024B98 RID: 150424
		[Nullable(2)]
		private USplineComponent Spline;

		// Token: 0x04024B99 RID: 150425
		private readonly List<float> PointDistances = new List<float>();

		// Token: 0x04024B9A RID: 150426
		private readonly List<int> LoadedSplineIds = new List<int>();

		// Token: 0x04024B9B RID: 150427
		private readonly List<ScatterSegment> ScatterSegments = new List<ScatterSegment>();

		// Token: 0x04024B9C RID: 150428
		private readonly ActorIgnoreCache SelfActorIgnoreCache = new ActorIgnoreCache();

		// Token: 0x04024B9D RID: 150429
		private readonly ActorIgnoreCache TargetActorIgnoreCache = new ActorIgnoreCache();

		// Token: 0x04024B9E RID: 150430
		private bool Started;

		// Token: 0x04024B9F RID: 150431
		private bool Reached;

		// Token: 0x04024BA0 RID: 150432
		private bool Withdrawing;

		// Token: 0x04024BA1 RID: 150433
		private bool ScatterClassRequested;

		// Token: 0x04024BA2 RID: 150434
		private bool ScatterClassReady;

		// Token: 0x04024BA3 RID: 150435
		private bool RestorePending;

		// Token: 0x04024BA4 RID: 150436
		private bool TargetReady;

		// Token: 0x04024BA5 RID: 150437
		[Nullable(2)]
		private WaitEntityTask TargetWaitTask;

		// Token: 0x04024BA6 RID: 150438
		private bool Blocked;

		// Token: 0x04024BA7 RID: 150439
		private bool SplineInvalidLogged;

		// Token: 0x04024BA8 RID: 150440
		private bool ConstantTickEnabled;

		// Token: 0x04024BA9 RID: 150441
		[Nullable(2)]
		private BP_EffectAudio_C GrowthAudioActor;

		// Token: 0x04024BAA RID: 150442
		private int GrowthAudioHandle;

		// Token: 0x04024BAB RID: 150443
		private bool GrowthAudioPaused;

		// Token: 0x04024BAC RID: 150444
		private readonly TArray<FVector> EmptyGrowthAudioLocationOffsets = new TArray<FVector>();
	}
}
