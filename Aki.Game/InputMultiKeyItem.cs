using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000D6A RID: 3434
[NullableContext(1)]
[Nullable(0)]
public class InputMultiKeyItem : UiPanelBase
{
	// Token: 0x06008CE3 RID: 36067 RVA: 0x002A9DA6 File Offset: 0x002A7FA6
	[NullableContext(2)]
	public InputMultiKeyItem(bool bListenPlatformChanged = true, bool bListenKeyChanged = true, string uniqueId = null)
	{
	}

	// Token: 0x06008CE4 RID: 36068 RVA: 0x002A9DC4 File Offset: 0x002A7FC4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06008CE5 RID: 36069 RVA: 0x002A9E50 File Offset: 0x002A8050
	protected override UniTask OnBeforeStartAsync()
	{
		InputMultiKeyItem.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<InputMultiKeyItem.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008CE6 RID: 36070 RVA: 0x002A9E93 File Offset: 0x002A8093
	protected override void OnStart()
	{
		this.InputKeyDisplayData = new InputKeyDisplayData();
	}

	// Token: 0x06008CE7 RID: 36071 RVA: 0x002A9EA0 File Offset: 0x002A80A0
	protected override void OnBeforeDestroy()
	{
		InputKeyDisplayData inputKeyDisplayData = this.InputKeyDisplayData;
		if (inputKeyDisplayData != null)
		{
			inputKeyDisplayData.Reset();
		}
		this.OneInputKeyItem = null;
		this.TwoInputKeyItem = null;
	}

	// Token: 0x06008CE8 RID: 36072 RVA: 0x002A9EC4 File Offset: 0x002A80C4
	protected override void OnBeforeShow()
	{
		if (this.<bListenPlatformChanged>P)
		{
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
		}
		if (this.<bListenKeyChanged>P)
		{
			EventSystem.Instance.Add(EEventName.OnActionKeyChanged, new Action<string>(this.OnActionKeyChanged));
			EventSystem.Instance.Add(EEventName.OnAxisKeyChanged, new Action<string>(this.OnAxisKeyChanged));
		}
		if (this.ActionOrAxisKeyItem != null)
		{
			this.RefreshByActionOrAxisInternal(this.ActionOrAxisKeyItem);
		}
	}

	// Token: 0x06008CE9 RID: 36073 RVA: 0x002A9F4C File Offset: 0x002A814C
	protected override void OnAfterHide()
	{
		if (this.<bListenPlatformChanged>P)
		{
			EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
		}
		if (this.<bListenKeyChanged>P)
		{
			EventSystem.Instance.Remove(EEventName.OnActionKeyChanged, new Action<string>(this.OnActionKeyChanged));
			EventSystem.Instance.Remove(EEventName.OnAxisKeyChanged, new Action<string>(this.OnAxisKeyChanged));
		}
	}

	// Token: 0x06008CEA RID: 36074 RVA: 0x002A9FBD File Offset: 0x002A81BD
	private void InputControllerChange(EInputControllerType eInputControllerType, EInputControllerType inputControllerType)
	{
		if (this.ActionOrAxisKeyItem == null)
		{
			return;
		}
		this.RefreshByActionOrAxisInternal(this.ActionOrAxisKeyItem);
	}

	// Token: 0x06008CEB RID: 36075 RVA: 0x002A9FD4 File Offset: 0x002A81D4
	private void OnActionKeyChanged(string actionName)
	{
		if (this.ActionOrAxisKeyItem == null)
		{
			return;
		}
		if (this.ActionOrAxisKeyItem.ActionOrAxisName != actionName)
		{
			return;
		}
		this.RefreshByActionOrAxisInternal(this.ActionOrAxisKeyItem);
	}

	// Token: 0x06008CEC RID: 36076 RVA: 0x002A9FFF File Offset: 0x002A81FF
	private void OnAxisKeyChanged(string axisName)
	{
		if (this.ActionOrAxisKeyItem == null)
		{
			return;
		}
		if (this.ActionOrAxisKeyItem.ActionOrAxisName != axisName)
		{
			return;
		}
		this.RefreshByActionOrAxisInternal(this.ActionOrAxisKeyItem);
	}

	// Token: 0x06008CED RID: 36077 RVA: 0x002AA02A File Offset: 0x002A822A
	public void RefreshByKeyList(InputKeyItemData singleInputKeyItemData, [Nullable(2)] InputKeyItemData doubleInputKeyItem = null)
	{
		this.RefreshByKeyListInternal(singleInputKeyItemData, doubleInputKeyItem, null);
		this.ActionOrAxisKeyItem = null;
	}

	// Token: 0x06008CEE RID: 36078 RVA: 0x002AA03C File Offset: 0x002A823C
	[NullableContext(2)]
	private void RefreshByKeyListInternal([Nullable(1)] InputKeyItemData singleInputKeyItemData, InputKeyItemData doubleInputKeyItem = null, string linkString = null)
	{
		if (singleInputKeyItemData != null)
		{
			InputKeyItem oneInputKeyItem = this.OneInputKeyItem;
			if (oneInputKeyItem != null)
			{
				oneInputKeyItem.Refresh(singleInputKeyItemData);
			}
			InputKeyItem oneInputKeyItem2 = this.OneInputKeyItem;
			if (oneInputKeyItem2 != null)
			{
				oneInputKeyItem2.SetActive(true);
			}
			this.KeyLength = 1;
		}
		UUIText text = base.GetText(0);
		if (doubleInputKeyItem != null)
		{
			InputKeyItem twoInputKeyItem = this.TwoInputKeyItem;
			if (twoInputKeyItem != null)
			{
				twoInputKeyItem.Refresh(doubleInputKeyItem);
			}
			InputKeyItem twoInputKeyItem2 = this.TwoInputKeyItem;
			if (twoInputKeyItem2 != null)
			{
				twoInputKeyItem2.SetActive(true);
			}
			text.SetText(linkString ?? "+", true);
			text.SetUIActive(true);
			this.KeyLength = 2;
			return;
		}
		text.SetUIActive(false);
		InputKeyItem twoInputKeyItem3 = this.TwoInputKeyItem;
		if (twoInputKeyItem3 == null)
		{
			return;
		}
		twoInputKeyItem3.SetActive(false);
	}

	// Token: 0x06008CEF RID: 36079 RVA: 0x002AA0E2 File Offset: 0x002A82E2
	public void RefreshByKey(InputKeyItemData inputKeyItemData)
	{
		this.RefreshByKeyInternal(inputKeyItemData);
		this.ActionOrAxisKeyItem = null;
	}

	// Token: 0x06008CF0 RID: 36080 RVA: 0x002AA0F2 File Offset: 0x002A82F2
	private void RefreshByKeyInternal(InputKeyItemData inputKeyItemData)
	{
		InputKeyItem oneInputKeyItem = this.OneInputKeyItem;
		if (oneInputKeyItem != null)
		{
			oneInputKeyItem.Refresh(inputKeyItemData);
		}
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.SetUIActive(false);
		}
		InputKeyItem twoInputKeyItem = this.TwoInputKeyItem;
		if (twoInputKeyItem != null)
		{
			twoInputKeyItem.SetActive(false);
		}
		this.KeyLength = 1;
	}

