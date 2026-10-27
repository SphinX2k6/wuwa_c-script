using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02004C17 RID: 19479
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillButtonUiGamepadData : SkillButtonUiGamepadDataBase
	{
		// Token: 0x0603264A RID: 206410 RVA: 0x00BBB684 File Offset: 0x00BB9884
		public override void Init()
		{
			this.GamepadDataType = ESkillButtonGamepadDataType.Normal;
			this.IsPressCombineButton = false;
			this.InitAllActionNameList();
			this.InitGamepadIcon();
			this.SwitchInteractData.Init(ESkillButtonGamepadDataType.Normal, "幻象1");
			this.RefreshBaseConfigByUserSetting();
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity != null && getCurrentEntity.Valid)
			{
				this.RefreshIsPhantomRole();
				this.RefreshFollowerAiming();
				this.ChangeSkillOnAimStateChange();
			}
			this.RefreshSwitchInteractOpen(true);
			this.RefreshButtonData();
		}

		// Token: 0x0603264B RID: 206411 RVA: 0x00BBB6FC File Offset: 0x00BB98FC
		public override void Clear()
		{
			this.ControlCameraByMoveAxis = false;
			this.ClearInputAxis();
		}

		// Token: 0x0603264C RID: 206412 RVA: 0x00BBB70C File Offset: 0x00BB990C
		private void InitAllActionNameList()
		{
			this.AllActionNameList.Clear();
			foreach (string item in SkillButtonUiGamepadData.actionNameToButtonTypeMap.Keys)
			{
				this.AllActionNameList.Add(item);
			}
			this.AllActionNameList.Add("手柄主攻击");
			this.AllActionNameList.Add("手柄副攻击");
		}

		// Token: 0x0603264D RID: 206413 RVA: 0x00BBB794 File Offset: 0x00BB9994
		public override IReadOnlyList<string> GetAllActionNameList()
		{
			return this.AllActionNameList;
		}

		// Token: 0x0603264E RID: 206414 RVA: 0x00BBB79C File Offset: 0x00BB999C
		private void InitGamepadIcon()
		{
			this.NoneIcon = UiResourceConfig.Instance.GetResourcePath("SP_IconXboxNoneIcon");
		}

		// Token: 0x0603264F RID: 206415 RVA: 0x00BBB7B4 File Offset: 0x00BB99B4
		public unsafe override void RefreshBaseConfigByUserSetting()
		{
			this.CombineButtonKey = EKey.Gamepad_LeftShoulder;
			this.ButtonKeyList.Clear();
			foreach (string item in SkillButtonUiGamepadData.mainKeys)
			{
				this.ButtonKeyList.Add(item);
			}
			foreach (string item2 in SkillButtonUiGamepadData.dPadKeys)
			{
				this.ButtonKeyList.Add(item2);
			}
			foreach (string text in SkillButtonUiGamepadData.subKeys)
			{
				if (!(text == this.CombineButtonKey))
				{
					if (text == EKey.Gamepad_RightTrigger)
					{
						this.KeyRightTriggerIndex = this.ButtonKeyList.Count - 4 - 4;
					}
					this.ButtonKeyList.Add(text);
				}
			}
			this.ButtonKeyList.Add(EKey.Gamepad_RightThumbstick);
			this.ChangeSkillActionName = null;
			this.ChangeSkillAimKeys = null;
			this.AttackActionNormalKeys = null;
			this.AttackActionAimKeys = null;
			this.ButtonKeyToActionNameMap.Clear();
			foreach (string text2 in SkillButtonUiGamepadData.initActionNames)
			{
				InputActionBinding actionBinding = InputSettingsManager.Instance.GetActionBinding(text2);
				if (actionBinding != null)
				{
					List<string> list = new List<string>();
					actionBinding.GetKeyNameList(list);
					if (list.Count != 0)
					{
						foreach (string text3 in list)
						{
							if (this.ButtonKeyList.Contains(text3))
							{
								this.ButtonKeyToActionNameMap[text3] = text2;
								if (text3 == EKey.Gamepad_RightTrigger)
								{
									this.ChangeSkillActionName = text2;
									this.ChangeSkillAimKeys = list;
									List<string> list2 = new List<string>(this.ChangeSkillAimKeys);
									list2.RemoveAt(list2.IndexOf(text3));
									list2.Add(EKey.Gamepad_RightThumbstick);
									this.ChangeSkillAimKeys = list2;
								}
							}
						}
						if (text2 == "攻击")
						{
							this.AttackActionNormalKeys = list;
							this.AttackActionAimKeys = this.AttackActionNormalKeys;
							List<string> attackActionAimKeys = this.AttackActionAimKeys;
							int num = 1 + attackActionAimKeys.Count;
							List<string> list3 = new List<string>(num);
							CollectionsMarshal.SetCount<string>(list3, num);
							Span<string> span = CollectionsMarshal.AsSpan<string>(list3);
							int num2 = 0;
							Span<string> span2 = CollectionsMarshal.AsSpan<string>(attackActionAimKeys);
							span2.CopyTo(span.Slice(num2, span2.Length));
							num2 += span2.Length;
							*span[num2] = EKey.Gamepad_RightTrigger;
							List<string> attackActionAimKeys2 = list3;
							this.AttackActionAimKeys = attackActionAimKeys2;
						}
					}
				}
			}
			if (this.ChangeSkillActionName == "攻击")
			{
				InputActionBinding actionBinding2 = InputSettingsManager.Instance.GetActionBinding("攀爬");
				List<string> list4 = new List<string>();
				if (actionBinding2 != null)
				{
					actionBinding2.GetKeyNameList(list4);
				}
				this.ClimbActionNormalKeys = list4;
			}
			else
			{
				this.ClimbActionNormalKeys = null;
			}
			this.CombinationKeyToActionNameMap.Clear();
			foreach (string text4 in SkillButtonUiGamepadData.initActionNames)
			{
				InputCombinationActionBinding combinationActionBindingByActionName = InputSettingsManager.Instance.GetCombinationActionBindingByActionName(text4);
				if (combinationActionBindingByActionName != null)
				{
					IReadOnlyDictionary<string, string> keyMap = combinationActionBindingByActionName.GetKeyMap();
					if (keyMap != null)
					{
						foreach (KeyValuePair<string, string> keyValuePair in keyMap)
						{
							string text5;
							string text6;
							keyValuePair.Deconstruct(out text5, out text6);
							string a = text5;
							string text7 = text6;
							if (!(a != this.CombineButtonKey) && this.ButtonKeyList.Contains(text7))
							{
								this.CombinationKeyToActionNameMap[text7] = text4;
							}
						}
					}
				}
			}
			this.RefreshGamepadMainAttackKey();
			this.RefreshRouletteKey();
			this.RefreshSkillButtonTypeList();
			this.RefreshCombineButtonVisible();
		}

		// Token: 0x06032650 RID: 206416 RVA: 0x00BBBB80 File Offset: 0x00BB9D80
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
						string text;
						string text2;
						keyValuePair.Deconstruct(out text, out text2);
						string rouletteMainKey = text;
						string rouletteSecondKey = text2;
						this.RouletteMainKey = rouletteMainKey;
						this.RouletteSecondKey = rouletteSecondKey;
					}
				}
			}
		}

		// Token: 0x06032651 RID: 206417 RVA: 0x00BBBC78 File Offset: 0x00BB9E78
		private void RefreshGamepadMainAttackKey()
		{
			InputActionBinding actionBinding = InputSettingsManager.Instance.GetActionBinding("手柄主攻击");
			InputActionBinding actionBinding2 = InputSettingsManager.Instance.GetActionBinding("攻击");
			IReadOnlyList<string> keyNameListA = (actionBinding != null) ? actionBinding.GetGamepadKeyNameList() : null;
			IReadOnlyList<string> readOnlyList = (actionBinding2 != null) ? actionBinding2.GetGamepadKeyNameList() : null;
			if (!this.CheckKeyNameListEqual(keyNameListA, readOnlyList))
			{
				List<string> list = new List<string>();
				if (readOnlyList != null)
				{
					list.AddRange(readOnlyList);
				}
				InputSettingsManager.Instance.SetActionKeys("手柄主攻击", list);
			}
			InputCombinationActionBinding combinationActionBindingByActionName = InputSettingsManager.Instance.GetCombinationActionBindingByActionName("手柄主攻击");
			InputCombinationActionBinding combinationActionBindingByActionName2 = InputSettingsManager.Instance.GetCombinationActionBindingByActionName("攻击");
			IReadOnlyDictionary<string, string> readOnlyDictionary = (combinationActionBindingByActionName != null) ? combinationActionBindingByActionName.GetGamepadKeyNameMap() : null;
			IReadOnlyDictionary<string, string> readOnlyDictionary2 = (combinationActionBindingByActionName2 != null) ? combinationActionBindingByActionName2.GetGamepadKeyNameMap() : null;
			if (!this.CheckKeyNameMapEqual(readOnlyDictionary, readOnlyDictionary2))
			{
				if (readOnlyDictionary != null)
				{
					foreach (KeyValuePair<string, string> keyValuePair in readOnlyDictionary)
					{
						string text;
						string text2;
						keyValuePair.Deconstruct(out text, out text2);
						string mainKeyName = text;
						string secondaryKeyName = text2;
						EInputBindingType currentBindingType = combinationActionBindingByActionName.CurrentBindingType;
						InputSettingsManager.Instance.RemoveCombinationActionKeyMap("手柄主攻击", mainKeyName, secondaryKeyName, currentBindingType);
					}
				}
				if (readOnlyDictionary2 != null)
				{
					foreach (KeyValuePair<string, string> keyValuePair in readOnlyDictionary2)
					{
						string text;
						string text2;
						keyValuePair.Deconstruct(out text2, out text);
						string mainKeyName2 = text2;
						string secondaryKeyName2 = text;
						EInputBindingType currentBindingType2 = combinationActionBindingByActionName2.CurrentBindingType;
						InputSettingsManager.Instance.AddCombinationActionKeyMap("手柄主攻击", mainKeyName2, secondaryKeyName2, currentBindingType2);
					}
				}
			}
		}

		// Token: 0x06032652 RID: 206418 RVA: 0x00BBBE18 File Offset: 0x00BBA018
		private bool CheckKeyNameListEqual([Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<string> keyNameListA, [Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<string> keyNameListB)
		{
			if (keyNameListA == keyNameListB)
			{
				return true;
			}
			if (keyNameListA == null || keyNameListB == null)
			{
				return false;
			}
			if (keyNameListA.Count != keyNameListB.Count)
			{
				return false;
			}
			for (int i = 0; i < keyNameListA.Count; i++)
			{
				if (keyNameListA[i] != keyNameListB[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06032653 RID: 206419 RVA: 0x00BBBE6C File Offset: 0x00BBA06C
		private bool CheckKeyNameMapEqual([Nullable(new byte[]
		{
			2,
			1,
			1
		})] IReadOnlyDictionary<string, string> keyNameMapA, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] IReadOnlyDictionary<string, string> keyNameMapB)
		{
			if (keyNameMapA == keyNameMapB)
			{
				return true;
			}
			if (keyNameMapA == null || keyNameMapB == null)
			{
				return false;
			}
			if (keyNameMapA.Count != keyNameMapB.Count)
			{
				return false;
			}
			foreach (KeyValuePair<string, string> keyValuePair in keyNameMapA)
			{
				string key = keyValuePair.Key;
				string value = keyValuePair.Value;
				string a;
				if (!keyNameMapB.TryGetValue(key, out a) || a != value)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06032654 RID: 206420 RVA: 0x00BBBEFC File Offset: 0x00BBA0FC
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
			Array.Resize<int>(ref this.SubAimSkillButtonTypeList, 4);
			for (int l = 0; l < 3; l++)
			{
				this.SubAimSkillButtonTypeList[l] = this.SubSkillButtonTypeList[l];
			}
			this.SubAimSkillButtonTypeList[this.KeyRightTriggerIndex] = 11;
			this.SubAimSkillButtonTypeList[3] = this.SubSkillButtonTypeList[this.KeyRightTriggerIndex];
		}

		// Token: 0x06032655 RID: 206421 RVA: 0x00BBC02C File Offset: 0x00BBA22C
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

		// Token: 0x06032656 RID: 206422 RVA: 0x00BBC084 File Offset: 0x00BBA284
		private ESkillButtonType GetNormalSkillButtonTypeByIndex(int index, bool isPressCombineButton)
		{
			string key = this.ButtonKeyList[index];
			string text;
			if (isPressCombineButton)
			{
				this.CombinationKeyToActionNameMap.TryGetValue(key, out text);
			}
			else
			{
				this.ButtonKeyToActionNameMap.TryGetValue(key, out text);
			}
			if (string.IsNullOrEmpty(text))
			{
				return ESkillButtonType.None;
			}
			int result;
			if (!SkillButtonUiGamepadData.actionNameToButtonTypeMap.TryGetValue(text, out result))
			{
				return ESkillButtonType.None;
			}
			return (ESkillButtonType)result;
		}

		// Token: 0x06032657 RID: 206423 RVA: 0x00BBC0DD File Offset: 0x00BBA2DD
		public override void RefreshSwitchInteractOpen(bool isInit = false)
		{
			this.SwitchInteractData.RefreshSwitchInteractOpen(isInit);
		}

		// Token: 0x06032658 RID: 206424 RVA: 0x00BBC0EC File Offset: 0x00BBA2EC
		public override bool RefreshButtonData()
		{
			this.RefreshStateByTag();
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
				if (!this.IsAimActionKeys)
				{
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
						if (!this.IsPressCombineButton || this.SubAimSkillButtonTypeList[m] != 11)
						{
							this.PushSubSkillButton(this.SubAimSkillButtonTypeList[m]);
						}
					}
				}
			}
			else
			{
				for (int n = 0; n < 4; n++)
				{
					int? buttonTypeByIndex = this.GetButtonTypeByIndex(this.MainSkillCombineButtonTypeList, n, false);
					if (this.MainSkillCombineButtonTypeList[n] != 0)
					{
						this.CurButtonTypeList.Add(buttonTypeByIndex);
					}
					else
					{
						this.CurButtonTypeList.Add(this.GetButtonTypeByIndex(this.MainSkillButtonTypeList, n, false));
					}
				}
				for (int num = 0; num < 4; num++)
				{
					this.CurButtonTypeList.Add(this.GetButtonTypeByIndex(this.MainSkillCombineButtonTypeList, num, true));
				}
				for (int num2 = 0; num2 < 4; num2++)
				{
					int? buttonTypeByIndex2 = this.GetButtonTypeByIndex(this.DpadSkillCombineButtonTypeList, num2, false);
					if (this.DpadSkillCombineButtonTypeList[num2] != 0)
					{
						this.CurButtonTypeList.Add(buttonTypeByIndex2);
					}
					else
					{
						this.CurButtonTypeList.Add(this.GetButtonTypeByIndex(this.DpadSkillButtonTypeList, num2, false));
					}
				}
				for (int num3 = 0; num3 < 3; num3++)
				{
					this.PushSubSkillButton(this.SubSkillCombineButtonTypeList[num3]);
				}
			}
			if (this.Climbing)
			{
				int num4 = this.CurButtonTypeList.IndexOf(new int?(4));
				if (num4 != -1)
				{
					this.CurButtonTypeList[num4] = new int?(2);
				}
			}
			if (SkillButtonUiModel.Instance.GetButtonTypeList().Contains(12))
			{
				int num5 = this.CurButtonTypeList.IndexOf(new int?(101));
				if (num5 >= 0)
				{
					this.CurButtonTypeList[num5] = new int?(12);
				}
			}
			return true;
		}

		// Token: 0x06032659 RID: 206425 RVA: 0x00BBC360 File Offset: 0x00BBA560
		private int? GetButtonTypeByIndex(int[] buttonTypeList, int index, bool isSecondButton = false)
		{
			int num = buttonTypeList[index];
			if ((num == 101 || this.CheckSkillButtonVisibleByButtonType(num).GetValueOrDefault()) && this.CheckSkillButtonVisibleByState(num, isSecondButton))
			{
				return new int?(num);
			}
			return new int?(0);
		}

		// Token: 0x0603265A RID: 206426 RVA: 0x00BBC3A0 File Offset: 0x00BBA5A0
		private bool CheckSkillButtonVisibleByState(int buttonType, bool isSecondButton = false)
		{
			if (this.IsPhantomRole)
			{
				return SkillButtonUiGamepadData.phantomRoleButtonTypeSet.Contains(buttonType) || (this.PhantomRoleButtonTypeList != null && this.PhantomRoleButtonTypeList.Contains(buttonType));
			}
			return (this.CurStateTagId == 0 || this.StateButtonTypeList == null || this.StateButtonTypeList.Contains(buttonType)) && (!isSecondButton || SkillButtonUiGamepadData.mainSecondButtonTypeSet.Contains(buttonType));
		}

		// Token: 0x0603265B RID: 206427 RVA: 0x00BBC410 File Offset: 0x00BBA610
		private bool? CheckSkillButtonVisibleByButtonType(int buttonType)
		{
			if (buttonType == 0)
			{
				return new bool?(false);
			}
			SkillButtonUiModel instance = SkillButtonUiModel.Instance;
			SkillButtonData skillButtonDataByButton = instance.GetSkillButtonDataByButton((ESkillButtonType)buttonType);
			if (skillButtonDataByButton != null)
			{
				return new bool?(skillButtonDataByButton.IsVisible());
			}
			BehaviorButtonData behaviorButtonDataByButton = instance.GetBehaviorButtonDataByButton((EBehaviorType)buttonType);
			if (behaviorButtonDataByButton == null)
			{
				return null;
			}
			return new bool?(behaviorButtonDataByButton.IsVisible());
		}

		// Token: 0x0603265C RID: 206428 RVA: 0x00BBC464 File Offset: 0x00BBA664
		private void PushSubSkillButton(int buttonType)
		{
			if (this.IsPhantomRole || this.CurStateTagId != 0)
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
				if (!SkillButtonUiGamepadData.subButtonTypeSet.Contains(buttonType))
				{
					this.CurButtonTypeList.Add(null);
					return;
				}
				this.CurButtonTypeList.Add(new int?(buttonType));
				return;
			}
		}

		// Token: 0x0603265D RID: 206429 RVA: 0x00BBC4E8 File Offset: 0x00BBA6E8
		private void RefreshStateByTag()
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity == null || !getCurrentEntity.Valid)
			{
				return;
			}
			BaseTagComponent baseTagComponent = getCurrentEntity.Entity.CheckGetComponent<BaseTagComponent>();
			this.Climbing = baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.攀爬"]);
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

		// Token: 0x0603265E RID: 206430 RVA: 0x00BBC63C File Offset: 0x00BBA83C
		public override int GetButtonTypeByActionName(string actionName)
		{
			int result;
			if (!SkillButtonUiGamepadData.actionNameToButtonTypeMap.TryGetValue(actionName, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x0603265F RID: 206431 RVA: 0x00BBC65B File Offset: 0x00BBA85B
		public override bool IsAim()
		{
			BehaviorButtonData behaviorButtonDataByButtonType = this.GetBehaviorButtonDataByButtonType(EBehaviorType.Aim);
			return (behaviorButtonDataByButtonType != null && behaviorButtonDataByButtonType.State == 1) || this.IsFollowerAiming;
		}

		// Token: 0x06032660 RID: 206432 RVA: 0x00BBC67E File Offset: 0x00BBA87E
		public override void SetIsPressCombineButton(bool value)
		{
			if (this.IsPressCombineButton == value)
			{
				return;
			}
			this.IsPressCombineButton = value;
			this.RefreshButtonData();
		}

		// Token: 0x06032661 RID: 206433 RVA: 0x00BBC698 File Offset: 0x00BBA898
		public override bool GetIsPressCombineButton()
		{
			return this.IsPressCombineButton;
		}

		// Token: 0x06032662 RID: 206434 RVA: 0x00BBC6A0 File Offset: 0x00BBA8A0
		[NullableContext(2)]
		public BehaviorButtonData GetBehaviorButtonDataByButtonType(EBehaviorType buttonType)
		{
			return SkillButtonUiModel.Instance.GetBehaviorButtonDataByButton(buttonType);
		}

		// Token: 0x06032663 RID: 206435 RVA: 0x00BBC6AD File Offset: 0x00BBA8AD
		public override void RefreshSkillButtonData(ESkillButtonRefreshReason refreshReason)
		{
			if (refreshReason == ESkillButtonRefreshReason.ChangeRole)
			{
				this.RefreshIsPhantomRole();
				this.RefreshFollowerAiming();
				this.ChangeSkillOnAimStateChange();
				this.RefreshButtonData();
				this.RefreshInteractBehaviorData();
			}
		}

		// Token: 0x06032664 RID: 206436 RVA: 0x00BBC6D4 File Offset: 0x00BBA8D4
		private void RefreshIsPhantomRole()
		{
			this.IsPhantomRole = false;
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity == null || !getCurrentEntity.Valid)
			{
				return;
			}
			CreatureDataComponent component = getCurrentEntity.Entity.GetComponent<CreatureDataComponent>();
			if (component == null)
			{
				return;
			}
			this.IsPhantomRole = (component.GetRoleConfig().Value.RoleType == 2);
			if (this.IsPhantomRole)
			{
				SkillButtonUiModel instance = SkillButtonUiModel.Instance;
				SkillButtonEntityData curSkillButtonEntityData = instance.GetCurSkillButtonEntityData();
				this.PhantomRoleButtonTypeList = ((curSkillButtonEntityData != null) ? ((curSkillButtonEntityData.SkillButtonIndexConfig != null) ? curSkillButtonEntityData.SkillButtonIndexConfig.GetValueOrDefault().DesktopButtonTypeList() : null) : null);
			}
		}

		// Token: 0x06032665 RID: 206437 RVA: 0x00BBC776 File Offset: 0x00BBA976
		public override bool RefreshAimState()
		{
			if (this.ChangeSkillOnAimStateChange())
			{
				this.RefreshButtonData();
				return true;
			}
			return false;
		}

		// Token: 0x06032666 RID: 206438 RVA: 0x00BBC78C File Offset: 0x00BBA98C
		private bool RefreshFollowerAiming()
		{
			bool followerAiming = BattleUiModel.Instance.FormationData.GetFollowerAiming();
			if (this.IsFollowerAiming != followerAiming)
			{
				this.IsFollowerAiming = followerAiming;
				return true;
			}
			return false;
		}

		// Token: 0x06032667 RID: 206439 RVA: 0x00BBC7BC File Offset: 0x00BBA9BC
		public bool ChangeSkillOnAimStateChange()
		{
			if (this.IsAim() == this.IsAimActionKeys)
			{
				return false;
			}
			this.ChangeAimActionKeys();
			return true;
		}

		// Token: 0x06032668 RID: 206440 RVA: 0x00BBC7D8 File Offset: 0x00BBA9D8
		private void ChangeAimActionKeys()
		{
			if (this.LockRefresh)
			{
				return;
			}
			this.LockRefresh = true;
			this.IsAimActionKeys = !this.IsAimActionKeys;
			TsCharacterController characterController = Global.CharacterController;
			if (this.IsAimActionKeys)
			{
				if (this.ChangeSkillActionName == "攻击")
				{
					if (this.AttackActionAimKeys != null)
					{
						characterController.SetActionEnable("攻击", false);
						foreach (string keyName in this.AttackActionAimKeys)
						{
							characterController.SetCustomAction(keyName, "攻击");
						}
						characterController.SetCustomAction(EKey.Gamepad_RightThumbstick, "攻击");
						characterController.SetActionEnable("攀爬", false);
						if (this.ClimbActionNormalKeys != null)
						{
							foreach (string text in this.ClimbActionNormalKeys)
							{
								if (text != EKey.Gamepad_RightTrigger)
								{
									characterController.SetCustomAction(text, "攀爬");
								}
							}
						}
						characterController.SetCustomAction(EKey.Gamepad_RightThumbstick, "攀爬");
					}
					else
					{
						Log.Instance.Error(ELogModule.Battle, ELogAuthor.CFT, "攻击输入没有绑定任何按键，瞄准时使RT键生效", default(ReadOnlySpan<ValueTuple<string, object>>));
					}
				}
				else
				{
					if (!string.IsNullOrEmpty(this.ChangeSkillActionName))
					{
						characterController.SetActionEnable(this.ChangeSkillActionName, false);
						foreach (string keyName2 in this.ChangeSkillAimKeys)
						{
							characterController.SetCustomAction(keyName2, this.ChangeSkillActionName);
						}
					}
					if (this.AttackActionAimKeys != null)
					{
						characterController.SetActionEnable("攻击", false);
						using (List<string>.Enumerator enumerator = this.AttackActionAimKeys.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								string keyName3 = enumerator.Current;
								characterController.SetCustomAction(keyName3, "攻击");
							}
							goto IL_37A;
						}
					}
					Log.Instance.Error(ELogModule.Battle, ELogAuthor.CFT, "攻击输入没有绑定任何按键，瞄准时使RT键生效", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
			else if (this.ChangeSkillActionName == "攻击")
			{
				characterController.SetActionEnable("攀爬", true);
				characterController.SetActionEnable("攻击", true);
				foreach (string keyName4 in this.AttackActionAimKeys)
				{
					characterController.ResetAllCustomAction(keyName4);
				}
				if (this.ClimbActionNormalKeys != null)
				{
					foreach (string text2 in this.ClimbActionNormalKeys)
					{
						if (text2 != EKey.Gamepad_RightTrigger)
						{
							characterController.ResetAllCustomAction(text2);
						}
					}
				}
				characterController.ResetAllCustomAction(EKey.Gamepad_RightThumbstick);
			}
			else
			{
				if (!string.IsNullOrEmpty(this.ChangeSkillActionName))
				{
					characterController.SetActionEnable(this.ChangeSkillActionName, true);
					foreach (string keyName5 in this.ChangeSkillAimKeys)
					{
						characterController.ResetAllCustomAction(keyName5);
					}
				}
				characterController.SetActionEnable("攻击", true);
				foreach (string keyName6 in this.AttackActionAimKeys)
				{
					characterController.ResetAllCustomAction(keyName6);
				}
			}
			IL_37A:
			this.LockRefresh = false;
		}

		// Token: 0x06032669 RID: 206441 RVA: 0x00BBCBCC File Offset: 0x00BBADCC
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

		// Token: 0x0603266A RID: 206442 RVA: 0x00BBCC0C File Offset: 0x00BBAE0C
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
				if (SkillButtonUiGamepadData.initActionNames.Contains(actionName))
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
				if (SkillButtonUiGamepadData.initActionNames.Contains(actionName))
				{
					Log.Instance.Error(ELogModule.Battle, ELogAuthor.CFT, "在未知情况下触发了改键", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				return;
			}
		}

		// Token: 0x0603266B RID: 206443 RVA: 0x00BBCCAA File Offset: 0x00BBAEAA
		public override void AddChangeKeyReason(EGamepadChangeKeyReason reason)
		{
			if (this.ChangeKeyReasonSet.Count == 0 && this.IsAimActionKeys)
			{
				this.ChangeAimActionKeys();
			}
			this.ChangeKeyReasonSet.Add(reason);
		}

		// Token: 0x0603266C RID: 206444 RVA: 0x00BBCCD4 File Offset: 0x00BBAED4
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
			if (this.IsAim() != this.IsAimActionKeys)
			{
				this.ChangeAimActionKeys();
			}
			this.RefreshButtonData();
			if (Info.Instance.IsInGamepad())
			{
				SkillButtonEntityData curSkillButtonEntityData = SkillButtonUiModel.Instance.GetCurSkillButtonEntityData();
				if (curSkillButtonEntityData == null)
				{
					return;
				}
				curSkillButtonEntityData.RefreshSkillButtonData(ESkillButtonRefreshReason.GamepadRefreshKeyAction);
			}
		}

		// Token: 0x0603266D RID: 206445 RVA: 0x00BBCD4D File Offset: 0x00BBAF4D
		public override void AddAllowChangeKeyReason(string reason)
		{
			this.AllowChangeKeyReasonSet.Add(reason);
		}

		// Token: 0x0603266E RID: 206446 RVA: 0x00BBCD5C File Offset: 0x00BBAF5C
		public override void RemoveAllowChangeKeyReason(string reason)
		{
			this.AllowChangeKeyReasonSet.Remove(reason);
		}

		// Token: 0x0603266F RID: 206447 RVA: 0x00BBCD6B File Offset: 0x00BBAF6B
		public override void CacheInputAxis(in EInputAxis axis, float value)
		{
			this.InputAxisMap[axis] = value;
		}

		// Token: 0x06032670 RID: 206448 RVA: 0x00BBCD7F File Offset: 0x00BBAF7F
		public override float GetInputAxis(in EInputAxis axis)
		{
			return this.InputAxisMap.GetValueOrDefault(axis, 0f);
		}

		// Token: 0x06032671 RID: 206449 RVA: 0x00BBCD97 File Offset: 0x00BBAF97
		public override void ClearInputAxis()
		{
			this.InputAxisMap.Clear();
		}

		// Token: 0x06032673 RID: 206451 RVA: 0x00BBCE00 File Offset: 0x00BBB000
		// Note: this type is marked as 'beforefieldinit'.
		static SkillButtonUiGamepadData()
		{
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			dictionary["跳跃"] = 1;
			dictionary["攀爬"] = 2;
			dictionary["攻击"] = 4;
			dictionary["闪避"] = 5;
			dictionary["技能1"] = 6;
			dictionary["幻象1"] = 7;
			dictionary["大招"] = 8;
			dictionary["幻象2"] = 9;
			dictionary["瞄准"] = 101;
			dictionary["通用交互"] = 104;
			dictionary["任务追踪"] = 105;
			SkillButtonUiGamepadData.actionNameToButtonTypeMap = dictionary;
			SkillButtonUiGamepadData.initActionNames = new string[]
			{
				"跳跃",
				"攻击",
				"闪避",
				"技能1",
				"幻象1",
				"大招",
				"幻象2",
				"瞄准",
				"通用交互"
			};
			SkillButtonUiGamepadData.mainSecondButtonTypeSet = new HashSet<int>
			{
				1,
				2,
				4,
				5,
				6,
				8,
				7,
				9,
				101,
				104
			};
			SkillButtonUiGamepadData.subButtonTypeSet = new HashSet<int>
			{
				1,
				2,
				4,
				6,
				8,
				7,
				9,
				11,
				101,
				104
			};
			SkillButtonUiGamepadData.phantomRoleButtonTypeSet = new HashSet<int>
			{
				101,
				104
			};
		}

		// Token: 0x0401AD32 RID: 109874
		[StaticVariableRuleIgnore]
		private static readonly string[] mainKeys = new string[]
		{
			EKey.Gamepad_FaceButton_Top,
			EKey.Gamepad_FaceButton_Left,
			EKey.Gamepad_FaceButton_Bottom,
			EKey.Gamepad_FaceButton_Right
		};

		// Token: 0x0401AD33 RID: 109875
		private const int MAIN_HALF_NUM = 4;

		// Token: 0x0401AD34 RID: 109876
		[StaticVariableRuleIgnore]
		private static readonly string[] dPadKeys = new string[]
		{
			EKey.Gamepad_DPad_Up,
			EKey.Gamepad_DPad_Left,
			EKey.Gamepad_DPad_Down,
			EKey.Gamepad_DPad_Right
		};

		// Token: 0x0401AD35 RID: 109877
		private const int DPAD_KEY_NUM = 4;

		// Token: 0x0401AD36 RID: 109878
		[StaticVariableRuleIgnore]
		private static readonly string[] subKeys = new string[]
		{
			EKey.Gamepad_LeftTrigger,
			EKey.Gamepad_RightTrigger,
			EKey.Gamepad_LeftShoulder,
			EKey.Gamepad_RightShoulder
		};

		// Token: 0x0401AD37 RID: 109879
		private const int SUB_KEY_NUM = 3;

		// Token: 0x0401AD38 RID: 109880
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<string, int> actionNameToButtonTypeMap;

		// Token: 0x0401AD39 RID: 109881
		[StaticVariableRuleIgnore]
		private static readonly string[] initActionNames;

		// Token: 0x0401AD3A RID: 109882
		[StaticVariableRuleIgnore]
		private static readonly HashSet<int> mainSecondButtonTypeSet;

		// Token: 0x0401AD3B RID: 109883
		[StaticVariableRuleIgnore]
		private static readonly HashSet<int> subButtonTypeSet;

		// Token: 0x0401AD3C RID: 109884
		[StaticVariableRuleIgnore]
		private static readonly HashSet<int> phantomRoleButtonTypeSet;

		// Token: 0x0401AD3D RID: 109885
		private readonly List<string> AllActionNameList = new List<string>();

		// Token: 0x0401AD3E RID: 109886
		public readonly HashSet<string> AllowChangeKeyReasonSet = new HashSet<string>();

		// Token: 0x0401AD3F RID: 109887
		private readonly HashSet<EGamepadChangeKeyReason> ChangeKeyReasonSet = new HashSet<EGamepadChangeKeyReason>();

		// Token: 0x0401AD40 RID: 109888
		private readonly Dictionary<string, string> ButtonKeyToActionNameMap = new Dictionary<string, string>();

		// Token: 0x0401AD41 RID: 109889
		private readonly Dictionary<string, string> CombinationKeyToActionNameMap = new Dictionary<string, string>();

		// Token: 0x0401AD42 RID: 109890
		private int KeyRightTriggerIndex = 1;

		// Token: 0x0401AD43 RID: 109891
		[Nullable(2)]
		private string ChangeSkillActionName;

		// Token: 0x0401AD44 RID: 109892
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> ChangeSkillAimKeys;

		// Token: 0x0401AD45 RID: 109893
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> AttackActionNormalKeys;

		// Token: 0x0401AD46 RID: 109894
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> AttackActionAimKeys;

		// Token: 0x0401AD47 RID: 109895
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> ClimbActionNormalKeys;

		// Token: 0x0401AD48 RID: 109896
		private bool IsPressCombineButton;

		// Token: 0x0401AD49 RID: 109897
		public bool IsShowCombineButton;

		// Token: 0x0401AD4A RID: 109898
		private bool IsFollowerAiming;

		// Token: 0x0401AD4B RID: 109899
		private bool IsAimActionKeys;

		// Token: 0x0401AD4C RID: 109900
		private bool ChangeKeyActionInMenuView;

		// Token: 0x0401AD4D RID: 109901
		private bool LockRefresh;

		// Token: 0x0401AD4E RID: 109902
		public bool Climbing;

		// Token: 0x0401AD4F RID: 109903
		public int CurStateTagId;

		// Token: 0x0401AD50 RID: 109904
		[Nullable(2)]
		public List<int> StateButtonTypeList;

		// Token: 0x0401AD51 RID: 109905
		public bool IsPhantomRole;

		// Token: 0x0401AD52 RID: 109906
		[Nullable(2)]
		public int[] PhantomRoleButtonTypeList;

		// Token: 0x0401AD53 RID: 109907
		private readonly Dictionary<EInputAxis, float> InputAxisMap = new Dictionary<EInputAxis, float>();
	}
}
