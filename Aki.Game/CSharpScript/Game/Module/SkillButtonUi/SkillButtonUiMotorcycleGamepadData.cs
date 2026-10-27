using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02004C1A RID: 19482
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillButtonUiMotorcycleGamepadData : SkillButtonUiGamepadDataBase
	{
		// Token: 0x060326C2 RID: 206530 RVA: 0x00BBE2CC File Offset: 0x00BBC4CC
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

		// Token: 0x060326C3 RID: 206531 RVA: 0x00BBE318 File Offset: 0x00BBC518
		public override void Clear()
		{
			this.ControlCameraByMoveAxis = false;
			this.ClearInputAxis();
		}

		// Token: 0x060326C4 RID: 206532 RVA: 0x00BBE328 File Offset: 0x00BBC528
		private void InitAllActionNameList()
		{
			foreach (string item in SkillButtonUiMotorcycleGamepadData.actionNameToButtonTypeMap.Keys)
			{
				this.AllActionNameList.Add(item);
			}
		}

		// Token: 0x060326C5 RID: 206533 RVA: 0x00BBE384 File Offset: 0x00BBC584
		public override IReadOnlyList<string> GetAllActionNameList()
		{
			return this.AllActionNameList;
		}

		// Token: 0x060326C6 RID: 206534 RVA: 0x00BBE38C File Offset: 0x00BBC58C
		public override IReadOnlyList<string> GetAllAxisNameList()
		{
			return SkillButtonUiMotorcycleGamepadData.initAxisNames;
		}

		// Token: 0x060326C7 RID: 206535 RVA: 0x00BBE393 File Offset: 0x00BBC593
		private void InitGamepadIcon()
		{
			this.NoneIcon = UiResourceConfig.Instance.GetResourcePath("SP_IconXboxNoneIcon");
		}

		// Token: 0x060326C8 RID: 206536 RVA: 0x00BBE3AC File Offset: 0x00BBC5AC
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

		// Token: 0x060326C9 RID: 206537 RVA: 0x00BBE6F4 File Offset: 0x00BBC8F4
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

		// Token: 0x060326CA RID: 206538 RVA: 0x00BBE7E4 File Offset: 0x00BBC9E4
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

		// Token: 0x060326CB RID: 206539 RVA: 0x00BBE8D8 File Offset: 0x00BBCAD8
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

		// Token: 0x060326CC RID: 206540 RVA: 0x00BBE9BC File Offset: 0x00BBCBBC
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

		// Token: 0x060326CD RID: 206541 RVA: 0x00BBEA14 File Offset: 0x00BBCC14
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

		// Token: 0x060326CE RID: 206542 RVA: 0x00BBEAB4 File Offset: 0x00BBCCB4
		public override void RefreshSwitchInteractOpen(bool isInit = false)
		{
			this.SwitchInteractData.RefreshSwitchInteractOpen(isInit);
		}

		// Token: 0x060326CF RID: 206543 RVA: 0x00BBEAC4 File Offset: 0x00BBCCC4
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

		// Token: 0x060326D0 RID: 206544 RVA: 0x00BBED4C File Offset: 0x00BBCF4C
		private int? GetButtonTypeByIndex(int[] buttonTypeList, int index, bool isSecondButton = false)
		{
			int num = buttonTypeList[index];
			if ((num == 101 || this.CheckSkillButtonVisibleByButtonType(num).GetValueOrDefault()) && this.CheckSkillButtonVisibleByState(num, isSecondButton))
			{
				return new int?(num);
			}
			return new int?(0);
		}

		// Token: 0x060326D1 RID: 206545 RVA: 0x00BBED8A File Offset: 0x00BBCF8A
		private bool CheckSkillButtonVisibleByState(int buttonType, bool isSecondButton = false)
		{
			return (this.CurStateTagId == 0 || this.StateButtonTypeList == null || this.StateButtonTypeList.Contains(buttonType)) && (!isSecondButton || SkillButtonUiMotorcycleGamepadData.mainSecondButtonTypeSet.Contains(buttonType));
		}

		// Token: 0x060326D2 RID: 206546 RVA: 0x00BBEDC0 File Offset: 0x00BBCFC0
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

		// Token: 0x060326D3 RID: 206547 RVA: 0x00BBEE20 File Offset: 0x00BBD020
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

		// Token: 0x060326D4 RID: 206548 RVA: 0x00BBEE9C File Offset: 0x00BBD09C
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

		// Token: 0x060326D5 RID: 206549 RVA: 0x00BBEFEC File Offset: 0x00BBD1EC
		public override int GetButtonTypeByActionName(string actionName)
		{
			int result;
			if (!SkillButtonUiMotorcycleGamepadData.actionNameToButtonTypeMap.TryGetValue(actionName, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x060326D6 RID: 206550 RVA: 0x00BBF00C File Offset: 0x00BBD20C
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

		// Token: 0x060326D7 RID: 206551 RVA: 0x00BBF03C File Offset: 0x00BBD23C
		public override void SetIsPressCombineButton(bool value)
		{
			if (this.IsPressCombineButton == value)
			{
				return;
			}
			this.IsPressCombineButton = value;
			this.RefreshButtonData();
		}

		// Token: 0x060326D8 RID: 206552 RVA: 0x00BBF056 File Offset: 0x00BBD256
		public override bool GetIsPressCombineButton()
		{
			return this.IsPressCombineButton;
		}

		// Token: 0x060326D9 RID: 206553 RVA: 0x00BBF05E File Offset: 0x00BBD25E
		[NullableContext(2)]
		public BehaviorButtonData GetBehaviorButtonDataByButtonType(EBehaviorType buttonType)
		{
			return SkillButtonUiModel.Instance.GetBehaviorButtonDataByButton(buttonType);
		}

		// Token: 0x060326DA RID: 206554 RVA: 0x00BBF06B File Offset: 0x00BBD26B
		public override void RefreshSkillButtonData(ESkillButtonRefreshReason refreshReason)
		{
			if (refreshReason == ESkillButtonRefreshReason.ChangeRole)
			{
				this.RefreshButtonData();
				this.RefreshInteractBehaviorData();
			}
		}

		// Token: 0x060326DB RID: 206555 RVA: 0x00BBF080 File Offset: 0x00BBD280
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

		// Token: 0x060326DC RID: 206556 RVA: 0x00BBF0C0 File Offset: 0x00BBD2C0
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
				if (SkillButtonUiMotorcycleGamepadData.initActionNames.Contains(actionName))
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
				if (SkillButtonUiMotorcycleGamepadData.initActionNames.Contains(actionName))
				{
					Log.Instance.Error(ELogModule.Battle, ELogAuthor.CFT, "在未知情况下触发了改键", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				return;
			}
		}

		// Token: 0x060326DD RID: 206557 RVA: 0x00BBF15E File Offset: 0x00BBD35E
		public override void AddChangeKeyReason(EGamepadChangeKeyReason reason)
		{
			this.ChangeKeyReasonSet.Add(reason);
		}

		// Token: 0x060326DE RID: 206558 RVA: 0x00BBF170 File Offset: 0x00BBD370
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

		// Token: 0x060326DF RID: 206559 RVA: 0x00BBF1DA File Offset: 0x00BBD3DA
		public override void AddAllowChangeKeyReason(string reason)
		{
			this.AllowChangeKeyReasonSet.Add(reason);
		}

		// Token: 0x060326E0 RID: 206560 RVA: 0x00BBF1E9 File Offset: 0x00BBD3E9
		public override void RemoveAllowChangeKeyReason(string reason)
		{
			this.AllowChangeKeyReasonSet.Remove(reason);
		}

		// Token: 0x060326E1 RID: 206561 RVA: 0x00BBF1F8 File Offset: 0x00BBD3F8
		public override void CacheInputAxis(in EInputAxis axis, float value)
		{
			this.InputAxisMap[axis] = value;
		}

		// Token: 0x060326E2 RID: 206562 RVA: 0x00BBF20C File Offset: 0x00BBD40C
		public override float GetInputAxis(in EInputAxis axis)
		{
			return this.InputAxisMap.GetValueOrDefault(axis, 0f);
		}

		// Token: 0x060326E3 RID: 206563 RVA: 0x00BBF224 File Offset: 0x00BBD424
		public override void ClearInputAxis()
		{
			this.InputAxisMap.Clear();
		}

		// Token: 0x060326E5 RID: 206565 RVA: 0x00BBF2A0 File Offset: 0x00BBD4A0
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

		// Token: 0x0401AD75 RID: 109941
		[StaticVariableRuleIgnore]
		private static readonly string[] mainKeys = new string[]
		{
			EKey.Gamepad_FaceButton_Top,
			EKey.Gamepad_FaceButton_Left,
			EKey.Gamepad_FaceButton_Bottom,
			EKey.Gamepad_FaceButton_Right
		};

		// Token: 0x0401AD76 RID: 109942
		private const int MAIN_HALF_NUM = 4;

		// Token: 0x0401AD77 RID: 109943
		[StaticVariableRuleIgnore]
		private static readonly string[] dPadKeys = new string[]
		{
			EKey.Gamepad_DPad_Up,
			EKey.Gamepad_DPad_Left,
			EKey.Gamepad_DPad_Down,
			EKey.Gamepad_DPad_Right
		};

		// Token: 0x0401AD78 RID: 109944
		private const int DPAD_KEY_NUM = 4;

		// Token: 0x0401AD79 RID: 109945
		[StaticVariableRuleIgnore]
		private static readonly string[] subKeys = new string[]
		{
			EKey.Gamepad_LeftTrigger,
			EKey.Gamepad_RightTrigger,
			EKey.Gamepad_LeftShoulder,
			EKey.Gamepad_RightShoulder
		};

		// Token: 0x0401AD7A RID: 109946
		private const int SUB_KEY_NUM = 3;

		// Token: 0x0401AD7B RID: 109947
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<string, string> axisToActionKey;

		// Token: 0x0401AD7C RID: 109948
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<string, int> actionNameToButtonTypeMap;

		// Token: 0x0401AD7D RID: 109949
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<string, int[]> axisNameToButtonTypeMap;

		// Token: 0x0401AD7E RID: 109950
		private static readonly IReadOnlyList<string> initActionNames;

		// Token: 0x0401AD7F RID: 109951
		[StaticVariableRuleIgnore]
		private static readonly string[] initAxisNames;

		// Token: 0x0401AD80 RID: 109952
		[StaticVariableRuleIgnore]
		private static readonly HashSet<int> mainSecondButtonTypeSet;

		// Token: 0x0401AD81 RID: 109953
		[StaticVariableRuleIgnore]
		private static readonly HashSet<int> subButtonTypeSet;

		// Token: 0x0401AD82 RID: 109954
		private static readonly IReadOnlyList<string> musicActionNames;

		// Token: 0x0401AD83 RID: 109955
		private readonly List<string> AllActionNameList = new List<string>();

		// Token: 0x0401AD84 RID: 109956
		public readonly HashSet<string> AllowChangeKeyReasonSet = new HashSet<string>();

		// Token: 0x0401AD85 RID: 109957
		private readonly HashSet<EGamepadChangeKeyReason> ChangeKeyReasonSet = new HashSet<EGamepadChangeKeyReason>();

		// Token: 0x0401AD86 RID: 109958
		private readonly Dictionary<string, string> ButtonKeyToActionNameMap = new Dictionary<string, string>();

		// Token: 0x0401AD87 RID: 109959
		private readonly Dictionary<string, string> CombinationKeyToActionNameMap = new Dictionary<string, string>();

		// Token: 0x0401AD88 RID: 109960
		private readonly Dictionary<string, SkillButtonAxisKey> ButtonKeyToAxisKeyMap = new Dictionary<string, SkillButtonAxisKey>();

		// Token: 0x0401AD89 RID: 109961
		private bool IsPressCombineButton;

		// Token: 0x0401AD8A RID: 109962
		public bool IsShowCombineButton;

		// Token: 0x0401AD8B RID: 109963
		private bool ChangeKeyActionInMenuView;

		// Token: 0x0401AD8C RID: 109964
		private readonly bool LockRefresh;

		// Token: 0x0401AD8D RID: 109965
		public bool ShootEnable;

		// Token: 0x0401AD8E RID: 109966
		public int CurStateTagId;

		// Token: 0x0401AD8F RID: 109967
		[Nullable(2)]
		public List<int> StateButtonTypeList;

		// Token: 0x0401AD90 RID: 109968
		private readonly Dictionary<EInputAxis, float> InputAxisMap = new Dictionary<EInputAxis, float>();

		// Token: 0x0401AD91 RID: 109969
		public List<string> MusicSubKeyList = new List<string>();
	}
}