	// Token: 0x06008CF1 RID: 36081 RVA: 0x002AA132 File Offset: 0x002A8332
	public void RefreshByActionOrAxis(InputActionOrAxisKeyItem actionOrAxisKeyItem, bool hideMainKey = false)
	{
		this.ActionOrAxisKeyItem = actionOrAxisKeyItem;
		this.HideMainKey = hideMainKey;
		this.RefreshByActionOrAxisInternal(actionOrAxisKeyItem);
	}

	// Token: 0x06008CF2 RID: 36082 RVA: 0x002AA14C File Offset: 0x002A834C
	private void RefreshByActionOrAxisInternal(InputActionOrAxisKeyItem actionOrAxisKeyItem)
	{
		if (this.InputKeyDisplayData == null)
		{
			return;
		}
		if (this.RootItem == null || !this.RootItem.IsValid())
		{
			return;
		}
		string actionOrAxisName = actionOrAxisKeyItem.ActionOrAxisName;
		this.InputKeyDisplayData.Reset();
		bool flag = InputSettingsManager.Instance.GetActionKeyDisplayData(this.InputKeyDisplayData, actionOrAxisName);
		if (!flag)
		{
			flag = InputSettingsManager.Instance.GetAxisKeyDisplayData(this.InputKeyDisplayData, actionOrAxisName);
		}
		if (!flag)
		{
			InputKeyItem oneInputKeyItem = this.OneInputKeyItem;
			if (oneInputKeyItem != null)
			{
				oneInputKeyItem.SetActive(false);
			}
			InputKeyItem twoInputKeyItem = this.TwoInputKeyItem;
			if (twoInputKeyItem != null)
			{
				twoInputKeyItem.SetActive(false);
			}
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			this.KeyLength = 0;
			return;
		}
		int valueOrDefault = actionOrAxisKeyItem.Index.GetValueOrDefault();
		string[] displayKeyNameList = this.InputKeyDisplayData.GetDisplayKeyNameList(valueOrDefault);
		if (displayKeyNameList == null || displayKeyNameList.Length == 0 || (this.HideMainKey && displayKeyNameList.Length == 1))
		{
			InputKeyItem oneInputKeyItem2 = this.OneInputKeyItem;
			if (oneInputKeyItem2 != null)
			{
				oneInputKeyItem2.SetActive(false);
			}
			InputKeyItem twoInputKeyItem2 = this.TwoInputKeyItem;
			if (twoInputKeyItem2 != null)
			{
				twoInputKeyItem2.SetActive(false);
			}
			UUIText text2 = base.GetText(0);
			if (text2 != null)
			{
				text2.SetUIActive(false);
			}
			this.KeyLength = 0;
			return;
		}
		if (displayKeyNameList.Length == 1)
		{
			this.KeyLength = 1;
			InputKeyItemData singleInputKeyItemData = new InputKeyItemData
			{
				KeyName = displayKeyNameList[0],
				IsLongPressDisable = actionOrAxisKeyItem.IsLongPressDisable,
				LongPressTime = actionOrAxisKeyItem.LongPressTime,
				DelayPressTime = actionOrAxisKeyItem.DelayPressTime,
				IsLongPressProcessVisible = actionOrAxisKeyItem.IsLongPressProcessVisible,
				IsShowLongPressWhenPress = actionOrAxisKeyItem.IsShowLongPressWhenPress,
				IsShowLongPressWhenRelease = actionOrAxisKeyItem.IsShowLongPressWhenRelease,
				IsTextArrowVisible = actionOrAxisKeyItem.IsTextArrowVisible,
				IsUpArrowVisible = actionOrAxisKeyItem.IsUpArrowVisible,
				IsDownArrowVisible = actionOrAxisKeyItem.IsDownArrowVisible,
				IsShowTextArrowWhenPress = actionOrAxisKeyItem.IsShowTextArrowWhenPress,
				IsShowTextArrowWhenRelease = actionOrAxisKeyItem.IsShowTextArrowWhenRelease,
				DescriptionId = actionOrAxisKeyItem.DescriptionId
			};
			this.RefreshByKeyListInternal(singleInputKeyItemData, null, null);
			return;
		}
		if (displayKeyNameList.Length == 2)
		{
			this.KeyLength = 2;
			InputKeyItemData singleInputKeyItemData2 = new InputKeyItemData
			{
				KeyName = displayKeyNameList[0]
			};
			InputKeyItemData inputKeyItemData = new InputKeyItemData
			{
				KeyName = displayKeyNameList[1],
				LongPressTime = actionOrAxisKeyItem.LongPressTime,
				IsLongPressProcessVisible = actionOrAxisKeyItem.IsLongPressProcessVisible,
				IsShowLongPressWhenPress = actionOrAxisKeyItem.IsShowLongPressWhenPress,
				IsShowLongPressWhenRelease = actionOrAxisKeyItem.IsShowLongPressWhenRelease,
				IsTextArrowVisible = actionOrAxisKeyItem.IsTextArrowVisible,
				IsUpArrowVisible = actionOrAxisKeyItem.IsUpArrowVisible,
				IsDownArrowVisible = actionOrAxisKeyItem.IsDownArrowVisible,
				IsShowTextArrowWhenPress = actionOrAxisKeyItem.IsShowTextArrowWhenPress,
				IsShowTextArrowWhenRelease = actionOrAxisKeyItem.IsShowTextArrowWhenRelease,
				DescriptionId = actionOrAxisKeyItem.DescriptionId
			};
			if (this.HideMainKey)
			{
				this.RefreshByKeyListInternal(inputKeyItemData, null, null);
				return;
			}
			this.RefreshByKeyListInternal(singleInputKeyItemData2, inputKeyItemData, actionOrAxisKeyItem.LinkString);
		}
	}

