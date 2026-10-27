using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001EFD RID: 7933
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryQuestItemChildItem : UiPanelBase, IGridProxy<HonamiStoryQuestDataBase>
{
	// Token: 0x0600F43D RID: 62525 RVA: 0x003AEA54 File Offset: 0x003ACC54
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600F43E RID: 62526 RVA: 0x003AEC04 File Offset: 0x003ACE04
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(4);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
	}

	// Token: 0x0600F43F RID: 62527 RVA: 0x003AEC28 File Offset: 0x003ACE28
	protected override void OnBeforeDestroy()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(4);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.OnStateChange.Remove(new Action<EToggleState>(this.OnToggleStateChange));
	}

	// Token: 0x17001310 RID: 4880
	// (get) Token: 0x0600F440 RID: 62528 RVA: 0x003AEC4C File Offset: 0x003ACE4C
	[Nullable(2)]
	public HonamiStoryQuestDataBase Data
	{
		[NullableContext(2)]
		get
		{
			return this.TaskData;
		}
	}

	// Token: 0x17001311 RID: 4881
	// (get) Token: 0x0600F441 RID: 62529 RVA: 0x003AEC54 File Offset: 0x003ACE54
	// (set) Token: 0x0600F442 RID: 62530 RVA: 0x003AEC5C File Offset: 0x003ACE5C
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	public IScrollViewDelegate<IGridProxy<HonamiStoryQuestDataBase>, HonamiStoryQuestDataBase> ScrollViewDelegate { [return: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] set; }

	// Token: 0x17001312 RID: 4882
	// (get) Token: 0x0600F443 RID: 62531 RVA: 0x003AEC65 File Offset: 0x003ACE65
	// (set) Token: 0x0600F444 RID: 62532 RVA: 0x003AEC6D File Offset: 0x003ACE6D
	public int GridIndex { get; set; }

	// Token: 0x17001313 RID: 4883
	// (get) Token: 0x0600F445 RID: 62533 RVA: 0x003AEC76 File Offset: 0x003ACE76
	// (set) Token: 0x0600F446 RID: 62534 RVA: 0x003AEC7E File Offset: 0x003ACE7E
	public int DisplayIndex { get; set; }

	// Token: 0x0600F447 RID: 62535 RVA: 0x003AEC88 File Offset: 0x003ACE88
	public void Refresh(HonamiStoryQuestDataBase data, bool isSelected, int gridIndex)
	{
		if (this.ActivityData == null)
		{
			this.ActivityData = HonamiStoryModel.Instance.GetActivityData(true);
		}
		this.TaskData = data;
		this.RefreshTaskInfo();
		base.GetText(3).SetUIActive(false);
		base.GetText(8).SetUIActive(false);
	}

	// Token: 0x0600F448 RID: 62536 RVA: 0x003AECD8 File Offset: 0x003ACED8
	private void RefreshTaskInfo()
	{
		string text = ConfigMultiTextLang.GetLocalTextNew(this.TaskData.GetNameKey(), null) ?? this.TaskData.GetNameKey();
		UUIText text2 = base.GetText(2);
		string newText;
		if (this.TaskData.TaskType == EHonamiStoryQuestType.Main)
		{
			newText = StringUtils.Format((base.GetExtendToggle(4).GetToggleState() == EToggleState.ETT_Checked) ? "<color=#5988a5>{0}</color>" : "<color=#b3dffa>{0}</color>", new string[]
			{
				text
			});
			if (text2 != null)
			{
				text2.SetRichText(true);
			}
		}
		else if ((this.TaskData as HonamiStorySubQuestData).Config.Value.TaskType != 1)
		{
			if (text2 != null)
			{
				text2.SetRichText(false);
			}
			newText = text;
		}
		else
		{
			if (text2 != null)
			{
				text2.SetRichText(true);
			}
			newText = StringUtils.Format((base.GetExtendToggle(4).GetToggleState() == EToggleState.ETT_Checked) ? "<color=#5988a5>{0}</color>" : "<color=#b3dffa>{0}</color>", new string[]
			{
				text
			});
		}
		if (text2 != null)
		{
			text2.SetText(newText, true);
		}
		base.GetItem(9).SetUIActive(this.TaskData.IsFinished());
	}

	// Token: 0x0600F449 RID: 62537 RVA: 0x003AEDE1 File Offset: 0x003ACFE1
	public void BindOnClickTask(Action<HonamiStoryQuestItemChildItem> callback)
	{
		this.OnClickTask = callback;
	}

	// Token: 0x0600F44A RID: 62538 RVA: 0x003AEDEA File Offset: 0x003ACFEA
	private void OnClickToggle(EToggleState toggleState)
	{
		Action<HonamiStoryQuestItemChildItem> onClickTask = this.OnClickTask;
		if (onClickTask == null)
		{
			return;
		}
		onClickTask(this);
	}

	// Token: 0x0600F44B RID: 62539 RVA: 0x003AEDFD File Offset: 0x003ACFFD
	public void Clear()
	{
	}

	// Token: 0x0600F44C RID: 62540 RVA: 0x003AEDFF File Offset: 0x003ACFFF
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x0600F44D RID: 62541 RVA: 0x003AEE01 File Offset: 0x003AD001
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x0600F44E RID: 62542 RVA: 0x003AEE03 File Offset: 0x003AD003
	public void OnSelected()
	{
		base.GetExtendToggle(4).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		this.RefreshTaskInfo();
	}

	// Token: 0x0600F44F RID: 62543 RVA: 0x003AEE1C File Offset: 0x003AD01C
	public void OnDeselected()
	{
		base.GetExtendToggle(4).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.RefreshTaskInfo();
	}

	// Token: 0x0600F450 RID: 62544 RVA: 0x003AEE35 File Offset: 0x003AD035
	public object GetKey(HonamiStoryQuestDataBase data, int gridIndex)
	{
		return this.GridIndex;
	}

	// Token: 0x0600F451 RID: 62545 RVA: 0x003AEE42 File Offset: 0x003AD042
	private void OnToggleStateChange(EToggleState _)
	{
		this.RefreshTaskInfo();
	}

	// Token: 0x0400710D RID: 28941
	private const string RICHTXT_SELECTED = "<color=#5988a5>{0}</color>";

	// Token: 0x0400710E RID: 28942
	private const string RICHTXT_DESELECTED = "<color=#b3dffa>{0}</color>";

	// Token: 0x0400710F RID: 28943
	[Nullable(2)]
	private HonamiStoryActivityData ActivityData;

	// Token: 0x04007110 RID: 28944
	[Nullable(2)]
	private HonamiStoryQuestDataBase TaskData;

	// Token: 0x04007111 RID: 28945
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<HonamiStoryQuestItemChildItem> OnClickTask;

	// Token: 0x020084FD RID: 34045
	[NullableContext(0)]
	private enum EHonamiStoryQuestItemChildItemComponent
	{
		// Token: 0x0402B471 RID: 177265
		TraceItem,
		// Token: 0x0402B472 RID: 177266
		LockItem,
		// Token: 0x0402B473 RID: 177267
		NameText,
		// Token: 0x0402B474 RID: 177268
		DistanceText,
		// Token: 0x0402B475 RID: 177269
		Toggle,
		// Token: 0x0402B476 RID: 177270
		QualityColorItem,
		// Token: 0x0402B477 RID: 177271
		RedDotItem,
		// Token: 0x0402B478 RID: 177272
		CircleSprite,
		// Token: 0x0402B479 RID: 177273
		LockText,
		// Token: 0x0402B47A RID: 177274
		FinishItem
	}
}
