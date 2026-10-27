using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020026B3 RID: 9907
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class QuestTreeNodeContainer : QuestTreeNodeItemBase<List<QuestTreeNodeData>>
{
	// Token: 0x17001A52 RID: 6738
	// (get) Token: 0x060144C7 RID: 83143 RVA: 0x005215CC File Offset: 0x0051F7CC
	public override EQuestTreeNodeType Type
	{
		get
		{
			return EQuestTreeNodeType.Container;
		}
	}

	// Token: 0x060144C8 RID: 83144 RVA: 0x005215D0 File Offset: 0x0051F7D0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060144C9 RID: 83145 RVA: 0x005216C0 File Offset: 0x0051F8C0
	protected override void OnStart()
	{
		this.ItemPool = new QuestTreeNodeItemPool(base.Loader, base.GetItem(2));
		Ticker ticker = TickSystem.Instance.Add(new Action<float>(this.OnTick), "QuestTreePictureNodeItem", ETickingGroup.TG_PrePhysics, true, 0, true);
		this.TickId = ((ticker != null) ? ticker.Id : -1);
	}

	// Token: 0x060144CA RID: 83146 RVA: 0x00521716 File Offset: 0x0051F916
	protected override void OnBeforeDestroy()
	{
		this.ItemPool.ClearPool();
		if (this.TickId != -1)
		{
			TickSystem.Instance.Remove(this.TickId);
			this.TickId = -1;
		}
	}

	// Token: 0x060144CB RID: 83147 RVA: 0x00521744 File Offset: 0x0051F944
	public override void Refresh(List<QuestTreeNodeData> data, bool isSelected, int gridIndex)
	{
		this.RefreshAsync(data, isSelected, gridIndex);
	}

	// Token: 0x060144CC RID: 83148 RVA: 0x00521750 File Offset: 0x0051F950
	public override UniTask RefreshAsync(List<QuestTreeNodeData> data, bool isSelected, int gridIndex)
	{
		QuestTreeNodeContainer.<RefreshAsync>d__11 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.data = data;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<QuestTreeNodeContainer.<RefreshAsync>d__11>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060144CD RID: 83149 RVA: 0x0052179B File Offset: 0x0051F99B
	public override void UpdateData(QuestTreeNodeData data)
	{
	}

	// Token: 0x060144CE RID: 83150 RVA: 0x0052179D File Offset: 0x0051F99D
	public override void UpdateDataList(List<QuestTreeNodeData> data)
	{
	}

	// Token: 0x060144CF RID: 83151 RVA: 0x005217A0 File Offset: 0x0051F9A0
	public override UniTask CreateSelf(UUIItem parent)
	{
		QuestTreeNodeContainer.<CreateSelf>d__14 <CreateSelf>d__;
		<CreateSelf>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateSelf>d__.<>4__this = this;
		<CreateSelf>d__.parent = parent;
		<CreateSelf>d__.<>1__state = -1;
		<CreateSelf>d__.<>t__builder.Start<QuestTreeNodeContainer.<CreateSelf>d__14>(ref <CreateSelf>d__);
		return <CreateSelf>d__.<>t__builder.Task;
	}

	// Token: 0x060144D0 RID: 83152 RVA: 0x005217EC File Offset: 0x0051F9EC
	public override float GetAdditionalHeight()
	{
		IQuestTreeNodeItem itemByData = this.ItemPool.GetItemByData(this.Data[0]);
		if (itemByData != null)
		{
			return Math.Max(itemByData.GetAdditionalHeight() - base.GetItem(2).GetHeight(), 0f);
		}
		return 0f;
	}

	// Token: 0x060144D1 RID: 83153 RVA: 0x00521838 File Offset: 0x0051FA38
	private void OnTick(float delta)
	{
		float additionalHeight = this.GetAdditionalHeight();
		this.LayoutMargin.Bottom = additionalHeight;
		base.GetVerticalLayout(0).SetPadding(this.LayoutMargin);
	}

	// Token: 0x040098B3 RID: 39091
	private QuestTreeNodeItemPool ItemPool;

	// Token: 0x040098B4 RID: 39092
	private List<QuestTreeNodeData> Data = new List<QuestTreeNodeData>();

	// Token: 0x040098B5 RID: 39093
	private int TickId = -1;

	// Token: 0x040098B6 RID: 39094
	private FMargin LayoutMargin = new FMargin(0f, 0f, 0f, 0f);

	// Token: 0x02008CFD RID: 36093
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402DBE8 RID: 187368
		public const int LayoutSelf = 0;

		// Token: 0x0402DBE9 RID: 187369
		public const int ItemLayoutUp = 1;

		// Token: 0x0402DBEA RID: 187370
		public const int ItemContainer = 2;

		// Token: 0x0402DBEB RID: 187371
		public const int ItemLineTypeA = 3;

		// Token: 0x0402DBEC RID: 187372
		public const int ItemLineTypeB = 4;

		// Token: 0x0402DBED RID: 187373
		public const int ItemLayoutDown = 5;
	}
}
