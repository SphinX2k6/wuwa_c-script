using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.TurntableControl
{
	// Token: 0x02005B19 RID: 23321
	[NullableContext(2)]
	[Nullable(0)]
	public class TurntableControlView : UiViewBase
	{
		// Token: 0x06039607 RID: 235015 RVA: 0x01019FA0 File Offset: 0x010181A0
		[NullableContext(1)]
		public TurntableControlView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06039608 RID: 235016 RVA: 0x01019FAC File Offset: 0x010181AC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnBtnResetClicked)),
				new ValueTuple<int, Delegate>(1, new Action(this.OnBtnSwitchClicked)),
				new ValueTuple<int, Delegate>(3, new Action(this.OnBtnBackClicked))
			};
			if (TurntableControlController.Instance.GetControlType().GetValueOrDefault() == EControllerType.FixedAngle)
			{
				this.BtnBindInfo.Add(new ValueTuple<int, Delegate>(2, new Action(this.OnBtnRotateClicked)));
			}
		}

		// Token: 0x06039609 RID: 235017 RVA: 0x0101A0A4 File Offset: 0x010182A4
		protected override void OnStart()
		{
			this.BtnReset = base.GetButton(0);
			this.BtnSwitch = base.GetButton(1);
			this.BtnRotate = base.GetButton(2);
			this.BtnBack = base.GetButton(3);
			EControllerType? controlType = TurntableControlController.Instance.GetControlType();
			EControllerType econtrollerType = EControllerType.FreeAngle;
			if (controlType.GetValueOrDefault() == econtrollerType & controlType != null)
			{
				this.BtnRotate.OnPointDownCallBack.Bind(new Action(this.OnBtnRotateDown));
				this.BtnRotate.OnPointUpCallBack.Bind(new Action(this.OnBtnRotateUp));
				UiComponentUtil.BindAudioEvent(this.BtnRotate);
			}
		}

		// Token: 0x0603960A RID: 235018 RVA: 0x0101A149 File Offset: 0x01018349
		protected override void OnBeforeShow()
		{
			UiTimeDilation.Instance.AddWaitSetTimeDilationTag("TurntableControl");
		}

		// Token: 0x0603960B RID: 235019 RVA: 0x0101A15A File Offset: 0x0101835A
		protected override void OnAfterHide()
		{
			UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("TurntableControl");
		}

		// Token: 0x0603960C RID: 235020 RVA: 0x0101A16C File Offset: 0x0101836C
		protected override void OnBeforeDestroy()
		{
			TurntableControlController.Instance.HandleTurntableControlViewClose();
			if (this.BtnRotate.OnPointDownCallBack.IsBound())
			{
				this.BtnRotate.OnPointDownCallBack.Unbind();
			}
			if (this.BtnRotate.OnPointUpCallBack.IsBound())
			{
				this.BtnRotate.OnPointUpCallBack.Unbind();
			}
			UiComponentUtil.UnBindAudioEvent(this.BtnRotate);
			this.BtnReset = null;
			this.BtnSwitch = null;
			this.BtnRotate = null;
			this.BtnBack = null;
		}

		// Token: 0x0603960D RID: 235021 RVA: 0x0101A1F0 File Offset: 0x010183F0
		protected override void OnAfterShow()
		{
			if (TurntableControlController.Instance.IsAllRingsAtTarget())
			{
				this.BtnReset.SetSelfInteractive(false);
				this.BtnSwitch.SetSelfInteractive(false);
				this.BtnRotate.SetSelfInteractive(false);
			}
			if (!this.OpenViewSeqEventTriggered)
			{
				Log.Instance.Info(ELogModule.SceneItem, ELogAuthor.ZYL, "[TurntableControlView] Seq事件未触发过，初始隐藏UI", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.GetRootItem().SetUIActive(false);
			}
		}

		// Token: 0x0603960E RID: 235022 RVA: 0x0101A260 File Offset: 0x01018460
		protected override void OnAddEventListener()
		{
			Entity controllerEntity = TurntableControlController.Instance.GetControllerEntity();
			if (controllerEntity != null && !EventSystem.Instance.HasWithTarget(controllerEntity, EEventName.OnTurntableControllerBusyStateChange, new Action<bool, bool>(this.OnTurntableControllerBusyStateChange)))
			{
				EventSystem.Instance.AddWithTarget(controllerEntity, EEventName.OnTurntableControllerBusyStateChange, new Action<bool, bool>(this.OnTurntableControllerBusyStateChange));
			}
			EventSystem.Instance.Add(EEventName.OnExecuteUiCameraSequenceEvent, new Action<string>(this.OnExecuteUiCameraSequenceEvent));
		}

		// Token: 0x0603960F RID: 235023 RVA: 0x0101A2D4 File Offset: 0x010184D4
		protected override void OnRemoveEventListener()
		{
			Entity controllerEntity = TurntableControlController.Instance.GetControllerEntity();
			if (controllerEntity != null && EventSystem.Instance.HasWithTarget(controllerEntity, EEventName.OnTurntableControllerBusyStateChange, new Action<bool, bool>(this.OnTurntableControllerBusyStateChange)))
			{
				EventSystem.Instance.RemoveWithTarget(controllerEntity, EEventName.OnTurntableControllerBusyStateChange, new Action<bool, bool>(this.OnTurntableControllerBusyStateChange));
			}
			EventSystem.Instance.Remove(EEventName.OnExecuteUiCameraSequenceEvent, new Action<string>(this.OnExecuteUiCameraSequenceEvent));
		}

		// Token: 0x06039610 RID: 235024 RVA: 0x0101A348 File Offset: 0x01018548
		[NullableContext(1)]
		private void OnExecuteUiCameraSequenceEvent(string sequenceEventName)
		{
			if (sequenceEventName == "OnOpenTurntableControlViewBlackScreen")
			{
				this.OpenViewSeqEventTriggered = true;
				TurntableControlController.Instance.SelectRingByIndex(0, true);
				Log.Instance.Info(ELogModule.SceneItem, ELogAuthor.ZYL, "[TurntableControlView] Seq触发黑幕进入事件，显示UI", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.GetRootItem().SetUIActive(true);
			}
		}

		// Token: 0x06039611 RID: 235025 RVA: 0x0101A3A0 File Offset: 0x010185A0
		private void OnTurntableControllerBusyStateChange(bool isBusyRotating, bool isBusyAnimating)
		{
			if (isBusyAnimating)
			{
				this.BtnReset.SetSelfInteractive(false);
				this.BtnSwitch.SetSelfInteractive(false);
				this.BtnRotate.SetSelfInteractive(false);
				this.BtnBack.SetSelfInteractive(false);
				return;
			}
			if (isBusyRotating)
			{
				this.BtnReset.SetSelfInteractive(false);
				this.BtnSwitch.SetSelfInteractive(true);
				if (TurntableControlController.Instance.GetControlType().GetValueOrDefault() == EControllerType.FixedAngle)
				{
					this.BtnRotate.SetSelfInteractive(false);
				}
				else
				{
					this.BtnRotate.SetSelfInteractive(true);
				}
				this.BtnBack.SetSelfInteractive(false);
				return;
			}
			this.BtnReset.SetSelfInteractive(true);
			this.BtnSwitch.SetSelfInteractive(true);
			this.BtnRotate.SetSelfInteractive(true);
			this.BtnBack.SetSelfInteractive(true);
		}

		// Token: 0x06039612 RID: 235026 RVA: 0x0101A468 File Offset: 0x01018668
		private void OnBtnResetClicked()
		{
			this.OnTurntableControllerBusyStateChange(false, true);
			this.OnBtnResetClickedImp();
		}

		// Token: 0x06039613 RID: 235027 RVA: 0x0101A47C File Offset: 0x0101867C
		private UniTask OnBtnResetClickedImp()
		{
			TurntableControlView.<OnBtnResetClickedImp>d__18 <OnBtnResetClickedImp>d__;
			<OnBtnResetClickedImp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBtnResetClickedImp>d__.<>4__this = this;
			<OnBtnResetClickedImp>d__.<>1__state = -1;
			<OnBtnResetClickedImp>d__.<>t__builder.Start<TurntableControlView.<OnBtnResetClickedImp>d__18>(ref <OnBtnResetClickedImp>d__);
			return <OnBtnResetClickedImp>d__.<>t__builder.Task;
		}

		// Token: 0x06039614 RID: 235028 RVA: 0x0101A4BF File Offset: 0x010186BF
		private void OnBtnSwitchClicked()
		{
			TurntableControlController.Instance.SwitchSelectedRing();
		}

		// Token: 0x06039615 RID: 235029 RVA: 0x0101A4CB File Offset: 0x010186CB
		private void OnBtnRotateClicked()
		{
			TurntableControlController.Instance.StartRotateSelected();
		}

		// Token: 0x06039616 RID: 235030 RVA: 0x0101A4D7 File Offset: 0x010186D7
		private void OnBtnRotateDown()
		{
			TurntableControlController.Instance.StartRotateSelected();
		}

		// Token: 0x06039617 RID: 235031 RVA: 0x0101A4E3 File Offset: 0x010186E3
		private void OnBtnRotateUp()
		{
			TurntableControlController.Instance.StopAllRotate();
		}

		// Token: 0x06039618 RID: 235032 RVA: 0x0101A4EF File Offset: 0x010186EF
		private void OnBtnBackClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401E41B RID: 123931
		private UUIButtonComponent BtnReset;

		// Token: 0x0401E41C RID: 123932
		private UUIButtonComponent BtnSwitch;

		// Token: 0x0401E41D RID: 123933
		private UUIButtonComponent BtnRotate;

		// Token: 0x0401E41E RID: 123934
		private UUIButtonComponent BtnBack;

		// Token: 0x0401E41F RID: 123935
		private bool OpenViewSeqEventTriggered;

		// Token: 0x0200B71B RID: 46875
		[NullableContext(0)]
		public enum ETurntableControlView
		{
			// Token: 0x040389C9 RID: 231881
			BtnReset,
			// Token: 0x040389CA RID: 231882
			BtnSwitch,
			// Token: 0x040389CB RID: 231883
			BtnRotate,
			// Token: 0x040389CC RID: 231884
			BtnBack
		}
	}
}
