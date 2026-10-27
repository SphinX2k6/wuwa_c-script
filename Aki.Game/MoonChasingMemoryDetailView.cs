using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001345 RID: 4933
[NullableContext(1)]
[Nullable(0)]
public class MoonChasingMemoryDetailView : UiViewBase
{
	// Token: 0x06008956 RID: 35158 RVA: 0x001D5308 File Offset: 0x001D3508
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

	// Token: 0x06008957 RID: 35159 RVA: 0x001D538E File Offset: 0x001D358E
	public MoonChasingMemoryDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06008958 RID: 35160 RVA: 0x001D5398 File Offset: 0x001D3598
	protected override void OnStart()
	{
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.CloseSelf));
		this.ContentLayoutA = new GenericLayout<MemoryContentItemA, IMemoryItemData>(base.GetGridLayout(1), new Func<MemoryContentItemA>(this.OnCreateContentA), null, false, true);
		this.ContentLayoutB = new GenericLayout<MemoryContentItemB, IMemoryItemData>(base.GetHorizontalLayout(3), new Func<MemoryContentItemB>(this.OnCreateContentB), null, false, true);
	}

	// Token: 0x06008959 RID: 35161 RVA: 0x001D5414 File Offset: 0x001D3614
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

	// Token: 0x0600895A RID: 35162 RVA: 0x001D54F0 File Offset: 0x001D36F0
	private MemoryContentItemA OnCreateContentA()
	{
		return new MemoryContentItemA();
	}

	// Token: 0x0600895B RID: 35163 RVA: 0x001D54F7 File Offset: 0x001D36F7
	private MemoryContentItemB OnCreateContentB()
	{
		return new MemoryContentItemB();
	}

	// Token: 0x04003D41 RID: 15681
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003D42 RID: 15682
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MemoryContentItemA, IMemoryItemData> ContentLayoutA;

	// Token: 0x04003D43 RID: 15683
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MemoryContentItemB, IMemoryItemData> ContentLayoutB;

	// Token: 0x020079A7 RID: 31143
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x040280EE RID: 164078
		public const int Caption = 0;

		// Token: 0x040280EF RID: 164079
		public const int ContentLayoutA = 1;

		// Token: 0x040280F0 RID: 164080
		public const int ContentA = 2;

		// Token: 0x040280F1 RID: 164081
		public const int ContentLayoutB = 3;

		// Token: 0x040280F2 RID: 164082
		public const int ContentB = 4;
	}
}