	// Token: 0x06008CF3 RID: 36083 RVA: 0x002AA3E6 File Offset: 0x002A85E6
	public void SetEnable(bool bEnable, bool bForce = false)
	{
		if (this.IsEnable == bEnable && !bForce)
		{
			return;
		}
		if (bEnable)
		{
			this.RootItem.SetAlpha(1f);
		}
		else
		{
			this.RootItem.SetAlpha(0.2f);
		}
		this.IsEnable = bEnable;
	}

	// Token: 0x06008CF4 RID: 36084 RVA: 0x002AA421 File Offset: 0x002A8621
	public void SetLongPressDisable(bool bDisable)
	{
		if (this.ActionOrAxisKeyItem != null)
		{
			this.ActionOrAxisKeyItem.IsLongPressDisable = new bool?(bDisable);
		}
		InputKeyItem oneInputKeyItem = this.OneInputKeyItem;
		if (oneInputKeyItem != null)
		{
			oneInputKeyItem.SetLongPressDisable(bDisable);
		}
		InputKeyItem twoInputKeyItem = this.TwoInputKeyItem;
		if (twoInputKeyItem == null)
		{
			return;
		}
		twoInputKeyItem.SetLongPressDisable(bDisable);
	}

	// Token: 0x06008CF5 RID: 36085 RVA: 0x002AA45F File Offset: 0x002A865F
	public void SetLongPressTime(float time)
	{
		InputKeyItem oneInputKeyItem = this.OneInputKeyItem;
		if (oneInputKeyItem != null)
		{
			oneInputKeyItem.SetLongPressTime(time);
		}
		InputKeyItem twoInputKeyItem = this.TwoInputKeyItem;
		if (twoInputKeyItem != null)
		{
			twoInputKeyItem.SetLongPressTime(time);
		}
		if (this.ActionOrAxisKeyItem != null)
		{
			this.ActionOrAxisKeyItem.LongPressTime = new float?(time);
		}
	}

