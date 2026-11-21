using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.KeySetting;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Module.Menu.KeySettingsView;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020014FE RID: 5374
[NullableContext(2)]
[Nullable(0)]
public class CommonKeySettingPanel : KeySettingPanelBase
{
	// Token: 0x0600D6ED RID: 55021 RVA: 0x003FBCD3 File Offset: 0x003F9ED3
	public CommonKeySettingPanel(EKeySettingExclusiveType exclusiveType = EKeySettingExclusiveType.None) : base(exclusiveType)
	{
	}

	// Token: 0x0600D6EE RID: 55022 RVA: 0x003FBCDC File Offset: 0x003F9EDC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(15, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(16, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(17, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnLeftButtonClicked)),
			new ValueTuple<int, Delegate>(1, new Action(this.OnRightButtonClicked)),
			new ValueTuple<int, Delegate>(9, new Action(this.OnResetButtonClicked)),
			new ValueTuple<int, Delegate>(14, new Action(this.OnResetButtonClicked)),
			new ValueTuple<int, Delegate>(15, new Action(this.OnGamepadOperationButtonClicked)),
			new ValueTuple<int, Delegate>(16, new Action(this.OnGamepadOperationButtonClicked))
		};
	}

	// Token: 0x0600D6EF RID: 55023 RVA: 0x003FBF28 File Offset: 0x003FA128
	protected override UniTask OnBeforeStartAsync()
	{
		CommonKeySettingPanel.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonKeySettingPanel.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D6F0 RID: 55024 RVA: 0x003FBF6C File Offset: 0x003FA16C
	protected override void OnStart()
	{
		this.Refresh();
		this.RefreshEditKeyTips(null);
		this.InitializePlatformInfo();
		EventSystem.Instance.Add(EEventName.OnDeviceLangChange, new Action(this.OnDeviceLangChange));
		UUIItem item = base.GetItem(17);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x0600D6F1 RID: 55025 RVA: 0x003FBFBB File Offset: 0x003FA1BB
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnDeviceLangChange, new Action(this.OnDeviceLangChange));
	}

	// Token: 0x0600D6F2 RID: 55026 RVA: 0x003FBFD9 File Offset: 0x003FA1D9
	protected override void OnWaitKeySetting()
	{
	}

	// Token: 0x0600D6F3 RID: 55027 RVA: 0x003FBFDB File Offset: 0x003FA1DB
	protected override void OnBeforeBeginEditKey()
	{
		CommonKeySettingRowsPanel pcPanel = this.PcPanel;
		if (pcPanel != null)
		{
			pcPanel.StopScroll();
		}
		CommonKeySettingRowsPanel gamepadPanel = this.GamepadPanel;
		if (gamepadPanel == null)
		{
			return;
		}
		gamepadPanel.StopScroll();
	}

	// Token: 0x0600D6F4 RID: 55028 RVA: 0x003FBFFE File Offset: 0x003FA1FE
	protected override void OnBeginEditKey()
	{
		GamepadItemBase gamepadItem = this.GamepadItem;
		if (gamepadItem != null)
		{
			gamepadItem.SetAllKeyDisable();
		}
		this.RefreshEditKeyTips("EditKey_Text");
	}

	// Token: 0x0600D6F5 RID: 55029 RVA: 0x003FC01C File Offset: 0x003FA21C
	protected override void OnFinishEditKey()
	{
		this.RefreshEditKeyTips(null);
	}

	// Token: 0x0600D6F6 RID: 55030 RVA: 0x003FC025 File Offset: 0x003FA225
	[NullableContext(1)]
	protected override void OnKeyChange(KeySettingRowData data, CSharpScript.Game.Module.Menu.EInputControllerType type)
	{
	}

	// Token: 0x0600D6F7 RID: 55031 RVA: 0x003FC027 File Offset: 0x003FA227
	protected override void OnKeySelected(KeySettingRowData data)
	{
	}

	// Token: 0x0600D6F8 RID: 55032 RVA: 0x003FC02C File Offset: 0x003FA22C
	protected override void OnKeyHover(KeySettingRowData data)
	{
		if (KeySettingViewModel.InputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard)
		{
			GamepadItemBase gamepadItem = this.GamepadItem;
			if (gamepadItem == null)
			{
				return;
			}
			gamepadItem.SetAllKeyDisable();
			return;
		}
		else
		{
			this.HoverKeySettingRowData = data;
			if (data == null)
			{
				GamepadItemBase gamepadItem2 = this.GamepadItem;
				if (gamepadItem2 == null)
				{
					return;
				}
				gamepadItem2.SetAllKeyDisable();
				return;
			}
			else
			{
				List<string> displayKeyName = data.GetDisplayKeyName(KeySettingViewModel.InputControllerType);
				if (displayKeyName == null)
				{
					GamepadItemBase gamepadItem3 = this.GamepadItem;
					if (gamepadItem3 == null)
					{
						return;
					}
					gamepadItem3.SetAllKeyDisable();
					return;
				}
				else
				{
					GamepadItemBase gamepadItem4 = this.GamepadItem;
					if (gamepadItem4 == null)
					{
						return;
					}
					gamepadItem4.SetKeysEnable(displayKeyName.ToArray());
					return;
				}
			}
		}
	}

	// Token: 0x0600D6F9 RID: 55033 RVA: 0x003FC0A4 File Offset: 0x003FA2A4
	protected override void OnKeyUnHover(KeySettingRowData data)
	{
		if (KeySettingViewModel.InputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard)
		{
			GamepadItemBase gamepadItem = this.GamepadItem;
			if (gamepadItem == null)
			{
				return;
			}
			gamepadItem.SetAllKeyDisable();
			return;
		}
		else
		{
			if (this.HoverKeySettingRowData != null)
			{
				int configId = this.HoverKeySettingRowData.ConfigId;
				int? num = (data != null) ? new int?(data.ConfigId) : null;
				if (configId == num.GetValueOrDefault() & num != null)
				{
					GamepadItemBase gamepadItem2 = this.GamepadItem;
					if (gamepadItem2 == null)
					{
						return;
					}
					gamepadItem2.SetAllKeyDisable();
				}
				return;
			}
			GamepadItemBase gamepadItem3 = this.GamepadItem;
			if (gamepadItem3 == null)
			{
				return;
			}
			gamepadItem3.SetAllKeyDisable();
			return;
		}
	}

	// Token: 0x0600D6FA RID: 55034 RVA: 0x003FC12B File Offset: 0x003FA32B
	private void Refresh()
	{
		this.RefreshDeviceSwitcher();
		this.RefreshKeySettingPanel();
		this.RefreshGamepadPanel();
	}

	// Token: 0x0600D6FB RID: 55035 RVA: 0x003FC140 File Offset: 0x003FA340
	private void RefreshDeviceSwitcher()
	{
		IKeySettingDeviceInfo keySettingDeviceInfo;
		if (!KeySettingDefine.keySettingDeviceInfoRecord.TryGetValue(KeySettingViewModel.CurrentDeviceType, out keySettingDeviceInfo))
		{
			return;
		}
		string nameTextId = keySettingDeviceInfo.NameTextId;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), nameTextId, Array.Empty<object>());
		if (KeySettingViewModel.CurrentDeviceType == EKeySettingDeviceType.Keyboard)
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.SetSelfInteractive(false);
			}
			UUIButtonComponent button2 = base.GetButton(1);
			if (button2 == null)
			{
				return;
			}
			button2.SetSelfInteractive(true);
			return;
		}
		else
		{
			UUIButtonComponent button3 = base.GetButton(0);
			if (button3 != null)
			{
				button3.SetSelfInteractive(true);
			}
			UUIButtonComponent button4 = base.GetButton(1);
			if (button4 == null)
			{
				return;
			}
			button4.SetSelfInteractive(false);
			return;
		}
	}

	// Token: 0x0600D6FC RID: 55036 RVA: 0x003FC1D4 File Offset: 0x003FA3D4
	private void RefreshKeySettingPanel()
	{
		CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType = KeySettingViewModel.InputControllerType;
		if (inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard)
		{
			this.RefreshKeyBoardTab();
			return;
		}
		if (inputControllerType != CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad)
		{
			return;
		}
		this.RefreshGamepadTab();
	}

	// Token: 0x0600D6FD RID: 55037 RVA: 0x003FC200 File Offset: 0x003FA400
	private void RefreshGamepadPanel()
	{
		if (KeySettingViewModel.InputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad)
		{
			global::EInputControllerType lastGamepadEnum = InputKeyUtils.GetLastGamepadEnum();
			if (Info.Instance.CheckIsPsGamepad(lastGamepadEnum))
			{
				this.GamepadItem = this.PsGamepadItem;
				PsGamepadItem psGamepadItem = this.PsGamepadItem;
				if (psGamepadItem != null)
				{
					psGamepadItem.SetActive(true);
				}
				XboxGamepadItem xboxGamepadItem = this.XboxGamepadItem;
				if (xboxGamepadItem == null)
				{
					return;
				}
				xboxGamepadItem.SetActive(false);
				return;
			}
			else
			{
				this.GamepadItem = this.XboxGamepadItem;
				XboxGamepadItem xboxGamepadItem2 = this.XboxGamepadItem;
				if (xboxGamepadItem2 != null)
				{
					xboxGamepadItem2.SetActive(true);
				}
				PsGamepadItem psGamepadItem2 = this.PsGamepadItem;
				if (psGamepadItem2 == null)
				{
					return;
				}
				psGamepadItem2.SetActive(false);
				return;
			}
		}
		else
		{
			this.GamepadItem = null;
			PsGamepadItem psGamepadItem3 = this.PsGamepadItem;
			if (psGamepadItem3 != null)
			{
				psGamepadItem3.SetActive(false);
			}
			XboxGamepadItem xboxGamepadItem3 = this.XboxGamepadItem;
			if (xboxGamepadItem3 == null)
			{
				return;
			}
			xboxGamepadItem3.SetActive(false);
			return;
		}
	}

	// Token: 0x0600D6FE RID: 55038 RVA: 0x003FC2B4 File Offset: 0x003FA4B4
	private void RefreshKeyBoardTab()
	{
		CommonKeySettingRowsPanel pcPanel = this.PcPanel;
		if (pcPanel != null)
		{
			pcPanel.Refresh(KeySettingViewModel.GetKeySettingDataList(), KeySettingViewModel.InputControllerType);
		}
		CommonKeySettingRowsPanel pcPanel2 = this.PcPanel;
		if (pcPanel2 != null)
		{
			pcPanel2.SetActive(true);
		}
		CommonKeySettingRowsPanel gamepadPanel = this.GamepadPanel;
		if (gamepadPanel != null)
		{
			gamepadPanel.SetActive(false);
		}
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		UUIItem item2 = base.GetItem(3);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		UUIButtonComponent button = base.GetButton(9);
		if (button != null)
		{
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(true);
			}
		}
		UUIButtonComponent button2 = base.GetButton(15);
		if (button2 != null)
		{
			UUIItem uuiitem2 = button2.RootUIComp.Get();
			if (uuiitem2 != null)
			{
				uuiitem2.SetUIActive(false);
			}
		}
		UUIButtonComponent button3 = base.GetButton(16);
		if (button3 != null)
		{
			UUIItem uuiitem3 = button3.RootUIComp.Get();
			if (uuiitem3 != null)
			{
				uuiitem3.SetUIActive(false);
			}
		}
		UUIItem item3 = base.GetItem(13);
		if (item3 == null)
		{
			return;
		}
		item3.SetUIActive(false);
	}

	// Token: 0x0600D6FF RID: 55039 RVA: 0x003FC3B0 File Offset: 0x003FA5B0
	private void RefreshGamepadTab()
	{
		CommonKeySettingRowsPanel gamepadPanel = this.GamepadPanel;
		if (gamepadPanel != null)
		{
			gamepadPanel.Refresh(KeySettingViewModel.GetKeySettingDataList(), KeySettingViewModel.InputControllerType);
		}
		CommonKeySettingRowsPanel gamepadPanel2 = this.GamepadPanel;
		if (gamepadPanel2 != null)
		{
			gamepadPanel2.SetActive(true);
		}
		CommonKeySettingRowsPanel pcPanel = this.PcPanel;
		if (pcPanel != null)
		{
			pcPanel.SetActive(false);
		}
		bool flag = Info.Instance.IsHomeConsolePlatform();
		global::EInputControllerType lastGamepadEnum = InputKeyUtils.GetLastGamepadEnum();
		bool flag2 = Info.Instance.CheckIsBackBoneGamepad(lastGamepadEnum);
		bool flag3 = flag || flag2;
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(3);
		if (item2 != null)
		{
			item2.SetUIActive(true);
		}
		UUIButtonComponent button = base.GetButton(9);
		if (button != null)
		{
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(!flag3);
			}
		}
		UUIButtonComponent button2 = base.GetButton(15);
		if (button2 != null)
		{
			UUIItem uuiitem2 = button2.RootUIComp.Get();
			if (uuiitem2 != null)
			{
				uuiitem2.SetUIActive(false);
			}
		}
		UUIButtonComponent button3 = base.GetButton(16);
		if (button3 != null)
		{
			UUIItem uuiitem3 = button3.RootUIComp.Get();
			if (uuiitem3 != null)
			{
				uuiitem3.SetUIActive(false);
			}
		}
		UUIItem item3 = base.GetItem(13);
		if (item3 == null)
		{
			return;
		}
		item3.SetUIActive(flag3);
	}

	// Token: 0x0600D700 RID: 55040 RVA: 0x003FC4CC File Offset: 0x003FA6CC
	private void RefreshEditKeyTips(string textId = null)
	{
		if (StringUtils.IsEmpty(textId))
		{
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(11);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			this.TipsSequencePlayer.StopCurrentSequence(false, false);
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), textId, Array.Empty<object>());
		UUIItem item3 = base.GetItem(7);
		if (item3 != null)
		{
			item3.SetUIActive(true);
		}
		UUIItem item4 = base.GetItem(11);
		if (item4 != null)
		{
			item4.SetUIActive(false);
		}
		this.TipsSequencePlayer.PlayLevelSequenceByName("Start".ToString(), false, null, false);
	}

	// Token: 0x0600D701 RID: 55041 RVA: 0x003FC574 File Offset: 0x003FA774
	private void InitializePlatformInfo()
	{
		bool flag = Info.Instance.IsHomeConsolePlatform();
		bool flag2 = Info.Instance.IsMobileInputModel() && Info.Instance.IsInGamepad();
		UUIButtonComponent button = base.GetButton(0);
		if (button != null)
		{
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(!flag && !flag2);
			}
		}
		UUIButtonComponent button2 = base.GetButton(1);
		if (button2 != null)
		{
			UUIItem uuiitem2 = button2.RootUIComp.Get();
			if (uuiitem2 != null)
			{
				uuiitem2.SetUIActive(!flag && !flag2);
			}
		}
		global::EInputControllerType lastGamepadEnum = InputKeyUtils.GetLastGamepadEnum();
		bool flag3 = Info.Instance.IsInGamepad() && Info.Instance.CheckIsBackBoneGamepad(lastGamepadEnum);
		bool flag4 = flag || flag3;
		UUIItem item = base.GetItem(12);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(!flag4);
	}

	// Token: 0x0600D702 RID: 55042 RVA: 0x003FC643 File Offset: 0x003FA843
	private void OnLeftButtonClicked()
	{
		if (KeySettingViewModel.InputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard)
		{
			KeySettingViewModel.InputControllerType = CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad;
		}
		else if (KeySettingViewModel.InputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad)
		{
			KeySettingViewModel.InputControllerType = CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard;
		}
		this.Refresh();
		EventSystem.Instance.Emit<string>(EEventName.FinishGuideStepByEvent, "MenuView");
	}

	// Token: 0x0600D703 RID: 55043 RVA: 0x003FC67E File Offset: 0x003FA87E
	private void OnRightButtonClicked()
	{
		if (KeySettingViewModel.InputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard)
		{
			KeySettingViewModel.InputControllerType = CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad;
		}
		else if (KeySettingViewModel.InputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad)
		{
			KeySettingViewModel.InputControllerType = CSharpScript.Game.Module.Menu.EInputControllerType.Keyboard;
		}
		this.Refresh();
		EventSystem.Instance.Emit<string>(EEventName.FinishGuideStepByEvent, "MenuView");
	}

	// Token: 0x0600D704 RID: 55044 RVA: 0x003FC6BC File Offset: 0x003FA8BC
	private void OnResetButtonClicked()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ResetAllInput);
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			KeySettingViewModel.ResetSettings();
			InputSettingsController.Instance.InputSettingUpdateRequest();
			this.Refresh();
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600D705 RID: 55045 RVA: 0x003FC6F8 File Offset: 0x003FA8F8
	private void OnGamepadOperationButtonClicked()
	{
		UiManager.Instance.OpenView(EUiViewName.OperationPreferencesView, null, null);
	}

	// Token: 0x0600D706 RID: 55046 RVA: 0x003FC70B File Offset: 0x003FA90B
	private void OnDeviceLangChange()
	{
		if (KeySettingViewModel.CurrentDeviceType != EKeySettingDeviceType.Keyboard)
		{
			return;
		}
		if (KeySettingViewModel.IsEditing)
		{
			KeySettingViewModel.ExternalFinishEditKey();
		}
		this.Refresh();
	}

	// Token: 0x04007864 RID: 30820
	private GamepadItemBase GamepadItem;

	// Token: 0x04007865 RID: 30821
	private PsGamepadItem PsGamepadItem;

	// Token: 0x04007866 RID: 30822
	private XboxGamepadItem XboxGamepadItem;

	// Token: 0x04007867 RID: 30823
	private KeySettingRowData HoverKeySettingRowData;

	// Token: 0x04007868 RID: 30824
	private CommonKeySettingRowsPanel PcPanel;

	// Token: 0x04007869 RID: 30825
	private CommonKeySettingRowsPanel GamepadPanel;

	// Token: 0x0400786A RID: 30826
	private LevelSequencePlayer TipsSequencePlayer;

	// Token: 0x020077AA RID: 30634
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04026D6D RID: 159085
		public const int LeftButton = 0;

		// Token: 0x04026D6E RID: 159086
		public const int RightButton = 1;

		// Token: 0x04026D6F RID: 159087
		public const int DeviceNameText = 2;

		// Token: 0x04026D70 RID: 159088
		public const int GamepadItem = 3;

		// Token: 0x04026D71 RID: 159089
		public const int KeyboardItem = 4;

		// Token: 0x04026D72 RID: 159090
		public const int GamepadKeySettingItem = 5;

		// Token: 0x04026D73 RID: 159091
		public const int PcKeySettingItem = 6;

		// Token: 0x04026D74 RID: 159092
		public const int TipsItem = 7;

		// Token: 0x04026D75 RID: 159093
		public const int TipsText = 8;

		// Token: 0x04026D76 RID: 159094
		public const int ResetButton = 9;

		// Token: 0x04026D77 RID: 159095
		public const int GamepadPanelItem = 10;

		// Token: 0x04026D78 RID: 159096
		public const int SwitcherItem = 11;

		// Token: 0x04026D79 RID: 159097
		public const int GamepadLogoItem = 12;

		// Token: 0x04026D7A RID: 159098
		public const int PsAndBackBoneButtonsItem = 13;

		// Token: 0x04026D7B RID: 159099
		public const int PsAndBackBoneResetButton = 14;

		// Token: 0x04026D7C RID: 159100
		public const int GamepadOperationButton = 15;

		// Token: 0x04026D7D RID: 159101
		public const int PsAndBackBoneGamepadOperationButton = 16;

		// Token: 0x04026D7E RID: 159102
		public const int ExclusiveTypeTabRootItem = 17;
	}
}
