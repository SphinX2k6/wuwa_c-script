using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Roulette.View;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001EB9 RID: 7865
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseRouletteMainViewProxy : RouletteMainViewProxyBase
{
	// Token: 0x060136DD RID: 79581 RVA: 0x005AAC1C File Offset: 0x005A8E1C
	protected override UniTask OnBeforeStartAsync()
	{
		TrapDefenseRouletteMainViewProxy.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseRouletteMainViewProxy.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060136DE RID: 79582 RVA: 0x005AAC60 File Offset: 0x005A8E60
	protected override void OnBeforeShow()
	{
		if (!Info.Instance.IsInTouch())
		{
			string actionName = base.GetActionName();
			if (!InputDistributeModel.Instance.IsActionInPress(actionName))
			{
				this.View.CloseSelf(true);
			}
		}
	}

	// Token: 0x060136DF RID: 79583 RVA: 0x005AAC99 File Offset: 0x005A8E99
	protected override bool OnCanOpenView()
	{
		return RouletteModel.Instance.IsExploreRouletteOpen(true) && TrapDefenseModel.Instance.GetCurInstToLevelDataHasShop();
	}

	// Token: 0x060136E0 RID: 79584 RVA: 0x005AACB4 File Offset: 0x005A8EB4
	protected override RouletteComponentMain OnGetRouletteComponent()
	{
		if (this.RouletteComponentExplore == null)
		{
			this.RouletteComponentExplore = new RouletteComponentMainExplore();
			this.RouletteComponentExplore.RegisterViewProxy(this);
			this.RouletteComponentExplore.SetRootActor(this.View.RouletteUiItem.GetOwner(), true);
		}
		return this.RouletteComponentExplore;
	}

	// Token: 0x060136E1 RID: 79585 RVA: 0x005AAD02 File Offset: 0x005A8F02
	protected override ERouletteType OnGetRouletteType()
	{
		return ERouletteType.Explore;
	}

	// Token: 0x060136E2 RID: 79586 RVA: 0x005AAD05 File Offset: 0x005A8F05
	protected override bool OnGetCanSwitchType()
	{
		return false;
	}

	// Token: 0x060136E3 RID: 79587 RVA: 0x005AAD08 File Offset: 0x005A8F08
	protected override bool OnGetPanelSwitchOpen()
	{
		return false;
	}

	// Token: 0x060136E4 RID: 79588 RVA: 0x005AAD0B File Offset: 0x005A8F0B
	protected override bool OnGetCanOpenAssembly(ERouletteType rouletteType)
	{
		return false;
	}

	// Token: 0x060136E5 RID: 79589 RVA: 0x005AAD0E File Offset: 0x005A8F0E
	[return: Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	protected override List<ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>> OnGetExploreRouletteDataMap()
	{
		return this.TrapDefenseExploreRouletteMap;
	}

	// Token: 0x060136E6 RID: 79590 RVA: 0x005AAD18 File Offset: 0x005A8F18
	protected override int OnGetRouletteGridId(int index, ERouletteGridType gridType)
	{
		RouletteListDataBase rouletteListDataBase;
		if (RouletteModel.Instance.RouletteListDataMap.TryGetValue(this.RouletteType, out rouletteListDataBase))
		{
			return rouletteListDataBase.GetRouletteGridId(index, gridType, true).GetValueOrDefault();
		}
		return 0;
	}

	// Token: 0x060136E7 RID: 79591 RVA: 0x005AAD51 File Offset: 0x005A8F51
	protected override string OnGetActionName()
	{
		return "塔防轮盘";
	}

	// Token: 0x060136E8 RID: 79592 RVA: 0x005AAD58 File Offset: 0x005A8F58
	protected override void OnRefreshTips()
	{
		RouletteComponentMainExplore rouletteComponentExplore = this.RouletteComponentExplore;
		RouletteGridBase rouletteGridBase = (rouletteComponentExplore != null) ? rouletteComponentExplore.GetCurrentGrid() : null;
		if (rouletteGridBase != null && rouletteGridBase.Data != null && rouletteGridBase.Data.Id > 0)
		{
			int id = rouletteGridBase.Data.Id;
			TrapDefenseItem? trapDefenseItemByExploreToolId = TrapDefenseConfig.Instance.GetTrapDefenseItemByExploreToolId(id);
			this.ItemTips.RefreshTips((trapDefenseItemByExploreToolId != null) ? trapDefenseItemByExploreToolId.GetValueOrDefault().Desc : null);
			return;
		}
		this.ItemTips.RefreshTips(null);
	}

	// Token: 0x060136E9 RID: 79593 RVA: 0x005AADDC File Offset: 0x005A8FDC
	protected override void OnDestroy()
	{
		if (this.RouletteComponentExplore != null)
		{
			this.RouletteComponentExplore.Destroy(null);
			this.RouletteComponentExplore = null;
		}
	}

	// Token: 0x0400A63A RID: 42554
	[Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	private readonly List<ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>> TrapDefenseExploreRouletteMap = new List<ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>>
	{
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			1
		}, ERouletteComponentNode.RouletteItem1, ERouletteGridType.Explore),
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			2
		}, ERouletteComponentNode.RouletteItem2, ERouletteGridType.Explore),
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			3
		}, ERouletteComponentNode.RouletteItem3, ERouletteGridType.Explore),
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			4
		}, ERouletteComponentNode.RouletteItem4, ERouletteGridType.Explore),
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			5
		}, ERouletteComponentNode.RouletteItem5, ERouletteGridType.Explore),
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			6
		}, ERouletteComponentNode.RouletteItem6, ERouletteGridType.Explore),
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			7
		}, ERouletteComponentNode.RouletteItem7, ERouletteGridType.Explore),
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			8
		}, ERouletteComponentNode.RouletteItem8, ERouletteGridType.Explore)
	};

	// Token: 0x0400A63B RID: 42555
	[Nullable(2)]
	private RouletteComponentMainExplore RouletteComponentExplore;

	// Token: 0x0400A63C RID: 42556
	protected TrapDefenseRouletteItemTips ItemTips;
}
