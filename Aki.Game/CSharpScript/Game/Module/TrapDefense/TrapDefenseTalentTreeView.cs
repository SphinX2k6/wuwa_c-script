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
	// Token: 0x02004AD8 RID: 19160
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseTalentTreeView : UiTickViewBase
	{
		// Token: 0x060319FC RID: 203260 RVA: 0x00B83406 File Offset: 0x00B81606
		public TrapDefenseTalentTreeView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060319FD RID: 203261 RVA: 0x00B83410 File Offset: 0x00B81610
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

		// Token: 0x060319FE RID: 203262 RVA: 0x00B83584 File Offset: 0x00B81784
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseTalentTreeView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseTalentTreeView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060319FF RID: 203263 RVA: 0x00B835C8 File Offset: 0x00B817C8
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

		// Token: 0x06031A00 RID: 203264 RVA: 0x00B8360C File Offset: 0x00B8180C
		protected override void OnStart()
		{
			TrapDefenseModel.Instance.ViewModelTalentTree.AddDelegateOnNodeSelect(new Action<TrapDefenseTalentTreeNodeData, bool>(this.OnNodeSelect));
			TrapDefenseTalentTreeNodeData defaultSelectNode = this.GetDefaultSelectNode();
			TrapDefenseModel.Instance.ViewModelTalentTree.SelectNode(defaultSelectNode, true);
		}

		// Token: 0x06031A01 RID: 203265 RVA: 0x00B8364C File Offset: 0x00B8184C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.TrapDefenseTalentTreeUpdate, new Action(this.OnDataUpdate));
		}

		// Token: 0x06031A02 RID: 203266 RVA: 0x00B8366A File Offset: 0x00B8186A
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.TrapDefenseTalentTreeUpdate, new Action(this.OnDataUpdate));
		}

		// Token: 0x06031A03 RID: 203267 RVA: 0x00B83688 File Offset: 0x00B81888
		protected override void OnBeforeDestroy()
		{
			TrapDefenseModel.Instance.ViewModelTalentTree.RemoveDelegateOnNodeSelect(new Action<TrapDefenseTalentTreeNodeData, bool>(this.OnNodeSelect));
			TrapDefenseModel.Instance.ViewModelTalentTree.OnViewClose();
		}

		// Token: 0x06031A04 RID: 203268 RVA: 0x00B836B4 File Offset: 0x00B818B4
		private UniTask RefreshTree()
		{
			TrapDefenseTalentTreeView.<RefreshTree>d__19 <RefreshTree>d__;
			<RefreshTree>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTree>d__.<>4__this = this;
			<RefreshTree>d__.<>1__state = -1;
			<RefreshTree>d__.<>t__builder.Start<TrapDefenseTalentTreeView.<RefreshTree>d__19>(ref <RefreshTree>d__);
			return <RefreshTree>d__.<>t__builder.Task;
		}

		// Token: 0x06031A05 RID: 203269 RVA: 0x00B836F8 File Offset: 0x00B818F8
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

		// Token: 0x06031A06 RID: 203270 RVA: 0x00B83808 File Offset: 0x00B81A08
		private void RefreshDetailPanel(bool playSeq = true)
		{
			this.SeqPlayer.StopSequenceByKey("Switch", false, false);
			if (playSeq)
			{
				this.SeqPlayer.PlayLevelSequenceByName("Switch", false, null, false);
			}
			this.NodeDetailPanel.Refresh();
		}

		// Token: 0x06031A07 RID: 203271 RVA: 0x00B83850 File Offset: 0x00B81A50
		private void RefreshCurrency()
		{
			int talentTreeCurrencyItemId = TrapDefenseConfig.Instance.GetTalentTreeCurrencyItemId();
			int remainPoints = TrapDefenseModel.Instance.TalentTreeData.RemainPoints;
			this.CostBtn.RefreshTemp(talentTreeCurrencyItemId, remainPoints.ToString());
		}

		// Token: 0x06031A08 RID: 203272 RVA: 0x00B8388C File Offset: 0x00B81A8C
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

		// Token: 0x06031A09 RID: 203273 RVA: 0x00B838E0 File Offset: 0x00B81AE0
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

		// Token: 0x06031A0A RID: 203274 RVA: 0x00B83944 File Offset: 0x00B81B44
		private bool CanScrollToNodeNow(TrapDefenseTalentTreeNodeData node)
		{
			int num = Math.Max(node.Row - 1, 1);
			UUIItem itemByKey = this.ScrollTalents.GetItemByKey(num);
			return itemByKey != null && itemByKey.IsValid() && (num <= 1 || itemByKey.RelativeLocation.Y < -162f);
		}

		// Token: 0x06031A0B RID: 203275 RVA: 0x00B83998 File Offset: 0x00B81B98
		private void OnConfirmUnlock(int index)
		{
			TrapDefenseTalentTreeNodeData selectedNode = TrapDefenseModel.Instance.ViewModelTalentTree.SelectedNode;
			if (selectedNode == null)
			{
				return;
			}
			TrapDefenseController.Instance.RequestTrapDefenseTechUnlock(selectedNode.Id);
		}

		// Token: 0x06031A0C RID: 203276 RVA: 0x00B839CA File Offset: 0x00B81BCA
		private void OnNodeSelect(TrapDefenseTalentTreeNodeData node, bool shouldScroll)
		{
			this.RefreshBottomPanel();
			this.RefreshDetailPanel(true);
			if (shouldScroll)
			{
				this.TryingScrollToNode = true;
			}
		}

		// Token: 0x06031A0D RID: 203277 RVA: 0x00B839E3 File Offset: 0x00B81BE3
		private void OnDataUpdate()
		{
			this.RefreshTree();
			this.RefreshBottomPanel();
			this.RefreshDetailPanel(false);
			this.RefreshCurrency();
		}

		// Token: 0x0401A819 RID: 108569
		private const int GRID_START_POS = -162;

		// Token: 0x0401A81A RID: 108570
		private PopupCaptionItem Caption;

		// Token: 0x0401A81B RID: 108571
		private ButtonItem ConfirmBtn;

		// Token: 0x0401A81C RID: 108572
		private TrapDefenseTalentTreeDetailPanel NodeDetailPanel;

		// Token: 0x0401A81D RID: 108573
		private CommonCurrencyItem CostBtn;

		// Token: 0x0401A81E RID: 108574
		private GenericScrollViewNew<TrapDefenseTalentTreeRowItem, TrapDefenseTalentTreeRowData> ScrollTalents;

		// Token: 0x0401A81F RID: 108575
		private TrapDefenseTalentLockItem LockPanel;

		// Token: 0x0401A820 RID: 108576
		private TrapDefenseTalentUnlockItem UnlockPanel;

		// Token: 0x0401A821 RID: 108577
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0401A822 RID: 108578
		private bool TryingScrollToNode;

		// Token: 0x0200AC54 RID: 44116
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040345EF RID: 214511
			public const int ItemCaption = 0;

			// Token: 0x040345F0 RID: 214512
			public const int ItemDetailPanel = 1;

			// Token: 0x040345F1 RID: 214513
			public const int TextCost = 2;

			// Token: 0x040345F2 RID: 214514
			public const int ItemConfirmBtn = 3;

			// Token: 0x040345F3 RID: 214515
			public const int ItemLockPanel = 4;

			// Token: 0x040345F4 RID: 214516
			public const int ItemUnlockPanel = 5;

			// Token: 0x040345F5 RID: 214517
			public const int LayoutContent = 6;

			// Token: 0x040345F6 RID: 214518
			public const int ItemRow = 7;

			// Token: 0x040345F7 RID: 214519
			public const int ScrollTalents = 8;

			// Token: 0x040345F8 RID: 214520
			public const int TextUpgrade = 9;
		}
	}
}
