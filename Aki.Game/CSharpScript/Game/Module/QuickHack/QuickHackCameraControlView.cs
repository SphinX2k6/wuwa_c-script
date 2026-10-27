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
	// Token: 0x02004F8B RID: 20363
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickHackCameraControlView : UiTickViewBase, IUiProhibitRefreshData
	{
		// Token: 0x06034234 RID: 213556 RVA: 0x00C3C527 File Offset: 0x00C3A727
		public QuickHackCameraControlView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06034235 RID: 213557 RVA: 0x00C3C53C File Offset: 0x00C3A73C
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

		// Token: 0x06034236 RID: 213558 RVA: 0x00C3C804 File Offset: 0x00C3AA04
		protected override UniTask OnBeforeStartAsync()
		{
			QuickHackCameraControlView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<QuickHackCameraControlView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034237 RID: 213559 RVA: 0x00C3C848 File Offset: 0x00C3AA48
		protected override void OnStart()
		{
			this.CameraZoomAxisSpeed = ConfigCommonParamById.GetFloatConfig("CommonCameraZoomSpeed").GetValueOrDefault(1f);
			this.CameraPanel = new GenericLayout<QuickHackCameraControlItem, int>(base.GetHorizontalLayout(8), new Func<QuickHackCameraControlItem>(this.CreateCameraItem), base.GetItem(9).GetOwner() as AUIBaseActor, false, true);
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.SequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnSequenceEnd));
		}

		// Token: 0x06034238 RID: 213560 RVA: 0x00C3C8CC File Offset: 0x00C3AACC
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

		// Token: 0x06034239 RID: 213561 RVA: 0x00C3C9DC File Offset: 0x00C3ABDC
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			QuickHackCameraControlView.<OnPlayingStartSequenceAsync>d__17 <OnPlayingStartSequenceAsync>d__;
			<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingStartSequenceAsync>d__.<>4__this = this;
			<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
			<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<QuickHackCameraControlView.<OnPlayingStartSequenceAsync>d__17>(ref <OnPlayingStartSequenceAsync>d__);
			return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603423A RID: 213562 RVA: 0x00C3CA20 File Offset: 0x00C3AC20
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

		// Token: 0x0603423B RID: 213563 RVA: 0x00C3CAF0 File Offset: 0x00C3ACF0
		protected override void OnTick(float delta)
		{
			this.UpdateCameraSlider(false);
		}

		// Token: 0x0603423C RID: 213564 RVA: 0x00C3CAFC File Offset: 0x00C3ACFC
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

		// Token: 0x0603423D RID: 213565 RVA: 0x00C3CB5C File Offset: 0x00C3AD5C
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

		// Token: 0x0603423E RID: 213566 RVA: 0x00C3CBF8 File Offset: 0x00C3ADF8
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

		// Token: 0x0603423F RID: 213567 RVA: 0x00C3CC92 File Offset: 0x00C3AE92
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

		// Token: 0x06034240 RID: 213568 RVA: 0x00C3CCB8 File Offset: 0x00C3AEB8
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

		// Token: 0x06034241 RID: 213569 RVA: 0x00C3CD69 File Offset: 0x00C3AF69
		private QuickHackCameraControlItem CreateCameraItem()
		{
			QuickHackCameraControlItem quickHackCameraControlItem = new QuickHackCameraControlItem();
			quickHackCameraControlItem.RegisterOnCameraItemClick(new Action<int>(this.OnCameraItemClick));
			return quickHackCameraControlItem;
		}

		// Token: 0x06034242 RID: 213570 RVA: 0x00C3CD84 File Offset: 0x00C3AF84
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

		// Token: 0x06034243 RID: 213571 RVA: 0x00C3CE08 File Offset: 0x00C3B008
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

		// Token: 0x06034244 RID: 213572 RVA: 0x00C3CE5E File Offset: 0x00C3B05E
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

		// Token: 0x06034245 RID: 213573 RVA: 0x00C3CE8E File Offset: 0x00C3B08E
		protected void OnShowMouseCursor(bool value)
		{
			this.UpdateKeyItem();
		}

		// Token: 0x06034246 RID: 213574 RVA: 0x00C3CE96 File Offset: 0x00C3B096
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			this.UpdateKeyItem();
		}

		// Token: 0x06034247 RID: 213575 RVA: 0x00C3CE9E File Offset: 0x00C3B09E
		private void UpdateKeyItem()
		{
			base.GetItem(12).SetUIActive(Info.Instance.IsInKeyBoard() && !InputManager.Instance.IsShowMouseCursor());
		}

		// Token: 0x06034248 RID: 213576 RVA: 0x00C3CEC9 File Offset: 0x00C3B0C9
		public bool CheckCondition()
		{
			return !InputManager.Instance.IsShowMouseCursor() || !Info.Instance.IsInKeyBoard();
		}

		// Token: 0x06034249 RID: 213577 RVA: 0x00C3CEE6 File Offset: 0x00C3B0E6
		public string[] GetDistributeTags()
		{
			return new string[]
			{
				"FightInputRoot.FightInput.AxisInput.CameraInput.CameraRotation",
				"UiInputRoot.MouseInputTag",
				"UiInputRoot.Navigation"
			};
		}

		// Token: 0x0603424A RID: 213578 RVA: 0x00C3CF06 File Offset: 0x00C3B106
		private void OnLeftCameraClick()
		{
			if (QuickHackModel.Instance.IsQuickHacking)
			{
				return;
			}
			QuickHackController.Instance.ChangeNextCamera(false);
		}

		// Token: 0x0603424B RID: 213579 RVA: 0x00C3CF20 File Offset: 0x00C3B120
		private void OnRightCameraClick()
		{
			if (QuickHackModel.Instance.IsQuickHacking)
			{
				return;
			}
			QuickHackController.Instance.ChangeNextCamera(true);
		}

		// Token: 0x0603424C RID: 213580 RVA: 0x00C3CF3A File Offset: 0x00C3B13A
		private void OnCameraItemClick(int pbDataId)
		{
			if (QuickHackModel.Instance.IsQuickHacking)
			{
				return;
			}
			QuickHackController.Instance.ChangeCameraByPbDataId(pbDataId);
		}

		// Token: 0x0603424D RID: 213581 RVA: 0x00C3CF54 File Offset: 0x00C3B154
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

		// Token: 0x0603424E RID: 213582 RVA: 0x00C3CFB5 File Offset: 0x00C3B1B5
		private void OnQuickHackClick()
		{
			if (base.IsShow)
			{
				this.OpenQuickHack();
			}
		}

		// Token: 0x0603424F RID: 213583 RVA: 0x00C3CFC8 File Offset: 0x00C3B1C8
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

		// Token: 0x06034250 RID: 213584 RVA: 0x00C3D016 File Offset: 0x00C3B216
		private void OnCloseClick()
		{
			if (QuickHackModel.Instance.IsQuickHacking)
			{
				return;
			}
			QuickHackController.Instance.CloseQuickHackCameraControl();
		}

		// Token: 0x06034251 RID: 213585 RVA: 0x00C3D030 File Offset: 0x00C3B230
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

		// Token: 0x06034252 RID: 213586 RVA: 0x00C3D084 File Offset: 0x00C3B284
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

		// Token: 0x06034253 RID: 213587 RVA: 0x00C3D0D8 File Offset: 0x00C3B2D8
		private void OnZoomIncreaseRelease()
		{
			this.RemoveUpdateFovTimer();
		}

		// Token: 0x06034254 RID: 213588 RVA: 0x00C3D0E0 File Offset: 0x00C3B2E0
		private void OnZoomDecreaseRelease()
		{
			this.RemoveUpdateFovTimer();
		}

		// Token: 0x06034255 RID: 213589 RVA: 0x00C3D0E8 File Offset: 0x00C3B2E8
		private void RemoveUpdateFovTimer()
		{
			TimerHandle updateFovTimer = this.UpdateFovTimer;
			if (updateFovTimer != null)
			{
				updateFovTimer.Remove();
			}
			this.UpdateFovTimer = null;
		}

		// Token: 0x06034256 RID: 213590 RVA: 0x00C3D103 File Offset: 0x00C3B303
		private void OnIncreaseFov(float delta)
		{
			this.UpdateSliderByDeltaValue(1f);
		}

		// Token: 0x06034257 RID: 213591 RVA: 0x00C3D110 File Offset: 0x00C3B310
		private void OnReduceFov(float delta)
		{
			this.UpdateSliderByDeltaValue(-1f);
		}

		// Token: 0x06034258 RID: 213592 RVA: 0x00C3D11D File Offset: 0x00C3B31D
		private void OnSliderValueChange(float value)
		{
			this.UpdateSliderValue(value);
		}

		// Token: 0x06034259 RID: 213593 RVA: 0x00C3D128 File Offset: 0x00C3B328
		private void UpdateSliderByDeltaValue(float delta)
		{
			UUISliderComponent slider = base.GetSlider(4);
			float num = slider.GetValue() + delta;
			slider.SetValue(num, false);
			this.UpdateSliderValue(num);
		}

		// Token: 0x0603425A RID: 213594 RVA: 0x00C3D154 File Offset: 0x00C3B354
		private void UpdateSliderValue(float value)
		{
			QuickHackModel instance = QuickHackModel.Instance;
			float cameraControlMinFov = instance.CameraControlMinFov;
			float cameraControlMaxFov = instance.CameraControlMaxFov;
			float fov = MathUtils.Instance.RangeClamp(value, cameraControlMinFov, cameraControlMaxFov, cameraControlMaxFov, cameraControlMinFov);
			QuickHackController.Instance.UpdateCameraControlFov(fov);
		}

		// Token: 0x0603425B RID: 213595 RVA: 0x00C3D18E File Offset: 0x00C3B38E
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

		// Token: 0x0401BB89 RID: 113545
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401BB8A RID: 113546
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<QuickHackCameraControlItem, int> CameraPanel;

		// Token: 0x0401BB8B RID: 113547
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401BB8C RID: 113548
		private float CameraZoomAxisSpeed = 1f;

		// Token: 0x0401BB8D RID: 113549
		[Nullable(2)]
		private TimerHandle UpdateFovTimer;

		// Token: 0x0401BB8E RID: 113550
		private bool CameraSwitching;

		// Token: 0x0401BB8F RID: 113551
		private float CameraPitch;

		// Token: 0x0401BB90 RID: 113552
		private float CameraYaw;

		// Token: 0x0401BB91 RID: 113553
		private const float CHANGE_FOV_INTERVAL = 100f;

		// Token: 0x0401BB92 RID: 113554
		private const float CAMERA_YAW_SLIDER_OFFSET = 0.015f;

		// Token: 0x0401BB93 RID: 113555
		private const float CAMERA_PITCH_SLIDER_OFFSET = 0.04f;

		// Token: 0x0200B09F RID: 45215
		[NullableContext(0)]
		private class EComponentType
		{
			// Token: 0x04035995 RID: 219541
			public const int CameraPitchText = 0;

			// Token: 0x04035996 RID: 219542
			public const int CameraYawText = 1;

			// Token: 0x04035997 RID: 219543
			public const int CaptionItem = 2;

			// Token: 0x04035998 RID: 219544
			public const int ZoomIncreaseButton = 3;

			// Token: 0x04035999 RID: 219545
			public const int ZoomSlider = 4;

			// Token: 0x0403599A RID: 219546
			public const int ZoomDecreaseButton = 5;

			// Token: 0x0403599B RID: 219547
			public const int LeftCameraButton = 6;

			// Token: 0x0403599C RID: 219548
			public const int RightCameraButton = 7;

			// Token: 0x0403599D RID: 219549
			public const int CameraListPanel = 8;

			// Token: 0x0403599E RID: 219550
			public const int CameraItem = 9;

			// Token: 0x0403599F RID: 219551
			public const int PhotoButton = 10;

			// Token: 0x040359A0 RID: 219552
			public const int QuickHackButton = 11;

			// Token: 0x040359A1 RID: 219553
			public const int QuickHackKeyItem = 12;

			// Token: 0x040359A2 RID: 219554
			public const int CameraYawSlider = 13;

			// Token: 0x040359A3 RID: 219555
			public const int CameraPitchSlider = 14;
		}
	}
}
