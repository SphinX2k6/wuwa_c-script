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

// Token: 0x0200293E RID: 10558
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseRouletteMainViewProxy : RouletteMainViewProxyBase
{
	// Token: 0x06015CD8 RID: 89304 RVA: 0x0057FBE4 File Offset: 0x0057DDE4
	protected override UniTask OnBeforeStartAsync()
	{
		TrapDefenseRouletteMainViewProxy.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseRouletteMainViewProxy.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015CD9 RID: 89305 RVA: 0x0057FC28 File Offset: 0x0057DE28
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

	// Token: 0x06015CDA RID: 89306 RVA: 0x0057FC61 File Offset: 0x0057DE61
	protected override bool OnCanOpenView()
	{
		return RouletteModel.Instance.IsExploreRouletteOpen(true) && TrapDefenseModel.Instance.GetCurInstToLevelDataHasShop();
	}

	// Token: 0x06015CDB RID: 89307 RVA: 0x0057FC7C File Offset: 0x0057DE7C
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

	// Token: 0x06015CDC RID: 89308 RVA: 0x0057FCCA File Offset: 0x0057DECA
	protected override ERouletteType OnGetRouletteType()
	{
		return ERouletteType.Explore;
	}

	// Token: 0x06015CDD RID: 89309 RVA: 0x0057FCCD File Offset: 0x0057DECD
	protected override bool OnGetCanSwitchType()
	{
		return false;
	}

	// Token: 0x06015CDE RID: 89310 RVA: 0x0057FCD0 File Offset: 0x0057DED0
	protected override bool OnGetPanelSwitchOpen()
	{
		return false;
	}

	// Token: 0x06015CDF RID: 89311 RVA: 0x0057FCD3 File Offset: 0x0057DED3
	protected override bool OnGetCanOpenAssembly(ERouletteType rouletteType)
	{
		return false;
	}

	// Token: 0x06015CE0 RID: 89312 RVA: 0x0057FCD6 File Offset: 0x0057DED6
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

	// Token: 0x06015CE1 RID: 89313 RVA: 0x0057FCE0 File Offset: 0x0057DEE0
	protected override int OnGetRouletteGridId(int index, ERouletteGridType gridType)
	{
		RouletteListDataBase rouletteListDataBase;
		if (RouletteModel.Instance.RouletteListDataMap.TryGetValue(this.RouletteType, out rouletteListDataBase))
		{
			return rouletteListDataBase.GetRouletteGridId(index, gridType, true).GetValueOrDefault();
		}
		return 0;
	}

	// Token: 0x06015CE2 RID: 89314 RVA: 0x0057FD19 File Offset: 0x0057DF19
	protected override string OnGetActionName()
	{
		return "塔防轮盘";
	}

	// Token: 0x06015CE3 RID: 89315 RVA: 0x0057FD20 File Offset: 0x0057DF20
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

	// Token: 0x06015CE4 RID: 89316 RVA: 0x0057FDA4 File Offset: 0x0057DFA4
	protected override void OnDestroy()
	{
		if (this.RouletteComponentExplore != null)
		{
			this.RouletteComponentExplore.Destroy(null);
			this.RouletteComponentExplore = null;
		}
	}

	// Token: 0x0400A24F RID: 41551
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

	// Token: 0x0400A250 RID: 41552
	[Nullable(2)]
	private RouletteComponentMainExplore RouletteComponentExplore;

	// Token: 0x0400A251 RID: 41553
	protected TrapDefenseRouletteItemTips ItemTips;
}
