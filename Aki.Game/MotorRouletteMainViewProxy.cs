using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using UnrealEngine;

// Token: 0x02002938 RID: 10552
[NullableContext(1)]
[Nullable(0)]
public class MotorRouletteMainViewProxy : RouletteMainViewProxyBase
{
	// Token: 0x06015C7C RID: 89212 RVA: 0x0057EEFC File Offset: 0x0057D0FC
	protected override RouletteComponentMain OnGetRouletteComponent()
	{
		if (this.RouletteType == ERouletteType.Motor)
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

	// Token: 0x06015C7D RID: 89213 RVA: 0x0057EF98 File Offset: 0x0057D198
	protected override bool OnCanOpenView()
	{
		if (Info.Instance.IsInGamepad())
		{
			foreach (ERouletteType key in this.RouletteTypeList)
			{
				RouletteListDataBase rouletteListDataBase;
				if (RouletteModel.Instance.RouletteListDataMap.TryGetValue(key, out rouletteListDataBase) && rouletteListDataBase.IsMainRouletteCanOpenView(true))
				{
					return true;
				}
			}
			return false;
		}
		ERouletteType erouletteType = RouletteModel.Instance.GetRouletteActionOpenConfig(this.ActionType);
		if (erouletteType == ERouletteType.Explore)
		{
			erouletteType = ERouletteType.Motor;
		}
		RouletteListDataBase rouletteListDataBase2;
		return RouletteModel.Instance.RouletteListDataMap.TryGetValue(erouletteType, out rouletteListDataBase2) && rouletteListDataBase2.IsMainRouletteCanOpenView(true);
	}

	// Token: 0x06015C7E RID: 89214 RVA: 0x0057F04C File Offset: 0x0057D24C
	protected override ERouletteType OnGetRouletteType()
	{
		ERouletteType erouletteType = RouletteModel.Instance.GetRouletteActionOpenConfig(this.ActionType);
		if (erouletteType == ERouletteType.Explore)
		{
			erouletteType = ERouletteType.Motor;
		}
		bool flag = false;
		RouletteListDataBase rouletteListDataBase;
		if (RouletteModel.Instance.RouletteListDataMap.TryGetValue(ERouletteType.Motor, out rouletteListDataBase))
		{
			flag = rouletteListDataBase.IsMainRouletteCanOpenView(false);
		}
		bool flag2 = RouletteModel.Instance.IsFunctionRouletteOpen();
		if (erouletteType == ERouletteType.Function && !flag2)
		{
			return ERouletteType.Motor;
		}
		if (erouletteType == ERouletteType.Motor && !flag)
		{
			return ERouletteType.Function;
		}
		return erouletteType;
	}

	// Token: 0x06015C7F RID: 89215 RVA: 0x0057F0AC File Offset: 0x0057D2AC
	protected override bool OnGetCanSwitchType()
	{
		if (!Info.Instance.IsInGamepad())
		{
			return false;
		}
		foreach (ERouletteType key in this.RouletteTypeList)
		{
			RouletteListDataBase rouletteListDataBase;
			if (!RouletteModel.Instance.RouletteListDataMap.TryGetValue(key, out rouletteListDataBase))
			{
				return false;
			}
			if (!rouletteListDataBase.IsMainRouletteCanOpenView(false))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06015C80 RID: 89216 RVA: 0x0057F130 File Offset: 0x0057D330
	protected override bool OnGetPanelSwitchOpen()
	{
		if (!Info.Instance.IsInGamepad())
		{
			return false;
		}
		foreach (ERouletteType key in this.RouletteTypeList)
		{
			RouletteListDataBase rouletteListDataBase;
			if (!RouletteModel.Instance.RouletteListDataMap.TryGetValue(key, out rouletteListDataBase))
			{
				return false;
			}
			if (!rouletteListDataBase.IsRouletteOpen())
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06015C81 RID: 89217 RVA: 0x0057F1B4 File Offset: 0x0057D3B4
	protected override void OnRouletteTypeSwitch()
	{
		bool flag = this.RouletteType == ERouletteType.Motor;
		this.RouletteType = (flag ? ERouletteType.Function : ERouletteType.Motor);
		ERouletteType type = flag ? ERouletteType.Function : ERouletteType.Explore;
		RouletteModel.Instance.SaveRouletteActionOpenConfig(this.ActionType, type);
	}

	// Token: 0x06015C82 RID: 89218 RVA: 0x0057F1F4 File Offset: 0x0057D3F4
	public override EToggleState? GetToggle1State()
	{
		bool flag = this.RouletteType == ERouletteType.Motor;
		bool flag2 = false;
		RouletteListDataBase rouletteListDataBase;
		if (RouletteModel.Instance.RouletteListDataMap.TryGetValue(ERouletteType.Motor, out rouletteListDataBase))
		{
			flag2 = rouletteListDataBase.IsMainRouletteCanOpenView(false);
		}
		if (flag2)
		{
			return new EToggleState?(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked);
		}
		return new EToggleState?(EToggleState.ETT_UnDetermined);
	}

	// Token: 0x06015C83 RID: 89219 RVA: 0x0057F23F File Offset: 0x0057D43F
	public override EToggleState? GetToggle2State()
	{
		return new EToggleState?((this.RouletteType == ERouletteType.Function) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked);
	}

	// Token: 0x06015C84 RID: 89220 RVA: 0x0057F258 File Offset: 0x0057D458
	protected override bool OnGetCanOpenAssembly(ERouletteType rouletteType)
	{
		RouletteListDataBase rouletteListDataBase;
		return rouletteType != ERouletteType.Function || !RouletteModel.Instance.RouletteListDataMap.TryGetValue(ERouletteType.Function, out rouletteListDataBase) || !rouletteListDataBase.IsRouletteReplace();
	}

	// Token: 0x06015C85 RID: 89221 RVA: 0x0057F288 File Offset: 0x0057D488
	[return: Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	protected override List<ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>> OnGetExploreRouletteDataMap()
	{
		RouletteListDataBase rouletteListDataBase;
		if (RouletteModel.Instance.RouletteListDataMap.TryGetValue(ERouletteType.Motor, out rouletteListDataBase))
		{
			return rouletteListDataBase.GetRouletteDataMap();
		}
		return new List<ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>>();
	}

	// Token: 0x06015C86 RID: 89222 RVA: 0x0057F2B8 File Offset: 0x0057D4B8
	protected override int OnGetRouletteGridId(int index, ERouletteGridType gridType)
	{
		RouletteListDataBase rouletteListDataBase;
		if (RouletteModel.Instance.RouletteListDataMap.TryGetValue(this.RouletteType, out rouletteListDataBase))
		{
			return rouletteListDataBase.GetRouletteGridId(index, gridType, true).GetValueOrDefault();
		}
		return 0;
	}

	// Token: 0x06015C87 RID: 89223 RVA: 0x0057F2F4 File Offset: 0x0057D4F4
	protected override string OnGetActionName()
	{
		string actionName = RouletteModel.Instance.GetRouletteActionName[this.ActionType];
		return RouletteModel.Instance.GetRouletteMainAction(actionName);
	}

	// Token: 0x06015C88 RID: 89224 RVA: 0x0057F324 File Offset: 0x0057D524
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

	// Token: 0x0400A23B RID: 41531
	[Nullable(2)]
	private RouletteComponentMainExplore RouletteComponentExplore;

	// Token: 0x0400A23C RID: 41532
	[Nullable(2)]
	private RouletteComponentMainFunction RouletteComponentFunction;

	// Token: 0x0400A23D RID: 41533
	private readonly List<ERouletteType> RouletteTypeList = new List<ERouletteType>
	{
		ERouletteType.Motor,
		ERouletteType.Function
	};
}
