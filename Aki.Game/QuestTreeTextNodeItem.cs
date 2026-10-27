using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020026B7 RID: 9911
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class QuestTreeTextNodeItem : QuestTreeNodeItemBase<QuestTreeNodeData>
{
	// Token: 0x17001A55 RID: 6741
	// (get) Token: 0x06014507 RID: 83207 RVA: 0x00523208 File Offset: 0x00521408
	public override EQuestTreeNodeType Type
	{
		get
		{
			return EQuestTreeNodeType.Text;
		}
	}

	// Token: 0x06014508 RID: 83208 RVA: 0x0052320C File Offset: 0x0052140C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 25;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
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
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06014509 RID: 83209 RVA: 0x005235BC File Offset: 0x005217BC
	protected override void OnStart()
	{
		this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		base.GetItem(8).SetUIActive(false);
		QuestTreeModel.Instance.ViewModelChapter.AddOnSelectedDataChange(new Action<QuestTreeNodeData>(this.OnSelectedDataChange));
		QuestTreeModel.Instance.ViewModelChapter.AddOnLocatingNode(new Action<QuestTreeNodeData, bool>(this.OnLocateToNode));
		QuestTreeModel.Instance.ViewModelChapter.AddOnUpdateNode(new Action(this.OnUpdateNode));
		EventSystem.Instance.Add(EEventName.QuestTreeNodeDataUpdate, new Action<QuestTreeNodeData>(this.OnDataUpdate));
	}

	// Token: 0x0601450A RID: 83210 RVA: 0x00523654 File Offset: 0x00521854
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.QuestTreeNodeDataUpdate, new Action<QuestTreeNodeData>(this.OnDataUpdate));
		QuestTreeModel.Instance.ViewModelChapter.RemoveOnUpdateNode(new Action(this.OnUpdateNode));
		QuestTreeModel.Instance.ViewModelChapter.RemoveOnLocatingNode(new Action<QuestTreeNodeData, bool>(this.OnLocateToNode));
		QuestTreeModel.Instance.ViewModelChapter.RemoveOnSelectedDataChange(new Action<QuestTreeNodeData>(this.OnSelectedDataChange));
	}

	// Token: 0x0601450B RID: 83211 RVA: 0x005236D0 File Offset: 0x005218D0
	public override UniTask CreateSelf(UUIItem parent)
	{
		QuestTreeTextNodeItem.<CreateSelf>d__9 <CreateSelf>d__;
		<CreateSelf>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateSelf>d__.<>4__this = this;
		<CreateSelf>d__.parent = parent;
		<CreateSelf>d__.<>1__state = -1;
		<CreateSelf>d__.<>t__builder.Start<QuestTreeTextNodeItem.<CreateSelf>d__9>(ref <CreateSelf>d__);
		return <CreateSelf>d__.<>t__builder.Task;
	}

	// Token: 0x0601450C RID: 83212 RVA: 0x0052371B File Offset: 0x0052191B
	public override void UpdateData(QuestTreeNodeData data)
	{
		this.Data = data;
		this.RefreshInfo(data);
		this.RefreshLines(data);
		this.RefreshChildren(data);
	}

	// Token: 0x0601450D RID: 83213 RVA: 0x0052373A File Offset: 0x0052193A
	public override void Refresh(QuestTreeNodeData data, bool isSelected, int gridIndex)
	{
		this.UpdateData(data);
	}

	// Token: 0x0601450E RID: 83214 RVA: 0x00523744 File Offset: 0x00521944
	public override float GetAdditionalHeight()
	{
		QuestTreeNodeData nextQuestNode = this.Data.NextQuestNode;
		if (nextQuestNode != null && nextQuestNode.Config.NodeType == 3 && this.Child != null)
		{
			return (this.Child as QuestTreeNodeItemBase<QuestTreeNodeData>).GetAdditionalHeight() + base.GetExtendToggle(0).GetRootComponent().GetHeight();
		}
		return 0f;
	}

	// Token: 0x0601450F RID: 83215 RVA: 0x005237A8 File Offset: 0x005219A8
	protected override void LocateSelf(bool tween = true)
	{
		UUIItem rootComponent = base.GetExtendToggle(0).GetRootComponent();
		QuestTreeNodeLocatingHelper locatingHelper = QuestTreeModel.Instance.ViewModelChapter.LocatingHelper;
		if (locatingHelper != null)
		{
			locatingHelper.LocateToNode(rootComponent, tween, false);
		}
		if (this.Data.IsTracking || this.Data.DisplayState == EQuestTreeNodeState.Available)
		{
			this.SeqPlayer.PlayLevelSequenceByName("Jumpy", false, null, false);
		}
	}

	// Token: 0x06014510 RID: 83216 RVA: 0x00523815 File Offset: 0x00521A15
	[NullableContext(2)]
	public override UUIItem GetGuideFocusUiItem()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return null;
		}
		return extendToggle.GetRootComponent();
	}

	// Token: 0x06014511 RID: 83217 RVA: 0x0052382C File Offset: 0x00521A2C
	private void RefreshInfo(QuestTreeNodeData data)
	{
		EQuestTreeNodeState displayState = data.DisplayState;
		base.GetItem(4).SetUIActive(!data.IsTracking && displayState == EQuestTreeNodeState.Locked);
		base.GetItem(1).SetUIActive(!data.IsTracking && displayState == EQuestTreeNodeState.Finished);
		base.GetItem(2).SetUIActive(!data.IsTracking && displayState == EQuestTreeNodeState.Available);
		base.GetItem(3).SetUIActive(data.IsTracking);
		base.GetItem(5).SetUIActive(!data.IsTracking && displayState == EQuestTreeNodeState.InProgress);
		this.SetSpriteByPath(data.TypeIconPath, base.GetSprite(6), false, null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), data.Config.Name, Array.Empty<object>());
	}

	// Token: 0x06014512 RID: 83218 RVA: 0x00523900 File Offset: 0x00521B00
	private UniTask RefreshChildren(QuestTreeNodeData data)
	{
		QuestTreeTextNodeItem.<RefreshChildren>d__16 <RefreshChildren>d__;
		<RefreshChildren>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshChildren>d__.<>4__this = this;
		<RefreshChildren>d__.data = data;
		<RefreshChildren>d__.<>1__state = -1;
		<RefreshChildren>d__.<>t__builder.Start<QuestTreeTextNodeItem.<RefreshChildren>d__16>(ref <RefreshChildren>d__);
		return <RefreshChildren>d__.<>t__builder.Task;
	}

	// Token: 0x06014513 RID: 83219 RVA: 0x0052394C File Offset: 0x00521B4C
	private void RefreshLines(QuestTreeNodeData data)
	{
		this.HideAllLines();
		bool flag;
		if (data.PreQuestNodes.Count != 0)
		{
			QuestTreeNodeData questTreeNodeData = data.PreQuestNodes[0];
			flag = (questTreeNodeData != null && questTreeNodeData.Config.QuestType == 1);
		}
		else
		{
			flag = true;
		}
		bool flag2 = flag;
		base.GetItem(9).SetUIActive(true);
		base.GetItem(10).SetUIActive(data.Config.SortOrder < 0);
		base.GetItem(11).SetUIActive(data.Config.SortOrder > 0 && flag2 && data.BelongedNode == null);
		base.GetItem(12).SetUIActive(data.BelongedNode != null);
		UUIItem item = base.GetItem(24);
		bool uiactive;
		if (data.IsInPredecessorUnion() && data.IsLastNodeOfPredecessorUnion())
		{
			QuestTreeNodeData nextQuestNode = data.NextQuestNode;
			if (nextQuestNode == null || nextQuestNode.State > EQuestTreeNodeState.None)
			{
				uiactive = (data.State == EQuestTreeNodeState.Finished);
				goto IL_E5;
			}
		}
		uiactive = false;
		IL_E5:
		item.SetUIActive(uiactive);
		UUIItem item2 = base.GetItem(23);
		bool uiactive2;
		if (data.IsInPredecessorUnion() && !data.IsFirstNodeOfPredecessorUnion() && !data.IsLastNodeOfPredecessorUnion())
		{
			QuestTreeNodeData nextQuestNode2 = data.NextQuestNode;
			if (nextQuestNode2 == null || nextQuestNode2.State > EQuestTreeNodeState.None)
			{
				uiactive2 = (data.State == EQuestTreeNodeState.Finished);
				goto IL_12D;
			}
		}
		uiactive2 = false;
		IL_12D:
		item2.SetUIActive(uiactive2);
	}

	// Token: 0x06014514 RID: 83220 RVA: 0x00523A8C File Offset: 0x00521C8C
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	private UniTask<IQuestTreeNodeItem> AttachNextNodeParallel(QuestTreeNodeData nextNode)
	{
		QuestTreeTextNodeItem.<AttachNextNodeParallel>d__18 <AttachNextNodeParallel>d__;
		<AttachNextNodeParallel>d__.<>t__builder = AsyncUniTaskMethodBuilder<IQuestTreeNodeItem>.Create();
		<AttachNextNodeParallel>d__.<>4__this = this;
		<AttachNextNodeParallel>d__.nextNode = nextNode;
		<AttachNextNodeParallel>d__.<>1__state = -1;
		<AttachNextNodeParallel>d__.<>t__builder.Start<QuestTreeTextNodeItem.<AttachNextNodeParallel>d__18>(ref <AttachNextNodeParallel>d__);
		return <AttachNextNodeParallel>d__.<>t__builder.Task;
	}

	// Token: 0x06014515 RID: 83221 RVA: 0x00523AD8 File Offset: 0x00521CD8
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	private UniTask<IQuestTreeNodeItem> AttachNextNodeDown(QuestTreeNodeData nextNode)
	{
		QuestTreeTextNodeItem.<AttachNextNodeDown>d__19 <AttachNextNodeDown>d__;
		<AttachNextNodeDown>d__.<>t__builder = AsyncUniTaskMethodBuilder<IQuestTreeNodeItem>.Create();
		<AttachNextNodeDown>d__.<>4__this = this;
		<AttachNextNodeDown>d__.nextNode = nextNode;
		<AttachNextNodeDown>d__.<>1__state = -1;
		<AttachNextNodeDown>d__.<>t__builder.Start<QuestTreeTextNodeItem.<AttachNextNodeDown>d__19>(ref <AttachNextNodeDown>d__);
		return <AttachNextNodeDown>d__.<>t__builder.Task;
	}

	// Token: 0x06014516 RID: 83222 RVA: 0x00523B24 File Offset: 0x00521D24
	private void HideAllLines()
	{
		base.GetItem(10).SetUIActive(false);
		base.GetItem(11).SetUIActive(false);
		base.GetItem(12).SetUIActive(false);
		base.GetItem(24).SetUIActive(false);
		base.GetItem(23).SetUIActive(false);
		base.GetItem(15).SetUIActive(false);
		base.GetItem(16).SetUIActive(false);
		base.GetItem(17).SetUIActive(false);
		base.GetItem(18).SetUIActive(false);
		base.GetItem(13).SetUIActive(false);
		base.GetItem(14).SetUIActive(false);
		base.GetItem(19).SetUIActive(false);
		base.GetItem(20).SetUIActive(false);
		base.GetItem(21).SetUIActive(false);
		base.GetItem(22).SetUIActive(false);
	}

	// Token: 0x06014517 RID: 83223 RVA: 0x00523C03 File Offset: 0x00521E03
	private void OnClickToggle(EToggleState _)
	{
		QuestTreeModel.Instance.ViewModelChapter.SelectData(this.Data);
		QuestTreeController.Instance.ReportClickNode(this.Data);
		QuestTreeController.Instance.OpenNodeDetailView(this.Data);
	}

	// Token: 0x06014518 RID: 83224 RVA: 0x00523C3A File Offset: 0x00521E3A
	[NullableContext(2)]
	private void OnSelectedDataChange(QuestTreeNodeData data)
	{
		if (data != this.Data)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			return;
		}
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		this.LocateSelf(true);
	}

	// Token: 0x06014519 RID: 83225 RVA: 0x00523C6F File Offset: 0x00521E6F
	private void OnDataUpdate(QuestTreeNodeData data)
	{
		if (data != this.Data)
		{
			return;
		}
		this.RefreshInfo(data);
	}

	// Token: 0x0601451A RID: 83226 RVA: 0x00523C82 File Offset: 0x00521E82
	[NullableContext(2)]
	private void OnLocateToNode(QuestTreeNodeData data, bool tween)
	{
		if (data != this.Data)
		{
			return;
		}
		if (this.Data.BelongedNode != null)
		{
			return;
		}
		this.LocateSelf(tween);
		UiNavigationNewController.Instance.SetNavigationFocusForView(this.RootItem, true, false, false);
	}

	// Token: 0x0601451B RID: 83227 RVA: 0x00523CB7 File Offset: 0x00521EB7
	private void OnUpdateNode()
	{
		if (this.Data != null)
		{
			this.RefreshInfo(this.Data);
		}
	}

	// Token: 0x040098CA RID: 39114
	private QuestTreeNodeData Data;

	// Token: 0x040098CB RID: 39115
	[Nullable(2)]
	private IQuestTreeNodeItem Child;

	// Token: 0x040098CC RID: 39116
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x02008D09 RID: 36105
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402DC53 RID: 187475
		public const int Toggle = 0;

		// Token: 0x0402DC54 RID: 187476
		public const int ItemFinish = 1;

		// Token: 0x0402DC55 RID: 187477
		public const int ItemAvailable = 2;

		// Token: 0x0402DC56 RID: 187478
		public const int ItemTracking = 3;

		// Token: 0x0402DC57 RID: 187479
		public const int ItemLock = 4;

		// Token: 0x0402DC58 RID: 187480
		public const int ItemInProgress = 5;

		// Token: 0x0402DC59 RID: 187481
		public const int SpriteTypeIcon = 6;

		// Token: 0x0402DC5A RID: 187482
		public const int TextName = 7;

		// Token: 0x0402DC5B RID: 187483
		public const int ItemNew = 8;

		// Token: 0x0402DC5C RID: 187484
		public const int ItemLeftLineRoot = 9;

		// Token: 0x0402DC5D RID: 187485
		public const int ItemLeftLineDown = 10;

		// Token: 0x0402DC5E RID: 187486
		public const int ItemLeftLineUpLong = 11;

		// Token: 0x0402DC5F RID: 187487
		public const int ItemLeftLineUpShort = 12;

		// Token: 0x0402DC60 RID: 187488
		public const int ItemNextNodeAreaDownForSeries = 13;

		// Token: 0x0402DC61 RID: 187489
		public const int ItemNextNodeParentDownForSeries = 14;

		// Token: 0x0402DC62 RID: 187490
		public const int ItemNextNodeAreaDownForPicture = 15;

		// Token: 0x0402DC63 RID: 187491
		public const int ItemNextNodeParentDownForPicture = 16;

		// Token: 0x0402DC64 RID: 187492
		public const int ItemNextNodeAreaDownForText = 17;

		// Token: 0x0402DC65 RID: 187493
		public const int ItemNextNodeParentDownForText = 18;

		// Token: 0x0402DC66 RID: 187494
		public const int ItemNextNodeAreaParallelForPicture = 19;

		// Token: 0x0402DC67 RID: 187495
		public const int ItemNextNodeParentParallelForPicture = 20;

		// Token: 0x0402DC68 RID: 187496
		public const int ItemNextNodeAreaParallelForNonPicture = 21;

		// Token: 0x0402DC69 RID: 187497
		public const int ItemNextNodeParentParallelForNonPicture = 22;

		// Token: 0x0402DC6A RID: 187498
		public const int ItemRightLineInGroup = 23;

		// Token: 0x0402DC6B RID: 187499
		public const int ItemRightLineUpLast = 24;
	}
}
