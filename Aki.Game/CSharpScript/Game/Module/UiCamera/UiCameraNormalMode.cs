using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x0200399C RID: 14748
	[NullableContext(1)]
	[Nullable(0)]
	public class UiCameraNormalMode : UiCameraModeBase
	{
		// Token: 0x17004D88 RID: 19848
		// (get) Token: 0x06025FC8 RID: 155592 RVA: 0x00AA91A7 File Offset: 0x00AA73A7
		// (set) Token: 0x06025FC9 RID: 155593 RVA: 0x00AA91AF File Offset: 0x00AA73AF
		public EUiCameraNormalState State { get; private set; }

		// Token: 0x17004D89 RID: 19849
		// (get) Token: 0x06025FCA RID: 155594 RVA: 0x00AA91B8 File Offset: 0x00AA73B8
		public bool IsInputBlocked
		{
			get
			{
				return this.InputBlockReasons > EUiCameraInputBlockReason.None;
			}
		}

		// Token: 0x17004D8A RID: 19850
		// (get) Token: 0x06025FCB RID: 155595 RVA: 0x00AA91C3 File Offset: 0x00AA73C3
		public bool IsBlending
		{
			get
			{
				return base.GetComponent<UiCameraBlendComponent>().IsBlending;
			}
		}

		// Token: 0x17004D8B RID: 19851
		// (get) Token: 0x06025FCC RID: 155596 RVA: 0x00AA91D0 File Offset: 0x00AA73D0
		public bool IsPlayingSequence
		{
			get
			{
				return base.GetComponent<UiCameraSequenceComponent>().IsPlaying;
			}
		}

		// Token: 0x17004D8C RID: 19852
		// (get) Token: 0x06025FCD RID: 155597 RVA: 0x00AA91DD File Offset: 0x00AA73DD
		public bool IsPlayingBlendInSequence
		{
			get
			{
				return this.PlayingBlendInCameraSequence;
			}
		}

		// Token: 0x06025FCE RID: 155598 RVA: 0x00AA91E5 File Offset: 0x00AA73E5
		public bool IsCameraOutputTakenOverBySequence()
		{
			return this.CameraDetachedForSequence;
		}

		// Token: 0x06025FCF RID: 155599 RVA: 0x00AA91ED File Offset: 0x00AA73ED
		public void SetWorldLocation(FVectorDouble location)
		{
			base.GetComponent<UiCameraLogicComponent>().SetLocation(location);
			base.GetComponent<UiCameraBlendComponent>().SnapToDesired();
		}

		// Token: 0x06025FD0 RID: 155600 RVA: 0x00AA9206 File Offset: 0x00AA7406
		public void SetWorldRotation(FRotator rotation)
		{
			base.GetComponent<UiCameraLogicComponent>().SetRotation(rotation);
			base.GetComponent<UiCameraBlendComponent>().SnapToDesired();
		}

		// Token: 0x06025FD1 RID: 155601 RVA: 0x00AA9220 File Offset: 0x00AA7420
		protected override void RegisterComponents()
		{
			base.RegisterComponent(new UiCameraInputComponent());
			base.RegisterComponent(new UiCameraLogicComponent());
			base.RegisterComponent(new UiCameraBlendComponent());
			base.RegisterComponent(new UiCameraDisplayComponent());
			base.RegisterComponent(new UiCameraSequenceComponent());
			base.RegisterComponent(new UiCameraLoadingEffectComponent());
			base.RegisterComponent(new UiCameraActorDisplayComponent());
		}

		// Token: 0x06025FD2 RID: 155602 RVA: 0x00AA927C File Offset: 0x00AA747C
		internal bool RefreshHandleForActivation(UiCameraHandleData handleData)
		{
			UiCameraSequenceHandleData uiCameraSequenceHandleData = handleData as UiCameraSequenceHandleData;
			if (uiCameraSequenceHandleData != null && uiCameraSequenceHandleData.GetSequenceCameraData() == null)
			{
				SUiCameraAnimationSettings uiCameraAnimationConfig = UiCameraConfig.Instance.GetUiCameraAnimationConfig(handleData.GetHandleName());
				if (uiCameraAnimationConfig != null && UiCameraNormalMode.IsValidSequence(uiCameraAnimationConfig.BlendInCameraSequence))
				{
					if (!this.PlayingBlendInCameraSequence || this.PendingHandle != handleData)
					{
						uiCameraSequenceHandleData.ClearSequenceCameraData();
					}
					return uiCameraSequenceHandleData.RefreshConfigData(base.Owner.Model);
				}
			}
			return handleData.Refresh(base.Owner.Model);
		}

		// Token: 0x06025FD3 RID: 155603 RVA: 0x00AA92FC File Offset: 0x00AA74FC
		[NullableContext(2)]
		public unsafe bool PushCameraHandle([Nullable(1)] UiCameraHandleData handleData, UiCameraHandleData fromHandle = null, bool blend = true, bool playSequence = true, string blendName = null, [Nullable(new byte[]
		{
			2,
			1
		})] Action<UiCameraDefine.IFinishData> animationFinished = null)
		{
			UiCameraNormalMode.<>c__DisplayClass24_0 CS$<>8__locals1 = new UiCameraNormalMode.<>c__DisplayClass24_0();
			CS$<>8__locals1.handleData = handleData;
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.blend = blend;
			UiCameraNormalMode.<>c__DisplayClass24_0 CS$<>8__locals2 = CS$<>8__locals1;
			int operationId = this.OperationId + 1;
			this.OperationId = operationId;
			CS$<>8__locals2.operationId = operationId;
			this.StopSequence(true);
			base.GetComponent<UiCameraBlendComponent>().CancelBlend();
			base.GetComponent<UiCameraLoadingEffectComponent>().Stop();
			this.PendingHandle = null;
			if (!base.Owner.RefreshCameraActor())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCamera;
				ELogAuthor author = ELogAuthor.BB;
				string message = "激活镜头状态失败，UiCamera的CameraActor无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("HandleData", CS$<>8__locals1.handleData.ToString());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			base.GetComponent<UiCameraLogicComponent>().ResetForNewHandle();
			if (CS$<>8__locals1.handleData.ShouldSkipApply())
			{
				this.CommitActiveHandle(CS$<>8__locals1.handleData);
				EventSystem.Instance.Emit<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandle, CS$<>8__locals1.handleData);
				return true;
			}
			this.SetActive(true);
			this.PendingHandle = CS$<>8__locals1.handleData;
			SUiCameraAnimationSettings uiCameraAnimationConfig = CS$<>8__locals1.handleData.GetUiCameraAnimationConfig();
			UiCameraSequenceHandleData uiCameraSequenceHandleData = CS$<>8__locals1.handleData as UiCameraSequenceHandleData;
			bool flag = uiCameraSequenceHandleData != null && uiCameraSequenceHandleData.GetSequenceCameraData() == null && uiCameraAnimationConfig != null && UiCameraNormalMode.IsValidSequence(uiCameraAnimationConfig.BlendInCameraSequence);
			if (flag)
			{
				AActor targetActor = CS$<>8__locals1.handleData.GetTargetActor();
				if (targetActor == null || !targetActor.IsValid())
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.UiCamera;
					ELogAuthor author2 = ELogAuthor.BB;
					string message2 = "播放BlendIn相机Sequence失败，TargetActor无效";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("HandleData", CS$<>8__locals1.handleData.ToString());
					instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					this.PendingHandle = null;
					this.SetActive(false);
					return false;
				}
			}
			bool flag2 = false;
			if (flag)
			{
				flag2 = this.PlaySequence(uiCameraAnimationConfig.BlendInCameraSequence, uiCameraAnimationConfig.BlendInCameraSequencePlayRate, uiCameraAnimationConfig.bRevertBlendInCameraSequence, CS$<>8__locals1.handleData.GetTargetActor(), CS$<>8__locals1.operationId, true, true, delegate(bool completed)
				{
					if (!CS$<>8__locals1.handleData.Refresh(CS$<>8__locals1.<>4__this.Owner.Model))
					{
						Log instance4 = Log.Instance;
						ELogModule module4 = ELogModule.UiCamera;
						ELogAuthor author4 = ELogAuthor.BB;
						string message4 = "BlendIn相机Sequence结束后镜头状态刷新失败，等待重新激活";
						<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("HandleData", CS$<>8__locals1.handleData.ToString());
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Completed", completed);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("OperationId", CS$<>8__locals1.operationId);
						instance4.Warn(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
						CS$<>8__locals1.<>4__this.SuspendCameraHandle(CS$<>8__locals1.handleData);
						EventSystem.Instance.Emit<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandleFail, CS$<>8__locals1.handleData);
						return;
					}
					CS$<>8__locals1.<>4__this.ActivateHandle(CS$<>8__locals1.handleData, null, CS$<>8__locals1.blend, false, null, null, CS$<>8__locals1.operationId, false);
					if (completed)
					{
						EventSystem.Instance.Emit<UiCameraHandleData>(EEventName.OnUiBlendInCameraSequenceFinished, CS$<>8__locals1.handleData);
					}
				}, delegate
				{
					CS$<>8__locals1.<>4__this.EnterCameraForSequence(CS$<>8__locals1.handleData, CS$<>8__locals1.blend, CS$<>8__locals1.operationId);
				});
			}
			if (flag2)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.UiCamera;
				ELogAuthor author3 = ELogAuthor.BB;
				string message3 = "镜头状态数据------播放BlendIn相机Sequence";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("HandleData", CS$<>8__locals1.handleData.ToString());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("OperationId", CS$<>8__locals1.operationId);
				instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				EventSystem.Instance.Emit<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandle, CS$<>8__locals1.handleData);
				return true;
			}
			if (flag && !CS$<>8__locals1.handleData.Refresh(base.Owner.Model))
			{
				this.PendingHandle = null;
				this.SetActive(false);
				return false;
			}
			this.ActivateHandle(CS$<>8__locals1.handleData, fromHandle, CS$<>8__locals1.blend, playSequence, blendName, animationFinished, CS$<>8__locals1.operationId, true);
			return true;
		}

		// Token: 0x06025FD4 RID: 155604 RVA: 0x00AA95A8 File Offset: 0x00AA77A8
		[NullableContext(2)]
		public void PopCameraHandle([Nullable(1)] UiCameraHandleData fromHandle, UiCameraHandleData toHandle, bool blend, string blendName = null, Action onFinished = null)
		{
			UiCameraNormalMode.<>c__DisplayClass25_0 CS$<>8__locals1 = new UiCameraNormalMode.<>c__DisplayClass25_0();
			CS$<>8__locals1.onFinished = onFinished;
			CS$<>8__locals1.<>4__this = this;
			UiCameraNormalMode.<>c__DisplayClass25_0 CS$<>8__locals2 = CS$<>8__locals1;
			int operationId = this.OperationId + 1;
			this.OperationId = operationId;
			CS$<>8__locals2.operationId = operationId;
			this.StopSequence(true);
			base.GetComponent<UiCameraBlendComponent>().CancelBlend();
			base.GetComponent<UiCameraLoadingEffectComponent>().Stop();
			this.PendingHandle = toHandle;
			if (toHandle != null)
			{
				this.PushCameraHandle(toHandle, fromHandle, blend, blend, blendName, delegate(UiCameraDefine.IFinishData _)
				{
					Action onFinished2 = CS$<>8__locals1.onFinished;
					if (onFinished2 == null)
					{
						return;
					}
					onFinished2();
				});
				return;
			}
			SUiCameraAnimationSettings uiCameraAnimationConfig = fromHandle.GetUiCameraAnimationConfig();
			if (!blend)
			{
				base.Owner.Exit(0f, EViewTargetBlendFunction.VTBlend_Linear, 0f);
				this.FinishExit(CS$<>8__locals1.operationId, false, CS$<>8__locals1.onFinished);
				return;
			}
			bool flag = false;
			if (uiCameraAnimationConfig != null)
			{
				flag = this.PlaySequence(uiCameraAnimationConfig.BlendOutCameraSequence, uiCameraAnimationConfig.BlendOutCameraSequencePlayRate, uiCameraAnimationConfig.bRevertBlendOutCameraSequence, fromHandle.GetTargetActor(), CS$<>8__locals1.operationId, false, true, delegate(bool _)
				{
					CS$<>8__locals1.<>4__this.FinishExit(CS$<>8__locals1.operationId, true, CS$<>8__locals1.onFinished);
				}, null);
			}
			if (flag)
			{
				return;
			}
			if (uiCameraAnimationConfig != null && uiCameraAnimationConfig.bResetCameraTransform)
			{
				base.Owner.Model.ResetFightCameraRotation();
			}
			base.Owner.Exit((uiCameraAnimationConfig != null) ? uiCameraAnimationConfig.BlendOutTime : 0f, (uiCameraAnimationConfig != null) ? uiCameraAnimationConfig.BlendOutFunction : EViewTargetBlendFunction.VTBlend_Linear, (uiCameraAnimationConfig != null) ? uiCameraAnimationConfig.BlendOutExp : 0f);
			if (uiCameraAnimationConfig != null && uiCameraAnimationConfig.bResetCameraTransform)
			{
				FightCamera fightCamera = CameraModel.Instance.MainModel.FightCamera;
				if (fightCamera != null)
				{
					FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
					if (logicComponent != null)
					{
						logicComponent.ForceTickOutSide();
					}
				}
			}
			bool flag2 = false;
			if (uiCameraAnimationConfig != null)
			{
				flag2 = this.PlaySequence(uiCameraAnimationConfig.BlendOutSequence, uiCameraAnimationConfig.BlendOutPlayRate, uiCameraAnimationConfig.bBlendOutSequenceReverse, fromHandle.GetTargetActor(), CS$<>8__locals1.operationId, false, false, delegate(bool _)
				{
					CS$<>8__locals1.<>4__this.FinishExit(CS$<>8__locals1.operationId, false, CS$<>8__locals1.onFinished);
				}, null);
			}
			if (flag2)
			{
				return;
			}
			this.FinishExit(CS$<>8__locals1.operationId, false, CS$<>8__locals1.onFinished);
		}

		// Token: 0x06025FD5 RID: 155605 RVA: 0x00AA9780 File Offset: 0x00AA7980
		internal unsafe bool RestoreCameraHandle(UiCameraHandleData handleData)
		{
			if (!this.CameraActive || (this.ActiveHandle != handleData && this.PendingHandle != handleData))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCamera;
				ELogAuthor author = ELogAuthor.BB;
				string message = "恢复Ui镜头失败，栈顶Handle没有可恢复的表现状态";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("HandleData", handleData.ToString());
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item = "ActiveHandleData";
				UiCameraHandleData activeHandle = this.ActiveHandle;
				ptr = new ValueTuple<string, object>(item, (activeHandle != null) ? activeHandle.ToString() : null);
				ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
				string item2 = "PendingHandleData";
				UiCameraHandleData pendingHandle = this.PendingHandle;
				ptr2 = new ValueTuple<string, object>(item2, (pendingHandle != null) ? pendingHandle.ToString() : null);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return false;
			}
			if (!base.Owner.RefreshCameraActor())
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.UiCamera;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "恢复Ui镜头失败，CameraActor无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("HandleData", handleData.ToString());
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			if (!this.CameraDetachedForSequence && !base.GetComponent<UiCameraDisplayComponent>().RestoreCameraState())
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.UiCamera;
				ELogAuthor author3 = ELogAuthor.BB;
				string message3 = "恢复Ui镜头失败，没有有效的相机输出";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("HandleData", handleData.ToString());
				instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			if (!base.Owner.IsEntered)
			{
				base.Owner.Enter(0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null);
			}
			return true;
		}

		// Token: 0x06025FD6 RID: 155606 RVA: 0x00AA98E4 File Offset: 0x00AA7AE4
		[NullableContext(2)]
		internal UiCameraHandleData GetReactivationHandle(UiCameraHandleData stackTopHandle)
		{
			if (this.PlayingBlendInCameraSequence)
			{
				return this.PendingHandle ?? stackTopHandle;
			}
			if (this.IsBlending || this.IsPlayingSequence)
			{
				UiCameraHandleData result;
				if ((result = this.ActiveHandle) == null)
				{
					result = (this.PendingHandle ?? stackTopHandle);
				}
				return result;
			}
			if (this.PendingHandle != null)
			{
				return this.PendingHandle;
			}
			if (this.ActiveHandle != stackTopHandle)
			{
				return stackTopHandle;
			}
			return this.ActiveHandle;
		}

		// Token: 0x06025FD7 RID: 155607 RVA: 0x00AA994C File Offset: 0x00AA7B4C
		internal unsafe bool TryReactivateHandleDuringTransition(UiCameraHandleData handleData)
		{
			if (this.IsBlending)
			{
				if (this.ActiveHandle == handleData)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.UiCamera;
					ELogAuthor author = ELogAuthor.BB;
					string message = "Handle混合期间刷新当前表现数据，保留混合目标";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActiveHandleData", handleData.ToString());
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
					string item = "PendingHandleData";
					UiCameraHandleData pendingHandle = this.PendingHandle;
					ptr = new ValueTuple<string, object>(item, (pendingHandle != null) ? pendingHandle.ToString() : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("OperationId", this.OperationId);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					return true;
				}
				if (this.PendingHandle != handleData)
				{
					return false;
				}
				base.GetComponent<UiCameraLogicComponent>().Apply(handleData);
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.UiCamera;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "Handle混合期间刷新混合目标数据，保留当前混合";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
				string item2 = "ActiveHandleData";
				UiCameraHandleData activeHandle = this.ActiveHandle;
				ptr2 = new ValueTuple<string, object>(item2, (activeHandle != null) ? activeHandle.ToString() : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("PendingHandleData", handleData.ToString());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("OperationId", this.OperationId);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				return true;
			}
			else
			{
				if (!this.IsPlayingSequence)
				{
					return false;
				}
				if (this.ActiveHandle != handleData && this.PendingHandle != handleData)
				{
					return false;
				}
				if (!this.PlayingBlendInCameraSequence && this.ActiveHandle == handleData)
				{
					base.GetComponent<UiCameraLogicComponent>().Apply(handleData);
				}
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.UiCamera;
				ELogAuthor author3 = ELogAuthor.BB;
				string message3 = "Sequence播放期间刷新镜头数据，保留当前Sequence";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray4<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0);
				string item3 = "ActiveHandleData";
				UiCameraHandleData activeHandle2 = this.ActiveHandle;
				ptr3 = new ValueTuple<string, object>(item3, (activeHandle2 != null) ? activeHandle2.ToString() : null);
				ref ValueTuple<string, object> ptr4 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1);
				string item4 = "PendingHandleData";
				UiCameraHandleData pendingHandle2 = this.PendingHandle;
				ptr4 = new ValueTuple<string, object>(item4, (pendingHandle2 != null) ? pendingHandle2.ToString() : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("RefreshHandleData", handleData.ToString());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("OperationId", this.OperationId);
				instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 4));
				return true;
			}
		}

		// Token: 0x06025FD8 RID: 155608 RVA: 0x00AA9B91 File Offset: 0x00AA7D91
		internal void SuspendCameraHandle(UiCameraHandleData pendingHandle)
		{
			this.OperationId++;
			this.StopSequence(true);
			base.GetComponent<UiCameraBlendComponent>().CancelBlend();
			base.GetComponent<UiCameraLoadingEffectComponent>().Stop();
			this.PendingHandle = pendingHandle;
			this.SetActive(false);
		}

		// Token: 0x06025FD9 RID: 155609 RVA: 0x00AA9BCC File Offset: 0x00AA7DCC
		internal void SetInputBlocked(EUiCameraInputBlockReason reason, bool blocked)
		{
			if (blocked)
			{
				this.InputBlockReasons |= reason;
			}
			else
			{
				this.InputBlockReasons &= ~reason;
			}
			this.RefreshState();
		}

		// Token: 0x06025FDA RID: 155610 RVA: 0x00AA9BF6 File Offset: 0x00AA7DF6
		internal void SetActive(bool active)
		{
			this.CameraActive = active;
			if (!active)
			{
				this.InputBlockReasons = EUiCameraInputBlockReason.None;
			}
			this.RefreshState();
		}

		// Token: 0x06025FDB RID: 155611 RVA: 0x00AA9C0F File Offset: 0x00AA7E0F
		protected override void OnEnter()
		{
			this.RefreshState();
		}

		// Token: 0x06025FDC RID: 155612 RVA: 0x00AA9C17 File Offset: 0x00AA7E17
		protected override void OnExit()
		{
			this.StopSequence(false);
			base.GetComponent<UiCameraBlendComponent>().CancelBlend();
			base.GetComponent<UiCameraLoadingEffectComponent>().Stop();
			this.PendingHandle = null;
			this.ActiveHandle = null;
			this.SetActive(false);
		}

		// Token: 0x06025FDD RID: 155613 RVA: 0x00AA9C4C File Offset: 0x00AA7E4C
		[NullableContext(2)]
		private unsafe void ActivateHandle([Nullable(1)] UiCameraHandleData handleData, UiCameraHandleData fromHandle, bool blend, bool playSequence, string blendName, [Nullable(new byte[]
		{
			2,
			1
		})] Action<UiCameraDefine.IFinishData> animationFinished, int operationId, bool emitActivatedEvent = true)
		{
			SUiCameraAnimationBlendSettings blendSettings = this.GetBlendSettings(fromHandle, blend, blendName);
			bool flag = blendSettings != null && blendSettings.Time > 0f && fromHandle != null;
			if (flag)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCamera;
				ELogAuthor author = ELogAuthor.BB;
				string message = "镜头状态数据------开始Handle混合";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("LastHandleData", fromHandle.ToString());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PushHandleData", handleData.ToString());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("BlendName", blendName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("BlendTime", blendSettings.Time);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				EventSystem.Instance.Emit<UiCameraHandleData, UiCameraHandleData, string>(EEventName.OnPlayCameraAnimationStart, fromHandle, handleData, blendName ?? string.Empty);
				base.GetComponent<UiCameraBlendComponent>().BeginHandleBlend(blendSettings, delegate(bool completed)
				{
					this.OnBlendFinished(operationId, fromHandle, handleData, completed, animationFinished);
				});
				this.PlaySequence(blendSettings.LevelSequence, blendSettings.PlayRate, blendSettings.bReverse, handleData.GetTargetActor(), operationId, false, false, delegate(bool _)
				{
					this.TryPlayLoadingEffectAfterTransition(handleData);
				}, null);
			}
			base.Apply(handleData);
			if (flag)
			{
				this.PendingHandle = handleData;
			}
			else
			{
				this.CommitActiveHandle(handleData);
			}
			if (!base.Owner.IsEntered)
			{
				float num;
				if (!blend)
				{
					num = 0f;
				}
				else
				{
					SUiCameraAnimationSettings uiCameraAnimationConfig = handleData.GetUiCameraAnimationConfig();
					num = ((uiCameraAnimationConfig != null) ? uiCameraAnimationConfig.BlendInTime : 0f);
				}
				float num2 = num;
				if (num2 > 0f)
				{
					this.SetInputBlocked(EUiCameraInputBlockReason.Blend, true);
				}
				UiCamera owner = base.Owner;
				float blendTime = num2;
				SUiCameraAnimationSettings uiCameraAnimationConfig2 = handleData.GetUiCameraAnimationConfig();
				EViewTargetBlendFunction blendFunction = (uiCameraAnimationConfig2 != null) ? uiCameraAnimationConfig2.BlendInFunction : EViewTargetBlendFunction.VTBlend_Linear;
				SUiCameraAnimationSettings uiCameraAnimationConfig3 = handleData.GetUiCameraAnimationConfig();
				owner.Enter(blendTime, blendFunction, (uiCameraAnimationConfig3 != null) ? uiCameraAnimationConfig3.BlendInExp : 0f, delegate
				{
					if (operationId != this.OperationId || this.ActiveHandle != handleData)
					{
						return;
					}
					this.SetInputBlocked(EUiCameraInputBlockReason.Blend, false);
					EventSystem.Instance.Emit<UiCameraHandleData>(EEventName.OnUiBlendInTimeCameraFinished, handleData);
				});
			}
			if (emitActivatedEvent)
			{
				SUiCameraAnimationSettings uiCameraAnimationConfig4 = handleData.GetUiCameraAnimationConfig();
				if (uiCameraAnimationConfig4 != null && uiCameraAnimationConfig4.bResetCameraTransform)
				{
					base.Owner.Model.ResetFightCameraRotation();
				}
			}
			if (!flag)
			{
				bool playSequence2 = playSequence && fromHandle == null;
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.UiCamera;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "没有有效的Handle混合配置，直接激活镜头状态";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
				string item = "LastHandleData";
				UiCameraHandleData fromHandle2 = fromHandle;
				ptr = new ValueTuple<string, object>(item, (fromHandle2 != null) ? fromHandle2.ToString() : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("PushHandleData", handleData.ToString());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Blend", blend);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("BlendName", blendName);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
				if (!this.PlayBlendInSequence(handleData, playSequence2, operationId))
				{
					this.TryPlayLoadingEffect(handleData);
				}
			}
			if (!flag && emitActivatedEvent)
			{
				EventSystem.Instance.Emit<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandle, handleData);
			}
		}

		// Token: 0x06025FDE RID: 155614 RVA: 0x00AA9FC0 File Offset: 0x00AA81C0
		private bool PlayBlendInSequence(UiCameraHandleData handleData, bool playSequence, int operationId)
		{
			SUiCameraAnimationSettings uiCameraAnimationConfig = handleData.GetUiCameraAnimationConfig();
			return playSequence && !(uiCameraAnimationConfig == null) && this.PlaySequence(uiCameraAnimationConfig.BlendInSequence, uiCameraAnimationConfig.BlendInPlayRate, uiCameraAnimationConfig.bBlendInSequenceReverse, handleData.GetTargetActor(), operationId, false, false, delegate(bool _)
			{
				this.TryPlayLoadingEffectAfterTransition(handleData);
			}, null);
		}

		// Token: 0x06025FDF RID: 155615 RVA: 0x00AAA030 File Offset: 0x00AA8230
		private void TryPlayLoadingEffect(UiCameraHandleData handleData)
		{
			string viewName = handleData.GetViewName();
			if (string.IsNullOrEmpty(viewName))
			{
				return;
			}
			if (!UiCameraConfig.Instance.ShouldPlayLoadingCameraAnimation(viewName) || !UiManager.Instance.IsViewCreating((EUiViewName)viewName))
			{
				base.GetComponent<UiCameraLoadingEffectComponent>().Stop();
				return;
			}
			UiCameraConfig instance = UiCameraConfig.Instance;
			base.GetComponent<UiCameraLoadingEffectComponent>().Play(instance.GetLoadingCameraAnimationLength(), instance.GetLoadingCameraFocalDistance(), instance.GetLoadingCameraAperture());
		}

		// Token: 0x06025FE0 RID: 155616 RVA: 0x00AAA09B File Offset: 0x00AA829B
		private void TryPlayLoadingEffectAfterTransition(UiCameraHandleData handleData)
		{
			if (!this.IsBlending && !this.IsPlayingSequence)
			{
				this.TryPlayLoadingEffect(handleData);
			}
		}

		// Token: 0x06025FE1 RID: 155617 RVA: 0x00AAA0B4 File Offset: 0x00AA82B4
		private unsafe void OnBlendFinished(int operationId, UiCameraHandleData fromHandle, UiCameraHandleData toHandle, bool completed, [Nullable(new byte[]
		{
			2,
			1
		})] Action<UiCameraDefine.IFinishData> animationFinished)
		{
			UiCameraDefine.FinishData finishData = new UiCameraDefine.FinishData
			{
				FinishType = (completed ? ECameraAnimationFinishType.Finished : ECameraAnimationFinishType.Stop),
				FromHandleData = fromHandle,
				ToHandleData = toHandle
			};
			if (animationFinished != null)
			{
				animationFinished(finishData);
			}
			EventSystem.Instance.Emit<UiCameraDefine.IFinishData>(EEventName.OnPlayCameraAnimationFinish, finishData);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiCamera;
			ELogAuthor author = ELogAuthor.BB;
			string message = completed ? "镜头状态数据------Handle混合结束" : "镜头状态数据------Handle混合被停止";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("LastHandleData", fromHandle.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PushHandleData", toHandle.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("OperationId", operationId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			if (operationId != this.OperationId)
			{
				return;
			}
			if (completed)
			{
				this.CommitActiveHandle(toHandle);
				this.TryPlayLoadingEffectAfterTransition(toHandle);
				EventSystem.Instance.Emit<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandle, toHandle);
			}
		}

		// Token: 0x06025FE2 RID: 155618 RVA: 0x00AAA1B2 File Offset: 0x00AA83B2
		[NullableContext(2)]
		private SUiCameraAnimationBlendSettings GetBlendSettings(UiCameraHandleData fromHandle, bool blend, string blendName)
		{
			if (!blend || fromHandle == null || string.IsNullOrEmpty(blendName))
			{
				return null;
			}
			return UiCameraConfig.Instance.GetUiCameraAnimationBlendData(blendName);
		}

		// Token: 0x06025FE3 RID: 155619 RVA: 0x00AAA1D0 File Offset: 0x00AA83D0
		[NullableContext(2)]
		private void FinishExit(int operationId, bool exitCamera = true, Action onFinished = null)
		{
			if (operationId != this.OperationId)
			{
				return;
			}
			this.OperationId++;
			this.PendingHandle = null;
			this.ActiveHandle = null;
			this.StopSequence(false);
			if (exitCamera)
			{
				base.Owner.Exit(0f, EViewTargetBlendFunction.VTBlend_Linear, 0f);
			}
			this.SetActive(false);
			if (onFinished != null)
			{
				onFinished();
			}
		}

		// Token: 0x06025FE4 RID: 155620 RVA: 0x00AAA234 File Offset: 0x00AA8434
		[NullableContext(2)]
		private unsafe bool PlaySequence([Nullable(1)] TSoftObjectPtr<ULevelSequence> sequence, float playRate, bool reverse, AActor originActor, int operationId, bool blendInCameraSequence, bool takeOverCamera, Action<bool> onFinished = null, Action onStarted = null)
		{
			if (!UiCameraNormalMode.IsValidSequence(sequence))
			{
				return false;
			}
			this.PlayingBlendInCameraSequence = blendInCameraSequence;
			this.SetInputBlocked(EUiCameraInputBlockReason.Sequence, true);
			if (takeOverCamera)
			{
				base.GetComponent<UiCameraDisplayComponent>().DetachCameraForSequence();
				this.CameraDetachedForSequence = true;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiCamera;
			ELogAuthor author = ELogAuthor.BB;
			string message = "开始播放Ui相机Sequence";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Sequence", sequence.ToAssetPathName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("OperationId", operationId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("TakeOverCamera", takeOverCamera);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("CameraDetached", this.CameraDetachedForSequence);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4);
			string item = "HandleData";
			UiCameraHandleData uiCameraHandleData = this.PendingHandle ?? this.ActiveHandle;
			ptr = new ValueTuple<string, object>(item, (uiCameraHandleData != null) ? uiCameraHandleData.ToString() : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			if (base.GetComponent<UiCameraSequenceComponent>().PlaySequence(sequence, playRate, reverse, originActor, delegate(bool completed)
			{
				if (operationId != this.OperationId)
				{
					return;
				}
				this.FinishSequence();
				Action<bool> onFinished2 = onFinished;
				if (onFinished2 == null)
				{
					return;
				}
				onFinished2(completed);
			}, onStarted))
			{
				return true;
			}
			this.FinishSequence();
			return false;
		}

		// Token: 0x06025FE5 RID: 155621 RVA: 0x00AAA38C File Offset: 0x00AA858C
		private void EnterCameraForSequence(UiCameraHandleData handleData, bool blend, int operationId)
		{
			if (operationId != this.OperationId || this.PendingHandle != handleData || base.Owner.IsEntered)
			{
				return;
			}
			SUiCameraAnimationSettings uiCameraAnimationConfig = handleData.GetUiCameraAnimationConfig();
			base.Owner.Enter(blend ? ((uiCameraAnimationConfig != null) ? uiCameraAnimationConfig.BlendInTime : 0f) : 0f, (uiCameraAnimationConfig != null) ? uiCameraAnimationConfig.BlendInFunction : EViewTargetBlendFunction.VTBlend_Linear, (uiCameraAnimationConfig != null) ? uiCameraAnimationConfig.BlendInExp : 0f, null);
		}

		// Token: 0x06025FE6 RID: 155622 RVA: 0x00AAA40C File Offset: 0x00AA860C
		private void StopSequence(bool notifyInterrupted = true)
		{
			base.GetComponent<UiCameraSequenceComponent>().StopSequence(notifyInterrupted);
			this.FinishSequence();
		}

		// Token: 0x06025FE7 RID: 155623 RVA: 0x00AAA420 File Offset: 0x00AA8620
		internal unsafe void RefreshBlendInCameraSequenceOutput()
		{
			if (this.PlayingBlendInCameraSequence && this.CameraDetachedForSequence)
			{
				UiCameraSequenceHandleData uiCameraSequenceHandleData = this.PendingHandle as UiCameraSequenceHandleData;
				if (uiCameraSequenceHandleData != null)
				{
					if (!uiCameraSequenceHandleData.RefreshCameraSequenceData(base.Owner.CameraActor, base.Owner.CineCameraComponent))
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.UiCamera;
						ELogAuthor author = ELogAuthor.BB;
						string message = "保存BlendIn相机Sequence输出失败，CameraActor无效";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("HandleData", this.PendingHandle.ToString());
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("OperationId", this.OperationId);
						instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						return;
					}
					if (!uiCameraSequenceHandleData.Refresh(base.Owner.Model))
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.UiCamera;
						ELogAuthor author2 = ELogAuthor.BB;
						string message2 = "BlendIn相机Sequence输出解析失败";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("HandleData", uiCameraSequenceHandleData.ToString());
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("OperationId", this.OperationId);
						instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
						return;
					}
					base.GetComponent<UiCameraLogicComponent>().Apply(uiCameraSequenceHandleData);
					base.GetComponent<UiCameraBlendComponent>().SnapToDesired();
					return;
				}
			}
		}

		// Token: 0x06025FE8 RID: 155624 RVA: 0x00AAA560 File Offset: 0x00AA8760
		private unsafe void FinishSequence()
		{
			bool cameraDetachedForSequence = this.CameraDetachedForSequence;
			this.PlayingBlendInCameraSequence = false;
			if (this.CameraDetachedForSequence)
			{
				this.CameraDetachedForSequence = false;
				base.GetComponent<UiCameraDisplayComponent>().AttachCameraAfterSequence();
			}
			this.SetInputBlocked(EUiCameraInputBlockReason.Sequence, false);
			if (cameraDetachedForSequence)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCamera;
				ELogAuthor author = ELogAuthor.BB;
				string message = "结束Ui相机Sequence并恢复普通相机挂接";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("OperationId", this.OperationId);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item = "HandleData";
				UiCameraHandleData pendingHandle = this.PendingHandle;
				ptr = new ValueTuple<string, object>(item, (pendingHandle != null) ? pendingHandle.ToString() : null);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}

		// Token: 0x06025FE9 RID: 155625 RVA: 0x00AAA60C File Offset: 0x00AA880C
		private static bool IsValidSequence(TSoftObjectPtr<ULevelSequence> sequence)
		{
			TSoftObjectPtr<UObject> tsoftObjectPtr = new TSoftObjectPtr<UObject>(sequence);
			return UKismetSystemLibrary.IsValidSoftObjectReference(tsoftObjectPtr);
		}

		// Token: 0x06025FEA RID: 155626 RVA: 0x00AAA627 File Offset: 0x00AA8827
		private void CommitActiveHandle(UiCameraHandleData handleData)
		{
			this.ActiveHandle = handleData;
			this.PendingHandle = null;
		}

		// Token: 0x06025FEB RID: 155627 RVA: 0x00AAA638 File Offset: 0x00AA8838
		private void RefreshState()
		{
			if (!this.CameraActive)
			{
				this.State = EUiCameraNormalState.Inactive;
			}
			else if ((this.InputBlockReasons & EUiCameraInputBlockReason.Sequence) != EUiCameraInputBlockReason.None)
			{
				this.State = EUiCameraNormalState.PlayingCameraSequence;
			}
			else if ((this.InputBlockReasons & EUiCameraInputBlockReason.Blend) != EUiCameraInputBlockReason.None)
			{
				this.State = EUiCameraNormalState.Blending;
			}
			else
			{
				this.State = EUiCameraNormalState.Active;
			}
			base.GetComponent<UiCameraInputComponent>().SetModeBlocked(!this.CameraActive || this.IsInputBlocked);
		}

		// Token: 0x04014E24 RID: 85540
		private EUiCameraInputBlockReason InputBlockReasons;

		// Token: 0x04014E25 RID: 85541
		private bool CameraActive;

		// Token: 0x04014E26 RID: 85542
		[Nullable(2)]
		private UiCameraHandleData ActiveHandle;

		// Token: 0x04014E27 RID: 85543
		[Nullable(2)]
		private UiCameraHandleData PendingHandle;

		// Token: 0x04014E28 RID: 85544
		private int OperationId;

		// Token: 0x04014E29 RID: 85545
		private bool PlayingBlendInCameraSequence;

		// Token: 0x04014E2A RID: 85546
		private bool CameraDetachedForSequence;
	}
}
