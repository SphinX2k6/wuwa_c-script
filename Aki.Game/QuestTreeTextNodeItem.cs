using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001BA2 RID: 7074
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class QuestTreeTextNodeItem : QuestTreeNodeItemBase<QuestTreeNodeData>
{
	// Token: 0x17001A8D RID: 6797
	// (get) Token: 0x060119E9 RID: 72169 RVA: 0x00531F40 File Offset: 0x00530140
	public override EQuestTreeNodeType Type
	{
		get
		{
			return EQuestTreeNodeType.Text;
		}
	}

	// Token: 0x060119EA RID: 72170 RVA: 0x00531F44 File Offset: 0x00530144
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

	// Token: 0x060119EB RID: 72171 RVA: 0x005322F4 File Offset: 0x005304F4
	protected override void OnStart()
	{
		this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		base.GetItem(8).SetUIActive(false);
		QuestTreeModel.Instance.ViewModelChapter.AddOnSelectedDataChange(new Action<QuestTreeNodeData>(this.OnSelectedDataChange));
		QuestTreeModel.Instance.ViewModelChapter.AddOnLocatingNode(new Action<QuestTreeNodeData, bool>(this.OnLocateToNode));
		QuestTreeModel.Instance.ViewModelChapter.AddOnUpdateNode(new Action(this.OnUpdateNode));
		EventSystem.Instance.Add(EEventName.QuestTreeNodeDataUpdate, new Action<QuestTreeNodeData>(this.OnDataUpdate));
	}

	// Token: 0x060119EC RID: 72172 RVA: 0x0053238C File Offset: 0x0053058C
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.QuestTreeNodeDataUpdate, new Action<QuestTreeNodeData>(this.OnDataUpdate));
		QuestTreeModel.Instance.ViewModelChapter.RemoveOnUpdateNode(new Action(this.OnUpdateNode));
		QuestTreeModel.Instance.ViewModelChapter.RemoveOnLocatingNode(new Action<QuestTreeNodeData, bool>(this.OnLocateToNode));
		QuestTreeModel.Instance.ViewModelChapter.RemoveOnSelectedDataChange(new Action<QuestTreeNodeData>(this.OnSelectedDataChange));
	}

	// Token: 0x060119ED RID: 72173 RVA: 0x00532408 File Offset: 0x00530608
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

	// Token: 0x060119EE RID: 72174 RVA: 0x00532453 File Offset: 0x00530653
	public override void UpdateData(QuestTreeNodeData data)
	{
		this.Data = data;
		this.RefreshInfo(data);
		this.RefreshLines(data);
		this.RefreshChildren(data);
	}

	// Token: 0x060119EF RID: 72175 RVA: 0x00532472 File Offset: 0x00530672
	public override void Refresh(QuestTreeNodeData data, bool isSelected, int gridIndex)
	{
		this.UpdateData(data);
	}

	// Token: 0x060119F0 RID: 72176 RVA: 0x0053247C File Offset: 0x0053067C
	public override float GetAdditionalHeight()
	{
		QuestTreeNodeData nextQuestNode = this.Data.NextQuestNode;
		if (nextQuestNode != null && nextQuestNode.Config.NodeType == 3 && this.Child != null)
		{
			return (this.Child as QuestTreeNodeItemBase<QuestTreeNodeData>).GetAdditionalHeight() + base.GetExtendToggle(0).GetRootComponent().GetHeight();
		}
		return 0f;
	}

	// Token: 0x060119F1 RID: 72177 RVA: 0x005324E0 File Offset: 0x005306E0
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

	// Token: 0x060119F2 RID: 72178 RVA: 0x0053254D File Offset: 0x0053074D
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

	// Token: 0x060119F3 RID: 72179 RVA: 0x00532564 File Offset: 0x00530764
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

	// Token: 0x060119F4 RID: 72180 RVA: 0x00532638 File Offset: 0x00530838
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

	// Token: 0x060119F5 RID: 72181 RVA: 0x00532684 File Offset: 0x00530884
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

	// Token: 0x060119F6 RID: 72182 RVA: 0x005327C4 File Offset: 0x005309C4
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

	// Token: 0x060119F7 RID: 72183 RVA: 0x00532810 File Offset: 0x00530A10
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

	// Token: 0x060119F8 RID: 72184 RVA: 0x0053285C File Offset: 0x00530A5C
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

	// Token: 0x060119F9 RID: 72185 RVA: 0x0053293B File Offset: 0x00530B3B
	private void OnClickToggle(EToggleState _)
	{
		QuestTreeModel.Instance.ViewModelChapter.SelectData(this.Data);
		QuestTreeController.Instance.ReportClickNode(this.Data);
		QuestTreeController.Instance.OpenNodeDetailView(this.Data);
	}

	// Token: 0x060119FA RID: 72186 RVA: 0x00532972 File Offset: 0x00530B72
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

	// Token: 0x060119FB RID: 72187 RVA: 0x005329A7 File Offset: 0x00530BA7
	private void OnDataUpdate(QuestTreeNodeData data)
	{
		if (data != this.Data)
		{
			return;
		}
		this.RefreshInfo(data);
	}

	// Token: 0x060119FC RID: 72188 RVA: 0x005329BA File Offset: 0x00530BBA
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

	// Token: 0x060119FD RID: 72189 RVA: 0x005329EF File Offset: 0x00530BEF
	private void OnUpdateNode()
	{
		if (this.Data != null)
		{
			this.RefreshInfo(this.Data);
		}
	}

	// Token: 0x04009A22 RID: 39458
	private QuestTreeNodeData Data;

	// Token: 0x04009A23 RID: 39459
	[Nullable(2)]
	private IQuestTreeNodeItem Child;

	// Token: 0x04009A24 RID: 39460
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x02007E92 RID: 32402
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04028F6A RID: 167786
		public const int Toggle = 0;

		// Token: 0x04028F6B RID: 167787
		public const int ItemFinish = 1;

		// Token: 0x04028F6C RID: 167788
		public const int ItemAvailable = 2;

		// Token: 0x04028F6D RID: 167789
		public const int ItemTracking = 3;

		// Token: 0x04028F6E RID: 167790
		public const int ItemLock = 4;

		// Token: 0x04028F6F RID: 167791
		public const int ItemInProgress = 5;

		// Token: 0x04028F70 RID: 167792
		public const int SpriteTypeIcon = 6;

		// Token: 0x04028F71 RID: 167793
		public const int TextName = 7;

		// Token: 0x04028F72 RID: 167794
		public const int ItemNew = 8;

		// Token: 0x04028F73 RID: 167795
		public const int ItemLeftLineRoot = 9;

		// Token: 0x04028F74 RID: 167796
		public const int ItemLeftLineDown = 10;

		// Token: 0x04028F75 RID: 167797
		public const int ItemLeftLineUpLong = 11;

		// Token: 0x04028F76 RID: 167798
		public const int ItemLeftLineUpShort = 12;

		// Token: 0x04028F77 RID: 167799
		public const int ItemNextNodeAreaDownForSeries = 13;

		// Token: 0x04028F78 RID: 167800
		public const int ItemNextNodeParentDownForSeries = 14;

		// Token: 0x04028F79 RID: 167801
		public const int ItemNextNodeAreaDownForPicture = 15;

		// Token: 0x04028F7A RID: 167802
		public const int ItemNextNodeParentDownForPicture = 16;

		// Token: 0x04028F7B RID: 167803
		public const int ItemNextNodeAreaDownForText = 17;

		// Token: 0x04028F7C RID: 167804
		public const int ItemNextNodeParentDownForText = 18;

		// Token: 0x04028F7D RID: 167805
		public const int ItemNextNodeAreaParallelForPicture = 19;

		// Token: 0x04028F7E RID: 167806
		public const int ItemNextNodeParentParallelForPicture = 20;

		// Token: 0x04028F7F RID: 167807
		public const int ItemNextNodeAreaParallelForNonPicture = 21;

		// Token: 0x04028F80 RID: 167808
		public const int ItemNextNodeParentParallelForNonPicture = 22;

		// Token: 0x04028F81 RID: 167809
		public const int ItemRightLineInGroup = 23;

		// Token: 0x04028F82 RID: 167810
		public const int ItemRightLineUpLast = 24;
	}
}
