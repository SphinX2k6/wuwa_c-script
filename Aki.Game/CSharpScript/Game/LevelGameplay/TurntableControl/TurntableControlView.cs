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
	// Token: 0x020069BD RID: 27069
	[NullableContext(2)]
	[Nullable(0)]
	public class TurntableControlView : UiViewBase
	{
		// Token: 0x060435CB RID: 275915 RVA: 0x01075B0C File Offset: 0x01073D0C
		[NullableContext(1)]
		public TurntableControlView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060435CC RID: 275916 RVA: 0x01075B18 File Offset: 0x01073D18
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
			if (TurntableControlController.Instance.GetControlType().GetValueOrDefault() == Aki.TDConfigMgr.Component.EControllerType.FixedAngle)
			{
				this.BtnBindInfo.Add(new ValueTuple<int, Delegate>(2, new Action(this.OnBtnRotateClicked)));
			}
		}

		// Token: 0x060435CD RID: 275917 RVA: 0x01075C10 File Offset: 0x01073E10
		protected override void OnStart()
		{
			this.BtnReset = base.GetButton(0);
			this.BtnSwitch = base.GetButton(1);
			this.BtnRotate = base.GetButton(2);
			this.BtnBack = base.GetButton(3);
			Aki.TDConfigMgr.Component.EControllerType? controlType = TurntableControlController.Instance.GetControlType();
			Aki.TDConfigMgr.Component.EControllerType econtrollerType = Aki.TDConfigMgr.Component.EControllerType.FreeAngle;
			if (controlType.GetValueOrDefault() == econtrollerType & controlType != null)
			{
				this.BtnRotate.OnPointDownCallBack.Bind(new Action(this.OnBtnRotateDown));
				this.BtnRotate.OnPointUpCallBack.Bind(new Action(this.OnBtnRotateUp));
				UiComponentUtil.BindAudioEvent(this.BtnRotate);
			}
		}

		// Token: 0x060435CE RID: 275918 RVA: 0x01075CB5 File Offset: 0x01073EB5
		protected override void OnBeforeShow()
		{
			UiTimeDilation.Instance.AddWaitSetTimeDilationTag("TurntableControl");
		}

		// Token: 0x060435CF RID: 275919 RVA: 0x01075CC6 File Offset: 0x01073EC6
		protected override void OnAfterHide()
		{
			UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("TurntableControl");
		}

		// Token: 0x060435D0 RID: 275920 RVA: 0x01075CD8 File Offset: 0x01073ED8
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

		// Token: 0x060435D1 RID: 275921 RVA: 0x01075D5C File Offset: 0x01073F5C
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

		// Token: 0x060435D2 RID: 275922 RVA: 0x01075DCC File Offset: 0x01073FCC
		protected override void OnAddEventListener()
		{
			Entity controllerEntity = TurntableControlController.Instance.GetControllerEntity();
			if (controllerEntity != null && !EventSystem.Instance.HasWithTarget(controllerEntity, EEventName.OnTurntableControllerBusyStateChange, new Action<bool, bool>(this.OnTurntableControllerBusyStateChange)))
			{
				EventSystem.Instance.AddWithTarget(controllerEntity, EEventName.OnTurntableControllerBusyStateChange, new Action<bool, bool>(this.OnTurntableControllerBusyStateChange));
			}
			EventSystem.Instance.Add(EEventName.OnExecuteUiCameraSequenceEvent, new Action<string>(this.OnExecuteUiCameraSequenceEvent));
		}

		// Token: 0x060435D3 RID: 275923 RVA: 0x01075E40 File Offset: 0x01074040
		protected override void OnRemoveEventListener()
		{
			Entity controllerEntity = TurntableControlController.Instance.GetControllerEntity();
			if (controllerEntity != null && EventSystem.Instance.HasWithTarget(controllerEntity, EEventName.OnTurntableControllerBusyStateChange, new Action<bool, bool>(this.OnTurntableControllerBusyStateChange)))
			{
				EventSystem.Instance.RemoveWithTarget(controllerEntity, EEventName.OnTurntableControllerBusyStateChange, new Action<bool, bool>(this.OnTurntableControllerBusyStateChange));
			}
			EventSystem.Instance.Remove(EEventName.OnExecuteUiCameraSequenceEvent, new Action<string>(this.OnExecuteUiCameraSequenceEvent));
		}

		// Token: 0x060435D4 RID: 275924 RVA: 0x01075EB4 File Offset: 0x010740B4
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

		// Token: 0x060435D5 RID: 275925 RVA: 0x01075F0C File Offset: 0x0107410C
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
				if (TurntableControlController.Instance.GetControlType().GetValueOrDefault() == Aki.TDConfigMgr.Component.EControllerType.FixedAngle)
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

		// Token: 0x060435D6 RID: 275926 RVA: 0x01075FD4 File Offset: 0x010741D4
		private void OnBtnResetClicked()
		{
			this.OnTurntableControllerBusyStateChange(false, true);
			this.OnBtnResetClickedImp();
		}

		// Token: 0x060435D7 RID: 275927 RVA: 0x01075FE8 File Offset: 0x010741E8
		private UniTask OnBtnResetClickedImp()
		{
			TurntableControlView.<OnBtnResetClickedImp>d__18 <OnBtnResetClickedImp>d__;
			<OnBtnResetClickedImp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBtnResetClickedImp>d__.<>4__this = this;
			<OnBtnResetClickedImp>d__.<>1__state = -1;
			<OnBtnResetClickedImp>d__.<>t__builder.Start<TurntableControlView.<OnBtnResetClickedImp>d__18>(ref <OnBtnResetClickedImp>d__);
			return <OnBtnResetClickedImp>d__.<>t__builder.Task;
		}

		// Token: 0x060435D8 RID: 275928 RVA: 0x0107602B File Offset: 0x0107422B
		private void OnBtnSwitchClicked()
		{
			TurntableControlController.Instance.SwitchSelectedRing();
		}

		// Token: 0x060435D9 RID: 275929 RVA: 0x01076037 File Offset: 0x01074237
		private void OnBtnRotateClicked()
		{
			TurntableControlController.Instance.StartRotateSelected();
		}

		// Token: 0x060435DA RID: 275930 RVA: 0x01076043 File Offset: 0x01074243
		private void OnBtnRotateDown()
		{
			TurntableControlController.Instance.StartRotateSelected();
		}

		// Token: 0x060435DB RID: 275931 RVA: 0x0107604F File Offset: 0x0107424F
		private void OnBtnRotateUp()
		{
			TurntableControlController.Instance.StopAllRotate();
		}

		// Token: 0x060435DC RID: 275932 RVA: 0x0107605B File Offset: 0x0107425B
		private void OnBtnBackClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x0402322B RID: 143915
		private UUIButtonComponent BtnReset;

		// Token: 0x0402322C RID: 143916
		private UUIButtonComponent BtnSwitch;

		// Token: 0x0402322D RID: 143917
		private UUIButtonComponent BtnRotate;

		// Token: 0x0402322E RID: 143918
		private UUIButtonComponent BtnBack;

		// Token: 0x0402322F RID: 143919
		private bool OpenViewSeqEventTriggered;

		// Token: 0x0200CB3C RID: 52028
		[NullableContext(0)]
		public enum ETurntableControlView
		{
			// Token: 0x0403D5E7 RID: 251367
			BtnReset,
			// Token: 0x0403D5E8 RID: 251368
			BtnSwitch,
			// Token: 0x0403D5E9 RID: 251369
			BtnRotate,
			// Token: 0x0403D5EA RID: 251370
			BtnBack
		}
	}
}
