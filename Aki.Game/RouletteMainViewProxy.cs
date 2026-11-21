using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using UnrealEngine;

// Token: 0x02001EB7 RID: 7863
[NullableContext(1)]
[Nullable(0)]
public class RouletteMainViewProxy : RouletteMainViewProxyBase
{
	// Token: 0x060136A5 RID: 79525 RVA: 0x005AA75C File Offset: 0x005A895C
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

	// Token: 0x060136A6 RID: 79526 RVA: 0x005AA7F4 File Offset: 0x005A89F4
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

	// Token: 0x060136A7 RID: 79527 RVA: 0x005AA858 File Offset: 0x005A8A58
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

	// Token: 0x060136A8 RID: 79528 RVA: 0x005AA8A0 File Offset: 0x005A8AA0
	protected override bool OnGetCanSwitchType()
	{
		bool flag = RouletteModel.Instance.IsExploreRouletteOpen(false);
		bool flag2 = RouletteModel.Instance.IsFunctionRouletteOpen();
		return Info.Instance.IsInGamepad() && flag && flag2;
	}

	// Token: 0x060136A9 RID: 79529 RVA: 0x005AA8D4 File Offset: 0x005A8AD4
	protected override bool OnGetPanelSwitchOpen()
	{
		bool flag = RouletteModel.Instance.IsFunctionRouletteOpen();
		bool flag2 = FunctionModel.Instance.IsOpen(10026);
		return Info.Instance.IsInGamepad() && flag2 && flag;
	}

	// Token: 0x060136AA RID: 79530 RVA: 0x005AA90C File Offset: 0x005A8B0C
	protected override void OnRouletteTypeSwitch()
	{
		this.RouletteType = ((this.RouletteType == ERouletteType.Explore) ? ERouletteType.Function : ERouletteType.Explore);
		RouletteModel.Instance.SaveRouletteActionOpenConfig(this.ActionType, this.RouletteType);
	}

	// Token: 0x060136AB RID: 79531 RVA: 0x005AA948 File Offset: 0x005A8B48
	public override EToggleState? GetToggle1State()
	{
		bool flag = this.RouletteType == ERouletteType.Explore;
		if (RouletteModel.Instance.IsExploreRouletteOpen(false))
		{
			return new EToggleState?(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked);
		}
		return new EToggleState?(EToggleState.ETT_UnDetermined);
	}

	// Token: 0x060136AC RID: 79532 RVA: 0x005AA97F File Offset: 0x005A8B7F
	public override EToggleState? GetToggle2State()
	{
		return new EToggleState?((this.RouletteType == ERouletteType.Function) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked);
	}

	// Token: 0x060136AD RID: 79533 RVA: 0x005AA998 File Offset: 0x005A8B98
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

	// Token: 0x060136AE RID: 79534 RVA: 0x005AA9F0 File Offset: 0x005A8BF0
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

	// Token: 0x060136AF RID: 79535 RVA: 0x005AAA20 File Offset: 0x005A8C20
	protected override int OnGetRouletteGridId(int index, ERouletteGridType gridType)
	{
		RouletteListDataBase rouletteListDataBase;
		if (RouletteModel.Instance.RouletteListDataMap.TryGetValue(this.RouletteType, out rouletteListDataBase))
		{
			return rouletteListDataBase.GetRouletteGridId(index, gridType, true).GetValueOrDefault();
		}
		return 0;
	}

	// Token: 0x060136B0 RID: 79536 RVA: 0x005AAA5C File Offset: 0x005A8C5C
	protected override string OnGetActionName()
	{
		string actionName = RouletteModel.Instance.GetRouletteActionName[this.ActionType];
		return RouletteModel.Instance.GetRouletteMainAction(actionName);
	}

	// Token: 0x060136B1 RID: 79537 RVA: 0x005AAA8C File Offset: 0x005A8C8C
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

	// Token: 0x0400A633 RID: 42547
	[Nullable(2)]
	private RouletteComponentMainExplore RouletteComponentExplore;

	// Token: 0x0400A634 RID: 42548
	[Nullable(2)]
	private RouletteComponentMainFunction RouletteComponentFunction;
}
