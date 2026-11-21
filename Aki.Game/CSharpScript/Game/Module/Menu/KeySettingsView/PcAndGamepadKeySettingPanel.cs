using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.KeySetting;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x0200444D RID: 17485
	[NullableContext(1)]
	[Nullable(0)]
	public class PcAndGamepadKeySettingPanel : UiPanelBase
	{
		// Token: 0x0602C1BC RID: 180668 RVA: 0x00C620CC File Offset: 0x00C602CC
		public PcAndGamepadKeySettingPanel()
		{
			this.ResetBtnTextMap[1] = new Dictionary<int, string>();
			this.ResetBtnTextMap[2] = new Dictionary<int, string>();
			this.ResetBtnTextMap[1][0] = "KeyPositionReset_PC_Walk";
			this.ResetBtnTextMap[1][2] = "KeyPositionReset_PC_Drive";
			this.ResetBtnTextMap[2][0] = "KeyPositionReset_Handle_Walk";
			this.ResetBtnTextMap[2][2] = "KeyPositionReset_Handle_Drive";
		}

		// Token: 0x0602C1BD RID: 180669 RVA: 0x00C621D4 File Offset: 0x00C603D4
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

		// Token: 0x0602C1BE RID: 180670 RVA: 0x00C62420 File Offset: 0x00C60620
		private void OnLeftButtonClicked()
		{
			EInputControllerType inputControllerType = this.InputControllerType;
			if (this.CurrentDeviceType == EKeySettingDeviceType.Keyboard)
			{
				inputControllerType = this.GetInputControllerTypeByDeviceType(EKeySettingDeviceType.Gamepad);
			}
			else
			{
				inputControllerType = this.GetInputControllerTypeByDeviceType(EKeySettingDeviceType.Keyboard);
			}
			this.Refresh(inputControllerType);
			EventSystem.Instance.Emit<string>(EEventName.FinishGuideStepByEvent, "MenuView");
		}

		// Token: 0x0602C1BF RID: 180671 RVA: 0x00C6246C File Offset: 0x00C6066C
		private void OnRightButtonClicked()
		{
			EInputControllerType inputControllerType = this.InputControllerType;
			if (this.CurrentDeviceType == EKeySettingDeviceType.Keyboard)
			{
				inputControllerType = this.GetInputControllerTypeByDeviceType(EKeySettingDeviceType.Gamepad);
			}
			else
			{
				inputControllerType = this.GetInputControllerTypeByDeviceType(EKeySettingDeviceType.Keyboard);
			}
			this.Refresh(inputControllerType);
			EventSystem.Instance.Emit<string>(EEventName.FinishGuideStepByEvent, "MenuView");
		}

		// Token: 0x0602C1C0 RID: 180672 RVA: 0x00C624B8 File Offset: 0x00C606B8
		private void OnResetButtonClicked()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.KeySettingResetConfirm);
			string text = null;
			Dictionary<int, string> dictionary;
			if (this.ResetBtnTextMap.TryGetValue((int)this.InputControllerType, out dictionary))
			{
				dictionary.TryGetValue((int)this.CurrentExclusiveType, out text);
			}
			if (text != null)
			{
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew(text, null);
				if (localTextNew != null)
				{
					confirmBoxDataNew.SetTextArgs(new string[]
					{
						localTextNew
					});
				}
			}
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				foreach (EKeySettingRowDataHiddenType hiddenType in this.KeySettingRowDataHiddenTypeList)
				{
					foreach (EInputControllerType einputControllerType in this.KeySettingRowDataControllerTypeList)
					{
						foreach (KeySettingRowData keySettingRowData in this.GetKeySettingRowDataList(einputControllerType, this.CurrentExclusiveType, (int)hiddenType))
						{
							keySettingRowData.ResetKey(einputControllerType);
						}
					}
				}
				InputSettingsController.Instance.InputSettingUpdateRequest();
				this.Refresh(this.InputControllerType);
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0602C1C1 RID: 180673 RVA: 0x00C62538 File Offset: 0x00C60738
		private void OnGamepadOperationButtonClicked()
		{
			UiManager.Instance.OpenView(EUiViewName.OperationPreferencesView, null, null);
		}

		// Token: 0x0602C1C2 RID: 180674 RVA: 0x00C6254C File Offset: 0x00C6074C
		protected override UniTask OnBeforeStartAsync()
		{
			PcAndGamepadKeySettingPanel.<OnBeforeStartAsync>d__31 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PcAndGamepadKeySettingPanel.<OnBeforeStartAsync>d__31>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C1C3 RID: 180675 RVA: 0x00C62590 File Offset: 0x00C60790
		private UniTask CreateExclusiveTypeTabs()
		{
			PcAndGamepadKeySettingPanel.<CreateExclusiveTypeTabs>d__32 <CreateExclusiveTypeTabs>d__;
			<CreateExclusiveTypeTabs>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateExclusiveTypeTabs>d__.<>4__this = this;
			<CreateExclusiveTypeTabs>d__.<>1__state = -1;
			<CreateExclusiveTypeTabs>d__.<>t__builder.Start<PcAndGamepadKeySettingPanel.<CreateExclusiveTypeTabs>d__32>(ref <CreateExclusiveTypeTabs>d__);
			return <CreateExclusiveTypeTabs>d__.<>t__builder.Task;
		}

		// Token: 0x0602C1C4 RID: 180676 RVA: 0x00C625D4 File Offset: 0x00C607D4
		private void SelectExclusiveTypeTabByIndex(int index)
		{
			EKeySettingExclusiveType ekeySettingExclusiveType = KeySettingDefine.menuKeySettingExclusiveTypeList[index];
			if (ekeySettingExclusiveType == this.CurrentExclusiveType)
			{
				return;
			}
			this.CurrentExclusiveType = ekeySettingExclusiveType;
			this.CurrentExclusiveTypeTabIndex = index;
			this.Refresh(this.InputControllerType);
		}

		// Token: 0x0602C1C5 RID: 180677 RVA: 0x00C6260D File Offset: 0x00C6080D
		private KeySettingExclusiveTypeTabItem CreateExclusiveTypeTab([Nullable(2)] UUIItem iitem, int? index)
		{
			return new KeySettingExclusiveTypeTabItem();
		}

		// Token: 0x0602C1C6 RID: 180678 RVA: 0x00C62614 File Offset: 0x00C60814
		private void OnClickExclusiveTypeTab(int index)
		{
			this.SelectExclusiveTypeTabByIndex(index);
		}

		// Token: 0x0602C1C7 RID: 180679 RVA: 0x00C62620 File Offset: 0x00C60820
		private List<CommonTabItemData> LoadExclusiveTypeTabData()
		{
			List<CommonTabItemData> list = new List<CommonTabItemData>();
			foreach (EKeySettingExclusiveType typeId in KeySettingDefine.menuKeySettingExclusiveTypeList)
			{
				KeyExclusiveType? exclusiveTypeConfigById = MenuBaseConfig.Instance.GetExclusiveTypeConfigById((int)typeId);
				if (exclusiveTypeConfigById != null)
				{
					CommonTabItemData commonTabItemData = new CommonTabItemData();
					CommonTabData data = new CommonTabData(exclusiveTypeConfigById.Value.IconSpritePath, new CommonTabTitleData(exclusiveTypeConfigById.Value.Name, Array.Empty<object>()), null);
					commonTabItemData.Data = data;
					list.Add(commonTabItemData);
				}
			}
			return list;
		}

		// Token: 0x0602C1C8 RID: 180680 RVA: 0x00C626AC File Offset: 0x00C608AC
		private void SetExclusiveTypeTabCanInteract(bool canInteract)
		{
			if (!canInteract)
			{
				this.ExclusiveTypeTabComponent.ResetSelectIndex();
				using (Dictionary<int, KeySettingExclusiveTypeTabItem>.ValueCollection.Enumerator enumerator = this.ExclusiveTypeTabComponent.GetTabItemMap().Values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeySettingExclusiveTypeTabItem keySettingExclusiveTypeTabItem = enumerator.Current;
						keySettingExclusiveTypeTabItem.SetForceSwitch(EToggleState.ETT_UnDetermined, false);
					}
					return;
				}
			}
			foreach (KeySettingExclusiveTypeTabItem keySettingExclusiveTypeTabItem2 in this.ExclusiveTypeTabComponent.GetTabItemMap().Values)
			{
				keySettingExclusiveTypeTabItem2.SetForceSwitch(EToggleState.ETT_UnChecked, false);
			}
			this.ExclusiveTypeTabComponent.SelectToggleByIndex(this.CurrentExclusiveTypeTabIndex, true, true);
		}

		// Token: 0x0602C1C9 RID: 180681 RVA: 0x00C62774 File Offset: 0x00C60974
		private int GetInitialExclusiveTypeTabIndex()
		{
			EKeySettingExclusiveType? ekeySettingExclusiveType = null;
			BattleUiModel instance = BattleUiModel.Instance;
			bool? flag;
			if (instance == null)
			{
				flag = null;
			}
			else
			{
				BattleUiMotorcycleData motorcycleData = instance.MotorcycleData;
				flag = ((motorcycleData != null) ? new bool?(motorcycleData.IsDriving) : null);
			}
			bool? flag2 = flag;
			if (flag2.GetValueOrDefault())
			{
				ekeySettingExclusiveType = new EKeySettingExclusiveType?(EKeySettingExclusiveType.Motor);
			}
			return KeySettingDefine.menuKeySettingExclusiveTypeList.IndexOf(ekeySettingExclusiveType.GetValueOrDefault());
		}

		// Token: 0x0602C1CA RID: 180682 RVA: 0x00C627E0 File Offset: 0x00C609E0
		private void OnWaitPcKeyInput(KeySettingRowData keySettingRowData, KeySettingRowKeyItem keySettingRowKeyItem, KeySettingRowContainerItem keySettingRowContainerItem)
		{
			KeySettingPanel pcKeySettingPanel = this.PcKeySettingPanel;
			if (pcKeySettingPanel != null)
			{
				pcKeySettingPanel.SelectKeySettingRow(keySettingRowContainerItem);
			}
			EKeySettingOpenViewType openViewType = keySettingRowData.OpenViewType;
			if (openViewType != EKeySettingOpenViewType.None)
			{
				if (openViewType != EKeySettingOpenViewType.OpenAssemblyView)
				{
					if (openViewType == EKeySettingOpenViewType.OpenChangeLockView)
					{
						MenuController.Instance.OpenChangeLockView();
					}
				}
				else
				{
					RouletteController.Instance.OpenAssemblyView(ERouletteType.Function, null, null, null, false);
				}
				this.FinishEditKey();
				return;
			}
			if (keySettingRowData.IsLock)
			{
				GenericPromptController.Instance.ShowPromptByCode("KeyLock", Array.Empty<object>());
				this.FinishEditKey();
				return;
			}
			this.WaitKeySettingRowData = keySettingRowData;
			this.WaitKeySettingRowKeyItem = keySettingRowKeyItem;
			if (keySettingRowData.BothActionName != null && keySettingRowData.BothActionName.Count == 2)
			{
				ChangeActionInfo param = new ChangeActionInfo
				{
					InputControllerType = this.InputControllerType,
					KeySettingRowData = keySettingRowData,
					OnConfirmCallback = new Action<bool>(this.OnConfirmChangeBothAction)
				};
				UiManager.Instance.OpenView(EUiViewName.ChangeActionTipsView, param, null);
				this.FinishEditKey();
				return;
			}
			this.BeginEditKey();
		}

		// Token: 0x0602C1CB RID: 180683 RVA: 0x00C628E0 File Offset: 0x00C60AE0
		[NullableContext(2)]
		private void OnKeySettingRowHover(KeySettingRowData keySettingRowData)
		{
			if (this.InputControllerType == EInputControllerType.Keyboard)
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
				this.HoverKeySettingRowData = keySettingRowData;
				if (keySettingRowData == null)
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
					List<string> displayKeyName = keySettingRowData.GetDisplayKeyName(this.InputControllerType);
					if (displayKeyName == null || displayKeyName.Count == 0)
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

		// Token: 0x0602C1CC RID: 180684 RVA: 0x00C62964 File Offset: 0x00C60B64
		[NullableContext(2)]
		private void OnKeySettingRowUnHover(KeySettingRowData keySettingRowData)
		{
			if (this.InputControllerType == EInputControllerType.Keyboard)
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
					int? num = (keySettingRowData != null) ? new int?(keySettingRowData.ConfigId) : null;
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

		// Token: 0x0602C1CD RID: 180685 RVA: 0x00C629EC File Offset: 0x00C60BEC
		private void OnWaitGamepadKeyInput(KeySettingRowData keySettingRowData, KeySettingRowKeyItem keySettingRowKeyItem, KeySettingRowContainerItem keySettingRowContainerItem)
		{
			KeySettingPanel gamepadKeySettingPanel = this.GamepadKeySettingPanel;
			if (gamepadKeySettingPanel != null)
			{
				gamepadKeySettingPanel.SelectKeySettingRow(keySettingRowContainerItem);
			}
			EKeySettingOpenViewType openViewType = keySettingRowData.OpenViewType;
			if (openViewType != EKeySettingOpenViewType.None)
			{
				if (openViewType != EKeySettingOpenViewType.OpenAssemblyView)
				{
					if (openViewType == EKeySettingOpenViewType.OpenChangeLockView)
					{
						MenuController.Instance.OpenChangeLockView();
					}
				}
				else
				{
					RouletteController.Instance.OpenAssemblyView(ERouletteType.Function, null, null, null, false);
				}
				this.FinishEditKey();
				return;
			}
			if (keySettingRowData.IsLock)
			{
				GenericPromptController.Instance.ShowPromptByCode("KeyLock", Array.Empty<object>());
				this.FinishEditKey();
				return;
			}
			this.WaitKeySettingRowData = keySettingRowData;
			this.WaitKeySettingRowKeyItem = keySettingRowKeyItem;
			if (keySettingRowData.BothActionName != null && keySettingRowData.BothActionName.Count == 2)
			{
				ChangeActionInfo param = new ChangeActionInfo
				{
					InputControllerType = this.InputControllerType,
					KeySettingRowData = keySettingRowData,
					OnConfirmCallback = new Action<bool>(this.OnConfirmChangeBothAction)
				};
				UiManager.Instance.OpenView(EUiViewName.ChangeActionTipsView, param, null);
				this.FinishEditKey();
				return;
			}
			this.BeginEditKey();
		}

		// Token: 0x0602C1CE RID: 180686 RVA: 0x00C62AEC File Offset: 0x00C60CEC
		private void OnConfirmChangeBothAction(bool bRevert)
		{
			if (this.WaitKeySettingRowData == null)
			{
				this.FinishEditKey();
				return;
			}
			if (bRevert)
			{
				this.WaitKeySettingRowData.ChangeBothAction(this.InputControllerType);
				KeySettingRowKeyItem waitKeySettingRowKeyItem = this.WaitKeySettingRowKeyItem;
				if (waitKeySettingRowKeyItem != null)
				{
					waitKeySettingRowKeyItem.Refresh(this.WaitKeySettingRowData, this.InputControllerType);
				}
				InputSettingsController.Instance.InputSettingUpdateRequest();
				InputSettings.Instance.SaveKeyMappings();
			}
			this.FinishEditKey();
		}

		// Token: 0x0602C1CF RID: 180687 RVA: 0x00C62B54 File Offset: 0x00C60D54
		private void FillSettingRowDataLists(IReadOnlyList<KeyType> keyTypeConfigList)
		{
			foreach (EInputControllerType controllerType in this.KeySettingRowDataControllerTypeList)
			{
				foreach (EKeySettingExclusiveType exclusiveType in KeySettingDefine.menuKeySettingExclusiveTypeList)
				{
					List<KeySettingRowData> keySettingRowDataList = this.GetKeySettingRowDataList(controllerType, exclusiveType, 0);
					List<KeySettingRowData> keySettingRowDataList2 = this.GetKeySettingRowDataList(controllerType, exclusiveType, 1);
					this.FillSettingRowDataList(keySettingRowDataList, keySettingRowDataList2, keyTypeConfigList, controllerType, exclusiveType);
				}
			}
		}

		// Token: 0x0602C1D0 RID: 180688 RVA: 0x00C62BE0 File Offset: 0x00C60DE0
		protected override void OnStart()
		{
			IReadOnlyList<KeyType> allKeyTypeConfig = MenuBaseConfig.Instance.GetAllKeyTypeConfig();
			if (allKeyTypeConfig == null)
			{
				return;
			}
			this.KeySettingRowDataMap.Clear();
			this.HiddenKeySettingRowDataMap.Clear();
			this.InitializeKeySettingDeviceInfo();
			this.FillSettingRowDataLists(allKeyTypeConfig);
			this.InitializePlatformInfo();
			this.RefreshEditKeyTips(null);
			this.AddEvents();
			int initialExclusiveTypeTabIndex = this.GetInitialExclusiveTypeTabIndex();
			this.ExclusiveTypeTabComponent.SelectToggleByIndex(initialExclusiveTypeTabIndex, true, true);
		}

		// Token: 0x0602C1D1 RID: 180689 RVA: 0x00C62C48 File Offset: 0x00C60E48
		protected override void OnBeforeDestroy()
		{
			this.RemoveEvents();
			this.RemoveEditKeyTimerHandle();
			LevelSequencePlayer tipsSequencePlayer = this.TipsSequencePlayer;
			if (tipsSequencePlayer != null)
			{
				tipsSequencePlayer.Clear();
			}
			this.TipsSequencePlayer = null;
			this.PcKeySettingPanel = null;
			this.GamepadKeySettingPanel = null;
			this.WaitKeySettingRowData = null;
			this.WaitKeySettingRowKeyItem = null;
			this.XboxGamepadItem = null;
			this.PsGamepadItem = null;
			this.GamepadItem = null;
			this.HoverKeySettingRowData = null;
		}

		// Token: 0x0602C1D2 RID: 180690 RVA: 0x00C62CB1 File Offset: 0x00C60EB1
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey));
			EventSystem.Instance.Add(EEventName.OnDeviceLangChange, new Action(this.OnDeviceLangChange));
		}

		// Token: 0x0602C1D3 RID: 180691 RVA: 0x00C62CEB File Offset: 0x00C60EEB
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey));
			EventSystem.Instance.Remove(EEventName.OnDeviceLangChange, new Action(this.OnDeviceLangChange));
		}

		// Token: 0x0602C1D4 RID: 180692 RVA: 0x00C62D28 File Offset: 0x00C60F28
		private unsafe void OnInputAnyKey(bool bPress, FKey key)
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.RepeatKeyTipsView))
			{
				return;
			}
			if (MenuModel.Instance == null || !MenuModel.Instance.IsWaitForKeyInput)
			{
				return;
			}
			Log.Instance.Info(ELogModule.InputSettings, ELogAuthor.TZJ, "[KeySetting] 输入", default(ReadOnlySpan<ValueTuple<string, object>>));
			string keyName = key.KeyName.ToString();
			InputActionBinding actionBinding = InputSettingsManager.Instance.GetActionBinding("放弃改键");
			if (actionBinding != null && actionBinding.HasKey(keyName))
			{
				this.FinishEditKey();
				return;
			}
			if (this.WaitKeySettingRowData == null)
			{
				this.FinishEditKey();
				return;
			}
			if (this.WaitKeySettingRowData.IsLock)
			{
				GenericPromptController.Instance.ShowPromptByCode("KeyLock", Array.Empty<object>());
				this.FinishEditKey();
				return;
			}
			if (bPress)
			{
				this.RecordEditKey(keyName);
				return;
			}
			if (this.EditKeyNameList.Count <= 0)
			{
				return;
			}
			if (this.EditKeyNameList.Count > 1)
			{
				if (!this.WaitKeySettingRowData.CanCombination)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.InputSettings;
					ELogAuthor author = ELogAuthor.XXJ;
					string message = "[KeySetting]改键失败，原因：该输入在配置上不允许修改成组合键";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActionOrAxisName", this.WaitKeySettingRowData.GetActionOrAxisName());
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					GenericPromptController.Instance.ShowPromptByCode("ErrorKey", Array.Empty<object>());
					this.ClearEditKeyNameList();
					return;
				}
				if (!this.WaitKeySettingRowData.IsAllowCombinationKey(this.EditKeyNameList[0], this.EditKeyNameList[1]))
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.InputSettings;
					ELogAuthor author2 = ELogAuthor.XXJ;
					string message2 = "[KeySetting]改键失败，原因：尝试修改为组合输入，但不在允许设置的组合按键范围配置里内";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActionOrAxisName", this.WaitKeySettingRowData.GetActionOrAxisName());
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("MainKey", this.EditKeyNameList[0]);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("SecondKey", this.EditKeyNameList[1]);
					instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					GenericPromptController.Instance.ShowPromptByCode("ErrorKey", Array.Empty<object>());
					this.ClearEditKeyNameList();
					return;
				}
			}
			else
			{
				if (!this.WaitKeySettingRowData.IsAllowKey(this.EditKeyNameList[0]))
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.InputSettings;
					ELogAuthor author3 = ELogAuthor.XXJ;
					string message3 = "[KeySetting]改键失败，原因：不在允许设置的组合按键范围配置里内";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("ActionOrAxisName", this.WaitKeySettingRowData.GetActionOrAxisName());
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("this.EditKeyNameList[0]", this.EditKeyNameList[0]);
					instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
					GenericPromptController.Instance.ShowPromptByCode("ErrorKey", Array.Empty<object>());
					this.ClearEditKeyNameList();
					return;
				}
				if (!MenuController.Instance.IsInputControllerTypeIncludeKey(this.InputControllerType, this.EditKeyNameList[0]))
				{
					GenericPromptController.Instance.ShowPromptByCode("ErrorKey", Array.Empty<object>());
					this.ClearEditKeyNameList();
					return;
				}
			}
			List<KeySettingRowData> keySettingRowDataList = this.GetKeySettingRowDataList(EInputControllerType.Gamepad, this.CurrentExclusiveType, 0);
			if (InputSettings.Instance.IsKeyboardKey(keyName) || InputSettings.Instance.IsMouseButton(keyName))
			{
				keySettingRowDataList = this.GetKeySettingRowDataList(EInputControllerType.Keyboard, this.CurrentExclusiveType, 0);
			}
			KeySettingRowData sameKeySettingRowData = this.GetSameKeySettingRowData(keySettingRowDataList, this.EditKeyNameList, this.WaitKeySettingRowData);
			if (sameKeySettingRowData == null || !sameKeySettingRowData.IsCheckSameKey)
			{
				if (this.EditKeyNameList.Count > 0)
				{
					this.WaitKeySettingRowData.SetKey(this.EditKeyNameList, this.InputControllerType);
					KeySettingRowKeyItem waitKeySettingRowKeyItem = this.WaitKeySettingRowKeyItem;
					if (waitKeySettingRowKeyItem != null)
					{
						waitKeySettingRowKeyItem.Refresh(this.WaitKeySettingRowData, this.InputControllerType);
					}
					this.SetAndRefreshConnectedKey(this.WaitKeySettingRowData, this.EditKeyNameList);
					InputSettingsController.Instance.InputSettingUpdateRequest();
					InputSettings.Instance.SaveKeyMappings();
					this.FinishEditKey();
				}
				return;
			}
			List<string> currentKeyName = this.WaitKeySettingRowData.GetCurrentKeyName(this.InputControllerType);
			if (currentKeyName == null)
			{
				return;
			}
			if (!sameKeySettingRowData.CanCombination && currentKeyName.Count > 1)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("CombineKeyDisable", Array.Empty<object>());
				this.ClearEditKeyNameList();
				return;
			}
			if (this.WaitKeySettingRowData.CanDisable)
			{
				this.FinishEditKey();
				ScrollingTipsController.Instance.ShowTipsByTextId("KeyUnalterable_Text", Array.Empty<object>());
				return;
			}
			List<string> editKeyNameList = new List<string>
			{
				this.EditKeyNameList[0]
			};
			if (this.EditKeyNameList.Count > 1)
			{
				string text = this.EditKeyNameList[1];
				if (text != null)
				{
					editKeyNameList.Add(text);
				}
			}
			RepeatKeyInfo param = new RepeatKeyInfo
			{
				InputControllerType = this.InputControllerType,
				CurrentKeySettingRowData = this.WaitKeySettingRowData,
				RepeatKeySettingRowData = sameKeySettingRowData,
				OnCloseCallback = delegate(bool bConfirm)
				{
					if (!bConfirm)
					{
						this.SetInputDisable(true);
						return;
					}
					this.FinishEditKey();
					List<string> currentKeyName2 = this.WaitKeySettingRowData.GetCurrentKeyName(this.InputControllerType);
					if (currentKeyName2 == null)
					{
						return;
					}
					if (!sameKeySettingRowData.IsActionOrAxis && !this.WaitKeySettingRowData.IsActionOrAxis && sameKeySettingRowData.GetActionOrAxisName() == this.WaitKeySettingRowData.GetActionOrAxisName() && !sameKeySettingRowData.IsCombination(this.InputControllerType) && !this.WaitKeySettingRowData.IsCombination(this.InputControllerType))
					{
						Dictionary<string, float> axisKeyScaleMap = this.WaitKeySettingRowData.GetAxisKeyScaleMap();
						string key2 = this.WaitKeySettingRowData.ConvertKeyToActionOrAxis(editKeyNameList[0]);
						string key3 = this.WaitKeySettingRowData.ConvertKeyToActionOrAxis(currentKeyName2[0]);
						float value;
						float value3;
						if (axisKeyScaleMap.TryGetValue(key2, out value))
						{
							float value2;
							if (axisKeyScaleMap.TryGetValue(key3, out value2))
							{
								axisKeyScaleMap[key2] = value2;
							}
							axisKeyScaleMap[key3] = value;
						}
						else if (axisKeyScaleMap.TryGetValue(key3, out value3))
						{
							axisKeyScaleMap[key2] = value3;
						}
						this.WaitKeySettingRowData.SetAxisBindingKeys(axisKeyScaleMap, this.WaitKeySettingRowData.BindingType);
					}
					else
					{
						sameKeySettingRowData.SetKey(currentKeyName2, this.InputControllerType);
						this.WaitKeySettingRowData.SetKey(editKeyNameList, this.InputControllerType);
					}
					KeySettingPanel currentKeySettingPanel = this.GetCurrentKeySettingPanel();
					if (currentKeySettingPanel != null)
					{
						currentKeySettingPanel.RefreshRow(this.WaitKeySettingRowData);
					}
					if (currentKeySettingPanel != null)
					{
						currentKeySettingPanel.RefreshRow(sameKeySettingRowData);
					}
					this.SetAndRefreshConnectedKey(this.WaitKeySettingRowData, editKeyNameList);
					this.SetAndRefreshConnectedKey(sameKeySettingRowData, currentKeyName2);
					InputSettingsController.Instance.InputSettingUpdateRequest();
					InputSettings.Instance.SaveKeyMappings();
				}
			};
			this.SetInputDisable(false);
			UiManager.Instance.OpenView(EUiViewName.RepeatKeyTipsView, param, null);
		}

		// Token: 0x0602C1D5 RID: 180693 RVA: 0x00C6320D File Offset: 0x00C6140D
		private void OnDeviceLangChange()
		{
			if (this.CurrentDeviceType == EKeySettingDeviceType.Keyboard)
			{
				UUIItem item = base.GetItem(7);
				if (item != null && item.bIsUIActive)
				{
					this.FinishEditKey();
				}
				this.Refresh(EInputControllerType.Keyboard);
			}
		}

		// Token: 0x0602C1D6 RID: 180694 RVA: 0x00C6323C File Offset: 0x00C6143C
		private unsafe List<KeySettingRowData> SetConnectedKey(KeySettingRowData keySettingRawData, List<string> keyNameList)
		{
			List<KeySettingRowData> list = new List<KeySettingRowData>();
			foreach (int num in keySettingRawData.ConnectedKeySettingIdList)
			{
				KeySetting? config = ConfigKeySettingById.GetConfig(num, true);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InputSettings;
				ELogAuthor author = ELogAuthor.TZJ;
				string message = "[KeySetting] 设置连锁键位 连锁Id";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item = "KeySettingRowData";
				KeySetting? keySettingConfig = keySettingRawData.GetKeySettingConfig();
				ptr = new ValueTuple<string, object>(item, (keySettingConfig != null) ? new int?(keySettingConfig.GetValueOrDefault().Id) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Id", num);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				KeySettingRowData keySettingRowData;
				if (config != null && config.Value.OnlyWorkNotShow)
				{
					keySettingRowData = this.GetHiddenKeySettingDataByConfigId(num);
				}
				else
				{
					keySettingRowData = this.GetKeySettingDataByConfigId(num);
				}
				if (keySettingRowData == null)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.InputSettings;
					ELogAuthor author2 = ELogAuthor.TZJ;
					string message2 = "[KeySetting] 设置连锁键位 连锁Id 找不到数据";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
					string item2 = "KeySettingRowData";
					keySettingConfig = keySettingRawData.GetKeySettingConfig();
					ptr2 = new ValueTuple<string, object>(item2, (keySettingConfig != null) ? new int?(keySettingConfig.GetValueOrDefault().Id) : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Id", num);
					instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				}
				else
				{
					keySettingRowData.SetKey(keyNameList, this.InputControllerType);
					list.Add(keySettingRowData);
				}
			}
			return list;
		}

		// Token: 0x0602C1D7 RID: 180695 RVA: 0x00C63420 File Offset: 0x00C61620
		private unsafe void SetAndRefreshConnectedKey(KeySettingRowData keySettingRawData, List<string> keyNameList)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.TZJ;
			string message = "[KeySetting] 设置连锁键位";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			KeySetting? keySetting;
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("KeySettingRowData", (keySettingRawData.GetKeySettingConfig() != null) ? new int?(keySetting.GetValueOrDefault().Id) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("KeyNameList", keyNameList);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("连锁列表", keySettingRawData.ConnectedKeySettingIdList);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			List<KeySettingRowData> list = this.SetConnectedKey(keySettingRawData, keyNameList);
			KeySettingPanel currentKeySettingPanel = this.GetCurrentKeySettingPanel();
			foreach (KeySettingRowData keySettingRowData in list)
			{
				if (currentKeySettingPanel != null)
				{
					currentKeySettingPanel.RefreshRow(keySettingRowData);
				}
			}
		}

		// Token: 0x0602C1D8 RID: 180696 RVA: 0x00C63528 File Offset: 0x00C61728
		private void InitializeKeySettingDeviceInfo()
		{
			KeySettingDeviceInfo value = new KeySettingDeviceInfo
			{
				DeviceType = EKeySettingDeviceType.Keyboard,
				NameTextId = "Text_KeyBoard_Text"
			};
			KeySettingDeviceInfo value2 = new KeySettingDeviceInfo
			{
				DeviceType = EKeySettingDeviceType.Gamepad,
				NameTextId = "Text_Handle_Text"
			};
			this.KeySettingDeviceInfoMap.Add(EKeySettingDeviceType.Keyboard, value);
			this.KeySettingDeviceInfoMap.Add(EKeySettingDeviceType.Gamepad, value2);
		}

		// Token: 0x0602C1D9 RID: 180697 RVA: 0x00C63580 File Offset: 0x00C61780
		private List<KeySettingRowData> GetKeySettingRowDataList(EInputControllerType controllerType, EKeySettingExclusiveType exclusiveType, int hiddenType)
		{
			while (this.KeySettingRowDataListMap.Count <= (int)controllerType)
			{
				this.KeySettingRowDataListMap.Add(new List<List<List<KeySettingRowData>>>());
			}
			List<List<List<KeySettingRowData>>> list = this.KeySettingRowDataListMap[(int)controllerType];
			while (list.Count <= (int)exclusiveType)
			{
				list.Add(new List<List<KeySettingRowData>>());
			}
			List<List<KeySettingRowData>> list2 = list[(int)exclusiveType];
			while (list2.Count <= hiddenType)
			{
				list2.Add(new List<KeySettingRowData>());
			}
			return list2[hiddenType];
		}

		// Token: 0x0602C1DA RID: 180698 RVA: 0x00C635F8 File Offset: 0x00C617F8
		private void FillSettingRowDataList(List<KeySettingRowData> outputRowDataList, List<KeySettingRowData> outputHiddenRowDataList, IReadOnlyList<KeyType> keyTypeConfigList, EInputControllerType controllerType, EKeySettingExclusiveType exclusiveType)
		{
			outputRowDataList.Clear();
			outputHiddenRowDataList.Clear();
			MenuBaseConfig instance = MenuBaseConfig.Instance;
			foreach (KeyType keyType in keyTypeConfigList)
			{
				int typeId = keyType.TypeId;
				IReadOnlyList<KeySetting> collection = instance.GetExclusiveKeySettingConfigByTypeIdAndInputControllerType(typeId, (int)controllerType, exclusiveType) ?? new List<KeySetting>();
				IReadOnlyList<KeySetting> collection2 = instance.GetExclusiveKeySettingConfigByTypeIdAndInputControllerType(typeId, 0, exclusiveType) ?? new List<KeySetting>();
				List<KeySetting> list = new List<KeySetting>();
				list.AddRange(collection);
				list.AddRange(collection2);
				if (list.Count > 0)
				{
					bool flag = false;
					foreach (KeySetting keySetting in list)
					{
						if (!keySetting.OnlyWorkNotShow)
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						KeySettingRowData keySettingRowData = new KeySettingRowData();
						keySettingRowData.InitializeKeyType(keyType);
						outputRowDataList.Add(keySettingRowData);
					}
					list.Sort(delegate(KeySetting aConfig, KeySetting bConfig)
					{
						if (aConfig.SortId == bConfig.SortId)
						{
							return aConfig.Id - bConfig.Id;
						}
						return aConfig.SortId - bConfig.SortId;
					});
					foreach (KeySetting keySettingConfig in list)
					{
						KeySettingRowData keySettingRowData2 = new KeySettingRowData();
						if (!this.KeySettingRowDataMap.ContainsKey(keySettingConfig.Id))
						{
							keySettingRowData2.InitializeKeySetting(keySettingConfig);
							if (keySettingConfig.OnlyWorkNotShow)
							{
								outputHiddenRowDataList.Add(keySettingRowData2);
								this.HiddenKeySettingRowDataMap.Add(keySettingConfig.Id, keySettingRowData2);
							}
							else
							{
								outputRowDataList.Add(keySettingRowData2);
								this.KeySettingRowDataMap.Add(keySettingConfig.Id, keySettingRowData2);
							}
						}
					}
				}
			}
		}

		// Token: 0x0602C1DB RID: 180699 RVA: 0x00C637FC File Offset: 0x00C619FC
		private void InitializePlatformInfo()
		{
			bool flag = Info.Instance.IsPs5Platform() || Info.Instance.IsXboxPlatform();
			bool flag2 = Info.Instance.IsMobileInputModel() && Info.Instance.IsInGamepad();
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(!flag && !flag2);
			}
			UUIButtonComponent button2 = base.GetButton(1);
			if (button2 != null)
			{
				button2.RootUIComp.Get().SetUIActive(!flag && !flag2);
			}
			EInputControllerType lastGamepadEnum = InputKeyUtils.GetLastGamepadEnum();
			bool flag3 = Info.Instance.IsInGamepad() && Info.Instance.CheckIsBackBoneGamepad(lastGamepadEnum);
			bool flag4 = flag || flag3;
			UUIItem item = base.GetItem(12);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(!flag4);
		}

		// Token: 0x0602C1DC RID: 180700 RVA: 0x00C638D0 File Offset: 0x00C61AD0
		public void Refresh(EInputControllerType inputControllerType)
		{
			this.InputControllerType = inputControllerType;
			EKeySettingDeviceType deviceType = this.InputControllerTypeConvertToDeviceType(inputControllerType);
			this.RefreshDeviceSwitcher(deviceType);
			this.RefreshKeySettingPanel(inputControllerType, this.CurrentExclusiveType);
			this.RefreshGamepadPanel(inputControllerType);
			this.RefreshResetButtonText(inputControllerType);
		}

		// Token: 0x0602C1DD RID: 180701 RVA: 0x00C63910 File Offset: 0x00C61B10
		private void RefreshDeviceSwitcher(EKeySettingDeviceType deviceType)
		{
			this.CurrentDeviceType = deviceType;
			IKeySettingDeviceInfo keySettingDeviceInfo;
			if (!this.KeySettingDeviceInfoMap.TryGetValue(deviceType, out keySettingDeviceInfo))
			{
				return;
			}
			string nameTextId = keySettingDeviceInfo.NameTextId;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), nameTextId, Array.Empty<object>());
			if (this.CurrentDeviceType == EKeySettingDeviceType.Keyboard)
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

		// Token: 0x0602C1DE RID: 180702 RVA: 0x00C639A8 File Offset: 0x00C61BA8
		private void RefreshKeyBoardTab(EInputControllerType inputControllerType, EKeySettingExclusiveType exclusiveType)
		{
			KeySettingPanel pcKeySettingPanel = this.PcKeySettingPanel;
			if (pcKeySettingPanel != null)
			{
				pcKeySettingPanel.Refresh(this.GetKeySettingRowDataList(EInputControllerType.Keyboard, exclusiveType, 0), inputControllerType);
			}
			KeySettingPanel pcKeySettingPanel2 = this.PcKeySettingPanel;
			if (pcKeySettingPanel2 != null)
			{
				pcKeySettingPanel2.SetActive(true);
			}
			KeySettingPanel gamepadKeySettingPanel = this.GamepadKeySettingPanel;
			if (gamepadKeySettingPanel != null)
			{
				gamepadKeySettingPanel.SetActive(false);
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
			this.RefreshButtons(inputControllerType);
		}

		// Token: 0x0602C1DF RID: 180703 RVA: 0x00C63A24 File Offset: 0x00C61C24
		private void RefreshGamepadTab(EInputControllerType inputControllerType, EKeySettingExclusiveType exclusiveType)
		{
			KeySettingPanel gamepadKeySettingPanel = this.GamepadKeySettingPanel;
			if (gamepadKeySettingPanel != null)
			{
				gamepadKeySettingPanel.Refresh(this.GetKeySettingRowDataList(EInputControllerType.Gamepad, exclusiveType, 0), inputControllerType);
			}
			KeySettingPanel gamepadKeySettingPanel2 = this.GamepadKeySettingPanel;
			if (gamepadKeySettingPanel2 != null)
			{
				gamepadKeySettingPanel2.SetActive(true);
			}
			KeySettingPanel pcKeySettingPanel = this.PcKeySettingPanel;
			if (pcKeySettingPanel != null)
			{
				pcKeySettingPanel.SetActive(false);
			}
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
			this.RefreshButtons(inputControllerType);
		}

		// Token: 0x0602C1E0 RID: 180704 RVA: 0x00C63AA0 File Offset: 0x00C61CA0
		private void RefreshButtons(EInputControllerType inputControllerType)
		{
			if (inputControllerType != EInputControllerType.Keyboard)
			{
				if (inputControllerType == EInputControllerType.Gamepad)
				{
					bool flag = Info.Instance.IsHomeConsolePlatform();
					EInputControllerType lastGamepadEnum = InputKeyUtils.GetLastGamepadEnum();
					bool flag2 = Info.Instance.CheckIsBackBoneGamepad(lastGamepadEnum);
					bool flag3 = flag || flag2;
					UUIButtonComponent button = base.GetButton(9);
					if (button != null)
					{
						button.RootUIComp.Get().SetUIActive(!flag3);
					}
					UUIButtonComponent button2 = base.GetButton(15);
					if (button2 != null)
					{
						button2.RootUIComp.Get().SetUIActive(!flag3);
					}
					UUIButtonComponent button3 = base.GetButton(16);
					if (button3 != null)
					{
						button3.RootUIComp.Get().SetUIActive(flag3);
					}
					UUIItem item = base.GetItem(13);
					if (item == null)
					{
						return;
					}
					item.SetUIActive(flag3);
				}
				return;
			}
			UUIButtonComponent button4 = base.GetButton(9);
			if (button4 != null)
			{
				button4.RootUIComp.Get().SetUIActive(true);
			}
			UUIButtonComponent button5 = base.GetButton(15);
			if (button5 != null)
			{
				button5.RootUIComp.Get().SetUIActive(false);
			}
			UUIButtonComponent button6 = base.GetButton(16);
			if (button6 != null)
			{
				button6.RootUIComp.Get().SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(13);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x0602C1E1 RID: 180705 RVA: 0x00C63BCA File Offset: 0x00C61DCA
		private void RefreshKeySettingPanel(EInputControllerType inputControllerType, EKeySettingExclusiveType exclusiveType)
		{
			if (inputControllerType == EInputControllerType.Keyboard)
			{
				this.RefreshKeyBoardTab(inputControllerType, exclusiveType);
				return;
			}
			if (inputControllerType != EInputControllerType.Gamepad)
			{
				return;
			}
			this.RefreshGamepadTab(inputControllerType, exclusiveType);
		}

		// Token: 0x0602C1E2 RID: 180706 RVA: 0x00C63BE8 File Offset: 0x00C61DE8
		private void RefreshGamepadPanel(EInputControllerType inputControllerType)
		{
			if (inputControllerType == EInputControllerType.Gamepad)
			{
				EInputControllerType lastGamepadEnum = InputKeyUtils.GetLastGamepadEnum();
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

		// Token: 0x0602C1E3 RID: 180707 RVA: 0x00C63C96 File Offset: 0x00C61E96
		private void RefreshResetButtonText(EInputControllerType inputControllerType)
		{
			if (inputControllerType != EInputControllerType.Keyboard)
			{
				if (inputControllerType == EInputControllerType.Gamepad)
				{
					KeySettingPanelResetButton resetButton = this.ResetButton;
					if (resetButton == null)
					{
						return;
					}
					resetButton.SetConfirmText("PlayerController_ResetButton_Controller");
				}
				return;
			}
			KeySettingPanelResetButton resetButton2 = this.ResetButton;
			if (resetButton2 == null)
			{
				return;
			}
			resetButton2.SetConfirmText("PlayerController_ResetButton");
		}

		// Token: 0x0602C1E4 RID: 180708 RVA: 0x00C63CCB File Offset: 0x00C61ECB
		private EKeySettingDeviceType InputControllerTypeConvertToDeviceType(EInputControllerType inputControllerType)
		{
			if (inputControllerType == EInputControllerType.Keyboard)
			{
				return EKeySettingDeviceType.Keyboard;
			}
			if (inputControllerType != EInputControllerType.Gamepad)
			{
				return EKeySettingDeviceType.None;
			}
			return EKeySettingDeviceType.Gamepad;
		}

		// Token: 0x0602C1E5 RID: 180709 RVA: 0x00C63CDC File Offset: 0x00C61EDC
		private EInputControllerType GetInputControllerTypeByDeviceType(EKeySettingDeviceType deviceType)
		{
			if (deviceType == EKeySettingDeviceType.Keyboard)
			{
				return EInputControllerType.Keyboard;
			}
			return EInputControllerType.Gamepad;
		}

		// Token: 0x0602C1E6 RID: 180710 RVA: 0x00C63CE8 File Offset: 0x00C61EE8
		[return: Nullable(2)]
		private KeySettingRowData GetSameKeySettingRowData(List<KeySettingRowData> keySettingRowDataList, List<string> checkKeyNameList, [Nullable(2)] KeySettingRowData filterKeyRowData)
		{
			if (checkKeyNameList.Count <= 0)
			{
				return null;
			}
			foreach (KeySettingRowData keySettingRowData in keySettingRowDataList)
			{
				if (keySettingRowData != filterKeyRowData && keySettingRowData.HasKey(checkKeyNameList, this.InputControllerType))
				{
					return keySettingRowData;
				}
			}
			return null;
		}

		// Token: 0x0602C1E7 RID: 180711 RVA: 0x00C63D54 File Offset: 0x00C61F54
		private void BeginEditKey()
		{
			KeySettingPanel pcKeySettingPanel = this.PcKeySettingPanel;
			if (pcKeySettingPanel != null)
			{
				pcKeySettingPanel.StopScroll();
			}
			KeySettingPanel gamepadKeySettingPanel = this.GamepadKeySettingPanel;
			if (gamepadKeySettingPanel != null)
			{
				gamepadKeySettingPanel.StopScroll();
			}
			this.SetExclusiveTypeTabCanInteract(false);
			UUIButtonComponent button = base.GetButton(9);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(false);
			}
			this.EditKeyTimerHandle = TimerSystem.GameplayTimeInstance.Next(delegate(float _)
			{
				Log.Instance.Info(ELogModule.InputSettings, ELogAuthor.XXJ, "[KeySetting]当等待键盘输入改键时26", default(ReadOnlySpan<ValueTuple<string, object>>));
				GamepadItemBase gamepadItem = this.GamepadItem;
				if (gamepadItem != null)
				{
					gamepadItem.SetAllKeyDisable();
				}
				this.HoverKeySettingRowData = null;
				this.RemoveEditKeyTimerHandle();
				this.SetInputDisable(true);
				this.RefreshEditKeyTips("EditKey_Text");
			}, null, null);
			foreach (KeySettingExclusiveTypeTabItem keySettingExclusiveTypeTabItem in this.ExclusiveTypeTabComponent.GetTabItemMap().Values)
			{
				keySettingExclusiveTypeTabItem.SetForceSwitch(EToggleState.ETT_UnDetermined, false);
			}
		}

		// Token: 0x0602C1E8 RID: 180712 RVA: 0x00C63E18 File Offset: 0x00C62018
		private void FinishEditKey()
		{
			Log.Instance.Info(ELogModule.InputSettings, ELogAuthor.XXJ, "[KeySetting]当输入改键结束时", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.SetInputDisable(false);
			this.RemoveEditKeyTimerHandle();
			this.RefreshEditKeyTips(null);
			KeySettingPanel currentKeySettingPanel = this.GetCurrentKeySettingPanel();
			if (currentKeySettingPanel != null)
			{
				currentKeySettingPanel.SelectKeySettingRow(null);
			}
			UiLayer.Instance.SetShowMaskLayer("KeySettingMask", false);
			this.SetExclusiveTypeTabCanInteract(true);
			this.RefreshButtons(this.InputControllerType);
		}

		// Token: 0x0602C1E9 RID: 180713 RVA: 0x00C63E8C File Offset: 0x00C6208C
		private void RecordEditKey(string keyName)
		{
			this.EditKeyNameList.Add(keyName);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[KeySetting]记录要设置的按键";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EditKeyNameList", this.EditKeyNameList);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602C1EA RID: 180714 RVA: 0x00C63ED4 File Offset: 0x00C620D4
		private void SetInputDisable(bool isDisable)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[KeySetting]设置是否允许输入";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("isWait", isDisable);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.ClearEditKeyNameList();
			MenuModel.Instance.IsWaitForKeyInput = isDisable;
			InputDistributeController.Instance.RefreshInputTag();
			UiLayer.Instance.SetShowMaskLayer("KeySettingMask", isDisable);
		}

		// Token: 0x0602C1EB RID: 180715 RVA: 0x00C63F38 File Offset: 0x00C62138
		private void ClearEditKeyNameList()
		{
			this.EditKeyNameList.Clear();
		}

		// Token: 0x0602C1EC RID: 180716 RVA: 0x00C63F45 File Offset: 0x00C62145
		private void RemoveEditKeyTimerHandle()
		{
			if (this.EditKeyTimerHandle != null && TimerSystem.GameplayTimeInstance.Has(this.EditKeyTimerHandle))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.EditKeyTimerHandle);
				this.EditKeyTimerHandle = null;
			}
		}

		// Token: 0x0602C1ED RID: 180717 RVA: 0x00C63F7C File Offset: 0x00C6217C
		[NullableContext(2)]
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
			this.TipsSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x0602C1EE RID: 180718 RVA: 0x00C64020 File Offset: 0x00C62220
		[NullableContext(2)]
		private KeySettingRowData GetKeySettingDataByConfigId(int configId)
		{
			KeySettingRowData result;
			if (this.KeySettingRowDataMap.TryGetValue(configId, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0602C1EF RID: 180719 RVA: 0x00C64040 File Offset: 0x00C62240
		[NullableContext(2)]
		private KeySettingRowData GetHiddenKeySettingDataByConfigId(int configId)
		{
			KeySettingRowData result;
			if (this.HiddenKeySettingRowDataMap.TryGetValue(configId, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0602C1F0 RID: 180720 RVA: 0x00C64060 File Offset: 0x00C62260
		[NullableContext(2)]
		private KeySettingPanel GetCurrentKeySettingPanel()
		{
			EInputControllerType inputControllerType = this.InputControllerType;
			if (inputControllerType == EInputControllerType.Keyboard)
			{
				return this.PcKeySettingPanel;
			}
			if (inputControllerType != EInputControllerType.Gamepad)
			{
				return null;
			}
			return this.GamepadKeySettingPanel;
		}

		// Token: 0x0602C1F1 RID: 180721 RVA: 0x00C64090 File Offset: 0x00C62290
		[NullableContext(2)]
		public UUIItem GetGuideItemByKeySettingId(int configId, bool? needScrollTo = false)
		{
			KeySettingPanel currentKeySettingPanel = this.GetCurrentKeySettingPanel();
			KeySettingRowData keySettingDataByConfigId = this.GetKeySettingDataByConfigId(configId);
			if (currentKeySettingPanel == null || keySettingDataByConfigId == null)
			{
				return null;
			}
			KeySettingRowContainerItem rowByData = currentKeySettingPanel.GetRowByData(keySettingDataByConfigId, needScrollTo.Value);
			if (rowByData == null)
			{
				return null;
			}
			return rowByData.GetRootItem();
		}

		// Token: 0x04017C20 RID: 97312
		[Nullable(2)]
		private KeySettingPanel PcKeySettingPanel;

		// Token: 0x04017C21 RID: 97313
		[Nullable(2)]
		private KeySettingPanel GamepadKeySettingPanel;

		// Token: 0x04017C22 RID: 97314
		private readonly List<List<List<List<KeySettingRowData>>>> KeySettingRowDataListMap = new List<List<List<List<KeySettingRowData>>>>();

		// Token: 0x04017C23 RID: 97315
		private readonly Dictionary<int, KeySettingRowData> KeySettingRowDataMap = new Dictionary<int, KeySettingRowData>();

		// Token: 0x04017C24 RID: 97316
		private readonly Dictionary<int, KeySettingRowData> HiddenKeySettingRowDataMap = new Dictionary<int, KeySettingRowData>();

		// Token: 0x04017C25 RID: 97317
		private EInputControllerType InputControllerType;

		// Token: 0x04017C26 RID: 97318
		[Nullable(2)]
		private KeySettingRowData WaitKeySettingRowData;

		// Token: 0x04017C27 RID: 97319
		[Nullable(2)]
		private KeySettingRowKeyItem WaitKeySettingRowKeyItem;

		// Token: 0x04017C28 RID: 97320
		[Nullable(2)]
		private TimerHandle EditKeyTimerHandle;

		// Token: 0x04017C29 RID: 97321
		private readonly Dictionary<EKeySettingDeviceType, IKeySettingDeviceInfo> KeySettingDeviceInfoMap = new Dictionary<EKeySettingDeviceType, IKeySettingDeviceInfo>();

		// Token: 0x04017C2A RID: 97322
		private EKeySettingDeviceType CurrentDeviceType;

		// Token: 0x04017C2B RID: 97323
		private readonly List<string> EditKeyNameList = new List<string>();

		// Token: 0x04017C2C RID: 97324
		[Nullable(2)]
		private XboxGamepadItem XboxGamepadItem;

		// Token: 0x04017C2D RID: 97325
		[Nullable(2)]
		private PsGamepadItem PsGamepadItem;

		// Token: 0x04017C2E RID: 97326
		[Nullable(2)]
		public GamepadItemBase GamepadItem;

		// Token: 0x04017C2F RID: 97327
		[Nullable(2)]
		private KeySettingRowData HoverKeySettingRowData;

		// Token: 0x04017C30 RID: 97328
		[Nullable(2)]
		private LevelSequencePlayer TipsSequencePlayer;

		// Token: 0x04017C31 RID: 97329
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TabComponent<KeySettingExclusiveTypeTabItem> ExclusiveTypeTabComponent;

		// Token: 0x04017C32 RID: 97330
		private EKeySettingExclusiveType CurrentExclusiveType;

		// Token: 0x04017C33 RID: 97331
		private int CurrentExclusiveTypeTabIndex;

		// Token: 0x04017C34 RID: 97332
		[Nullable(2)]
		private KeySettingPanelResetButton ResetButton;

		// Token: 0x04017C35 RID: 97333
		private readonly List<EKeySettingRowDataHiddenType> KeySettingRowDataHiddenTypeList = new List<EKeySettingRowDataHiddenType>
		{
			EKeySettingRowDataHiddenType.Normal,
			EKeySettingRowDataHiddenType.Hidden
		};

		// Token: 0x04017C36 RID: 97334
		private readonly List<EInputControllerType> KeySettingRowDataControllerTypeList = new List<EInputControllerType>
		{
			EInputControllerType.Keyboard,
			EInputControllerType.Gamepad
		};

		// Token: 0x04017C37 RID: 97335
		private readonly Dictionary<int, Dictionary<int, string>> ResetBtnTextMap = new Dictionary<int, Dictionary<int, string>>();

		// Token: 0x0200A11B RID: 41243
		[NullableContext(0)]
		public class EChildType
		{
			// Token: 0x040320CA RID: 205002
			public const int LeftButton = 0;

			// Token: 0x040320CB RID: 205003
			public const int RightButton = 1;

			// Token: 0x040320CC RID: 205004
			public const int DeviceNameText = 2;

			// Token: 0x040320CD RID: 205005
			public const int GamepadItem = 3;

			// Token: 0x040320CE RID: 205006
			public const int KeyboardItem = 4;

			// Token: 0x040320CF RID: 205007
			public const int GamepadKeySettingItem = 5;

			// Token: 0x040320D0 RID: 205008
			public const int PcKeySettingItem = 6;

			// Token: 0x040320D1 RID: 205009
			public const int TipsItem = 7;

			// Token: 0x040320D2 RID: 205010
			public const int TipsText = 8;

			// Token: 0x040320D3 RID: 205011
			public const int ResetButton = 9;

			// Token: 0x040320D4 RID: 205012
			public const int GamepadPanelItem = 10;

			// Token: 0x040320D5 RID: 205013
			public const int SwitcherItem = 11;

			// Token: 0x040320D6 RID: 205014
			public const int GamepadLogoItem = 12;

			// Token: 0x040320D7 RID: 205015
			public const int PsAndBackBoneButtonsItem = 13;

			// Token: 0x040320D8 RID: 205016
			public const int PsAndBackBoneResetButton = 14;

			// Token: 0x040320D9 RID: 205017
			public const int GamepadOperationButton = 15;

			// Token: 0x040320DA RID: 205018
			public const int PsAndBackBoneGamepadOperationButton = 16;

			// Token: 0x040320DB RID: 205019
			public const int ExclusiveTypeToggleGroup = 17;
		}
	}
}
