using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001ACC RID: 6860
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MapExploreStoryItem : GridProxyAbstract<IMapExploreStoryItemData>
{
	// Token: 0x0600CB92 RID: 52114 RVA: 0x002E76D8 File Offset: 0x002E58D8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600CB93 RID: 52115 RVA: 0x002E77C5 File Offset: 0x002E59C5
	protected override void OnBeforeCreate()
	{
		this.Sequence = new LevelSequencePlayer(this.RootItem);
		this.Sequence.BindSequenceCloseEvent(new TSequenceEndEvent(this.SequenceCloseEvent), false);
	}

	// Token: 0x0600CB94 RID: 52116 RVA: 0x002E77F0 File Offset: 0x002E59F0
	protected override void OnStart()
	{
	}

	// Token: 0x0600CB95 RID: 52117 RVA: 0x002E77F2 File Offset: 0x002E59F2
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer sequence = this.Sequence;
		if (sequence == null)
		{
			return;
		}
		sequence.Clear();
	}

	// Token: 0x0600CB96 RID: 52118 RVA: 0x002E7804 File Offset: 0x002E5A04
	private void SetTextNew(MapExploreStoryItem.EChildType index, string text = null)
	{
		UUIText text2 = base.GetText((int)index);
		if (!string.IsNullOrEmpty(text))
		{
			if (text2 != null)
			{
				text2.ShowTextNew(text);
				return;
			}
		}
		else if (text2 != null)
		{
			text2.SetText("", true);
		}
	}

	// Token: 0x0600CB97 RID: 52119 RVA: 0x002E783C File Offset: 0x002E5A3C
	public override void Refresh(IMapExploreStoryItemData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		this.SetTextNew(MapExploreStoryItem.EChildType.TxtTitle, data.StoryTitle);
		this.SetTextNew(MapExploreStoryItem.EChildType.TxtContent, data.StoryContent);
		this.SetTextNew(MapExploreStoryItem.EChildType.TxtContentLocked, data.LockedDesc);
		if (data.IsOpen)
		{
			bool? isNewOpen = data.IsNewOpen;
			bool flag = false;
			if (isNewOpen.GetValueOrDefault() == flag & isNewOpen != null)
			{
				this.SetOpenState();
				return;
			}
		}
		this.SetLockedState();
	}

	// Token: 0x0600CB98 RID: 52120 RVA: 0x002E78AC File Offset: 0x002E5AAC
	private void SetOpenState()
	{
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.SetUIActive(true);
		}
		UUIItem item2 = base.GetItem(5);
		if (item2 == null)
		{
			return;
		}
		IMapExploreStoryItemData itemData = this.ItemData;
		item2.SetUIActive(!string.IsNullOrEmpty((itemData != null) ? itemData.StoryTitle : null));
	}

	// Token: 0x0600CB99 RID: 52121 RVA: 0x002E790A File Offset: 0x002E5B0A
	private void SetLockedState()
	{
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(5);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(false);
	}

	// Token: 0x0600CB9A RID: 52122 RVA: 0x002E7944 File Offset: 0x002E5B44
	public void PlayNewOpenAnim()
	{
		LevelSequencePlayer sequence = this.Sequence;
		if (sequence == null)
		{
			return;
		}
		sequence.PlayLevelSequenceByName("Unlock", false, null, false);
	}

	// Token: 0x0600CB9B RID: 52123 RVA: 0x002E7971 File Offset: 0x002E5B71
	private void SequenceCloseEvent(string sequenceName)
	{
		if (sequenceName != "Unlock")
		{
			return;
		}
		this.SetOpenState();
	}

	// Token: 0x04005DA0 RID: 23968
	private LevelSequencePlayer Sequence;

	// Token: 0x04005DA1 RID: 23969
	private IMapExploreStoryItemData ItemData;

	// Token: 0x0200802D RID: 32813
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04029D95 RID: 171413
		ItemRoot,
		// Token: 0x04029D96 RID: 171414
		TxtTitle,
		// Token: 0x04029D97 RID: 171415
		TxtContent,
		// Token: 0x04029D98 RID: 171416
		ItemRootLocked,
		// Token: 0x04029D99 RID: 171417
		TxtContentLocked,
		// Token: 0x04029D9A RID: 171418
		ItemTitleRoot
	}
}
