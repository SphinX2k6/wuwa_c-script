using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020026BD RID: 9917
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class QuestTreeChapterGroupItem : GridProxyAbstract<List<QuestTreeChapterData>>
{
	// Token: 0x0601454F RID: 83279 RVA: 0x00525040 File Offset: 0x00523240
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
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
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06014550 RID: 83280 RVA: 0x005251D8 File Offset: 0x005233D8
	protected override void OnStart()
	{
		this.AttachPointList.Add(base.GetItem(6));
		this.AttachPointList.Add(base.GetItem(7));
		this.AttachPointList.Add(base.GetItem(8));
		this.AttachPointList.Add(base.GetItem(9));
		this.AttachPointList.Add(base.GetItem(10));
		this.ContainerList.Add(base.GetItem(1));
		this.ContainerList.Add(base.GetItem(2));
		this.ContainerList.Add(base.GetItem(3));
		this.ContainerList.Add(base.GetItem(4));
		this.ContainerList.Add(base.GetItem(5));
		this.ChapterItemList = new List<QuestTreeChapterItem>();
		for (int i = 0; i < 5; i++)
		{
			this.ChapterItemList.Add(new QuestTreeChapterItem());
		}
	}

	// Token: 0x06014551 RID: 83281 RVA: 0x005252C2 File Offset: 0x005234C2
	public override void Refresh(List<QuestTreeChapterData> data, bool isSelected, int gridIndex)
	{
		this.RefreshImp(data);
	}

	// Token: 0x06014552 RID: 83282 RVA: 0x005252CC File Offset: 0x005234CC
	public override UniTask RefreshAsync(List<QuestTreeChapterData> data, bool isSelected, int gridIndex)
	{
		QuestTreeChapterGroupItem.<RefreshAsync>d__8 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.data = data;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<QuestTreeChapterGroupItem.<RefreshAsync>d__8>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014553 RID: 83283 RVA: 0x00525318 File Offset: 0x00523518
	private UniTask RefreshImp(List<QuestTreeChapterData> data)
	{
		QuestTreeChapterGroupItem.<RefreshImp>d__9 <RefreshImp>d__;
		<RefreshImp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshImp>d__.<>4__this = this;
		<RefreshImp>d__.data = data;
		<RefreshImp>d__.<>1__state = -1;
		<RefreshImp>d__.<>t__builder.Start<QuestTreeChapterGroupItem.<RefreshImp>d__9>(ref <RefreshImp>d__);
		return <RefreshImp>d__.<>t__builder.Task;
	}

	// Token: 0x06014554 RID: 83284 RVA: 0x00525364 File Offset: 0x00523564
	[NullableContext(2)]
	public UUIItem GetChapterToggleUiItem(int chapterId)
	{
		foreach (QuestTreeChapterItem questTreeChapterItem in this.ChapterItemList)
		{
			if (questTreeChapterItem.GetChapterId() == chapterId)
			{
				return questTreeChapterItem.GetToggleUiItem();
			}
		}
		return null;
	}

	// Token: 0x040098DF RID: 39135
	private List<QuestTreeChapterData> DataList = new List<QuestTreeChapterData>();

	// Token: 0x040098E0 RID: 39136
	private List<UUIItem> AttachPointList = new List<UUIItem>();

	// Token: 0x040098E1 RID: 39137
	private List<UUIItem> ContainerList = new List<UUIItem>();

	// Token: 0x040098E2 RID: 39138
	private List<QuestTreeChapterItem> ChapterItemList = new List<QuestTreeChapterItem>();

	// Token: 0x02008D1B RID: 36123
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402DCCE RID: 187598
		public const int ItemSelf = 0;

		// Token: 0x0402DCCF RID: 187599
		public const int ItemContainer1 = 1;

		// Token: 0x0402DCD0 RID: 187600
		public const int ItemContainer2 = 2;

		// Token: 0x0402DCD1 RID: 187601
		public const int ItemContainer3 = 3;

		// Token: 0x0402DCD2 RID: 187602
		public const int ItemContainer4 = 4;

		// Token: 0x0402DCD3 RID: 187603
		public const int ItemContainer5 = 5;

		// Token: 0x0402DCD4 RID: 187604
		public const int ItemAttachPoint1 = 6;

		// Token: 0x0402DCD5 RID: 187605
		public const int ItemAttachPoint2 = 7;

		// Token: 0x0402DCD6 RID: 187606
		public const int ItemAttachPoint3 = 8;

		// Token: 0x0402DCD7 RID: 187607
		public const int ItemAttachPoint4 = 9;

		// Token: 0x0402DCD8 RID: 187608
		public const int ItemAttachPoint5 = 10;
	}
}
