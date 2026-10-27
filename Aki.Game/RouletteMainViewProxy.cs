using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using UnrealEngine;

// Token: 0x0200293C RID: 10556
[NullableContext(1)]
[Nullable(0)]
public class RouletteMainViewProxy : RouletteMainViewProxyBase
{
	// Token: 0x06015CA0 RID: 89248 RVA: 0x0057F724 File Offset: 0x0057D924
	protected override RouletteComponentMain OnGetRouletteComponent()
	{
		if (this.RouletteType == ERouletteType.Explore)
		{
			if (this.RouletteComponentExplore == null)
			{
				this.RouletteComponentExplore = new RouletteComponentMainExplore();
				this.RouletteComponentExplore.RegisterViewProxy(this);
				this.RouletteComponentExplore.SetRootActor(this.View.RouletteUiItem.GetOwner(), true);
			}
			return this.RouletteComponentExplore;
		}
		if (this.RouletteComponentFunction == null)
		{
			this.RouletteComponentFunction = new RouletteComponentMainFunction();
			this.RouletteComponentFunction.RegisterViewProxy(this);
			this.RouletteComponentFunction.SetRootActor(this.View.RouletteUiItem.GetOwner(), true);
		}
		return this.RouletteComponentFunction;
	}

	// Token: 0x06015CA1 RID: 89249 RVA: 0x0057F7BC File Offset: 0x0057D9BC
	protected override bool OnCanOpenView()
	{
		if (Info.Instance.IsInGamepad())
		{
			return RouletteModel.Instance.IsExploreRouletteOpen(true) || RouletteModel.Instance.IsFunctionRouletteOpen();
		}
		ERouletteType rouletteActionOpenConfig = RouletteModel.Instance.GetRouletteActionOpenConfig(this.ActionType);
		if (rouletteActionOpenConfig == ERouletteType.Explore)
		{
			return RouletteModel.Instance.IsExploreRouletteOpen(true);
		}
		return rouletteActionOpenConfig != ERouletteType.Function || RouletteModel.Instance.IsFunctionRouletteOpen();
	}

	// Token: 0x06015CA2 RID: 89250 RVA: 0x0057F820 File Offset: 0x0057DA20
	protected override ERouletteType OnGetRouletteType()
	{
		ERouletteType rouletteActionOpenConfig = RouletteModel.Instance.GetRouletteActionOpenConfig(this.ActionType);
		bool flag = RouletteModel.Instance.IsExploreRouletteOpen(false);
		bool flag2 = RouletteModel.Instance.IsFunctionRouletteOpen();
		if (rouletteActionOpenConfig == ERouletteType.Function && !flag2)
		{
			return ERouletteType.Explore;
		}
		if (rouletteActionOpenConfig == ERouletteType.Explore && !flag)
		{
			return ERouletteType.Function;
		}
		return rouletteActionOpenConfig;
	}

	// Token: 0x06015CA3 RID: 89251 RVA: 0x0057F868 File Offset: 0x0057DA68
	protected override bool OnGetCanSwitchType()
	{
		bool flag = RouletteModel.Instance.IsExploreRouletteOpen(false);
		bool flag2 = RouletteModel.Instance.IsFunctionRouletteOpen();
		return Info.Instance.IsInGamepad() && flag && flag2;
	}

	// Token: 0x06015CA4 RID: 89252 RVA: 0x0057F89C File Offset: 0x0057DA9C
	protected override bool OnGetPanelSwitchOpen()
	{
		bool flag = RouletteModel.Instance.IsFunctionRouletteOpen();
		bool flag2 = FunctionModel.Instance.IsOpen(10026);
		return Info.Instance.IsInGamepad() && flag2 && flag;
	}

