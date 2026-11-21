using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02003BCB RID: 15307
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillButtonUiMotorcycleGamepadData : SkillButtonUiGamepadDataBase
	{
		// Token: 0x06027475 RID: 160885 RVA: 0x00B02F10 File Offset: 0x00B01110
		public override void Init()
		{
			this.GamepadDataType = ESkillButtonGamepadDataType.Motorcycle;
			this.IsPressCombineButton = false;
			this.InitAllActionNameList();
			this.InitGamepadIcon();
			this.SwitchInteractData.Init(ESkillButtonGamepadDataType.Motorcycle, "载具探索工具");
			this.RefreshBaseConfigByUserSetting();
			this.RefreshSwitchInteractOpen(true);
			this.RefreshButtonData();
		}

		// Token: 0x06027476 RID: 160886 RVA: 0x00B02F5C File Offset: 0x00B0115C
		public override void Clear()
		{
			this.ControlCameraByMoveAxis = false;
			this.ClearInputAxis();
		}

		// Token: 0x06027477 RID: 160887 RVA: 0x00B02F6C File Offset: 0x00B0116C
		private void InitAllActionNameList()
		{
			foreach (string item in SkillButtonUiMotorcycleGamepadData.actionNameToButtonTypeMap.Keys)
			{
				this.AllActionNameList.Add(item);
			}
		}

		// Token: 0x06027478 RID: 160888 RVA: 0x00B02FC8 File Offset: 0x00B011C8
		public override IReadOnlyList<string> GetAllActionNameList()
		{
			return this.AllActionNameList;
		}

		// Token: 0x06027479 RID: 160889 RVA: 0x00B02FD0 File Offset: 0x00B011D0
		public override IReadOnlyList<string> GetAllAxisNameList()
		{
			return SkillButtonUiMotorcycleGamepadData.initAxisNames;
		}

		// Token: 0x0602747A RID: 160890 RVA: 0x00B02FD7 File Offset: 0x00B011D7
		private void InitGamepadIcon()
		{
			this.NoneIcon = UiResourceConfig.Instance.GetResourcePath("SP_IconXboxNoneIcon");
		}

		// Token: 0x0602747B RID: 160891 RVA: 0x00B02FF0 File Offset: 0x00B011F0
		public override void RefreshBaseConfigByUserSetting()
		{
			this.CombineButtonKey = EKey.Gamepad_LeftShoulder;
			this.ButtonKeyList.Clear();
			foreach (string item in SkillButtonUiMotorcycleGamepadData.mainKeys)
			{
				this.ButtonKeyList.Add(item);
			}
			foreach (string item2 in SkillButtonUiMotorcycleGamepadData.dPadKeys)
			{
				this.ButtonKeyList.Add(item2);
			}
			foreach (string text in SkillButtonUiMotorcycleGamepadData.subKeys)
			{
				if (!(text == this.CombineButtonKey))
				{
					this.ButtonKeyList.Add(text);
				}
			}
			this.ButtonKeyList.Add(EKey.Gamepad_RightThumbstick);
			this.ButtonKeyToActionNameMap.Clear();
			foreach (string text2 in SkillButtonUiMotorcycleGamepadData.initActionNames)
			{
				InputActionBinding actionBinding = InputSettingsManager.Instance.GetActionBinding(text2);
				if (actionBinding != null)
				{
					List<string> list = new List<string>();
					actionBinding.GetKeyNameList(list);
					if (list != null && list.Count != 0)
					{
						foreach (string text3 in list)
						{
							if (this.ButtonKeyList.Contains(text3))
							{
								this.ButtonKeyToActionNameMap[text3] = text2;
							}
						}
					}
				}
			}
			this.CombinationKeyToActionNameMap.Clear();
			foreach (string text4 in SkillButtonUiMotorcycleGamepadData.initActionNames)
			{
				InputCombinationActionBinding combinationActionBindingByActionName = InputSettingsManager.Instance.GetCombinationActionBindingByActionName(text4);
				if (combinationActionBindingByActionName != null)
				{
					Dictionary<string, string> dictionary = new Dictionary<string, string>();
					combinationActionBindingByActionName.GetKeyMap(dictionary);
					foreach (KeyValuePair<string, string> keyValuePair in dictionary)
					{
						string key = keyValuePair.Key;
						string value = keyValuePair.Value;
						if (!(key != this.CombineButtonKey) && this.ButtonKeyList.Contains(value))
						{
							this.CombinationKeyToActionNameMap[value] = text4;
						}
					}
				}
			}
			this.ButtonKeyToAxisKeyMap.Clear();
			foreach (string axisName in SkillButtonUiMotorcycleGamepadData.initAxisNames)
			{
				InputAxisBinding axisBinding = InputSettingsManager.Instance.GetAxisBinding(axisName);
				if (axisBinding != null)
				{
					for (int j = 0; j < 2; j++)
					{
						InputAxisKey gamepadKeyByIndex = axisBinding.GetGamepadKeyByIndex(j);
						if (gamepadKeyByIndex != null)
						{
							string valueOrDefault = SkillButtonUiMotorcycleGamepadData.axisToActionKey.GetValueOrDefault(gamepadKeyByIndex.KeyName, gamepadKeyByIndex.KeyName);
							if (!string.IsNullOrEmpty(valueOrDefault) && this.ButtonKeyList.Contains(valueOrDefault))
							{
								this.ButtonKeyToAxisKeyMap[valueOrDefault] = new SkillButtonAxisKey
								{
									AxisName = axisName,
									KeyName = valueOrDefault,
									Scale = gamepadKeyByIndex.Scale
								};
							}
						}
					}
				}
			}
			this.RefreshRouletteKey();
			this.RefreshMusicKey();
			this.RefreshSkillButtonTypeList();
			this.RefreshCombineButtonVisible();
		}

		// Token: 0x0602747C RID: 160892 RVA: 0x00B03338 File Offset: 0x00B01538
		private void RefreshRouletteKey()
		{
			this.RouletteKey = null;
			this.RouletteMainKey = null;
			this.RouletteSecondKey = null;
			string actionName = "幻象探索选择界面";
			InputActionBinding actionBinding = InputSettingsManager.Instance.GetActionBinding(actionName);
			IReadOnlyList<string> readOnlyList = (actionBinding != null) ? actionBinding.GetGamepadKeyNameListReadonly() : null;
			if (readOnlyList != null && readOnlyList.Count > 0 && readOnlyList[0] != EKey.Gamepad_Invalid)
			{
				this.RouletteKey = readOnlyList[0];
				return;
			}
			InputCombinationActionBinding combinationActionBindingByActionName = InputSettingsManager.Instance.GetCombinationActionBindingByActionName(actionName);
			if (combinationActionBindingByActionName != null && combinationActionBindingByActionName.HasGamepadCombinationAction())
			{
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				combinationActionBindingByActionName.GetGamepadKeyNameMap(dictionary);
				using (Dictionary<string, string>.Enumerator enumerator = dictionary.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						KeyValuePair<string, string> keyValuePair = enumerator.Current;
						this.RouletteMainKey = keyValuePair.Key;
						this.RouletteSecondKey = keyValuePair.Value;
					}
				}
			}
		}

		// Token: 0x0602747D RID: 160893 RVA: 0x00B03428 File Offset: 0x00B01628
		private void RefreshMusicKey()
		{
			this.MusicSubKeyList.Clear();
			foreach (string text in SkillButtonUiMotorcycleGamepadData.musicActionNames)
			{
				InputCombinationActionBinding combinationActionBindingByActionName = InputSettingsManager.Instance.GetCombinationActionBindingByActionName(text);
				if (combinationActionBindingByActionName != null)
				{
					Dictionary<string, string> dictionary = new Dictionary<string, string>();
					combinationActionBindingByActionName.GetKeyMap(dictionary);
					foreach (KeyValuePair<string, string> keyValuePair in dictionary)
					{
						string key = keyValuePair.Key;
						string value = keyValuePair.Value;
						if (!(key != this.CombineButtonKey))
						{
							this.MusicSubKeyList.Add(value);
							if (this.ButtonKeyList.Contains(value))
							{
								this.CombinationKeyToActionNameMap[value] = text;
							}
						}
					}
				}
			}
		}

		// Token: 0x0602747E RID: 160894 RVA: 0x00B0351C File Offset: 0x00B0171C
		private void RefreshSkillButtonTypeList()
		{
			Array.Resize<int>(ref this.MainSkillButtonTypeList, 4);
			Array.Resize<int>(ref this.MainSkillCombineButtonTypeList, 4);
			for (int i = 0; i < 4; i++)
			{
				this.MainSkillButtonTypeList[i] = (int)this.GetNormalSkillButtonTypeByIndex(i, false);
				this.MainSkillCombineButtonTypeList[i] = (int)this.GetNormalSkillButtonTypeByIndex(i, true);
			}
			Array.Resize<int>(ref this.DpadSkillButtonTypeList, 4);
			Array.Resize<int>(ref this.DpadSkillCombineButtonTypeList, 4);
			for (int j = 0; j < 4; j++)
			{
				this.DpadSkillButtonTypeList[j] = (int)this.GetNormalSkillButtonTypeByIndex(4 + j, false);
				this.DpadSkillCombineButtonTypeList[j] = (int)this.GetNormalSkillButtonTypeByIndex(4 + j, true);
			}
			Array.Resize<int>(ref this.SubSkillButtonTypeList, 3);
			Array.Resize<int>(ref this.SubSkillCombineButtonTypeList, 3);
			for (int k = 0; k < 3; k++)
			{
				this.SubSkillButtonTypeList[k] = (int)this.GetNormalSkillButtonTypeByIndex(8 + k, false);
				this.SubSkillCombineButtonTypeList[k] = (int)this.GetNormalSkillButtonTypeByIndex(8 + k, true);
			}
		}

		// Token: 0x0602747F RID: 160895 RVA: 0x00B03600 File Offset: 0x00B01800
		private void RefreshCombineButtonVisible()
		{
			int[] array = this.MainSkillCombineButtonTypeList;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != 0)
				{
					this.IsShowCombineButton = true;
					return;
				}
			}
			array = this.SubSkillCombineButtonTypeList;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != 0)
				{
					this.IsShowCombineButton = true;
					return;
				}
			}
			this.IsShowCombineButton = false;
		}

		// Token: 0x06027480 RID: 160896 RVA: 0x00B03658 File Offset: 0x00B01858
		private ESkillButtonType GetNormalSkillButtonTypeByIndex(int index, bool isPressCombineButton)
		{
			string text = null;
			string key = this.ButtonKeyList[index];
			if (isPressCombineButton)
			{
				this.CombinationKeyToActionNameMap.TryGetValue(key, out text);
			}
			else
			{
				this.ButtonKeyToActionNameMap.TryGetValue(key, out text);
			}
			if (!string.IsNullOrEmpty(text))
			{
				int result;
				if (SkillButtonUiMotorcycleGamepadData.actionNameToButtonTypeMap.TryGetValue(text, out result))
				{
					return (ESkillButtonType)result;
				}
				return ESkillButtonType.None;
			}
			else
			{
				SkillButtonAxisKey skillButtonAxisKey;
				int[] array;
				if (isPressCombineButton || !this.ButtonKeyToAxisKeyMap.TryGetValue(key, out skillButtonAxisKey) || skillButtonAxisKey == null || !SkillButtonUiMotorcycleGamepadData.axisNameToButtonTypeMap.TryGetValue(skillButtonAxisKey.AxisName, out array) || array == null)
				{
					return ESkillButtonType.None;
				}
				if (skillButtonAxisKey.Scale != 1f)
				{
					return (ESkillButtonType)array[1];
				}
				return (ESkillButtonType)array[0];
			}
		}

		// Token: 0x06027481 RID: 160897 RVA: 0x00B036F8 File Offset: 0x00B018F8
		public override void RefreshSwitchInteractOpen(bool isInit = false)
		{
			this.SwitchInteractData.RefreshSwitchInteractOpen(isInit);
		}

		// Token: 0x06027482 RID: 160898 RVA: 0x00B03708 File Offset: 0x00B01908
		public override bool RefreshButtonData()
		{
			this.RefreshStateByTag();
			List<int?> curButtonTypeList = this.CurButtonTypeList;
			this.CurButtonTypeList = this.LastButtonTypeList;
			this.LastButtonTypeList = curButtonTypeList;
			this.CurButtonTypeList.Clear();
			if (!this.IsPressCombineButton)
			{
				for (int i = 0; i < 4; i++)
				{
					this.CurButtonTypeList.Add(this.GetButtonTypeByIndex(this.MainSkillButtonTypeList, i, false));
				}
				for (int j = 0; j < 4; j++)
				{
					this.CurButtonTypeList.Add(this.GetButtonTypeByIndex(this.MainSkillCombineButtonTypeList, j, true));
				}
				for (int k = 0; k < 4; k++)
				{
					this.CurButtonTypeList.Add(this.GetButtonTypeByIndex(this.DpadSkillButtonTypeList, k, false));
				}
				for (int l = 0; l < 3; l++)
				{
					this.PushSubSkillButton(this.SubSkillButtonTypeList[l]);
				}
				this.CurButtonTypeList.Add(null);
			}
			else
			{
				for (int m = 0; m < 4; m++)
				{
					int? buttonTypeByIndex = this.GetButtonTypeByIndex(this.MainSkillCombineButtonTypeList, m, false);
					if (this.MainSkillCombineButtonTypeList[m] != 0)
					{
						this.CurButtonTypeList.Add(buttonTypeByIndex);
					}
					else
					{
						this.CurButtonTypeList.Add(this.GetButtonTypeByIndex(this.MainSkillButtonTypeList, m, false));
					}
				}
				for (int n = 0; n < 4; n++)
				{
					this.CurButtonTypeList.Add(this.GetButtonTypeByIndex(this.MainSkillCombineButtonTypeList, n, true));
				}
				for (int num = 0; num < 4; num++)
				{
					int? buttonTypeByIndex2 = this.GetButtonTypeByIndex(this.DpadSkillCombineButtonTypeList, num, false);
					if (this.DpadSkillCombineButtonTypeList[num] != 0)
					{
						this.CurButtonTypeList.Add(buttonTypeByIndex2);
					}
					else
					{
						this.CurButtonTypeList.Add(this.GetButtonTypeByIndex(this.DpadSkillButtonTypeList, num, false));
					}
				}
				for (int num2 = 0; num2 < 3; num2++)
				{
					this.PushSubSkillButton(this.SubSkillCombineButtonTypeList[num2]);
				}
			}
			if (this.ShootEnable)
			{
				int num3 = this.CurButtonTypeList.IndexOf(new int?(1));
				if (num3 != -1)
				{
					this.CurButtonTypeList[num3] = new int?(4);
				}
			}
			int count = this.CurButtonTypeList.Count;
			if (count != this.LastButtonTypeList.Count)
			{
				return true;
			}
			for (int num4 = 0; num4 < count; num4++)
			{
				int? num5 = this.CurButtonTypeList[num4];
				int? num6 = this.LastButtonTypeList[num4];
				if (!(num5.GetValueOrDefault() == num6.GetValueOrDefault() & num5 != null == (num6 != null)))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06027483 RID: 160899 RVA: 0x00B03990 File Offset: 0x00B01B90
		private int? GetButtonTypeByIndex(int[] buttonTypeList, int index, bool isSecondButton = false)
		{
			int num = buttonTypeList[index];
			if ((num == 101 || this.CheckSkillButtonVisibleByButtonType(num).GetValueOrDefault()) && this.CheckSkillButtonVisibleByState(num, isSecondButton))
			{
				return new int?(num);
			}
			return new int?(0);
		}

		// Token: 0x06027484 RID: 160900 RVA: 0x00B039CE File Offset: 0x00B01BCE
		private bool CheckSkillButtonVisibleByState(int buttonType, bool isSecondButton = false)
		{
			return (this.CurStateTagId == 0 || this.StateButtonTypeList == null || this.StateButtonTypeList.Contains(buttonType)) && (!isSecondButton || SkillButtonUiMotorcycleGamepadData.mainSecondButtonTypeSet.Contains(buttonType));
		}

		// Token: 0x06027485 RID: 160901 RVA: 0x00B03A04 File Offset: 0x00B01C04
		private bool? CheckSkillButtonVisibleByButtonType(int buttonType)
		{
			if (buttonType == 0)
			{
				return new bool?(false);
			}
			SkillButtonUiModel instance = SkillButtonUiModel.Instance;
			SkillButtonData skillButtonData = (instance != null) ? instance.GetSkillButtonDataByButton((ESkillButtonType)buttonType) : null;
			if (skillButtonData != null)
			{
				return new bool?(skillButtonData.IsVisible());
			}
			BehaviorButtonData behaviorButtonData = (instance != null) ? instance.GetBehaviorButtonDataByButton((EBehaviorType)buttonType) : null;
			if (behaviorButtonData == null)
			{
				return null;
			}
			return new bool?(behaviorButtonData.IsVisible());
		}

		// Token: 0x06027486 RID: 160902 RVA: 0x00B03A64 File Offset: 0x00B01C64
		private void PushSubSkillButton(int buttonType)
		{
			if (this.CurStateTagId != 0)
			{
				if (!this.CheckSkillButtonVisibleByState(buttonType, false))
				{
					this.CurButtonTypeList.Add(null);
					return;
				}
				this.CurButtonTypeList.Add(new int?(buttonType));
				return;
			}
			else
			{
				if (!SkillButtonUiMotorcycleGamepadData.subButtonTypeSet.Contains(buttonType))
				{
					this.CurButtonTypeList.Add(null);
					return;
				}
				this.CurButtonTypeList.Add(new int?(buttonType));
				return;
			}
		}

		// Token: 0x06027487 RID: 160903 RVA: 0x00B03AE0 File Offset: 0x00B01CE0
		private void RefreshStateByTag()
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity == null || !getCurrentEntity.Valid)
			{
				return;
			}
			BaseTagComponent baseTagComponent = getCurrentEntity.Entity.CheckGetComponent<BaseTagComponent>();
			this.ShootEnable = baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.功能开关.移动端浮游炮攻击按钮"]);
			this.CurStateTagId = 0;
			this.StateButtonTypeList = null;
			SkillButtonIndexData curSkillButtonIndexData = SkillButtonUiModel.Instance.CurSkillButtonIndexData;
			if (curSkillButtonIndexData == null)
			{
				return;
			}
			foreach (SkillButtonIndex skillButtonIndex in curSkillButtonIndexData.ButtonIndexConfigList)
			{
				foreach (DicIntIntArray dicIntIntArray in skillButtonIndex.GamepadButtonTypeMapIter())
				{
					int key = dicIntIntArray.Key;
					IntArray value = dicIntIntArray.Value.Value;
					if (baseTagComponent.HasTag(key))
					{
						this.CurStateTagId = key;
						this.StateButtonTypeList = new List<int>();
						for (int i = 0; i < value.ArrayIntLength; i++)
						{
							this.StateButtonTypeList.Add(value.ArrayInt(i));
						}
						return;
					}
				}
			}
		}

		// Token: 0x06027488 RID: 160904 RVA: 0x00B03C30 File Offset: 0x00B01E30
		public override int GetButtonTypeByActionName(string actionName)
		{
			int result;
			if (!SkillButtonUiMotorcycleGamepadData.actionNameToButtonTypeMap.TryGetValue(actionName, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x06027489 RID: 160905 RVA: 0x00B03C50 File Offset: 0x00B01E50
		public override int GetButtonTypeByAxisName(string axisName, float value)
		{
			int[] array;
			if (!SkillButtonUiMotorcycleGamepadData.axisNameToButtonTypeMap.TryGetValue(axisName, out array) || array == null)
			{
				return 0;
			}
			if (value <= 0f)
			{
				return array[1];
			}
			return array[0];
		}

		// Token: 0x0602748A RID: 160906 RVA: 0x00B03C80 File Offset: 0x00B01E80
		public override void SetIsPressCombineButton(bool value)
		{
			if (this.IsPressCombineButton == value)
			{
				return;
			}
			this.IsPressCombineButton = value;
			this.RefreshButtonData();
		}

		// Token: 0x0602748B RID: 160907 RVA: 0x00B03C9A File Offset: 0x00B01E9A
		public override bool GetIsPressCombineButton()
		{
			return this.IsPressCombineButton;
		}

		// Token: 0x0602748C RID: 160908 RVA: 0x00B03CA2 File Offset: 0x00B01EA2
		[NullableContext(2)]
		public BehaviorButtonData GetBehaviorButtonDataByButtonType(EBehaviorType buttonType)
		{
			return SkillButtonUiModel.Instance.GetBehaviorButtonDataByButton(buttonType);
		}

		// Token: 0x0602748D RID: 160909 RVA: 0x00B03CAF File Offset: 0x00B01EAF
		public override void RefreshSkillButtonData(ESkillButtonRefreshReason refreshReason)
		{
			if (refreshReason == ESkillButtonRefreshReason.ChangeRole)
			{
				this.RefreshButtonData();
				this.RefreshInteractBehaviorData();
			}
		}

		// Token: 0x0602748E RID: 160910 RVA: 0x00B03CC4 File Offset: 0x00B01EC4
		public override void RefreshInteractBehaviorData()
		{
			BehaviorButtonData behaviorButtonDataByButtonType = this.GetBehaviorButtonDataByButtonType(EBehaviorType.Interact);
			if (behaviorButtonDataByButtonType == null)
			{
				return;
			}
			bool flag = UiManager.Instance.IsViewOpen(EUiViewName.InteractionHintView);
			behaviorButtonDataByButtonType.SetEnable(flag);
			this.SwitchInteractData.SetInteractExist(flag, EGamepadInteractExistReason.InteractView);
		}

		// Token: 0x0602748F RID: 160911 RVA: 0x00B03D04 File Offset: 0x00B01F04
		public override void OnActionKeyChanged(string actionName)
		{
			if (actionName == "幻象探索选择界面")
			{
				this.RefreshRouletteKey();
				EventSystem.Instance.Emit(EEventName.BattleUiRouletteKeyChanged);
				return;
			}
			if (this.AllowChangeKeyReasonSet.Count > 0)
			{
				return;
			}
			if (this.ChangeKeyReasonSet.Count > 0)
			{
				if (this.ChangeKeyActionInMenuView)
				{
					return;
				}
				bool flag = false;
				for (int i = 0; i < SkillButtonUiMotorcycleGamepadData.initActionNames.Count; i++)
				{
					if (SkillButtonUiMotorcycleGamepadData.initActionNames[i] == actionName)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					this.ChangeKeyActionInMenuView = true;
				}
				return;
			}
			else
			{
				if (this.LockRefresh)
				{
					return;
				}
				bool flag2 = false;
				for (int j = 0; j < SkillButtonUiMotorcycleGamepadData.initActionNames.Count; j++)
				{
					if (SkillButtonUiMotorcycleGamepadData.initActionNames[j] == actionName)
					{
						flag2 = true;
						break;
					}
				}
				if (flag2)
				{
					Log.Instance.Error(ELogModule.Battle, ELogAuthor.CFT, "在未知情况下触发了改键", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				return;
			}
		}

		// Token: 0x06027490 RID: 160912 RVA: 0x00B03DEB File Offset: 0x00B01FEB
		public override void AddChangeKeyReason(EGamepadChangeKeyReason reason)
		{
			this.ChangeKeyReasonSet.Add(reason);
		}

		// Token: 0x06027491 RID: 160913 RVA: 0x00B03DFC File Offset: 0x00B01FFC
		public override void RemoveChangeKeyReason(EGamepadChangeKeyReason reason)
		{
			this.ChangeKeyReasonSet.Remove(reason);
			if (this.ChangeKeyReasonSet.Count != 0)
			{
				return;
			}
			if (this.ChangeKeyActionInMenuView)
			{
				this.ChangeKeyActionInMenuView = false;
				this.RefreshBaseConfigByUserSetting();
			}
			this.RefreshButtonData();
			if (Info.Instance.IsInGamepad())
			{
				SkillButtonUiModel instance = SkillButtonUiModel.Instance;
				if (instance == null)
				{
					return;
				}
				SkillButtonEntityData curSkillButtonEntityData = instance.GetCurSkillButtonEntityData();
				if (curSkillButtonEntityData == null)
				{
					return;
				}
				curSkillButtonEntityData.RefreshSkillButtonData(ESkillButtonRefreshReason.GamepadRefreshKeyAction);
			}
		}

		// Token: 0x06027492 RID: 160914 RVA: 0x00B03E66 File Offset: 0x00B02066
		public override void AddAllowChangeKeyReason(string reason)
		{
			this.AllowChangeKeyReasonSet.Add(reason);
		}

		// Token: 0x06027493 RID: 160915 RVA: 0x00B03E75 File Offset: 0x00B02075
		public override void RemoveAllowChangeKeyReason(string reason)
		{
			this.AllowChangeKeyReasonSet.Remove(reason);
		}

		// Token: 0x06027494 RID: 160916 RVA: 0x00B03E84 File Offset: 0x00B02084
		public override void CacheInputAxis(in EInputAxis axis, float value)
		{
			this.InputAxisMap[axis] = value;
		}

		// Token: 0x06027495 RID: 160917 RVA: 0x00B03E98 File Offset: 0x00B02098
		public override float GetInputAxis(in EInputAxis axis)
		{
			return this.InputAxisMap.GetValueOrDefault(axis, 0f);
		}

		// Token: 0x06027496 RID: 160918 RVA: 0x00B03EB0 File Offset: 0x00B020B0
		public override void ClearInputAxis()
		{
			this.InputAxisMap.Clear();
		}

		// Token: 0x06027498 RID: 160920 RVA: 0x00B03F2C File Offset: 0x00B0212C
		// Note: this type is marked as 'beforefieldinit'.
		static SkillButtonUiMotorcycleGamepadData()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			string key = EKey.Gamepad_LeftTriggerAxis;
			dictionary[key] = EKey.Gamepad_LeftTrigger;
			string key2 = EKey.Gamepad_RightTriggerAxis;
			dictionary[key2] = EKey.Gamepad_RightTrigger;
			SkillButtonUiMotorcycleGamepadData.axisToActionKey = dictionary;
			Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
			dictionary2["载具漂移"] = 1;
			dictionary2["载具氮气"] = 5;
			dictionary2["载具子弹跳"] = 6;
			dictionary2["载具辅助机攻击"] = 4;
			dictionary2["载具探索工具"] = 7;
			dictionary2["载具退场技和下车"] = 8;
			dictionary2["通用交互"] = 104;
			dictionary2["载具视角切换"] = 101;
			SkillButtonUiMotorcycleGamepadData.actionNameToButtonTypeMap = dictionary2;
			Dictionary<string, int[]> dictionary3 = new Dictionary<string, int[]>();
			dictionary3["MotorMoveForward"] = new int[]
			{
				201,
				202
			};
			SkillButtonUiMotorcycleGamepadData.axisNameToButtonTypeMap = dictionary3;
			SkillButtonUiMotorcycleGamepadData.initActionNames = new <>z__ReadOnlyArray<string>(new string[]
			{
				"载具漂移",
				"载具氮气",
				"载具子弹跳",
				"载具探索工具",
				"载具退场技和下车",
				"通用交互",
				"载具视角切换"
			});
			SkillButtonUiMotorcycleGamepadData.initAxisNames = new string[]
			{
				"MotorMoveForward"
			};
			SkillButtonUiMotorcycleGamepadData.mainSecondButtonTypeSet = new HashSet<int>
			{
				1,
				5,
				6,
				8,
				7,
				104,
				101,
				201,
				202
			};
			SkillButtonUiMotorcycleGamepadData.subButtonTypeSet = new HashSet<int>
			{
				1,
				5,
				6,
				8,
				7,
				104,
				101,
				201,
				202
			};
			SkillButtonUiMotorcycleGamepadData.musicActionNames = new <>z__ReadOnlyArray<string>(new string[]
			{
				"载具音乐上一首",
				"载具音乐下一首",
				"载具音乐播放暂停"
			});
		}

		// Token: 0x040156D2 RID: 87762
		[StaticVariableRuleIgnore]
		private static readonly string[] mainKeys = new string[]
		{
			EKey.Gamepad_FaceButton_Top,
			EKey.Gamepad_FaceButton_Left,
			EKey.Gamepad_FaceButton_Bottom,
			EKey.Gamepad_FaceButton_Right
		};

		// Token: 0x040156D3 RID: 87763
		private const int MAIN_HALF_NUM = 4;

		// Token: 0x040156D4 RID: 87764
		[StaticVariableRuleIgnore]
		private static readonly string[] dPadKeys = new string[]
		{
			EKey.Gamepad_DPad_Up,
			EKey.Gamepad_DPad_Left,
			EKey.Gamepad_DPad_Down,
			EKey.Gamepad_DPad_Right
		};

		// Token: 0x040156D5 RID: 87765
		private const int DPAD_KEY_NUM = 4;

		// Token: 0x040156D6 RID: 87766
		[StaticVariableRuleIgnore]
		private static readonly string[] subKeys = new string[]
		{
			EKey.Gamepad_LeftTrigger,
			EKey.Gamepad_RightTrigger,
			EKey.Gamepad_LeftShoulder,
			EKey.Gamepad_RightShoulder
		};

		// Token: 0x040156D7 RID: 87767
		private const int SUB_KEY_NUM = 3;

		// Token: 0x040156D8 RID: 87768
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<string, string> axisToActionKey;

		// Token: 0x040156D9 RID: 87769
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<string, int> actionNameToButtonTypeMap;

		// Token: 0x040156DA RID: 87770
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<string, int[]> axisNameToButtonTypeMap;

		// Token: 0x040156DB RID: 87771
		private static readonly IReadOnlyList<string> initActionNames;

		// Token: 0x040156DC RID: 87772
		[StaticVariableRuleIgnore]
		private static readonly string[] initAxisNames;

		// Token: 0x040156DD RID: 87773
		[StaticVariableRuleIgnore]
		private static readonly HashSet<int> mainSecondButtonTypeSet;

		// Token: 0x040156DE RID: 87774
		[StaticVariableRuleIgnore]
		private static readonly HashSet<int> subButtonTypeSet;

		// Token: 0x040156DF RID: 87775
		private static readonly IReadOnlyList<string> musicActionNames;

		// Token: 0x040156E0 RID: 87776
		private readonly List<string> AllActionNameList = new List<string>();

		// Token: 0x040156E1 RID: 87777
		public readonly HashSet<string> AllowChangeKeyReasonSet = new HashSet<string>();

		// Token: 0x040156E2 RID: 87778
		private readonly HashSet<EGamepadChangeKeyReason> ChangeKeyReasonSet = new HashSet<EGamepadChangeKeyReason>();

		// Token: 0x040156E3 RID: 87779
		private readonly Dictionary<string, string> ButtonKeyToActionNameMap = new Dictionary<string, string>();

		// Token: 0x040156E4 RID: 87780
		private readonly Dictionary<string, string> CombinationKeyToActionNameMap = new Dictionary<string, string>();

		// Token: 0x040156E5 RID: 87781
		private readonly Dictionary<string, SkillButtonAxisKey> ButtonKeyToAxisKeyMap = new Dictionary<string, SkillButtonAxisKey>();

		// Token: 0x040156E6 RID: 87782
		private bool IsPressCombineButton;

		// Token: 0x040156E7 RID: 87783
		public bool IsShowCombineButton;

		// Token: 0x040156E8 RID: 87784
		private bool ChangeKeyActionInMenuView;

		// Token: 0x040156E9 RID: 87785
		private readonly bool LockRefresh;

		// Token: 0x040156EA RID: 87786
		public bool ShootEnable;

		// Token: 0x040156EB RID: 87787
		public int CurStateTagId;

		// Token: 0x040156EC RID: 87788
		[Nullable(2)]
		public List<int> StateButtonTypeList;

		// Token: 0x040156ED RID: 87789
		private readonly Dictionary<EInputAxis, float> InputAxisMap = new Dictionary<EInputAxis, float>();

		// Token: 0x040156EE RID: 87790
		public List<string> MusicSubKeyList = new List<string>();
	}
}
