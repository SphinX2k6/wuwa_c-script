using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020007F9 RID: 2041
[NullableContext(1)]
[Nullable(0)]
public class MoonChasingMemoryDetailView : UiViewBase
{
	// Token: 0x06005CF1 RID: 23793 RVA: 0x001DE174 File Offset: 0x001DC374
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x06005CF2 RID: 23794 RVA: 0x001DE1FA File Offset: 0x001DC3FA
	public MoonChasingMemoryDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06005CF3 RID: 23795 RVA: 0x001DE204 File Offset: 0x001DC404
	protected override void OnStart()
	{
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.CloseSelf));
		this.ContentLayoutA = new GenericLayout<MemoryContentItemA, IMemoryItemData>(base.GetGridLayout(1), new Func<MemoryContentItemA>(this.OnCreateContentA), null, false, true);
		this.ContentLayoutB = new GenericLayout<MemoryContentItemB, IMemoryItemData>(base.GetHorizontalLayout(3), new Func<MemoryContentItemB>(this.OnCreateContentB), null, false, true);
	}

	// Token: 0x06005CF4 RID: 23796 RVA: 0x001DE280 File Offset: 0x001DC480
	protected override void OnBeforeShow()
	{
		List<IMemoryItemData> list = this.OpenParam as List<IMemoryItemData>;
		if (list == null)
		{
			return;
		}
		List<IMemoryItemData> list2 = new List<IMemoryItemData>();
		foreach (IMemoryItemData memoryItemData in list)
		{
			if (memoryItemData.Classify == EMemoryClassify.Normal)
			{
				list2.Add(memoryItemData);
			}
		}
		this.ContentLayoutA.RefreshByData(list2, null, false);
		List<IMemoryItemData> list3 = new List<IMemoryItemData>();
		foreach (IMemoryItemData memoryItemData2 in list)
		{
			if (memoryItemData2.Classify == EMemoryClassify.Important)
			{
				list3.Add(memoryItemData2);
			}
		}
		this.ContentLayoutB.RefreshByData(list3, null, false);
	}

	// Token: 0x06005CF5 RID: 23797 RVA: 0x001DE35C File Offset: 0x001DC55C
	private MemoryContentItemA OnCreateContentA()
	{
		return new MemoryContentItemA();
	}

	// Token: 0x06005CF6 RID: 23798 RVA: 0x001DE363 File Offset: 0x001DC563
	private MemoryContentItemB OnCreateContentB()
	{
		return new MemoryContentItemB();
	}

	// Token: 0x04003DD9 RID: 15833
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003DDA RID: 15834
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MemoryContentItemA, IMemoryItemData> ContentLayoutA;

	// Token: 0x04003DDB RID: 15835
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MemoryContentItemB, IMemoryItemData> ContentLayoutB;

	// Token: 0x02006B31 RID: 27441
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x0402341B RID: 144411
		public const int Caption = 0;

		// Token: 0x0402341C RID: 144412
		public const int ContentLayoutA = 1;

		// Token: 0x0402341D RID: 144413
		public const int ContentA = 2;

		// Token: 0x0402341E RID: 144414
		public const int ContentLayoutB = 3;

		// Token: 0x0402341F RID: 144415
		public const int ContentB = 4;
	}
}
