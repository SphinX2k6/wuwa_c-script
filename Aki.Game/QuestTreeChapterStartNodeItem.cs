using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020026AF RID: 9903
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeChapterStartNodeItem : UiPanelBase
{
	// Token: 0x0601448E RID: 83086 RVA: 0x0051FFA0 File Offset: 0x0051E1A0
	public QuestTreeChapterStartNodeItem(QuestTreeChapterData data)
	{
		this.Data = data;
	}

	// Token: 0x0601448F RID: 83087 RVA: 0x0051FFB8 File Offset: 0x0051E1B8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISizeControlByOther));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06014490 RID: 83088 RVA: 0x005200A8 File Offset: 0x0051E2A8
	protected override UniTask OnBeforeStartAsync()
	{
		QuestTreeChapterStartNodeItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<QuestTreeChapterStartNodeItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014491 RID: 83089 RVA: 0x005200EC File Offset: 0x0051E2EC
	protected override void OnStart()
	{
		this.OriginalAdditionalHeight = base.GetUiSizeControlByOther(5).GetAdditionalHeight();
		this.LayoutChildren = new GenericLayout<QuestTreeNodeItemBase<List<QuestTreeNodeData>>, List<QuestTreeNodeData>>(base.GetVerticalLayout(4), () => QuestTreeNodeItemFactory.Instance.CreateLogicalNodeItem<List<QuestTreeNodeData>>(EQuestTreeNodeType.Container), null, false, true);
		this.RefreshChildren();
		Ticker ticker = TickSystem.Instance.Add(new Action<float>(this.OnTick), "QuestTreeChapterStartNodeItem", ETickingGroup.TG_PrePhysics, true, 0, true);
		this.TickId = ((ticker != null) ? ticker.Id : -1);
	}

	// Token: 0x06014492 RID: 83090 RVA: 0x00520176 File Offset: 0x0051E376
	protected override void OnBeforeDestroy()
	{
		if (this.TickId != -1)
		{
			TickSystem.Instance.Remove(this.TickId);
			this.TickId = -1;
		}
		QuestTreeModel.Instance.ViewModelChapter.RemoveHeightBalanceValue(this.Data.Id);
	}

	// Token: 0x06014493 RID: 83091 RVA: 0x005201B4 File Offset: 0x0051E3B4
	public UniTask RefreshByData(QuestTreeChapterData data)
	{
		QuestTreeChapterStartNodeItem.<RefreshByData>d__10 <RefreshByData>d__;
		<RefreshByData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshByData>d__.<>4__this = this;
		<RefreshByData>d__.data = data;
		<RefreshByData>d__.<>1__state = -1;
		<RefreshByData>d__.<>t__builder.Start<QuestTreeChapterStartNodeItem.<RefreshByData>d__10>(ref <RefreshByData>d__);
		return <RefreshByData>d__.<>t__builder.Task;
	}

	// Token: 0x06014494 RID: 83092 RVA: 0x00520200 File Offset: 0x0051E400
	private UniTask RefreshInfo()
	{
		QuestTreeChapterStartNodeItem.<RefreshInfo>d__11 <RefreshInfo>d__;
		<RefreshInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshInfo>d__.<>4__this = this;
		<RefreshInfo>d__.<>1__state = -1;
		<RefreshInfo>d__.<>t__builder.Start<QuestTreeChapterStartNodeItem.<RefreshInfo>d__11>(ref <RefreshInfo>d__);
		return <RefreshInfo>d__.<>t__builder.Task;
	}

	// Token: 0x06014495 RID: 83093 RVA: 0x00520244 File Offset: 0x0051E444
	private void RefreshChildren()
	{
		List<List<QuestTreeNodeData>> noParentNodeGroupList = this.Data.GetNoParentNodeGroupList();
		this.LayoutChildren.RefreshByData(noParentNodeGroupList, null, false);
		base.GetItem(3).SetUIActive(noParentNodeGroupList.Count > 0);
	}

	// Token: 0x06014496 RID: 83094 RVA: 0x00520280 File Offset: 0x0051E480
	private void OnTick(float deltaTime)
	{
		UUIVerticalLayout verticalLayout = base.GetVerticalLayout(4);
		QuestTreeChapterViewModel viewModelChapter = QuestTreeModel.Instance.ViewModelChapter;
		int id = -1;
		float valueTop = 0f;
		float? num;
		if (verticalLayout == null)
		{
			num = null;
		}
		else
		{
			UUIItem rootComponent = verticalLayout.GetRootComponent();
			num = ((rootComponent != null) ? new float?(rootComponent.GetHeight()) : null);
		}
		float? num2 = num;
		viewModelChapter.RecordHeightBalanceValue(id, valueTop, num2.GetValueOrDefault());
		UUISizeControlByOther uiSizeControlByOther = base.GetUiSizeControlByOther(5);
		QuestTreeNodeItemBase<List<QuestTreeNodeData>> layoutItemByIndex = this.LayoutChildren.GetLayoutItemByIndex(this.LayoutChildren.GetDatas().Count - 1);
		if (layoutItemByIndex == null)
		{
			return;
		}
		uiSizeControlByOther.SetAdditionalHeight(this.OriginalAdditionalHeight - layoutItemByIndex.GetAdditionalHeight());
	}

	// Token: 0x04009890 RID: 39056
	private GenericLayout<QuestTreeNodeItemBase<List<QuestTreeNodeData>>, List<QuestTreeNodeData>> LayoutChildren;

	// Token: 0x04009891 RID: 39057
	private int TickId = -1;

	// Token: 0x04009892 RID: 39058
	private float OriginalAdditionalHeight;

	// Token: 0x04009893 RID: 39059
	private QuestTreeChapterData Data;

	// Token: 0x02008CEE RID: 36078
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402DB98 RID: 187288
		public const int TextureArea = 0;

		// Token: 0x0402DB99 RID: 187289
		public const int TextArea = 1;

		// Token: 0x0402DB9A RID: 187290
		public const int TextAreaSub = 2;

		// Token: 0x0402DB9B RID: 187291
		public const int ItemChildrenAreaRoot = 3;

		// Token: 0x0402DB9C RID: 187292
		public const int LayoutChildrenArea = 4;

		// Token: 0x0402DB9D RID: 187293
		public const int SizeLine = 5;
	}
}
