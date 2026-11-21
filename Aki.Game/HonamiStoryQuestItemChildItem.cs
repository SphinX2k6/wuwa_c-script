using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020013BF RID: 5055
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryQuestItemChildItem : UiPanelBase, IGridProxy<HonamiStoryQuestDataBase>
{
	// Token: 0x0600C85C RID: 51292 RVA: 0x003BA548 File Offset: 0x003B8748
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

	// Token: 0x0600C85D RID: 51293 RVA: 0x003BA6F8 File Offset: 0x003B88F8
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(4);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
	}

	// Token: 0x0600C85E RID: 51294 RVA: 0x003BA71C File Offset: 0x003B891C
	protected override void OnBeforeDestroy()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(4);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.OnStateChange.Remove(new Action<EToggleState>(this.OnToggleStateChange));
	}

	// Token: 0x1700133A RID: 4922
	// (get) Token: 0x0600C85F RID: 51295 RVA: 0x003BA740 File Offset: 0x003B8940
	[Nullable(2)]
	public HonamiStoryQuestDataBase Data
	{
		[NullableContext(2)]
		get
		{
			return this.TaskData;
		}
	}

	// Token: 0x1700133B RID: 4923
	// (get) Token: 0x0600C860 RID: 51296 RVA: 0x003BA748 File Offset: 0x003B8948
	// (set) Token: 0x0600C861 RID: 51297 RVA: 0x003BA750 File Offset: 0x003B8950
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

	// Token: 0x1700133C RID: 4924
	// (get) Token: 0x0600C862 RID: 51298 RVA: 0x003BA759 File Offset: 0x003B8959
	// (set) Token: 0x0600C863 RID: 51299 RVA: 0x003BA761 File Offset: 0x003B8961
	public int GridIndex { get; set; }

	// Token: 0x1700133D RID: 4925
	// (get) Token: 0x0600C864 RID: 51300 RVA: 0x003BA76A File Offset: 0x003B896A
	// (set) Token: 0x0600C865 RID: 51301 RVA: 0x003BA772 File Offset: 0x003B8972
	public int DisplayIndex { get; set; }

	// Token: 0x0600C866 RID: 51302 RVA: 0x003BA77C File Offset: 0x003B897C
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

	// Token: 0x0600C867 RID: 51303 RVA: 0x003BA7CC File Offset: 0x003B89CC
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

	// Token: 0x0600C868 RID: 51304 RVA: 0x003BA8D5 File Offset: 0x003B8AD5
	public void BindOnClickTask(Action<HonamiStoryQuestItemChildItem> callback)
	{
		this.OnClickTask = callback;
	}

	// Token: 0x0600C869 RID: 51305 RVA: 0x003BA8DE File Offset: 0x003B8ADE
	private void OnClickToggle(EToggleState toggleState)
	{
		Action<HonamiStoryQuestItemChildItem> onClickTask = this.OnClickTask;
		if (onClickTask == null)
		{
			return;
		}
		onClickTask(this);
	}

	// Token: 0x0600C86A RID: 51306 RVA: 0x003BA8F1 File Offset: 0x003B8AF1
	public void Clear()
	{
	}

	// Token: 0x0600C86B RID: 51307 RVA: 0x003BA8F3 File Offset: 0x003B8AF3
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x0600C86C RID: 51308 RVA: 0x003BA8F5 File Offset: 0x003B8AF5
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x0600C86D RID: 51309 RVA: 0x003BA8F7 File Offset: 0x003B8AF7
	public void OnSelected()
	{
		base.GetExtendToggle(4).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		this.RefreshTaskInfo();
	}

	// Token: 0x0600C86E RID: 51310 RVA: 0x003BA910 File Offset: 0x003B8B10
	public void OnDeselected()
	{
		base.GetExtendToggle(4).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.RefreshTaskInfo();
	}

	// Token: 0x0600C86F RID: 51311 RVA: 0x003BA929 File Offset: 0x003B8B29
	public object GetKey(HonamiStoryQuestDataBase data, int gridIndex)
	{
		return this.GridIndex;
	}

	// Token: 0x0600C870 RID: 51312 RVA: 0x003BA936 File Offset: 0x003B8B36
	private void OnToggleStateChange(EToggleState _)
	{
		this.RefreshTaskInfo();
	}

	// Token: 0x040071EE RID: 29166
	private const string RICHTXT_SELECTED = "<color=#5988a5>{0}</color>";

	// Token: 0x040071EF RID: 29167
	private const string RICHTXT_DESELECTED = "<color=#b3dffa>{0}</color>";

	// Token: 0x040071F0 RID: 29168
	[Nullable(2)]
	private HonamiStoryActivityData ActivityData;

	// Token: 0x040071F1 RID: 29169
	[Nullable(2)]
	private HonamiStoryQuestDataBase TaskData;

	// Token: 0x040071F2 RID: 29170
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<HonamiStoryQuestItemChildItem> OnClickTask;

	// Token: 0x02007682 RID: 30338
	[NullableContext(0)]
	private enum EHonamiStoryQuestItemChildItemComponent
	{
		// Token: 0x04026795 RID: 157589
		TraceItem,
		// Token: 0x04026796 RID: 157590
		LockItem,
		// Token: 0x04026797 RID: 157591
		NameText,
		// Token: 0x04026798 RID: 157592
		DistanceText,
		// Token: 0x04026799 RID: 157593
		Toggle,
		// Token: 0x0402679A RID: 157594
		QualityColorItem,
		// Token: 0x0402679B RID: 157595
		RedDotItem,
		// Token: 0x0402679C RID: 157596
		CircleSprite,
		// Token: 0x0402679D RID: 157597
		LockText,
		// Token: 0x0402679E RID: 157598
		FinishItem
	}
}
