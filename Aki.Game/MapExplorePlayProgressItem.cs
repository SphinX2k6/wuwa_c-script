using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001ACA RID: 6858
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MapExplorePlayProgressItem : GridProxyAbstract<IExplorePlayProgressItemData>
{
	// Token: 0x0600CB84 RID: 52100 RVA: 0x002E726C File Offset: 0x002E546C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
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

	// Token: 0x0600CB85 RID: 52101 RVA: 0x002E7359 File Offset: 0x002E5559
	protected override void OnBeforeCreate()
	{
		this.Sequence = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600CB86 RID: 52102 RVA: 0x002E736C File Offset: 0x002E556C
	[NullableContext(1)]
	public override void Refresh(IExplorePlayProgressItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.UpdatePlayPointType();
		if (data.LastPlayPointState != null)
		{
			this.UpdatePlayPointState(data.LastPlayPointState.Value);
			return;
		}
		this.UpdatePlayPointState(data.PlayPointState);
	}

	// Token: 0x0600CB87 RID: 52103 RVA: 0x002E73B8 File Offset: 0x002E55B8
	public void UpdatePlayPointType()
	{
		if (this.Data.IgnoreHiddenType.GetValueOrDefault())
		{
			base.GetSprite(4).SetUIActive(false);
			return;
		}
		if (this.Data.PlayPointType == EPlayPointType.Hidden)
		{
			base.GetSprite(4).SetUIActive(true);
			return;
		}
		base.GetSprite(4).SetUIActive(false);
	}

	// Token: 0x0600CB88 RID: 52104 RVA: 0x002E7414 File Offset: 0x002E5614
	private void UpdatePlayPointState(EPlayPointState playPointState)
	{
		base.GetSprite(1).SetUIActive(false);
		base.GetSprite(2).SetUIActive(false);
		base.GetSprite(3).SetUIActive(false);
		switch (playPointState)
		{
		case EPlayPointState.Locked:
			base.GetSprite(1).SetUIActive(true);
			base.GetSprite(5).SetFillAmount(0f);
			return;
		case EPlayPointState.ToBeCompleted:
			base.GetSprite(2).SetUIActive(true);
			base.GetSprite(5).SetFillAmount(0f);
			return;
		case EPlayPointState.Completed:
			base.GetSprite(3).SetUIActive(true);
			base.GetSprite(5).SetFillAmount(1f);
			return;
		default:
			return;
		}
	}

	// Token: 0x0600CB89 RID: 52105 RVA: 0x002E74B8 File Offset: 0x002E56B8
	public void CheckPlayStateChanged()
	{
		if (this.Data.LastPlayPointState == null)
		{
			return;
		}
		LevelSequencePlayer sequence = this.Sequence;
		if (sequence != null)
		{
			sequence.PlayLevelSequenceByName("Complete", false, null, false);
		}
		this.UpdatePlayPointState(this.Data.PlayPointState);
		this.Data.LastPlayPointState = null;
	}

	// Token: 0x0600CB8A RID: 52106 RVA: 0x002E7521 File Offset: 0x002E5721
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer sequence = this.Sequence;
		if (sequence != null)
		{
			sequence.Clear();
		}
		this.Sequence = null;
	}

	// Token: 0x04005D9D RID: 23965
	private LevelSequencePlayer Sequence;

	// Token: 0x04005D9E RID: 23966
	private IExplorePlayProgressItemData Data;

	// Token: 0x02008028 RID: 32808
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04029D83 RID: 171395
		IconRoot,
		// Token: 0x04029D84 RID: 171396
		LockedIcon,
		// Token: 0x04029D85 RID: 171397
		ToBeCompletedIcon,
		// Token: 0x04029D86 RID: 171398
		CompletedIcon,
		// Token: 0x04029D87 RID: 171399
		HiddenPoint,
		// Token: 0x04029D88 RID: 171400
		ProgressBar
	}
}
