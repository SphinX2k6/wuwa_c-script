using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002660 RID: 9824
public class QuestLockPreview : UiViewBase
{
	// Token: 0x060141B0 RID: 82352 RVA: 0x0051233F File Offset: 0x0051053F
	[NullableContext(1)]
	public QuestLockPreview(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060141B1 RID: 82353 RVA: 0x00512348 File Offset: 0x00510548
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

	// Token: 0x060141B2 RID: 82354 RVA: 0x005123D2 File Offset: 0x005105D2
	protected override void OnBeforeCreate()
	{
		this.OccupationInfo = (this.OpenParam as List<IOccupationInfo>);
	}

	// Token: 0x060141B3 RID: 82355 RVA: 0x005123E5 File Offset: 0x005105E5
	protected override void OnStart()
	{
		base.OnStart();
		this.InitLockReasonItems();
	}

	// Token: 0x060141B4 RID: 82356 RVA: 0x005123F4 File Offset: 0x005105F4
	private void InitLockReasonItems()
	{
		if (this.OccupationInfo == null || this.OccupationInfo.Count == 0)
		{
			return;
		}
		this.LockReasonItems = new List<LockReasonItem>();
		UUIItem item = base.GetItem(2);
		UUIItem item2 = base.GetItem(1);
		foreach (IOccupationInfo occupationInfo in this.OccupationInfo)
		{
			UUIItem uuiitem = LguiUtil.Instance.CopyItem(item, item2);
			LockReasonItem lockReasonItem = new LockReasonItem(occupationInfo);
			lockReasonItem.CreateThenShowByActorAsync(uuiitem.GetOwner(), null, false);
			this.LockReasonItems.Add(lockReasonItem);
		}
		item.SetUIActive(false);
	}

	// Token: 0x0400978B RID: 38795
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<IOccupationInfo> OccupationInfo;

	// Token: 0x0400978C RID: 38796
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<LockReasonItem> LockReasonItems;

	// Token: 0x02008C9C RID: 35996
	private class EChildComponent
	{
		// Token: 0x0402DA38 RID: 186936
		public const int SubTitleText = 0;

		// Token: 0x0402DA39 RID: 186937
		public const int Content = 1;

		// Token: 0x0402DA3A RID: 186938
		public const int LockReasonItem = 2;
	}
}
