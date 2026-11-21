using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000F7C RID: 3964
[NullableContext(1)]
[Nullable(0)]
public class MapAreaOnlyShowItem : UiPanelBase
{
	// Token: 0x06009EF7 RID: 40695 RVA: 0x002EEF24 File Offset: 0x002ED124
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009EF8 RID: 40696 RVA: 0x002EF011 File Offset: 0x002ED211
	protected override void OnBeforeCreate()
	{
		this.Sequence = new LevelSequencePlayer(this.RootItem);
		LevelSequencePlayer sequence = this.Sequence;
		if (sequence == null)
		{
			return;
		}
		sequence.BindSequenceCloseEvent(new TSequenceEndEvent(this.SequenceCloseEvent), false);
	}

	// Token: 0x06009EF9 RID: 40697 RVA: 0x002EF044 File Offset: 0x002ED244
	public void Refresh(IMapAreaOnlyShowItemData data, int? index = null)
	{
		this.Index = index.GetValueOrDefault();
		this.Data = data;
		this.StopSequenceToFirst();
		if (data.OpenCount > 0 || data.NewOpenCount > 0)
		{
			base.SetTextureByPath(data.IconPath, base.GetTexture(0), null, null);
		}
		for (int i = 0; i < 4; i++)
		{
			bool flag = i < data.OpenCount;
			UUISprite sprite = base.GetSprite(1 + i);
			if (sprite != null)
			{
				sprite.SetUIActive(!flag);
			}
			if (!flag && i < data.OpenCount + data.NewOpenCount)
			{
				LevelSequencePlayer sequence = this.Sequence;
				if (sequence != null)
				{
					sequence.PlayLevelSequenceByName(MapAreaOnlyShowItem.lockKeys[i], false, null, false);
				}
			}
		}
		bool uiactive = data.OpenCount + data.NewOpenCount < 4;
		UUISprite sprite2 = base.GetSprite(5);
		if (sprite2 == null)
		{
			return;
		}
		sprite2.SetUIActive(uiactive);
	}

	// Token: 0x06009EFA RID: 40698 RVA: 0x002EF127 File Offset: 0x002ED327
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer sequence = this.Sequence;
		if (sequence != null)
		{
			sequence.Clear();
		}
		this.Sequence = null;
	}

	// Token: 0x06009EFB RID: 40699 RVA: 0x002EF144 File Offset: 0x002ED344
	private void SequenceCloseEvent(string sequenceName)
	{
		if (!(sequenceName != "Unlock04".ToString()))
		{
			IMapAreaOnlyShowItemData data = this.Data;
			if (data == null || data.NewOpenCount != 0)
			{
				if (!base.IsUiActiveInHierarchy())
				{
					return;
				}
				LevelSequencePlayer sequence = this.Sequence;
				if (sequence != null && sequence.IsPlayingSequence("Unlock04"))
				{
					return;
				}
				LevelSequencePlayer sequence2 = this.Sequence;
				if (sequence2 == null)
				{
					return;
				}
				sequence2.PlayLevelSequenceByName("Complete", false, null, false);
				return;
			}
		}
	}

	// Token: 0x06009EFC RID: 40700 RVA: 0x002EF1C0 File Offset: 0x002ED3C0
	public void StopSequenceToFirst()
	{
		LevelSequencePlayer sequence = this.Sequence;
		if (sequence != null)
		{
			sequence.StopPlayingSequence(false, true);
		}
		LevelSequencePlayer sequence2 = this.Sequence;
		if (sequence2 == null)
		{
			return;
		}
		sequence2.PlayLevelSequenceByName("FirstStart", false, null, false);
	}

	// Token: 0x04005E31 RID: 24113
	[StaticVariableRuleIgnore]
	private static readonly string[] lockKeys = new string[]
	{
		"Unlock01",
		"Unlock02",
		"Unlock03",
		"Unlock04"
	};

	// Token: 0x04005E32 RID: 24114
	[Nullable(2)]
	private LevelSequencePlayer Sequence;

	// Token: 0x04005E33 RID: 24115
	private int Index;

	// Token: 0x04005E34 RID: 24116
	[Nullable(2)]
	private IMapAreaOnlyShowItemData Data;

	// Token: 0x020071A4 RID: 29092
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402503C RID: 151612
		TextureAreaIcon,
		// Token: 0x0402503D RID: 151613
		SpriteMask1,
		// Token: 0x0402503E RID: 151614
		SpriteMask2,
		// Token: 0x0402503F RID: 151615
		SpriteMask3,
		// Token: 0x04025040 RID: 151616
		SpriteMask4,
		// Token: 0x04025041 RID: 151617
		SpriteMaskLine
	}
}
