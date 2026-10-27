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

// Token: 0x0200202B RID: 8235
[NullableContext(2)]
[Nullable(0)]
public class CommonKeySettingPanel : KeySettingPanelBase
{
	// Token: 0x06010285 RID: 66181 RVA: 0x003EF6DB File Offset: 0x003ED8DB
	public CommonKeySettingPanel(EKeySettingExclusiveType exclusiveType = EKeySettingExclusiveType.None) : base(exclusiveType)
	{
	}

	// Token: 0x06010286 RID: 66182 RVA: 0x003EF6E4 File Offset: 0x003ED8E4
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

	// Token: 0x06010287 RID: 66183 RVA: 0x003EF930 File Offset: 0x003EDB30
	protected override UniTask OnBeforeStartAsync()
	{
		CommonKeySettingPanel.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonKeySettingPanel.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010288 RID: 66184 RVA: 0x003EF974 File Offset: 0x003EDB74
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

	// Token: 0x06010289 RID: 66185 RVA: 0x003EF9C3 File Offset: 0x003EDBC3
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnDeviceLangChange, new Action(this.OnDeviceLangChange));
	}

	// Token: 0x0601028A RID: 66186 RVA: 0x003EF9E1 File Offset: 0x003EDBE1
	protected override void OnWaitKeySetting()
	{
	}

	// Token: 0x0601028B RID: 66187 RVA: 0x003EF9E3 File Offset: 0x003EDBE3
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

	// Token: 0x0601028C RID: 66188 RVA: 0x003EFA06 File Offset: 0x003EDC06
	protected override void OnBeginEditKey()
	{
		GamepadItemBase gamepadItem = this.GamepadItem;
		if (gamepadItem != null)
		{
			gamepadItem.SetAllKeyDisable();
		}
		this.RefreshEditKeyTips("EditKey_Text");
	}

	// Token: 0x0601028D RID: 66189 RVA: 0x003EFA24 File Offset: 0x003EDC24
	protected override void OnFinishEditKey()
	{
		this.RefreshEditKeyTips(null);
	}

	// Token: 0x0601028E RID: 66190 RVA: 0x003EFA2D File Offset: 0x003EDC2D
	[NullableContext(1)]
	protected override void OnKeyChange(KeySettingRowData data, CSharpScript.Game.Module.Menu.EInputControllerType type)
	{
	}

	// Token: 0x0601028F RID: 66191 RVA: 0x003EFA2F File Offset: 0x003EDC2F
	protected override void OnKeySelected(KeySettingRowData data)
	{
	}

	// Token: 0x06010290 RID: 66192 RVA: 0x003EFA34 File Offset: 0x003EDC34
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

	// Token: 0x06010291 RID: 66193 RVA: 0x003EFAAC File Offset: 0x003EDCAC
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

	// Token: 0x06010292 RID: 66194 RVA: 0x003EFB33 File Offset: 0x003EDD33
	private void Refresh()
	{
		this.RefreshDeviceSwitcher();
		this.RefreshKeySettingPanel();
		this.RefreshGamepadPanel();
	}

	// Token: 0x06010293 RID: 66195 RVA: 0x003EFB48 File Offset: 0x003EDD48
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

	// Token: 0x06010294 RID: 66196 RVA: 0x003EFBDC File Offset: 0x003EDDDC
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

	// Token: 0x06010295 RID: 66197 RVA: 0x003EFC08 File Offset: 0x003EDE08
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

	// Token: 0x06010296 RID: 66198 RVA: 0x003EFCBC File Offset: 0x003EDEBC
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

	// Token: 0x06010297 RID: 66199 RVA: 0x003EFDB8 File Offset: 0x003EDFB8
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

	// Token: 0x06010298 RID: 66200 RVA: 0x003EFED4 File Offset: 0x003EE0D4
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

	// Token: 0x06010299 RID: 66201 RVA: 0x003EFF7C File Offset: 0x003EE17C
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

	// Token: 0x0601029A RID: 66202 RVA: 0x003F004B File Offset: 0x003EE24B
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

	// Token: 0x0601029B RID: 66203 RVA: 0x003F0086 File Offset: 0x003EE286
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

	// Token: 0x0601029C RID: 66204 RVA: 0x003F00C4 File Offset: 0x003EE2C4
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

	// Token: 0x0601029D RID: 66205 RVA: 0x003F0100 File Offset: 0x003EE300
	private void OnGamepadOperationButtonClicked()
	{
		UiManager.Instance.OpenView(EUiViewName.OperationPreferencesView, null, null);
	}

	// Token: 0x0601029E RID: 66206 RVA: 0x003F0113 File Offset: 0x003EE313
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

	// Token: 0x0400777B RID: 30587
	private GamepadItemBase GamepadItem;

	// Token: 0x0400777C RID: 30588
	private PsGamepadItem PsGamepadItem;

	// Token: 0x0400777D RID: 30589
	private XboxGamepadItem XboxGamepadItem;

	// Token: 0x0400777E RID: 30590
	private KeySettingRowData HoverKeySettingRowData;

	// Token: 0x0400777F RID: 30591
	private CommonKeySettingRowsPanel PcPanel;

	// Token: 0x04007780 RID: 30592
	private CommonKeySettingRowsPanel GamepadPanel;

	// Token: 0x04007781 RID: 30593
	private LevelSequencePlayer TipsSequencePlayer;

	// Token: 0x02008623 RID: 34339
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402BA5E RID: 178782
		public const int LeftButton = 0;

		// Token: 0x0402BA5F RID: 178783
		public const int RightButton = 1;

		// Token: 0x0402BA60 RID: 178784
		public const int DeviceNameText = 2;

		// Token: 0x0402BA61 RID: 178785
		public const int GamepadItem = 3;

		// Token: 0x0402BA62 RID: 178786
		public const int KeyboardItem = 4;

		// Token: 0x0402BA63 RID: 178787
		public const int GamepadKeySettingItem = 5;

		// Token: 0x0402BA64 RID: 178788
		public const int PcKeySettingItem = 6;

		// Token: 0x0402BA65 RID: 178789
		public const int TipsItem = 7;

		// Token: 0x0402BA66 RID: 178790
		public const int TipsText = 8;

		// Token: 0x0402BA67 RID: 178791
		public const int ResetButton = 9;

		// Token: 0x0402BA68 RID: 178792
		public const int GamepadPanelItem = 10;

		// Token: 0x0402BA69 RID: 178793
		public const int SwitcherItem = 11;

		// Token: 0x0402BA6A RID: 178794
		public const int GamepadLogoItem = 12;

		// Token: 0x0402BA6B RID: 178795
		public const int PsAndBackBoneButtonsItem = 13;

		// Token: 0x0402BA6C RID: 178796
		public const int PsAndBackBoneResetButton = 14;

		// Token: 0x0402BA6D RID: 178797
		public const int GamepadOperationButton = 15;

		// Token: 0x0402BA6E RID: 178798
		public const int PsAndBackBoneGamepadOperationButton = 16;

		// Token: 0x0402BA6F RID: 178799
		public const int ExclusiveTypeTabRootItem = 17;
	}
}