	// Token: 0x06015CA5 RID: 89253 RVA: 0x0057F8D4 File Offset: 0x0057DAD4
	protected override void OnRouletteTypeSwitch()
	{
		this.RouletteType = ((this.RouletteType == ERouletteType.Explore) ? ERouletteType.Function : ERouletteType.Explore);
		RouletteModel.Instance.SaveRouletteActionOpenConfig(this.ActionType, this.RouletteType);
	}

	// Token: 0x06015CA6 RID: 89254 RVA: 0x0057F910 File Offset: 0x0057DB10
	public override EToggleState? GetToggle1State()
	{
		bool flag = this.RouletteType == ERouletteType.Explore;
		if (RouletteModel.Instance.IsExploreRouletteOpen(false))
		{
			return new EToggleState?(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked);
		}
		return new EToggleState?(EToggleState.ETT_UnDetermined);
	}

	// Token: 0x06015CA7 RID: 89255 RVA: 0x0057F947 File Offset: 0x0057DB47
	public override EToggleState? GetToggle2State()
	{
		return new EToggleState?((this.RouletteType == ERouletteType.Function) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked);
	}

	// Token: 0x06015CA8 RID: 89256 RVA: 0x0057F960 File Offset: 0x0057DB60
	protected override bool OnGetCanOpenAssembly(ERouletteType rouletteType)
	{
		bool result = true;
		RouletteListDataBase rouletteListDataBase;
		RouletteListDataBase rouletteListDataBase2;
		if (rouletteType == ERouletteType.Explore && RouletteModel.Instance.RouletteListDataMap.TryGetValue(ERouletteType.Explore, out rouletteListDataBase) && rouletteListDataBase.IsRouletteReplace())
		{
			result = false;
		}
		else if (rouletteType == ERouletteType.Function && RouletteModel.Instance.RouletteListDataMap.TryGetValue(ERouletteType.Function, out rouletteListDataBase2) && rouletteListDataBase2.IsRouletteReplace())
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06015CA9 RID: 89257 RVA: 0x0057F9B8 File Offset: 0x0057DBB8
	[return: Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	protected override List<ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>> OnGetExploreRouletteDataMap()
	{
		RouletteListDataBase rouletteListDataBase;
		if (RouletteModel.Instance.RouletteListDataMap.TryGetValue(ERouletteType.Explore, out rouletteListDataBase))
		{
			return rouletteListDataBase.GetRouletteDataMap();
		}
		return new List<ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>>();
	}

	// Token: 0x06015CAA RID: 89258 RVA: 0x0057F9E8 File Offset: 0x0057DBE8
	protected override int OnGetRouletteGridId(int index, ERouletteGridType gridType)
	{
		RouletteListDataBase rouletteListDataBase;
		if (RouletteModel.Instance.RouletteListDataMap.TryGetValue(this.RouletteType, out rouletteListDataBase))
		{
			return rouletteListDataBase.GetRouletteGridId(index, gridType, true).GetValueOrDefault();
		}
		return 0;
	}

	// Token: 0x06015CAB RID: 89259 RVA: 0x0057FA24 File Offset: 0x0057DC24
	protected override string OnGetActionName()
	{
		string actionName = RouletteModel.Instance.GetRouletteActionName[this.ActionType];
		return RouletteModel.Instance.GetRouletteMainAction(actionName);
	}

	// Token: 0x06015CAC RID: 89260 RVA: 0x0057FA54 File Offset: 0x0057DC54
	protected override void OnDestroy()
	{
		if (this.RouletteComponentExplore != null)
		{
			this.RouletteComponentExplore.Destroy(null);
			this.RouletteComponentExplore = null;
		}
		if (this.RouletteComponentFunction != null)
		{
			this.RouletteComponentFunction.Destroy(null);
			this.RouletteComponentFunction = null;
		}
	}

	// Token: 0x0400A248 RID: 41544
	[Nullable(2)]
	private RouletteComponentMainExplore RouletteComponentExplore;

	// Token: 0x0400A249 RID: 41545
	[Nullable(2)]
	private RouletteComponentMainFunction RouletteComponentFunction;
}
