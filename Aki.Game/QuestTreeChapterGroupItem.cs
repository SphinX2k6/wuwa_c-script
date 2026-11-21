using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001BA8 RID: 7080
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class QuestTreeChapterGroupItem : GridProxyAbstract<List<QuestTreeChapterData>>
{
	// Token: 0x06011A31 RID: 72241 RVA: 0x00533D78 File Offset: 0x00531F78
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

	// Token: 0x06011A32 RID: 72242 RVA: 0x00533F10 File Offset: 0x00532110
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

	// Token: 0x06011A33 RID: 72243 RVA: 0x00533FFA File Offset: 0x005321FA
	public override void Refresh(List<QuestTreeChapterData> data, bool isSelected, int gridIndex)
	{
		this.RefreshImp(data);
	}

	// Token: 0x06011A34 RID: 72244 RVA: 0x00534004 File Offset: 0x00532204
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

	// Token: 0x06011A35 RID: 72245 RVA: 0x00534050 File Offset: 0x00532250
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

	// Token: 0x06011A36 RID: 72246 RVA: 0x0053409C File Offset: 0x0053229C
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

	// Token: 0x04009A37 RID: 39479
	private List<QuestTreeChapterData> DataList = new List<QuestTreeChapterData>();

	// Token: 0x04009A38 RID: 39480
	private List<UUIItem> AttachPointList = new List<UUIItem>();

	// Token: 0x04009A39 RID: 39481
	private List<UUIItem> ContainerList = new List<UUIItem>();

	// Token: 0x04009A3A RID: 39482
	private List<QuestTreeChapterItem> ChapterItemList = new List<QuestTreeChapterItem>();

	// Token: 0x02007EA4 RID: 32420
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04028FE5 RID: 167909
		public const int ItemSelf = 0;

		// Token: 0x04028FE6 RID: 167910
		public const int ItemContainer1 = 1;

		// Token: 0x04028FE7 RID: 167911
		public const int ItemContainer2 = 2;

		// Token: 0x04028FE8 RID: 167912
		public const int ItemContainer3 = 3;

		// Token: 0x04028FE9 RID: 167913
		public const int ItemContainer4 = 4;

		// Token: 0x04028FEA RID: 167914
		public const int ItemContainer5 = 5;

		// Token: 0x04028FEB RID: 167915
		public const int ItemAttachPoint1 = 6;

		// Token: 0x04028FEC RID: 167916
		public const int ItemAttachPoint2 = 7;

		// Token: 0x04028FED RID: 167917
		public const int ItemAttachPoint3 = 8;

		// Token: 0x04028FEE RID: 167918
		public const int ItemAttachPoint4 = 9;

		// Token: 0x04028FEF RID: 167919
		public const int ItemAttachPoint5 = 10;
	}
}
