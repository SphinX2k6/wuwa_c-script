using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000F89 RID: 3977
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MapExplorePlayProgressItem : GridProxyAbstract<IExplorePlayProgressItemData>
{
	// Token: 0x06009F95 RID: 40853 RVA: 0x002F23C0 File Offset: 0x002F05C0
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

	// Token: 0x06009F96 RID: 40854 RVA: 0x002F24AD File Offset: 0x002F06AD
	protected override void OnBeforeCreate()
	{
		this.Sequence = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06009F97 RID: 40855 RVA: 0x002F24C0 File Offset: 0x002F06C0
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

	// Token: 0x06009F98 RID: 40856 RVA: 0x002F250C File Offset: 0x002F070C
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

	// Token: 0x06009F99 RID: 40857 RVA: 0x002F2568 File Offset: 0x002F0768
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

	// Token: 0x06009F9A RID: 40858 RVA: 0x002F260C File Offset: 0x002F080C
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

	// Token: 0x06009F9B RID: 40859 RVA: 0x002F2675 File Offset: 0x002F0875
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer sequence = this.Sequence;
		if (sequence != null)
		{
			sequence.Clear();
		}
		this.Sequence = null;
	}

	// Token: 0x04005E6C RID: 24172
	private LevelSequencePlayer Sequence;

	// Token: 0x04005E6D RID: 24173
	private IExplorePlayProgressItemData Data;

	// Token: 0x020071B6 RID: 29110
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x040250B7 RID: 151735
		IconRoot,
		// Token: 0x040250B8 RID: 151736
		LockedIcon,
		// Token: 0x040250B9 RID: 151737
		ToBeCompletedIcon,
		// Token: 0x040250BA RID: 151738
		CompletedIcon,
		// Token: 0x040250BB RID: 151739
		HiddenPoint,
		// Token: 0x040250BC RID: 151740
		ProgressBar
	}
}