	// Token: 0x06008CF6 RID: 36086 RVA: 0x002AA49E File Offset: 0x002A869E
	public void ResetLongPress()
	{
		InputKeyItem oneInputKeyItem = this.OneInputKeyItem;
		if (oneInputKeyItem != null)
		{
			oneInputKeyItem.ResetLongPress();
		}
		InputKeyItem twoInputKeyItem = this.TwoInputKeyItem;
		if (twoInputKeyItem == null)
		{
			return;
		}
		twoInputKeyItem.ResetLongPress();
	}

	// Token: 0x06008CF7 RID: 36087 RVA: 0x002AA4C4 File Offset: 0x002A86C4
	public void SetDisableBySingleKeyList(IReadOnlyList<string> keyNameList)
	{
		if (this.KeyLength != 1)
		{
			this.SetEnable(true, false);
			return;
		}
		InputKeyItem oneInputKeyItem = this.OneInputKeyItem;
		string text = (oneInputKeyItem != null) ? oneInputKeyItem.GetKeyName() : null;
		if (string.IsNullOrEmpty(text))
		{
			this.SetEnable(true, false);
			return;
		}
		bool flag = false;
		for (int i = 0; i < keyNameList.Count; i++)
		{
			if (keyNameList[i] == text)
			{
				flag = true;
				break;
			}
		}
		this.SetEnable(!flag, false);
	}

	// Token: 0x06008CF8 RID: 36088 RVA: 0x002AA538 File Offset: 0x002A8738
	public int GetKeyLength()
	{
		return this.KeyLength;
	}

	// Token: 0x0400549A RID: 21658
	[CompilerGenerated]
	private bool <bListenPlatformChanged>P = bListenPlatformChanged;

	// Token: 0x0400549B RID: 21659
	[CompilerGenerated]
	private bool <bListenKeyChanged>P = bListenKeyChanged;

	// Token: 0x0400549C RID: 21660
	[Nullable(2)]
	[CompilerGenerated]
	private string <uniqueId>P = uniqueId;

	// Token: 0x0400549D RID: 21661
	[Nullable(2)]
	private InputKeyItem OneInputKeyItem;

	// Token: 0x0400549E RID: 21662
	[Nullable(2)]
	private InputKeyItem TwoInputKeyItem;

	// Token: 0x0400549F RID: 21663
	[Nullable(2)]
	private InputKeyDisplayData InputKeyDisplayData;

	// Token: 0x040054A0 RID: 21664
	[Nullable(2)]
	private InputActionOrAxisKeyItem ActionOrAxisKeyItem;

	// Token: 0x040054A1 RID: 21665
	private bool HideMainKey;

	// Token: 0x040054A2 RID: 21666
	private bool IsEnable;

	// Token: 0x040054A3 RID: 21667
	private int KeyLength;

	// Token: 0x02006FC6 RID: 28614
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x04024838 RID: 149560
		public const int AddText = 0;

		// Token: 0x04024839 RID: 149561
		public const int KeyItem1 = 1;

		// Token: 0x0402483A RID: 149562
		public const int KeyItem2 = 2;
	}
}
