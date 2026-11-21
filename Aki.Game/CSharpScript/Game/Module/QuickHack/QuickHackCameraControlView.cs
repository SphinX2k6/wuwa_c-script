using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F54 RID: 16212
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickHackCameraControlView : UiTickViewBase, IUiProhibitRefreshData
	{
		// Token: 0x060290A2 RID: 168098 RVA: 0x00B85CD3 File Offset: 0x00B83ED3
		public QuickHackCameraControlView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060290A3 RID: 168099 RVA: 0x00B85CE8 File Offset: 0x00B83EE8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 15;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUISliderComponent));
			this.ComponentRegisterInfos = list;
			num2 = 4;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnLeftCameraClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnRightCameraClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnPhotoClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(11, new Action(this.OnQuickHackClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060290A4 RID: 168100 RVA: 0x00B85FB0 File Offset: 0x00B841B0
		protected override UniTask OnBeforeStartAsync()
		{
			QuickHackCameraControlView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<QuickHackCameraControlView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060290A5 RID: 168101 RVA: 0x00B85FF4 File Offset: 0x00B841F4
		protected override void OnStart()
		{
			this.CameraZoomAxisSpeed = ConfigCommonParamById.GetFloatConfig("CommonCameraZoomSpeed").GetValueOrDefault(1f);
			this.CameraPanel = new GenericLayout<QuickHackCameraControlItem, int>(base.GetHorizontalLayout(8), new Func<QuickHackCameraControlItem>(this.CreateCameraItem), base.GetItem(9).GetOwner() as AUIBaseActor, false, true);
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.SequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnSequenceEnd));
		}

		// Token: 0x060290A6 RID: 168102 RVA: 0x00B86078 File Offset: 0x00B84278
		protected override void OnBeforeShow()
		{
			QuickHackModel instance = QuickHackModel.Instance;
			if (this.CameraPanel != null)
			{
				List<int> cameraControlPbDataIdList = instance.CameraControlPbDataIdList;
				int currentCameraControlIndex = instance.CurrentCameraControlIndex;
				int num = (cameraControlPbDataIdList != null) ? cameraControlPbDataIdList.Count : -1;
				if (cameraControlPbDataIdList != null)
				{
					this.CameraPanel.RefreshByData(cameraControlPbDataIdList, null, false);
					this.CameraPanel.SelectGridProxy(currentCameraControlIndex, false);
				}
				if (num >= 2)
				{
					EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "QuickHack_MultiCamera");
				}
			}
			this.UpdateKeyItem();
			EventSystem.Instance.Add<bool>(EEventName.OnShowMouseCursor, new Action<bool>(this.OnShowMouseCursor));
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			EventSystem.Instance.Add<int>(EEventName.OnQuickHackCameraControlChange, new Action<int>(this.OnCameraControlChange));
			UiProhibitFightInputCenter.Instance.RegisterExtraRefreshData(this.ViewInfo.Name, this);
			InputDistributeController.Instance.RefreshInputTag();
			base.GetSlider(4).OnValueChangeCb.Bind(new Action<float>(this.OnSliderValueChange));
			this.UpdateZoomSliderDefaultValue();
		}

		// Token: 0x060290A7 RID: 168103 RVA: 0x00B86188 File Offset: 0x00B84388
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			QuickHackCameraControlView.<OnPlayingStartSequenceAsync>d__17 <OnPlayingStartSequenceAsync>d__;
			<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingStartSequenceAsync>d__.<>4__this = this;
			<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
			<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<QuickHackCameraControlView.<OnPlayingStartSequenceAsync>d__17>(ref <OnPlayingStartSequenceAsync>d__);
			return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060290A8 RID: 168104 RVA: 0x00B861CC File Offset: 0x00B843CC
		protected override void OnAfterShow()
		{
			UUIButtonComponent button = base.GetButton(3);
			button.OnPointDownCallBack.Bind(new Action(this.OnZoomIncreasePress));
			button.OnPointUpCallBack.Bind(new Action(this.OnZoomIncreaseRelease));
			button.OnPointCancelCallBack.Bind(new Action(this.OnZoomIncreaseRelease));
			UUIButtonComponent button2 = base.GetButton(5);
			button2.OnPointDownCallBack.Bind(new Action(this.OnZoomDecreasePress));
			button2.OnPointUpCallBack.Bind(new Action(this.OnZoomDecreaseRelease));
			button2.OnPointCancelCallBack.Bind(new Action(this.OnZoomDecreaseRelease));
			InputDistributeController.Instance.BindAxis("WheelAxis", new TInputHandle<float>(this.OnInputWheelAxis));
			if (QuickHackModel.Instance.CameraControlAutoOpenQuickHack)
			{
				this.OpenQuickHack();
			}
		}

		// Token: 0x060290A9 RID: 168105 RVA: 0x00B8629C File Offset: 0x00B8449C
		protected override void OnTick(float delta)
		{
			this.UpdateCameraSlider(false);
		}

		// Token: 0x060290AA RID: 168106 RVA: 0x00B862A8 File Offset: 0x00B844A8
		private void UpdateCameraSlider(bool force = false)
		{
			Rotator cameraRotator = CameraModel.Instance.MainModel.CameraRotator;
			float pitch = cameraRotator.Pitch;
			if (force || pitch != this.CameraPitch)
			{
				this.UpdateCameraPitch(pitch);
				this.CameraPitch = pitch;
			}
			float yaw = cameraRotator.Yaw;
			if (force || yaw != this.CameraYaw)
			{
				this.UpdateCameraYaw(yaw);
				this.CameraYaw = yaw;
			}
		}

		// Token: 0x060290AB RID: 168107 RVA: 0x00B86308 File Offset: 0x00B84508
		private void UpdateCameraPitch(float pitch)
		{
			QuickHackModel instance = QuickHackModel.Instance;
			float num = MathUtils.Instance.WrapAngle(pitch - instance.CameraControlDefaultPitch);
			float inValue = 0.5f;
			float cameraControlPitchMin = instance.CameraControlPitchMin;
			float cameraControlPitchMax = instance.CameraControlPitchMax;
			if ((double)Math.Abs(cameraControlPitchMin - cameraControlPitchMax) > 0.0001)
			{
				inValue = MathUtils.Instance.RangeClamp(num, cameraControlPitchMin, cameraControlPitchMax, 0.04f, 0.96f);
			}
			base.GetText(0).SetText(Math.Round((double)num).ToString("F0"), true);
			base.GetSlider(14).SetValue(inValue, false);
		}

		// Token: 0x060290AC RID: 168108 RVA: 0x00B863A4 File Offset: 0x00B845A4
		private void UpdateCameraYaw(float yaw)
		{
			QuickHackModel instance = QuickHackModel.Instance;
			float num = MathUtils.Instance.WrapAngle(yaw - instance.CameraControlDefaultYaw);
			float inValue = 0.5f;
			float cameraControlYawMin = instance.CameraControlYawMin;
			float cameraControlYawMax = instance.CameraControlYawMax;
			if ((double)Math.Abs(cameraControlYawMin - cameraControlYawMax) > 0.0001)
			{
				inValue = MathUtils.Instance.RangeClamp(num, cameraControlYawMin, cameraControlYawMax, 0.015f, 0.985f);
			}
			base.GetText(1).SetText(Math.Round((double)num).ToString("F0"), true);
			base.GetSlider(13).SetValue(inValue, false);
		}

		// Token: 0x060290AD RID: 168109 RVA: 0x00B8643E File Offset: 0x00B8463E
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
			QuickHackController.Instance.CloseQuickHackCameraControl();
		}

		// Token: 0x060290AE RID: 168110 RVA: 0x00B86464 File Offset: 0x00B84664
		protected override void OnAfterHide()
		{
			EventSystem.Instance.Remove(EEventName.OnShowMouseCursor, new Action<bool>(this.OnShowMouseCursor));
			EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			EventSystem.Instance.Remove(EEventName.OnQuickHackCameraControlChange, new Action<int>(this.OnCameraControlChange));
			UiProhibitFightInputCenter.Instance.UnRegisterExtraRefreshData(this.ViewInfo.Name);
			InputDistributeController.Instance.RefreshInputTag();
			base.GetSlider(4).OnValueChangeCb.Unbind();
			InputDistributeController.Instance.UnBindAxis("WheelAxis", new TInputHandle<float>(this.OnInputWheelAxis));
		}

		// Token: 0x060290AF RID: 168111 RVA: 0x00B86515 File Offset: 0x00B84715
		private QuickHackCameraControlItem CreateCameraItem()
		{
			QuickHackCameraControlItem quickHackCameraControlItem = new QuickHackCameraControlItem();
			quickHackCameraControlItem.RegisterOnCameraItemClick(new Action<int>(this.OnCameraItemClick));
			return quickHackCameraControlItem;
		}

		// Token: 0x060290B0 RID: 168112 RVA: 0x00B86530 File Offset: 0x00B84730
		private void OnCameraControlChange(int pbDataId)
		{
			this.SequencePlayer.StopSequenceByKey("Switch", false, false);
			this.CameraSwitching = true;
			this.SequencePlayer.PlaySequencePurely("Switch", false, false);
			QuickHackModel instance = QuickHackModel.Instance;
			List<int> cameraControlPbDataIdList = instance.CameraControlPbDataIdList;
			if (cameraControlPbDataIdList != null)
			{
				GenericLayout<QuickHackCameraControlItem, int> cameraPanel = this.CameraPanel;
				if (cameraPanel != null)
				{
					cameraPanel.RefreshByData(cameraControlPbDataIdList, null, false);
				}
				GenericLayout<QuickHackCameraControlItem, int> cameraPanel2 = this.CameraPanel;
				if (cameraPanel2 != null)
				{
					cameraPanel2.SelectGridProxy(instance.CurrentCameraControlIndex, false);
				}
			}
			this.UpdateZoomSliderDefaultValue();
			this.UpdateCameraSlider(true);
		}

		// Token: 0x060290B1 RID: 168113 RVA: 0x00B865B4 File Offset: 0x00B847B4
		private void UpdateZoomSliderDefaultValue()
		{
			UUISliderComponent slider = base.GetSlider(4);
			QuickHackModel instance = QuickHackModel.Instance;
			float cameraControlMinFov = instance.CameraControlMinFov;
			float cameraControlMaxFov = instance.CameraControlMaxFov;
			float inValue = MathUtils.Instance.RangeClamp(instance.CameraControlDefaultFov, cameraControlMinFov, cameraControlMaxFov, cameraControlMaxFov, cameraControlMinFov);
			slider.SetMinValue(cameraControlMinFov, false, false);
			slider.SetMaxValue(cameraControlMaxFov, false, false);
			slider.SetValue(inValue, false);
		}

		// Token: 0x060290B2 RID: 168114 RVA: 0x00B8660A File Offset: 0x00B8480A
		private void OnSequenceEnd(string sequenceName)
		{
			if (sequenceName == "Switch" && this.CameraSwitching)
			{
				this.CameraSwitching = false;
				if (QuickHackModel.Instance.CameraControlAutoOpenQuickHack)
				{
					this.OpenQuickHack();
				}
			}
		}

		// Token: 0x060290B3 RID: 168115 RVA: 0x00B8663A File Offset: 0x00B8483A
		protected void OnShowMouseCursor(bool value)
		{
			this.UpdateKeyItem();
		}

		// Token: 0x060290B4 RID: 168116 RVA: 0x00B86642 File Offset: 0x00B84842
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			this.UpdateKeyItem();
		}

		// Token: 0x060290B5 RID: 168117 RVA: 0x00B8664A File Offset: 0x00B8484A
		private void UpdateKeyItem()
		{
			base.GetItem(12).SetUIActive(Info.Instance.IsInKeyBoard() && !InputManager.Instance.IsShowMouseCursor());
		}

		// Token: 0x060290B6 RID: 168118 RVA: 0x00B86675 File Offset: 0x00B84875
		public bool CheckCondition()
		{
			return !InputManager.Instance.IsShowMouseCursor() || !Info.Instance.IsInKeyBoard();
		}

		// Token: 0x060290B7 RID: 168119 RVA: 0x00B86692 File Offset: 0x00B84892
		public string[] GetDistributeTags()
		{
			return new string[]
			{
				"FightInputRoot.FightInput.AxisInput.CameraInput.CameraRotation",
				"UiInputRoot.MouseInputTag",
				"UiInputRoot.Navigation"
			};
		}

		// Token: 0x060290B8 RID: 168120 RVA: 0x00B866B2 File Offset: 0x00B848B2
		private void OnLeftCameraClick()
		{
			if (QuickHackModel.Instance.IsQuickHacking)
			{
				return;
			}
			QuickHackController.Instance.ChangeNextCamera(false);
		}

		// Token: 0x060290B9 RID: 168121 RVA: 0x00B866CC File Offset: 0x00B848CC
		private void OnRightCameraClick()
		{
			if (QuickHackModel.Instance.IsQuickHacking)
			{
				return;
			}
			QuickHackController.Instance.ChangeNextCamera(true);
		}

		// Token: 0x060290BA RID: 168122 RVA: 0x00B866E6 File Offset: 0x00B848E6
		private void OnCameraItemClick(int pbDataId)
		{
			if (QuickHackModel.Instance.IsQuickHacking)
			{
				return;
			}
			QuickHackController.Instance.ChangeCameraByPbDataId(pbDataId);
		}

		// Token: 0x060290BB RID: 168123 RVA: 0x00B86700 File Offset: 0x00B84900
		private void OnPhotoClick()
		{
			if (QuickHackModel.Instance.IsQuickHacking)
			{
				return;
			}
			PhotographController.Instance.ScreenShot(new PhotoSaveViewParam
			{
				ScreenShot = true,
				PrepareFullScreenShot = true,
				IsHiddenBattleView = false,
				HandBookPhotoData = null,
				GachaData = null,
				FragmentMemory = null,
				RoleSkinData = null,
				ShareId = 1
			});
		}

		// Token: 0x060290BC RID: 168124 RVA: 0x00B86761 File Offset: 0x00B84961
		private void OnQuickHackClick()
		{
			if (base.IsShow)
			{
				this.OpenQuickHack();
			}
		}

		// Token: 0x060290BD RID: 168125 RVA: 0x00B86774 File Offset: 0x00B84974
		private void OpenQuickHack()
		{
			if (QuickHackModel.Instance.IsQuickHacking)
			{
				return;
			}
			this.OnZoomIncreaseRelease();
			this.OnZoomDecreaseRelease();
			this.SequencePlayer.PlaySequencePurely("Invade", false, false);
			QuickHackController.Instance.OpenQuickHackByCameraControl(delegate
			{
				if (this.SequencePlayer != null)
				{
					this.SequencePlayer.StopSequenceByKey("Invade", false, false);
					this.SequencePlayer.PlaySequencePurely("InvadeOut", false, false);
				}
			});
		}

		// Token: 0x060290BE RID: 168126 RVA: 0x00B867C2 File Offset: 0x00B849C2
		private void OnCloseClick()
		{
			if (QuickHackModel.Instance.IsQuickHacking)
			{
				return;
			}
			QuickHackController.Instance.CloseQuickHackCameraControl();
		}

		// Token: 0x060290BF RID: 168127 RVA: 0x00B867DC File Offset: 0x00B849DC
		private void OnZoomIncreasePress()
		{
			if (QuickHackModel.Instance.IsQuickHacking)
			{
				return;
			}
			this.UpdateSliderByDeltaValue(1f);
			this.RemoveUpdateFovTimer();
			this.UpdateFovTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnIncreaseFov), 100f, 1f, null, null, true);
		}

		// Token: 0x060290C0 RID: 168128 RVA: 0x00B86830 File Offset: 0x00B84A30
		private void OnZoomDecreasePress()
		{
			if (QuickHackModel.Instance.IsQuickHacking)
			{
				return;
			}
			this.UpdateSliderByDeltaValue(-1f);
			this.RemoveUpdateFovTimer();
			this.UpdateFovTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnReduceFov), 100f, 1f, null, null, true);
		}

		// Token: 0x060290C1 RID: 168129 RVA: 0x00B86884 File Offset: 0x00B84A84
		private void OnZoomIncreaseRelease()
		{
			this.RemoveUpdateFovTimer();
		}

		// Token: 0x060290C2 RID: 168130 RVA: 0x00B8688C File Offset: 0x00B84A8C
		private void OnZoomDecreaseRelease()
		{
			this.RemoveUpdateFovTimer();
		}

		// Token: 0x060290C3 RID: 168131 RVA: 0x00B86894 File Offset: 0x00B84A94
		private void RemoveUpdateFovTimer()
		{
			TimerHandle updateFovTimer = this.UpdateFovTimer;
			if (updateFovTimer != null)
			{
				updateFovTimer.Remove();
			}
			this.UpdateFovTimer = null;
		}

		// Token: 0x060290C4 RID: 168132 RVA: 0x00B868AF File Offset: 0x00B84AAF
		private void OnIncreaseFov(float delta)
		{
			this.UpdateSliderByDeltaValue(1f);
		}

		// Token: 0x060290C5 RID: 168133 RVA: 0x00B868BC File Offset: 0x00B84ABC
		private void OnReduceFov(float delta)
		{
			this.UpdateSliderByDeltaValue(-1f);
		}

		// Token: 0x060290C6 RID: 168134 RVA: 0x00B868C9 File Offset: 0x00B84AC9
		private void OnSliderValueChange(float value)
		{
			this.UpdateSliderValue(value);
		}

		// Token: 0x060290C7 RID: 168135 RVA: 0x00B868D4 File Offset: 0x00B84AD4
		private void UpdateSliderByDeltaValue(float delta)
		{
			UUISliderComponent slider = base.GetSlider(4);
			float num = slider.GetValue() + delta;
			slider.SetValue(num, false);
			this.UpdateSliderValue(num);
		}

		// Token: 0x060290C8 RID: 168136 RVA: 0x00B86900 File Offset: 0x00B84B00
		private void UpdateSliderValue(float value)
		{
			QuickHackModel instance = QuickHackModel.Instance;
			float cameraControlMinFov = instance.CameraControlMinFov;
			float cameraControlMaxFov = instance.CameraControlMaxFov;
			float fov = MathUtils.Instance.RangeClamp(value, cameraControlMinFov, cameraControlMaxFov, cameraControlMaxFov, cameraControlMinFov);
			QuickHackController.Instance.UpdateCameraControlFov(fov);
		}

		// Token: 0x060290C9 RID: 168137 RVA: 0x00B8693A File Offset: 0x00B84B3A
		private void OnInputWheelAxis(string name, float value, InputIdentification inputIdentification)
		{
			if (QuickHackModel.Instance.IsQuickHacking)
			{
				return;
			}
			if (value != 0f)
			{
				this.UpdateSliderByDeltaValue(value * this.CameraZoomAxisSpeed);
			}
		}

		// Token: 0x0401655E RID: 91486
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401655F RID: 91487
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<QuickHackCameraControlItem, int> CameraPanel;

		// Token: 0x04016560 RID: 91488
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x04016561 RID: 91489
		private float CameraZoomAxisSpeed = 1f;

		// Token: 0x04016562 RID: 91490
		[Nullable(2)]
		private TimerHandle UpdateFovTimer;

		// Token: 0x04016563 RID: 91491
		private bool CameraSwitching;

		// Token: 0x04016564 RID: 91492
		private float CameraPitch;

		// Token: 0x04016565 RID: 91493
		private float CameraYaw;

		// Token: 0x04016566 RID: 91494
		private const float CHANGE_FOV_INTERVAL = 100f;

		// Token: 0x04016567 RID: 91495
		private const float CAMERA_YAW_SLIDER_OFFSET = 0.015f;

		// Token: 0x04016568 RID: 91496
		private const float CAMERA_PITCH_SLIDER_OFFSET = 0.04f;

		// Token: 0x02009ACF RID: 39631
		[NullableContext(0)]
		private class EComponentType
		{
			// Token: 0x040303C0 RID: 197568
			public const int CameraPitchText = 0;

			// Token: 0x040303C1 RID: 197569
			public const int CameraYawText = 1;

			// Token: 0x040303C2 RID: 197570
			public const int CaptionItem = 2;

			// Token: 0x040303C3 RID: 197571
			public const int ZoomIncreaseButton = 3;

			// Token: 0x040303C4 RID: 197572
			public const int ZoomSlider = 4;

			// Token: 0x040303C5 RID: 197573
			public const int ZoomDecreaseButton = 5;

			// Token: 0x040303C6 RID: 197574
			public const int LeftCameraButton = 6;

			// Token: 0x040303C7 RID: 197575
			public const int RightCameraButton = 7;

			// Token: 0x040303C8 RID: 197576
			public const int CameraListPanel = 8;

			// Token: 0x040303C9 RID: 197577
			public const int CameraItem = 9;

			// Token: 0x040303CA RID: 197578
			public const int PhotoButton = 10;

			// Token: 0x040303CB RID: 197579
			public const int QuickHackButton = 11;

			// Token: 0x040303CC RID: 197580
			public const int QuickHackKeyItem = 12;

			// Token: 0x040303CD RID: 197581
			public const int CameraYawSlider = 13;

			// Token: 0x040303CE RID: 197582
			public const int CameraPitchSlider = 14;
		}
	}
}
