using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001B4B RID: 6987
public class QuestLockPreview : UiViewBase
{
	// Token: 0x06011692 RID: 71314 RVA: 0x00520FF7 File Offset: 0x0051F1F7
	[NullableContext(1)]
	public QuestLockPreview(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011693 RID: 71315 RVA: 0x00521000 File Offset: 0x0051F200
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

	// Token: 0x06011694 RID: 71316 RVA: 0x0052108A File Offset: 0x0051F28A
	protected override void OnBeforeCreate()
	{
		this.OccupationInfo = (this.OpenParam as List<IOccupationInfo>);
	}

	// Token: 0x06011695 RID: 71317 RVA: 0x0052109D File Offset: 0x0051F29D
	protected override void OnStart()
	{
		base.OnStart();
		this.InitLockReasonItems();
	}

	// Token: 0x06011696 RID: 71318 RVA: 0x005210AC File Offset: 0x0051F2AC
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

	// Token: 0x040098E3 RID: 39139
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<IOccupationInfo> OccupationInfo;

	// Token: 0x040098E4 RID: 39140
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<LockReasonItem> LockReasonItems;

	// Token: 0x02007E25 RID: 32293
	private class EChildComponent
	{
		// Token: 0x04028D4F RID: 167247
		public const int SubTitleText = 0;

		// Token: 0x04028D50 RID: 167248
		public const int Content = 1;

		// Token: 0x04028D51 RID: 167249
		public const int LockReasonItem = 2;
	}
}
