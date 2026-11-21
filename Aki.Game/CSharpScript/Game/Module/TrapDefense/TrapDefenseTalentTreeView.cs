using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A80 RID: 14976
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseTalentTreeView : UiTickViewBase
	{
		// Token: 0x0602678C RID: 157580 RVA: 0x00AC73BA File Offset: 0x00AC55BA
		public TrapDefenseTalentTreeView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602678D RID: 157581 RVA: 0x00AC73C4 File Offset: 0x00AC55C4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602678E RID: 157582 RVA: 0x00AC7538 File Offset: 0x00AC5738
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseTalentTreeView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseTalentTreeView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602678F RID: 157583 RVA: 0x00AC757C File Offset: 0x00AC577C
		protected override void OnTick(float deltaTime)
		{
			if (!this.TryingScrollToNode)
			{
				return;
			}
			TrapDefenseTalentTreeNodeData selectedNode = TrapDefenseModel.Instance.ViewModelTalentTree.SelectedNode;
			if (selectedNode == null)
			{
				return;
			}
			if (this.CanScrollToNodeNow(selectedNode))
			{
				this.TryingScrollToNode = false;
				this.ScrollToNode(selectedNode, false);
			}
		}

		// Token: 0x06026790 RID: 157584 RVA: 0x00AC75C0 File Offset: 0x00AC57C0
		protected override void OnStart()
		{
			TrapDefenseModel.Instance.ViewModelTalentTree.AddDelegateOnNodeSelect(new Action<TrapDefenseTalentTreeNodeData, bool>(this.OnNodeSelect));
			TrapDefenseTalentTreeNodeData defaultSelectNode = this.GetDefaultSelectNode();
			TrapDefenseModel.Instance.ViewModelTalentTree.SelectNode(defaultSelectNode, true);
		}

		// Token: 0x06026791 RID: 157585 RVA: 0x00AC7600 File Offset: 0x00AC5800
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.TrapDefenseTalentTreeUpdate, new Action(this.OnDataUpdate));
		}

		// Token: 0x06026792 RID: 157586 RVA: 0x00AC761E File Offset: 0x00AC581E
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.TrapDefenseTalentTreeUpdate, new Action(this.OnDataUpdate));
		}

		// Token: 0x06026793 RID: 157587 RVA: 0x00AC763C File Offset: 0x00AC583C
		protected override void OnBeforeDestroy()
		{
			TrapDefenseModel.Instance.ViewModelTalentTree.RemoveDelegateOnNodeSelect(new Action<TrapDefenseTalentTreeNodeData, bool>(this.OnNodeSelect));
			TrapDefenseModel.Instance.ViewModelTalentTree.OnViewClose();
		}

		// Token: 0x06026794 RID: 157588 RVA: 0x00AC7668 File Offset: 0x00AC5868
		private UniTask RefreshTree()
		{
			TrapDefenseTalentTreeView.<RefreshTree>d__19 <RefreshTree>d__;
			<RefreshTree>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTree>d__.<>4__this = this;
			<RefreshTree>d__.<>1__state = -1;
			<RefreshTree>d__.<>t__builder.Start<TrapDefenseTalentTreeView.<RefreshTree>d__19>(ref <RefreshTree>d__);
			return <RefreshTree>d__.<>t__builder.Task;
		}

		// Token: 0x06026795 RID: 157589 RVA: 0x00AC76AC File Offset: 0x00AC58AC
		private void RefreshBottomPanel()
		{
			TrapDefenseTalentTreeNodeData selectedNode = TrapDefenseModel.Instance.ViewModelTalentTree.SelectedNode;
			if (selectedNode == null)
			{
				this.ConfirmBtn.SetActive(false);
				base.GetItem(4).SetUIActive(false);
				base.GetItem(5).SetUIActive(false);
				return;
			}
			bool flag = TrapDefenseModel.Instance.TalentTreeData.CanNodeUnlock(selectedNode);
			bool flag2 = TrapDefenseModel.Instance.TalentTreeData.CanNodeAfford(selectedNode);
			base.GetItem(4).SetUIActive(!flag && !selectedNode.IsUnlock);
			base.GetItem(5).SetUIActive(selectedNode.IsUnlock);
			List<ICostData> costData = selectedNode.GetCostData();
			this.ConfirmBtn.SetEnableClick(flag2);
			this.ConfirmBtn.SetActive(!selectedNode.IsUnlock && flag);
			if (costData.Count > 0)
			{
				base.GetText(2).SetText(costData[0].Cost.ToString(), true);
			}
			UUIText text = base.GetText(2);
			UUIItem uuiitem = text;
			bool bUseChangeColor = !flag2;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}

		// Token: 0x06026796 RID: 157590 RVA: 0x00AC77BC File Offset: 0x00AC59BC
		private void RefreshDetailPanel(bool playSeq = true)
		{
			this.SeqPlayer.StopSequenceByKey("Switch", false, false);
			if (playSeq)
			{
				this.SeqPlayer.PlayLevelSequenceByName("Switch", false, null, false);
			}
			this.NodeDetailPanel.Refresh();
		}

		// Token: 0x06026797 RID: 157591 RVA: 0x00AC7804 File Offset: 0x00AC5A04
		private void RefreshCurrency()
		{
			int talentTreeCurrencyItemId = TrapDefenseConfig.Instance.GetTalentTreeCurrencyItemId();
			int remainPoints = TrapDefenseModel.Instance.TalentTreeData.RemainPoints;
			this.CostBtn.RefreshTemp(talentTreeCurrencyItemId, remainPoints.ToString());
		}

		// Token: 0x06026798 RID: 157592 RVA: 0x00AC7840 File Offset: 0x00AC5A40
		private UniTask ScrollToNode(TrapDefenseTalentTreeNodeData node, bool tween = false)
		{
			TrapDefenseTalentTreeView.<ScrollToNode>d__23 <ScrollToNode>d__;
			<ScrollToNode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ScrollToNode>d__.<>4__this = this;
			<ScrollToNode>d__.node = node;
			<ScrollToNode>d__.tween = tween;
			<ScrollToNode>d__.<>1__state = -1;
			<ScrollToNode>d__.<>t__builder.Start<TrapDefenseTalentTreeView.<ScrollToNode>d__23>(ref <ScrollToNode>d__);
			return <ScrollToNode>d__.<>t__builder.Task;
		}

		// Token: 0x06026799 RID: 157593 RVA: 0x00AC7894 File Offset: 0x00AC5A94
		private TrapDefenseTalentTreeNodeData GetDefaultSelectNode()
		{
			ITrapDefenseTalentTreeViewParam trapDefenseTalentTreeViewParam = this.OpenParam as ITrapDefenseTalentTreeViewParam;
			TrapDefenseTalentTreeNodeData trapDefenseTalentTreeNodeData = null;
			if (trapDefenseTalentTreeViewParam != null && trapDefenseTalentTreeViewParam.TalentFuncType != null)
			{
				trapDefenseTalentTreeNodeData = TrapDefenseModel.Instance.TalentTreeData.GetDefaultSelectNodeByFuncType(trapDefenseTalentTreeViewParam.TalentFuncType.Value);
			}
			if (trapDefenseTalentTreeViewParam == null || trapDefenseTalentTreeNodeData == null)
			{
				trapDefenseTalentTreeNodeData = TrapDefenseModel.Instance.TalentTreeData.GetDefaultSelectNode();
			}
			return trapDefenseTalentTreeNodeData;
		}

		// Token: 0x0602679A RID: 157594 RVA: 0x00AC78F8 File Offset: 0x00AC5AF8
		private bool CanScrollToNodeNow(TrapDefenseTalentTreeNodeData node)
		{
			int num = Math.Max(node.Row - 1, 1);
			UUIItem itemByKey = this.ScrollTalents.GetItemByKey(num);
			return itemByKey != null && itemByKey.IsValid() && (num <= 1 || itemByKey.RelativeLocation.Y < -162f);
		}

		// Token: 0x0602679B RID: 157595 RVA: 0x00AC794C File Offset: 0x00AC5B4C
		private void OnConfirmUnlock(int index)
		{
			TrapDefenseTalentTreeNodeData selectedNode = TrapDefenseModel.Instance.ViewModelTalentTree.SelectedNode;
			if (selectedNode == null)
			{
				return;
			}
			TrapDefenseController.Instance.RequestTrapDefenseTechUnlock(selectedNode.Id);
		}

		// Token: 0x0602679C RID: 157596 RVA: 0x00AC797E File Offset: 0x00AC5B7E
		private void OnNodeSelect(TrapDefenseTalentTreeNodeData node, bool shouldScroll)
		{
			this.RefreshBottomPanel();
			this.RefreshDetailPanel(true);
			if (shouldScroll)
			{
				this.TryingScrollToNode = true;
			}
		}

		// Token: 0x0602679D RID: 157597 RVA: 0x00AC7997 File Offset: 0x00AC5B97
		private void OnDataUpdate()
		{
			this.RefreshTree();
			this.RefreshBottomPanel();
			this.RefreshDetailPanel(false);
			this.RefreshCurrency();
		}

		// Token: 0x0401516B RID: 86379
		private const int GRID_START_POS = -162;

		// Token: 0x0401516C RID: 86380
		private PopupCaptionItem Caption;

		// Token: 0x0401516D RID: 86381
		private ButtonItem ConfirmBtn;

		// Token: 0x0401516E RID: 86382
		private TrapDefenseTalentTreeDetailPanel NodeDetailPanel;

		// Token: 0x0401516F RID: 86383
		private CommonCurrencyItem CostBtn;

		// Token: 0x04015170 RID: 86384
		private GenericScrollViewNew<TrapDefenseTalentTreeRowItem, TrapDefenseTalentTreeRowData> ScrollTalents;

		// Token: 0x04015171 RID: 86385
		private TrapDefenseTalentLockItem LockPanel;

		// Token: 0x04015172 RID: 86386
		private TrapDefenseTalentUnlockItem UnlockPanel;

		// Token: 0x04015173 RID: 86387
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x04015174 RID: 86388
		private bool TryingScrollToNode;

		// Token: 0x02009674 RID: 38516
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0402EFA0 RID: 192416
			public const int ItemCaption = 0;

			// Token: 0x0402EFA1 RID: 192417
			public const int ItemDetailPanel = 1;

			// Token: 0x0402EFA2 RID: 192418
			public const int TextCost = 2;

			// Token: 0x0402EFA3 RID: 192419
			public const int ItemConfirmBtn = 3;

			// Token: 0x0402EFA4 RID: 192420
			public const int ItemLockPanel = 4;

			// Token: 0x0402EFA5 RID: 192421
			public const int ItemUnlockPanel = 5;

			// Token: 0x0402EFA6 RID: 192422
			public const int LayoutContent = 6;

			// Token: 0x0402EFA7 RID: 192423
			public const int ItemRow = 7;

			// Token: 0x0402EFA8 RID: 192424
			public const int ScrollTalents = 8;

			// Token: 0x0402EFA9 RID: 192425
			public const int TextUpgrade = 9;
		}
	}
}
