using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020018B1 RID: 6321
[NullableContext(1)]
[Nullable(0)]
public class InputMultiKeyItem : UiPanelBase
{
	// Token: 0x0600B8FA RID: 47354 RVA: 0x0029F686 File Offset: 0x0029D886
	[NullableContext(2)]
	public InputMultiKeyItem(bool bListenPlatformChanged = true, bool bListenKeyChanged = true, string uniqueId = null)
	{
	}

	// Token: 0x0600B8FB RID: 47355 RVA: 0x0029F6A4 File Offset: 0x0029D8A4
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

	// Token: 0x0600B8FC RID: 47356 RVA: 0x0029F730 File Offset: 0x0029D930
	protected override UniTask OnBeforeStartAsync()
	{
		InputMultiKeyItem.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<InputMultiKeyItem.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B8FD RID: 47357 RVA: 0x0029F773 File Offset: 0x0029D973
	protected override void OnStart()
	{
		this.InputKeyDisplayData = new InputKeyDisplayData();
	}

	// Token: 0x0600B8FE RID: 47358 RVA: 0x0029F780 File Offset: 0x0029D980
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

	// Token: 0x0600B8FF RID: 47359 RVA: 0x0029F7A4 File Offset: 0x0029D9A4
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

	// Token: 0x0600B900 RID: 47360 RVA: 0x0029F82C File Offset: 0x0029DA2C
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

	// Token: 0x0600B901 RID: 47361 RVA: 0x0029F89D File Offset: 0x0029DA9D
	private void InputControllerChange(EInputControllerType eInputControllerType, EInputControllerType inputControllerType)
	{
		if (this.ActionOrAxisKeyItem == null)
		{
			return;
		}
		this.RefreshByActionOrAxisInternal(this.ActionOrAxisKeyItem);
	}

	// Token: 0x0600B902 RID: 47362 RVA: 0x0029F8B4 File Offset: 0x0029DAB4
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

	// Token: 0x0600B903 RID: 47363 RVA: 0x0029F8DF File Offset: 0x0029DADF
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

	// Token: 0x0600B904 RID: 47364 RVA: 0x0029F90A File Offset: 0x0029DB0A
	public void RefreshByKeyList(InputKeyItemData singleInputKeyItemData, [Nullable(2)] InputKeyItemData doubleInputKeyItem = null)
	{
		this.RefreshByKeyListInternal(singleInputKeyItemData, doubleInputKeyItem, null);
		this.ActionOrAxisKeyItem = null;
	}

	// Token: 0x0600B905 RID: 47365 RVA: 0x0029F91C File Offset: 0x0029DB1C
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

	// Token: 0x0600B906 RID: 47366 RVA: 0x0029F9C2 File Offset: 0x0029DBC2
	public void RefreshByKey(InputKeyItemData inputKeyItemData)
	{
		this.RefreshByKeyInternal(inputKeyItemData);
		this.ActionOrAxisKeyItem = null;
	}

	// Token: 0x0600B907 RID: 47367 RVA: 0x0029F9D2 File Offset: 0x0029DBD2
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

	// Token: 0x0600B908 RID: 47368 RVA: 0x0029FA12 File Offset: 0x0029DC12
	public void RefreshByActionOrAxis(InputActionOrAxisKeyItem actionOrAxisKeyItem, bool hideMainKey = false)
	{
		this.ActionOrAxisKeyItem = actionOrAxisKeyItem;
		this.HideMainKey = hideMainKey;
		this.RefreshByActionOrAxisInternal(actionOrAxisKeyItem);
	}

	// Token: 0x0600B909 RID: 47369 RVA: 0x0029FA2C File Offset: 0x0029DC2C
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

	// Token: 0x0600B90A RID: 47370 RVA: 0x0029FCC6 File Offset: 0x0029DEC6
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

	// Token: 0x0600B90B RID: 47371 RVA: 0x0029FD01 File Offset: 0x0029DF01
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

	// Token: 0x0600B90C RID: 47372 RVA: 0x0029FD3F File Offset: 0x0029DF3F
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

	// Token: 0x0600B90D RID: 47373 RVA: 0x0029FD7E File Offset: 0x0029DF7E
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

	// Token: 0x0600B90E RID: 47374 RVA: 0x0029FDA4 File Offset: 0x0029DFA4
	public void SetDisableBySingleKeyList(IReadOnlyList<string> keyNameList)
	{
		if (this.KeyLength != 1)
		{
			this.SetEnable(true, false);
			return;
		}
		InputKeyItem oneInputKeyItem = this.OneInputKeyItem;
		string value = (oneInputKeyItem != null) ? oneInputKeyItem.GetKeyName() : null;
		if (string.IsNullOrEmpty(value))
		{
			this.SetEnable(true, false);
			return;
		}
		this.SetEnable(!keyNameList.Contains(value), false);
	}

	// Token: 0x0600B90F RID: 47375 RVA: 0x0029FDF8 File Offset: 0x0029DFF8
	public int GetKeyLength()
	{
		return this.KeyLength;
	}

	// Token: 0x040053EF RID: 21487
	[CompilerGenerated]
	private bool <bListenPlatformChanged>P = bListenPlatformChanged;

	// Token: 0x040053F0 RID: 21488
	[CompilerGenerated]
	private bool <bListenKeyChanged>P = bListenKeyChanged;

	// Token: 0x040053F1 RID: 21489
	[Nullable(2)]
	[CompilerGenerated]
	private string <uniqueId>P = uniqueId;

	// Token: 0x040053F2 RID: 21490
	[Nullable(2)]
	private InputKeyItem OneInputKeyItem;

	// Token: 0x040053F3 RID: 21491
	[Nullable(2)]
	private InputKeyItem TwoInputKeyItem;

	// Token: 0x040053F4 RID: 21492
	[Nullable(2)]
	private InputKeyDisplayData InputKeyDisplayData;

	// Token: 0x040053F5 RID: 21493
	[Nullable(2)]
	private InputActionOrAxisKeyItem ActionOrAxisKeyItem;

	// Token: 0x040053F6 RID: 21494
	private bool HideMainKey;

	// Token: 0x040053F7 RID: 21495
	private bool IsEnable;

	// Token: 0x040053F8 RID: 21496
	private int KeyLength;

	// Token: 0x02007E3F RID: 32319
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402950B RID: 169227
		public const int AddText = 0;

		// Token: 0x0402950C RID: 169228
		public const int KeyItem1 = 1;

		// Token: 0x0402950D RID: 169229
		public const int KeyItem2 = 2;
	}
}
