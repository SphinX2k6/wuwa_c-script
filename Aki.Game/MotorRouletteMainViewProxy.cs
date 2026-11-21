using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using UnrealEngine;

// Token: 0x02001EB3 RID: 7859
[NullableContext(1)]
[Nullable(0)]
public class MotorRouletteMainViewProxy : RouletteMainViewProxyBase
{
	// Token: 0x06013681 RID: 79489 RVA: 0x005A9F34 File Offset: 0x005A8134
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

	// Token: 0x06013682 RID: 79490 RVA: 0x005A9FD0 File Offset: 0x005A81D0
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

	// Token: 0x06013683 RID: 79491 RVA: 0x005AA084 File Offset: 0x005A8284
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

	// Token: 0x06013684 RID: 79492 RVA: 0x005AA0E4 File Offset: 0x005A82E4
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

	// Token: 0x06013685 RID: 79493 RVA: 0x005AA168 File Offset: 0x005A8368
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

	// Token: 0x06013686 RID: 79494 RVA: 0x005AA1EC File Offset: 0x005A83EC
	protected override void OnRouletteTypeSwitch()
	{
		bool flag = this.RouletteType == ERouletteType.Motor;
		this.RouletteType = (flag ? ERouletteType.Function : ERouletteType.Motor);
		ERouletteType type = flag ? ERouletteType.Function : ERouletteType.Explore;
		RouletteModel.Instance.SaveRouletteActionOpenConfig(this.ActionType, type);
	}

	// Token: 0x06013687 RID: 79495 RVA: 0x005AA22C File Offset: 0x005A842C
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

	// Token: 0x06013688 RID: 79496 RVA: 0x005AA277 File Offset: 0x005A8477
	public override EToggleState? GetToggle2State()
	{
		return new EToggleState?((this.RouletteType == ERouletteType.Function) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked);
	}

	// Token: 0x06013689 RID: 79497 RVA: 0x005AA290 File Offset: 0x005A8490
	protected override bool OnGetCanOpenAssembly(ERouletteType rouletteType)
	{
		RouletteListDataBase rouletteListDataBase;
		return rouletteType != ERouletteType.Function || !RouletteModel.Instance.RouletteListDataMap.TryGetValue(ERouletteType.Function, out rouletteListDataBase) || !rouletteListDataBase.IsRouletteReplace();
	}

	// Token: 0x0601368A RID: 79498 RVA: 0x005AA2C0 File Offset: 0x005A84C0
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

	// Token: 0x0601368B RID: 79499 RVA: 0x005AA2F0 File Offset: 0x005A84F0
	protected override int OnGetRouletteGridId(int index, ERouletteGridType gridType)
	{
		RouletteListDataBase rouletteListDataBase;
		if (RouletteModel.Instance.RouletteListDataMap.TryGetValue(this.RouletteType, out rouletteListDataBase))
		{
			return rouletteListDataBase.GetRouletteGridId(index, gridType, true).GetValueOrDefault();
		}
		return 0;
	}

	// Token: 0x0601368C RID: 79500 RVA: 0x005AA32C File Offset: 0x005A852C
	protected override string OnGetActionName()
	{
		string actionName = RouletteModel.Instance.GetRouletteActionName[this.ActionType];
		return RouletteModel.Instance.GetRouletteMainAction(actionName);
	}

	// Token: 0x0601368D RID: 79501 RVA: 0x005AA35C File Offset: 0x005A855C
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

	// Token: 0x0400A626 RID: 42534
	[Nullable(2)]
	private RouletteComponentMainExplore RouletteComponentExplore;

	// Token: 0x0400A627 RID: 42535
	[Nullable(2)]
	private RouletteComponentMainFunction RouletteComponentFunction;

	// Token: 0x0400A628 RID: 42536
	private readonly List<ERouletteType> RouletteTypeList = new List<ERouletteType>
	{
		ERouletteType.Motor,
		ERouletteType.Function
	};
}
