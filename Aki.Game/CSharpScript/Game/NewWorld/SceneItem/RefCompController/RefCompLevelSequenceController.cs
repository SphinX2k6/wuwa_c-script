using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface;
using CSharpScript.Game.LevelGamePlay.StaticScene;
using CSharpScript.Game.LevelGamePlay.StaticScene.Preprocessor;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Plot.PlotView;
using CSharpScript.Game.World.Controller;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.RefCompController
{
	// Token: 0x020071B7 RID: 29111
	[NullableContext(1)]
	[Nullable(0)]
	public class RefCompLevelSequenceController : RefCompControllerBase
	{
		// Token: 0x060473CF RID: 291791 RVA: 0x0121C6A5 File Offset: 0x0121A8A5
		public RefCompLevelSequenceController(Entity entity, long creatureDataId, int pbDataId) : base(entity, creatureDataId, pbDataId)
		{
		}

		// Token: 0x17009DB9 RID: 40377
		// (get) Token: 0x060473D0 RID: 291792 RVA: 0x0121C6C2 File Offset: 0x0121A8C2
		public override RefCompDefine.ERefCompControllerType Type
		{
			get
			{
				return RefCompDefine.ERefCompControllerType.LevelSequence;
			}
		}

		// Token: 0x060473D1 RID: 291793 RVA: 0x0121C6C5 File Offset: 0x0121A8C5
		public override void OnStart()
		{
			this.EventComp = this.Entity.GetComponent<LevelSequenceFrameEventComponent>();
			this.HostComponent = this.Entity.GetComponent<SceneItemReferenceComponent>();
		}

		// Token: 0x060473D2 RID: 291794 RVA: 0x0121C6E9 File Offset: 0x0121A8E9
		private void ManualTickPreMove(float deltaMs)
		{
			ManualTickSequenceDriver manualTickDriver = this.ManualTickDriver;
			if (manualTickDriver == null)
			{
				return;
			}
			manualTickDriver.Tick(deltaMs);
		}

		// Token: 0x060473D3 RID: 291795 RVA: 0x0121C6FC File Offset: 0x0121A8FC
		public override void OnEnd()
		{
			this.SubtitleCloseGuard.Stop();
			while (this.ResourceLoadCallbackHandleQueue != null && this.ResourceLoadCallbackHandleQueue.Size > 0)
			{
				RefCompLevelSequenceController.ResourceLoadCallbackHandle resourceLoadCallbackHandle = this.ResourceLoadCallbackHandleQueue.Pop();
				if (resourceLoadCallbackHandle != null && !resourceLoadCallbackHandle.LoadAsyncFinished && resourceLoadCallbackHandle.ResourceSystemId != -1)
				{
					ResourceSystem.Instance.CancelAsyncLoad(resourceLoadCallbackHandle.ResourceSystemId);
				}
			}
			if (this.SimpleSequenceActor != null)
			{
				this.SimpleSequenceActor.Clear();
			}
			this.ReleaseManualTickDriver();
		}

		// Token: 0x060473D4 RID: 291796 RVA: 0x0121C775 File Offset: 0x0121A975
		public void OnActorRemove()
		{
			this.SubtitleCloseGuard.Stop();
			this.NextSequenceJumpToEnd = true;
			SimpleLevelSequenceActor simpleSequenceActor = this.SimpleSequenceActor;
			if (simpleSequenceActor != null)
			{
				simpleSequenceActor.Clear();
			}
			this.SimpleSequenceActor = null;
			this.ReleaseManualTickDriver();
		}

		// Token: 0x060473D5 RID: 291797 RVA: 0x0121C7A7 File Offset: 0x0121A9A7
		private void ReleaseManualTickDriver()
		{
			this.ManualTickLoadRequestId++;
			this.UnregisterManualTickPreMove();
			if (this.ManualTickDriver != null)
			{
				this.ManualTickDriver.Release();
				this.ManualTickDriver = null;
			}
		}

		// Token: 0x060473D6 RID: 291798 RVA: 0x0121C7D8 File Offset: 0x0121A9D8
		private void RegisterManualTickPreMove()
		{
			if (this.ManualTickRegistered)
			{
				return;
			}
			if (this.HostComponent == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CK;
				string message = "[RefCompLevelSequenceController] 逐帧驱动注册 PreMoveTick 失败,宿主组件为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", this.PbDataId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			ComponentForceTickController.Instance.RegisterPreMoveTick(this.HostComponent, new Action<float>(this.ManualTickPreMove));
			this.ManualTickRegistered = true;
		}

		// Token: 0x060473D7 RID: 291799 RVA: 0x0121C84B File Offset: 0x0121AA4B
		private void UnregisterManualTickPreMove()
		{
			if (!this.ManualTickRegistered || this.HostComponent == null)
			{
				return;
			}
			ComponentForceTickController.Instance.UnregisterPreMoveTick(this.HostComponent);
			this.ManualTickRegistered = false;
		}

		// Token: 0x060473D8 RID: 291800 RVA: 0x0121C875 File Offset: 0x0121AA75
		public void OnHostEnable()
		{
			ManualTickSequenceDriver manualTickDriver = this.ManualTickDriver;
			if (manualTickDriver == null || !manualTickDriver.IsPlaying())
			{
				return;
			}
			this.RegisterManualTickPreMove();
		}

		// Token: 0x060473D9 RID: 291801 RVA: 0x0121C895 File Offset: 0x0121AA95
		public void OnHostDisable()
		{
			this.UnregisterManualTickPreMove();
		}

		// Token: 0x060473DA RID: 291802 RVA: 0x0121C8A0 File Offset: 0x0121AAA0
		public void HandleSequence(PlayLevelSequence inSequenceConfig)
		{
			RefCompLevelSequenceController.<>c__DisplayClass23_0 CS$<>8__locals1 = new RefCompLevelSequenceController.<>c__DisplayClass23_0();
			CS$<>8__locals1.inSequenceConfig = inSequenceConfig;
			CS$<>8__locals1.<>4__this = this;
			this.SubtitleCloseGuard.Stop();
			if (string.IsNullOrEmpty(CS$<>8__locals1.inSequenceConfig.LevelSequencePath) || CS$<>8__locals1.inSequenceConfig.LevelSequencePath == "None")
			{
				global::Log.Instance.Error(ELogModule.Interaction, ELogAuthor.YZH, "LevelSequence", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			if (!this.CheckAndDispatchDriveMode(CS$<>8__locals1.inSequenceConfig))
			{
				return;
			}
			CS$<>8__locals1.jumpToEnd = this.NextSequenceJumpToEnd;
			CS$<>8__locals1.tempInTransit = null;
			CS$<>8__locals1.tempOutTransit = null;
			if (CS$<>8__locals1.inSequenceConfig.Intro == null)
			{
				CS$<>8__locals1.tempInTransit = new RefCompDefine.TransitStruct(ELevelSequenceTransition.Camera, new float?(0f), new float?(0f), new float?(0f), new bool?(false), null);
			}
			else
			{
				ILevelSequenceTransitionType intro = CS$<>8__locals1.inSequenceConfig.Intro;
				if (intro != null && intro.Type == ELevelSequenceTransition.Camera)
				{
					ILevelSequenceTransitionType levelSequenceTransitionType = CS$<>8__locals1.inSequenceConfig.Intro as ICameraTransition;
					RefCompLevelSequenceController.<>c__DisplayClass23_0 CS$<>8__locals2 = CS$<>8__locals1;
					ELevelSequenceTransition transitType = ELevelSequenceTransition.Camera;
					float? duration;
					if (levelSequenceTransitionType.Duration == null)
					{
						duration = new float?(0f);
					}
					else
					{
						float? duration2 = levelSequenceTransitionType.Duration;
						float num = 0f;
						duration = ((duration2.GetValueOrDefault() > num & duration2 != null) ? levelSequenceTransitionType.Duration : new float?(0f));
					}
					CS$<>8__locals2.tempInTransit = new RefCompDefine.TransitStruct(transitType, duration, new float?(0f), new float?(0f), new bool?(true), null);
				}
				else
				{
					ILevelSequenceTransitionType levelSequenceTransitionType = CS$<>8__locals1.inSequenceConfig.Intro as IMaskTransition;
					IMaskTransition maskTransition = levelSequenceTransitionType as IMaskTransition;
					RefCompLevelSequenceController.<>c__DisplayClass23_0 CS$<>8__locals3 = CS$<>8__locals1;
					ELevelSequenceTransition transitType2 = ELevelSequenceTransition.Mask;
					float? duration3;
					if (levelSequenceTransitionType.Duration == null)
					{
						duration3 = new float?(0f);
					}
					else
					{
						float? duration2 = levelSequenceTransitionType.Duration;
						float num = 0f;
						duration3 = ((duration2.GetValueOrDefault() > num & duration2 != null) ? levelSequenceTransitionType.Duration : new float?(0f));
					}
					CS$<>8__locals3.tempInTransit = new RefCompDefine.TransitStruct(transitType2, duration3, new float?((maskTransition.FadeIn != null) ? ((maskTransition.FadeIn.Duration > 0f) ? maskTransition.FadeIn.Duration : 1f) : 1f), new float?((maskTransition.FadeOut != null) ? ((maskTransition.FadeOut.Duration > 0f) ? maskTransition.FadeOut.Duration : 1f) : 1f), new bool?(true), new ETransitionMask?(maskTransition.Mask));
				}
			}
			if (CS$<>8__locals1.inSequenceConfig.Outro == null)
			{
				CS$<>8__locals1.tempOutTransit = new RefCompDefine.TransitStruct(ELevelSequenceTransition.Camera, new float?(0f), new float?(0f), new float?(0f), new bool?(false), null);
			}
			else
			{
				ILevelSequenceTransitionType outro = CS$<>8__locals1.inSequenceConfig.Outro;
				if (outro != null && outro.Type == ELevelSequenceTransition.Camera)
				{
					ILevelSequenceTransitionType levelSequenceTransitionType = CS$<>8__locals1.inSequenceConfig.Outro as ICameraTransition;
					RefCompLevelSequenceController.<>c__DisplayClass23_0 CS$<>8__locals4 = CS$<>8__locals1;
					ELevelSequenceTransition transitType3 = ELevelSequenceTransition.Camera;
					float? duration4;
					if (levelSequenceTransitionType.Duration == null)
					{
						duration4 = new float?(0f);
					}
					else
					{
						float? duration2 = levelSequenceTransitionType.Duration;
						float num = 0f;
						duration4 = ((duration2.GetValueOrDefault() > num & duration2 != null) ? levelSequenceTransitionType.Duration : new float?(0f));
					}
					CS$<>8__locals4.tempOutTransit = new RefCompDefine.TransitStruct(transitType3, duration4, new float?(0f), new float?(0f), new bool?(true), null);
				}
				else
				{
					ILevelSequenceTransitionType levelSequenceTransitionType = CS$<>8__locals1.inSequenceConfig.Outro as IMaskTransition;
					IMaskTransition maskTransition2 = levelSequenceTransitionType as IMaskTransition;
					RefCompLevelSequenceController.<>c__DisplayClass23_0 CS$<>8__locals5 = CS$<>8__locals1;
					ELevelSequenceTransition transitType4 = ELevelSequenceTransition.Mask;
					float? duration5;
					if (levelSequenceTransitionType.Duration == null)
					{
						duration5 = new float?(0f);
					}
					else
					{
						float? duration2 = levelSequenceTransitionType.Duration;
						float num = 0f;
						duration5 = ((duration2.GetValueOrDefault() > num & duration2 != null) ? levelSequenceTransitionType.Duration : new float?(0f));
					}
					CS$<>8__locals5.tempOutTransit = new RefCompDefine.TransitStruct(transitType4, duration5, new float?((maskTransition2.FadeIn != null) ? ((maskTransition2.FadeIn.Duration > 0f) ? maskTransition2.FadeIn.Duration : 1f) : 1f), new float?((maskTransition2.FadeOut != null) ? ((maskTransition2.FadeOut.Duration > 0f) ? maskTransition2.FadeOut.Duration : 1f) : 1f), new bool?(true), new ETransitionMask?(maskTransition2.Mask));
				}
			}
			RefCompLevelSequenceController.<>c__DisplayClass23_0 CS$<>8__locals6 = CS$<>8__locals1;
			float? playRateAbs = new float?(Math.Abs(CS$<>8__locals1.inSequenceConfig.Rate.GetValueOrDefault(1f)));
			EKuroEasingFuncType easeType = EKuroEasingFuncType.KEF_Linear;
			IEaseData rateEase = CS$<>8__locals1.inSequenceConfig.RateEase;
			CS$<>8__locals6.tempPlayRateStruct = new RefCompDefine.PlayRateStruct(playRateAbs, easeType, new float?((rateEase != null) ? rateEase.Duration : 0f), new float?(0f));
			IEaseData rateEase2 = CS$<>8__locals1.inSequenceConfig.RateEase;
			EEaseType? eeaseType = (rateEase2 != null) ? new EEaseType?(rateEase2.Type) : null;
			if (eeaseType != null)
			{
				switch (eeaseType.GetValueOrDefault())
				{
				case EEaseType.Transient:
					CS$<>8__locals1.tempPlayRateStruct.EaseType = EKuroEasingFuncType.KEF_Linear;
					CS$<>8__locals1.tempPlayRateStruct.EaseDuration = new float?(0f);
					goto IL_5C4;
				case EEaseType.InOutCubic:
					CS$<>8__locals1.tempPlayRateStruct.EaseType = EKuroEasingFuncType.KEF_EaseInOut;
					CS$<>8__locals1.tempPlayRateStruct.EaseExponent = new float?((float)3);
					goto IL_5C4;
				case EEaseType.OutSine:
					CS$<>8__locals1.tempPlayRateStruct.EaseType = EKuroEasingFuncType.KEF_SinOut;
					goto IL_5C4;
				case EEaseType.OutQuart:
					CS$<>8__locals1.tempPlayRateStruct.EaseType = EKuroEasingFuncType.KEF_EaseOut;
					CS$<>8__locals1.tempPlayRateStruct.EaseExponent = new float?((float)4);
					goto IL_5C4;
				}
			}
			CS$<>8__locals1.tempPlayRateStruct.EaseType = EKuroEasingFuncType.KEF_Linear;
			IL_5C4:
			this.LoadResourceAsyncWithQueue<ULevelSequence>(CS$<>8__locals1.inSequenceConfig.LevelSequencePath, delegate([Nullable(2)] UObject data, string _)
			{
				if (data == null || !data.IsValid())
				{
					global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YZH, "此LevelEvent只能配置在SceneActorRefComponent中", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				LevelSequencePreprocessHelper.Instance.Apply((ULevelSequence)data, CS$<>8__locals1.inSequenceConfig.PreprocessOperation);
				if (CS$<>8__locals1.<>4__this.SimpleSequenceActor == null)
				{
					CS$<>8__locals1.<>4__this.SimpleSequenceActor = new SimpleLevelSequenceActor((ULevelSequence)data);
				}
				else
				{
					ALevelSequenceActor sequenceActor = CS$<>8__locals1.<>4__this.SimpleSequenceActor.GetSequenceActor();
					if (((sequenceActor != null) ? sequenceActor.GetSequence() : null) != data)
					{
						CS$<>8__locals1.<>4__this.SimpleSequenceActor.SetSequenceData((ULevelSequence)data);
					}
				}
				CS$<>8__locals1.<>4__this.SubtitleCloseGuard.Start(CS$<>8__locals1.<>4__this.SimpleSequenceActor, (ULevelSequence)data, CS$<>8__locals1.inSequenceConfig);
				CS$<>8__locals1.<>4__this.SimpleSequenceActor.UpdateSettings(new bool?(CS$<>8__locals1.inSequenceConfig.KeepUI.GetValueOrDefault()));
				CS$<>8__locals1.<>4__this.SimpleSequenceActor.SetCanPlayInLoading(CS$<>8__locals1.inSequenceConfig.IsPlayOnTeleport.GetValueOrDefault());
				if (CS$<>8__locals1.inSequenceConfig.IsEnableCenterOffset.GetValueOrDefault())
				{
					CS$<>8__locals1.<>4__this.SimpleSequenceActor.SetOriginTransform();
				}
				if (!string.IsNullOrEmpty(CS$<>8__locals1.inSequenceConfig.Mark))
				{
					LevelSequenceFrameEventComponent eventComp = CS$<>8__locals1.<>4__this.EventComp;
					if (eventComp != null)
					{
						eventComp.OnSequencePlayToMark(CS$<>8__locals1.inSequenceConfig.Mark, CS$<>8__locals1.<>4__this.SimpleSequenceActor.GetCurrentFrame(), CS$<>8__locals1.jumpToEnd, CS$<>8__locals1.inSequenceConfig.LevelSequencePath);
					}
					if (CS$<>8__locals1.<>4__this.EventComp != null)
					{
						CS$<>8__locals1.<>4__this.SimpleSequenceActor.AddOnPauseCallback(new Action(CS$<>8__locals1.<>4__this.EventComp.OnSequencePaused));
					}
					else
					{
						CS$<>8__locals1.<>4__this.SimpleSequenceActor.AddOnPauseCallback(null);
					}
				}
				else
				{
					ILoopRange loopRange = CS$<>8__locals1.inSequenceConfig.LoopRange;
					if (!string.IsNullOrEmpty((loopRange != null) ? loopRange.LeftMark : null))
					{
						CS$<>8__locals1.<>4__this.SimpleSequenceActor.PlayToMark(CS$<>8__locals1.inSequenceConfig.LoopRange.LeftMark, CS$<>8__locals1.tempInTransit, CS$<>8__locals1.tempOutTransit, CS$<>8__locals1.tempPlayRateStruct, CS$<>8__locals1.jumpToEnd);
					}
				}
				if (RefCompDefine.PrePhysicsSequenceConfig.Check(CS$<>8__locals1.inSequenceConfig.LevelSequencePath))
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Animation.ForbiddenEvaluateTwice 0", null);
				}
				TPlayMode? tplayMode;
				string a = (CS$<>8__locals1.inSequenceConfig.PlayMode != null) ? tplayMode.GetValueOrDefault().ToEnumString() : null;
				if (a == EPlayLevelSequenceType.ShortestPath.ToEnumString())
				{
					CS$<>8__locals1.<>4__this.SimpleSequenceActor.PlayToMarkByCheckWay(CS$<>8__locals1.inSequenceConfig.Mark, CS$<>8__locals1.tempInTransit, CS$<>8__locals1.tempOutTransit, CS$<>8__locals1.tempPlayRateStruct, CS$<>8__locals1.jumpToEnd);
				}
				else if (a == EPlayLevelSequenceType.Instant.ToEnumString())
				{
					CS$<>8__locals1.<>4__this.SimpleSequenceActor.PlayToMark(CS$<>8__locals1.inSequenceConfig.Mark, CS$<>8__locals1.tempInTransit, CS$<>8__locals1.tempOutTransit, CS$<>8__locals1.tempPlayRateStruct, true);
				}
				else if (a == EPlayLevelSequenceType.Loop.ToEnumString())
				{
					if (CS$<>8__locals1.inSequenceConfig.LoopRange != null)
					{
						CS$<>8__locals1.<>4__this.SimpleSequenceActor.PlayLoopBetweenMarks(CS$<>8__locals1.inSequenceConfig.LoopRange, CS$<>8__locals1.inSequenceConfig.Rate.GetValueOrDefault(1f) < 0f, CS$<>8__locals1.tempInTransit, CS$<>8__locals1.tempOutTransit, CS$<>8__locals1.tempPlayRateStruct, CS$<>8__locals1.jumpToEnd);
					}
					else
					{
						CS$<>8__locals1.<>4__this.SimpleSequenceActor.PlayLoop(CS$<>8__locals1.inSequenceConfig.Rate.GetValueOrDefault(1f) < 0f, -1, CS$<>8__locals1.tempInTransit, CS$<>8__locals1.tempOutTransit, CS$<>8__locals1.tempPlayRateStruct);
					}
				}
				else
				{
					CS$<>8__locals1.<>4__this.SimpleSequenceActor.PlayToMark(CS$<>8__locals1.inSequenceConfig.Mark, CS$<>8__locals1.tempInTransit, CS$<>8__locals1.tempOutTransit, CS$<>8__locals1.tempPlayRateStruct, CS$<>8__locals1.jumpToEnd);
				}
				if (RefCompDefine.PrePhysicsSequenceConfig.Check(CS$<>8__locals1.inSequenceConfig.LevelSequencePath))
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "Animation.ForbiddenEvaluateTwice 1", null);
				}
			}, ResourceSystem.EResourceLoadPriority.Default);
		}

		// Token: 0x060473DB RID: 291803 RVA: 0x0121CE94 File Offset: 0x0121B094
		private unsafe bool CheckAndDispatchDriveMode(PlayLevelSequence inSequenceConfig)
		{
			string levelSequencePath = inSequenceConfig.LevelSequencePath;
			if (string.IsNullOrEmpty(levelSequencePath) || levelSequencePath == "None")
			{
				return false;
			}
			RefCompLevelSequenceController.ESequenceTickMode esequenceTickMode = inSequenceConfig.IsCarryCharacter.GetValueOrDefault() ? RefCompLevelSequenceController.ESequenceTickMode.ManualTick : RefCompLevelSequenceController.ESequenceTickMode.Engine;
			if (this.LockedDriveMode != null)
			{
				RefCompLevelSequenceController.ESequenceTickMode? lockedDriveMode = this.LockedDriveMode;
				RefCompLevelSequenceController.ESequenceTickMode esequenceTickMode2 = esequenceTickMode;
				if (!(lockedDriveMode.GetValueOrDefault() == esequenceTickMode2 & lockedDriveMode != null))
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.SceneItem;
					ELogAuthor author = ELogAuthor.CK;
					string message = "[RefCompLevelSequenceController] Sequence 驱动方式冲突,同一组件不可混用驱动方式,跳过本次播放";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Path", levelSequencePath);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("LockedMode", this.LockedDriveMode);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("DesiredMode", esequenceTickMode);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					return false;
				}
			}
			this.LockedDriveMode = new RefCompLevelSequenceController.ESequenceTickMode?(esequenceTickMode);
			if (esequenceTickMode == RefCompLevelSequenceController.ESequenceTickMode.ManualTick)
			{
				this.WarnUnsupportedManualTickOptions(inSequenceConfig);
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.SceneItem;
				ELogAuthor author2 = ELogAuthor.CK;
				string message2 = "[RefCompLevelSequenceController] 分流至逐帧驱动分支(ManualTick)";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", levelSequencePath);
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.HandleSequenceByManualTick(inSequenceConfig);
				return false;
			}
			return true;
		}

		// Token: 0x060473DC RID: 291804 RVA: 0x0121CFCC File Offset: 0x0121B1CC
		private unsafe void WarnUnsupportedManualTickOptions(PlayLevelSequence inSequenceConfig)
		{
			List<string> list = new List<string>();
			if (inSequenceConfig.Intro != null)
			{
				list.Add("Intro");
			}
			if (inSequenceConfig.Outro != null)
			{
				list.Add("Outro");
			}
			if (inSequenceConfig.KeepUI.GetValueOrDefault())
			{
				list.Add("KeepUI");
			}
			if (inSequenceConfig.IsPlayOnTeleport.GetValueOrDefault())
			{
				list.Add("IsPlayOnTeleport");
			}
			if (inSequenceConfig.RateEase != null)
			{
				list.Add("RateEase");
			}
			if (list.Count == 0)
			{
				return;
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[RefCompLevelSequenceController] ManualTick(IsCarryCharacter)分支暂不支持以下配置,将被忽略,请勿与角色承载混用或改用引擎驱动";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Path", inSequenceConfig.LevelSequencePath);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("UnsupportedFields", string.Join(",", list));
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x060473DD RID: 291805 RVA: 0x0121D0BC File Offset: 0x0121B2BC
		private void HandleSequenceByManualTick(PlayLevelSequence inSequenceConfig)
		{
			string path = inSequenceConfig.LevelSequencePath;
			bool jumpToEnd = this.NextSequenceJumpToEnd;
			if (this.ManualTickDriver == null)
			{
				this.ManualTickDriver = new ManualTickSequenceDriver();
			}
			this.ManualTickLoadRequestId++;
			int requestId = this.ManualTickLoadRequestId;
			TTimerAction <>9__2;
			this.LoadResourceAsyncWithQueue<ULevelSequence>(path, delegate([Nullable(2)] UObject data, string _)
			{
				if (requestId != this.ManualTickLoadRequestId)
				{
					return;
				}
				if (data == null || !data.IsValid())
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.LevelEvent;
					ELogAuthor author = ELogAuthor.CK;
					string message = "[RefCompLevelSequenceController] 逐帧驱动 Sequence 加载失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", path);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				if (this.ManualTickDriver == null)
				{
					return;
				}
				Action frameEventCompensation = null;
				if (!string.IsNullOrEmpty(inSequenceConfig.Mark))
				{
					ALevelSequenceActor sequenceActor = this.ManualTickDriver.GetSequenceActor();
					int? num;
					if (sequenceActor == null)
					{
						num = null;
					}
					else
					{
						ULevelSequencePlayer sequencePlayer = sequenceActor.SequencePlayer;
						num = ((sequencePlayer != null) ? new int?(sequencePlayer.GetCurrentTime().Time.FrameNumber.Value) : null);
					}
					int? num2 = num;
					int valueOrDefault = num2.GetValueOrDefault();
					LevelSequenceFrameEventComponent eventComp = this.EventComp;
					if (eventComp != null)
					{
						eventComp.OnSequencePlayToMark(inSequenceConfig.Mark, valueOrDefault, jumpToEnd, path);
					}
					if (this.EventComp != null)
					{
						frameEventCompensation = new Action(this.EventComp.OnSequencePaused);
					}
				}
				Action onStopped = delegate()
				{
					Action frameEventCompensation = frameEventCompensation;
					if (frameEventCompensation != null)
					{
						frameEventCompensation();
					}
					TimerSystemInstance instance4 = TimerSystem.Instance;
					TTimerAction action;
					if ((action = <>9__2) == null)
					{
						action = (<>9__2 = delegate(float _)
						{
							ManualTickSequenceDriver manualTickDriver = this.ManualTickDriver;
							if (manualTickDriver != null && manualTickDriver.IsPlaying())
							{
								return;
							}
							this.UnregisterManualTickPreMove();
						});
					}
					instance4.Next(action, null, null);
				};
				this.ManualTickDriver.Play((ULevelSequence)data, inSequenceConfig, jumpToEnd, onStopped);
				if (!this.ManualTickDriver.IsPlaying())
				{
					global::Log instance2 = global::Log.Instance;
					ELogModule module2 = ELogModule.SceneItem;
					ELogAuthor author2 = ELogAuthor.CK;
					string message2 = "[RefCompLevelSequenceController] 逐帧驱动 Sequence 瞬时归位, 无需注册 PreMoveTick";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Path", path);
					instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return;
				}
				this.RegisterManualTickPreMove();
				global::Log instance3 = global::Log.Instance;
				ELogModule module3 = ELogModule.SceneItem;
				ELogAuthor author3 = ELogAuthor.CK;
				string message3 = "[RefCompLevelSequenceController] 逐帧驱动 Sequence 开始播放";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("Path", path);
				instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			}, ResourceSystem.EResourceLoadPriority.Default);
		}

		// Token: 0x060473DE RID: 291806 RVA: 0x0121D144 File Offset: 0x0121B344
		private int LoadResourceAsyncWithQueue<[Nullable(0)] T>(string path, [Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<UObject, string> callback, ResourceSystem.EResourceLoadPriority priority = ResourceSystem.EResourceLoadPriority.Default) where T : UObject
		{
			if (this.ResourceLoadCallbackHandleQueue == null)
			{
				this.ResourceLoadCallbackHandleQueue = new Queue<RefCompLevelSequenceController.ResourceLoadCallbackHandle>(4);
			}
			RefCompLevelSequenceController.ResourceLoadCallbackHandle handle = new RefCompLevelSequenceController.ResourceLoadCallbackHandle(path, callback);
			this.ResourceLoadCallbackHandleQueue.Push(handle);
			handle.ResourceSystemId = ResourceSystem.Instance.LoadAsync<T>(path, delegate([Nullable(2)] T asset, string loadPath)
			{
				this.OnResourceLoadAsyncCallback(handle, asset);
			}, priority, "js_undefined");
			return handle.ResourceSystemId;
		}

		// Token: 0x060473DF RID: 291807 RVA: 0x0121D1C4 File Offset: 0x0121B3C4
		private void OnResourceLoadAsyncCallback(RefCompLevelSequenceController.ResourceLoadCallbackHandle handle, [Nullable(2)] UObject asset)
		{
			handle.Asset = asset;
			handle.LoadAsyncFinished = true;
			while (this.ResourceLoadCallbackHandleQueue != null && !this.ResourceLoadCallbackHandleQueue.Empty)
			{
				RefCompLevelSequenceController.ResourceLoadCallbackHandle front = this.ResourceLoadCallbackHandleQueue.Front;
				if (front == null || !front.LoadAsyncFinished)
				{
					break;
				}
				RefCompLevelSequenceController.ResourceLoadCallbackHandle frontHandle = this.ResourceLoadCallbackHandleQueue.Pop();
				RefCompLevelSequenceController.ResourceLoadCallbackHandle frontHandle4 = frontHandle;
				if (RefCompDefine.PrePhysicsSequenceConfig.Check((frontHandle4 != null) ? frontHandle4.Path : null))
				{
					PlotController.Instance.NextAfterTick(delegate(float _)
					{
						RefCompLevelSequenceController.ResourceLoadCallbackHandle frontHandle3 = frontHandle;
						if (frontHandle3 == null)
						{
							return;
						}
						Action<UObject, string> callback2 = frontHandle3.Callback;
						if (callback2 == null)
						{
							return;
						}
						callback2(frontHandle.Asset, frontHandle.Path);
					});
				}
				else
				{
					RefCompLevelSequenceController.ResourceLoadCallbackHandle frontHandle2 = frontHandle;
					if (frontHandle2 != null)
					{
						Action<UObject, string> callback = frontHandle2.Callback;
						if (callback != null)
						{
							callback(frontHandle.Asset, frontHandle.Path);
						}
					}
				}
			}
		}

		// Token: 0x060473E0 RID: 291808 RVA: 0x0121D290 File Offset: 0x0121B490
		public bool ForceSwitchSceneCamera(bool bEnable)
		{
			if (this.SimpleSequenceActor == null)
			{
				if (bEnable)
				{
					global::Log.Instance.Info(ELogModule.SceneGameplay, ELogAuthor.JYS, "时间控制装置启动请求:失败，SimpleSequenceActor为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				return false;
			}
			return this.SimpleSequenceActor.ForceSwitchSceneCamera(bEnable);
		}

		// Token: 0x060473E1 RID: 291809 RVA: 0x0121D2D2 File Offset: 0x0121B4D2
		public void OnChangeTimeDilation(float timeDilation)
		{
			SimpleLevelSequenceActor simpleSequenceActor = this.SimpleSequenceActor;
			if (simpleSequenceActor != null)
			{
				simpleSequenceActor.SetTimeDilation(timeDilation);
			}
			ManualTickSequenceDriver manualTickDriver = this.ManualTickDriver;
			if (manualTickDriver == null)
			{
				return;
			}
			manualTickDriver.SetTimeDilation(timeDilation);
		}

		// Token: 0x060473E2 RID: 291810 RVA: 0x0121D2F7 File Offset: 0x0121B4F7
		public bool IsPlaying()
		{
			if (this.LockedDriveMode.GetValueOrDefault() == RefCompLevelSequenceController.ESequenceTickMode.ManualTick)
			{
				ManualTickSequenceDriver manualTickDriver = this.ManualTickDriver;
				return manualTickDriver != null && manualTickDriver.IsPlaying();
			}
			SimpleLevelSequenceActor simpleSequenceActor = this.SimpleSequenceActor;
			return simpleSequenceActor != null && simpleSequenceActor.IsPlaying();
		}

		// Token: 0x060473E3 RID: 291811 RVA: 0x0121D32A File Offset: 0x0121B52A
		[NullableContext(2)]
		public ALevelSequenceActor GetPlayingSequenceActor()
		{
			ManualTickSequenceDriver manualTickDriver = this.ManualTickDriver;
			ALevelSequenceActor result;
			if ((result = ((manualTickDriver != null) ? manualTickDriver.GetSequenceActor() : null)) == null)
			{
				SimpleLevelSequenceActor simpleSequenceActor = this.SimpleSequenceActor;
				if (simpleSequenceActor == null)
				{
					return null;
				}
				result = simpleSequenceActor.GetSequenceActor();
			}
			return result;
		}

		// Token: 0x060473E4 RID: 291812 RVA: 0x0121D354 File Offset: 0x0121B554
		public bool IsPlayToMarkFinished(string mark)
		{
			if (this.LockedDriveMode.GetValueOrDefault() == RefCompLevelSequenceController.ESequenceTickMode.ManualTick)
			{
				if (this.ManualTickDriver == null || this.ManualTickDriver.IsPlaying())
				{
					return false;
				}
				float? markTimeInSeconds = this.ManualTickDriver.GetMarkTimeInSeconds(mark);
				return markTimeInSeconds != null && MathF.Abs(this.ManualTickDriver.GetCurrentSeconds() - markTimeInSeconds.Value) <= 0.001f;
			}
			else
			{
				if (this.SimpleSequenceActor == null)
				{
					return false;
				}
				double? markValue = this.SimpleSequenceActor.GetMarkValue(mark);
				int? num = (markValue != null) ? new int?((int)markValue.GetValueOrDefault()) : null;
				return num != null && !this.IsPlaying() && this.SimpleSequenceActor.GetCurrentFrame() == num.Value;
			}
		}

		// Token: 0x060473E5 RID: 291813 RVA: 0x0121D424 File Offset: 0x0121B624
		public bool IsPlayBetweenMarks(string startMark, string endMark)
		{
			if (this.LockedDriveMode.GetValueOrDefault() == RefCompLevelSequenceController.ESequenceTickMode.ManualTick)
			{
				if (this.ManualTickDriver == null)
				{
					return false;
				}
				float? markTimeInSeconds = this.ManualTickDriver.GetMarkTimeInSeconds(startMark);
				float? markTimeInSeconds2 = this.ManualTickDriver.GetMarkTimeInSeconds(endMark);
				if (markTimeInSeconds == null || markTimeInSeconds2 == null)
				{
					return false;
				}
				float num = MathF.Min(markTimeInSeconds.Value, markTimeInSeconds2.Value);
				float num2 = MathF.Max(markTimeInSeconds.Value, markTimeInSeconds2.Value);
				float currentSeconds = this.ManualTickDriver.GetCurrentSeconds();
				return currentSeconds >= num && currentSeconds <= num2;
			}
			else
			{
				if (this.SimpleSequenceActor == null)
				{
					return false;
				}
				double? markValue = this.SimpleSequenceActor.GetMarkValue(startMark);
				double? markValue2 = this.SimpleSequenceActor.GetMarkValue(endMark);
				if (markValue == null || markValue2 == null)
				{
					return false;
				}
				double num3 = Math.Min(markValue.Value, markValue2.Value);
				double num4 = Math.Max(markValue.Value, markValue2.Value);
				int currentFrame = this.SimpleSequenceActor.GetCurrentFrame();
				return (double)currentFrame >= num3 && (double)currentFrame <= num4;
			}
		}

		// Token: 0x060473E6 RID: 291814 RVA: 0x0121D544 File Offset: 0x0121B744
		[return: Nullable(2)]
		public ISequenceProgressController CreateSequenceProgressController(string sequencePath)
		{
			if (StringUtils.IsBlank(sequencePath) || sequencePath == "None")
			{
				return null;
			}
			SplineConstrainedDragSequenceProgressController controller = new SplineConstrainedDragSequenceProgressController();
			this.LoadResourceAsyncWithQueue<ULevelSequence>(sequencePath, delegate([Nullable(2)] UObject data, string _)
			{
				controller.OnSequenceLoaded((ULevelSequence)data, sequencePath);
			}, ResourceSystem.EResourceLoadPriority.Default);
			return controller;
		}

		// Token: 0x04025772 RID: 153458
		[StaticVariableRuleIgnore]
		private static readonly Stat StatInstance = Stat.Create("RefCompLevelSequenceController", "", "");

		// Token: 0x04025773 RID: 153459
		[Nullable(2)]
		private LevelSequenceFrameEventComponent EventComp;

		// Token: 0x04025774 RID: 153460
		private readonly FloatingSubtitle2dCloseGuard SubtitleCloseGuard = new FloatingSubtitle2dCloseGuard();

		// Token: 0x04025775 RID: 153461
		[Nullable(2)]
		private EntityComponent HostComponent;

		// Token: 0x04025776 RID: 153462
		private RefCompLevelSequenceController.ESequenceTickMode? LockedDriveMode;

		// Token: 0x04025777 RID: 153463
		[Nullable(2)]
		private ManualTickSequenceDriver ManualTickDriver;

		// Token: 0x04025778 RID: 153464
		private int ManualTickLoadRequestId;

		// Token: 0x04025779 RID: 153465
		private bool ManualTickRegistered;

		// Token: 0x0402577A RID: 153466
		public bool NextSequenceJumpToEnd = true;

		// Token: 0x0402577B RID: 153467
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Queue<RefCompLevelSequenceController.ResourceLoadCallbackHandle> ResourceLoadCallbackHandleQueue;

		// Token: 0x0402577C RID: 153468
		[Nullable(2)]
		public SimpleLevelSequenceActor SimpleSequenceActor;

		// Token: 0x0200CF10 RID: 53008
		[Nullable(0)]
		private class ResourceLoadCallbackHandle
		{
			// Token: 0x06052028 RID: 335912 RVA: 0x01648D4C File Offset: 0x01646F4C
			public ResourceLoadCallbackHandle(string path, [Nullable(new byte[]
			{
				1,
				2,
				1
			})] Action<UObject, string> callback)
			{
			}

			// Token: 0x0403E455 RID: 255061
			[Nullable(new byte[]
			{
				1,
				2,
				1
			})]
			public readonly Action<UObject, string> Callback = callback;

			// Token: 0x0403E456 RID: 255062
			public readonly string Path = path;

			// Token: 0x0403E457 RID: 255063
			[Nullable(2)]
			public UObject Asset;

			// Token: 0x0403E458 RID: 255064
			public bool LoadAsyncFinished;

			// Token: 0x0403E459 RID: 255065
			public int ResourceSystemId = -1;
		}

		// Token: 0x0200CF11 RID: 53009
		[NullableContext(0)]
		private enum ESequenceTickMode
		{
			// Token: 0x0403E45B RID: 255067
			Engine,
			// Token: 0x0403E45C RID: 255068
			ManualTick
		}
	}
}
