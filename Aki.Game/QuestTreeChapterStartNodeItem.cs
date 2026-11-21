using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B9A RID: 7066
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeChapterStartNodeItem : UiPanelBase
{
	// Token: 0x06011970 RID: 72048 RVA: 0x0052ECD8 File Offset: 0x0052CED8
	public QuestTreeChapterStartNodeItem(QuestTreeChapterData data)
	{
		this.Data = data;
	}

	// Token: 0x06011971 RID: 72049 RVA: 0x0052ECF0 File Offset: 0x0052CEF0
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

	// Token: 0x06011972 RID: 72050 RVA: 0x0052EDE0 File Offset: 0x0052CFE0
	protected override UniTask OnBeforeStartAsync()
	{
		QuestTreeChapterStartNodeItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<QuestTreeChapterStartNodeItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011973 RID: 72051 RVA: 0x0052EE24 File Offset: 0x0052D024
	protected override void OnStart()
	{
		this.OriginalAdditionalHeight = base.GetUiSizeControlByOther(5).GetAdditionalHeight();
		this.LayoutChildren = new GenericLayout<QuestTreeNodeItemBase<List<QuestTreeNodeData>>, List<QuestTreeNodeData>>(base.GetVerticalLayout(4), () => QuestTreeNodeItemFactory.Instance.CreateLogicalNodeItem<List<QuestTreeNodeData>>(EQuestTreeNodeType.Container), null, false, true);
		this.RefreshChildren();
		Ticker ticker = TickSystem.Instance.Add(new Action<float>(this.OnTick), "QuestTreeChapterStartNodeItem", ETickingGroup.TG_PrePhysics, true, 0, true);
		this.TickId = ((ticker != null) ? ticker.Id : -1);
	}

	// Token: 0x06011974 RID: 72052 RVA: 0x0052EEAE File Offset: 0x0052D0AE
	protected override void OnBeforeDestroy()
	{
		if (this.TickId != -1)
		{
			TickSystem.Instance.Remove(this.TickId);
			this.TickId = -1;
		}
		QuestTreeModel.Instance.ViewModelChapter.RemoveHeightBalanceValue(this.Data.Id);
	}

	// Token: 0x06011975 RID: 72053 RVA: 0x0052EEEC File Offset: 0x0052D0EC
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

	// Token: 0x06011976 RID: 72054 RVA: 0x0052EF38 File Offset: 0x0052D138
	private UniTask RefreshInfo()
	{
		QuestTreeChapterStartNodeItem.<RefreshInfo>d__11 <RefreshInfo>d__;
		<RefreshInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshInfo>d__.<>4__this = this;
		<RefreshInfo>d__.<>1__state = -1;
		<RefreshInfo>d__.<>t__builder.Start<QuestTreeChapterStartNodeItem.<RefreshInfo>d__11>(ref <RefreshInfo>d__);
		return <RefreshInfo>d__.<>t__builder.Task;
	}

	// Token: 0x06011977 RID: 72055 RVA: 0x0052EF7C File Offset: 0x0052D17C
	private void RefreshChildren()
	{
		List<List<QuestTreeNodeData>> noParentNodeGroupList = this.Data.GetNoParentNodeGroupList();
		this.LayoutChildren.RefreshByData(noParentNodeGroupList, null, false);
		base.GetItem(3).SetUIActive(noParentNodeGroupList.Count > 0);
	}

	// Token: 0x06011978 RID: 72056 RVA: 0x0052EFB8 File Offset: 0x0052D1B8
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

	// Token: 0x040099E8 RID: 39400
	private GenericLayout<QuestTreeNodeItemBase<List<QuestTreeNodeData>>, List<QuestTreeNodeData>> LayoutChildren;

	// Token: 0x040099E9 RID: 39401
	private int TickId = -1;

	// Token: 0x040099EA RID: 39402
	private float OriginalAdditionalHeight;

	// Token: 0x040099EB RID: 39403
	private QuestTreeChapterData Data;

	// Token: 0x02007E77 RID: 32375
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04028EAF RID: 167599
		public const int TextureArea = 0;

		// Token: 0x04028EB0 RID: 167600
		public const int TextArea = 1;

		// Token: 0x04028EB1 RID: 167601
		public const int TextAreaSub = 2;

		// Token: 0x04028EB2 RID: 167602
		public const int ItemChildrenAreaRoot = 3;

		// Token: 0x04028EB3 RID: 167603
		public const int LayoutChildrenArea = 4;

		// Token: 0x04028EB4 RID: 167604
		public const int SizeLine = 5;
	}
}
