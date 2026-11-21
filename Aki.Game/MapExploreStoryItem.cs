using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000F8B RID: 3979
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MapExploreStoryItem : GridProxyAbstract<IMapExploreStoryItemData>
{
	// Token: 0x06009FA3 RID: 40867 RVA: 0x002F282C File Offset: 0x002F0A2C
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

	// Token: 0x06009FA4 RID: 40868 RVA: 0x002F2919 File Offset: 0x002F0B19
	protected override void OnBeforeCreate()
	{
		this.Sequence = new LevelSequencePlayer(this.RootItem);
		this.Sequence.BindSequenceCloseEvent(new TSequenceEndEvent(this.SequenceCloseEvent), false);
	}

	// Token: 0x06009FA5 RID: 40869 RVA: 0x002F2944 File Offset: 0x002F0B44
	protected override void OnStart()
	{
	}

	// Token: 0x06009FA6 RID: 40870 RVA: 0x002F2946 File Offset: 0x002F0B46
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer sequence = this.Sequence;
		if (sequence == null)
		{
			return;
		}
		sequence.Clear();
	}

	// Token: 0x06009FA7 RID: 40871 RVA: 0x002F2958 File Offset: 0x002F0B58
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

	// Token: 0x06009FA8 RID: 40872 RVA: 0x002F2990 File Offset: 0x002F0B90
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

	// Token: 0x06009FA9 RID: 40873 RVA: 0x002F2A00 File Offset: 0x002F0C00
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

	// Token: 0x06009FAA RID: 40874 RVA: 0x002F2A5E File Offset: 0x002F0C5E
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

	// Token: 0x06009FAB RID: 40875 RVA: 0x002F2A98 File Offset: 0x002F0C98
	public void PlayNewOpenAnim()
	{
		LevelSequencePlayer sequence = this.Sequence;
		if (sequence == null)
		{
			return;
		}
		sequence.PlayLevelSequenceByName("Unlock", false, null, false);
	}

	// Token: 0x06009FAC RID: 40876 RVA: 0x002F2AC5 File Offset: 0x002F0CC5
	private void SequenceCloseEvent(string sequenceName)
	{
		if (sequenceName != "Unlock")
		{
			return;
		}
		this.SetOpenState();
	}

	// Token: 0x04005E6F RID: 24175
	private LevelSequencePlayer Sequence;

	// Token: 0x04005E70 RID: 24176
	private IMapExploreStoryItemData ItemData;

	// Token: 0x020071BB RID: 29115
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x040250C9 RID: 151753
		ItemRoot,
		// Token: 0x040250CA RID: 151754
		TxtTitle,
		// Token: 0x040250CB RID: 151755
		TxtContent,
		// Token: 0x040250CC RID: 151756
		ItemRootLocked,
		// Token: 0x040250CD RID: 151757
		TxtContentLocked,
		// Token: 0x040250CE RID: 151758
		ItemTitleRoot
	}
}
