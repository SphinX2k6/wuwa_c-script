using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001ABD RID: 6845
[NullableContext(1)]
[Nullable(0)]
public class MapAreaOnlyShowItem : UiPanelBase
{
	// Token: 0x0600CAE6 RID: 51942 RVA: 0x002E3DA0 File Offset: 0x002E1FA0
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

	// Token: 0x0600CAE7 RID: 51943 RVA: 0x002E3E8D File Offset: 0x002E208D
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

	// Token: 0x0600CAE8 RID: 51944 RVA: 0x002E3EC0 File Offset: 0x002E20C0
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

	// Token: 0x0600CAE9 RID: 51945 RVA: 0x002E3FA3 File Offset: 0x002E21A3
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer sequence = this.Sequence;
		if (sequence != null)
		{
			sequence.Clear();
		}
		this.Sequence = null;
	}

	// Token: 0x0600CAEA RID: 51946 RVA: 0x002E3FC0 File Offset: 0x002E21C0
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

	// Token: 0x0600CAEB RID: 51947 RVA: 0x002E403C File Offset: 0x002E223C
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

	// Token: 0x04005D62 RID: 23906
	[StaticVariableRuleIgnore]
	private static readonly string[] lockKeys = new string[]
	{
		"Unlock01",
		"Unlock02",
		"Unlock03",
		"Unlock04"
	};

	// Token: 0x04005D63 RID: 23907
	[Nullable(2)]
	private LevelSequencePlayer Sequence;

	// Token: 0x04005D64 RID: 23908
	private int Index;

	// Token: 0x04005D65 RID: 23909
	[Nullable(2)]
	private IMapAreaOnlyShowItemData Data;

	// Token: 0x02008015 RID: 32789
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04029D03 RID: 171267
		TextureAreaIcon,
		// Token: 0x04029D04 RID: 171268
		SpriteMask1,
		// Token: 0x04029D05 RID: 171269
		SpriteMask2,
		// Token: 0x04029D06 RID: 171270
		SpriteMask3,
		// Token: 0x04029D07 RID: 171271
		SpriteMask4,
		// Token: 0x04029D08 RID: 171272
		SpriteMaskLine
	}
}
