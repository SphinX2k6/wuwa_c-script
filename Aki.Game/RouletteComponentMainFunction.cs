using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002921 RID: 10529
public class RouletteComponentMainFunction : RouletteComponentMain
{
	// Token: 0x06015B9D RID: 88989 RVA: 0x0057AEF4 File Offset: 0x005790F4
	[return: Nullable(new byte[]
	{
		2,
		0,
		1
	})]
	protected override List<ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>> GetRouletteInfoMap()
	{
		RouletteListDataBase rouletteListDataBase;
		if (RouletteModel.Instance.RouletteListDataMap.TryGetValue(ERouletteType.Function, out rouletteListDataBase))
		{
			return rouletteListDataBase.GetRouletteDataMap();
		}
		return null;
	}

	// Token: 0x06015B9E RID: 88990 RVA: 0x0057AF20 File Offset: 0x00579120
	protected override EGridBehavior JudgeGridStateByData(int id, ERouletteGridType gridType)
	{
		bool flag = id != 0;
		EGridBehavior? egridBehavior = RouletteGridForbiddenSettings.CheckGridSpecialState(ERouletteViewType.Main, gridType, id);
		if (!flag)
		{
			return EGridBehavior.Empty;
		}
		if (egridBehavior != null)
		{
			return egridBehavior.Value;
		}
		return EGridBehavior.Normal;
	}

	// Token: 0x06015B9F RID: 88991 RVA: 0x0057AF50 File Offset: 0x00579150
	protected override void RefreshRouletteItem()
	{
		base.SetTipsActive(true);
	}

	// Token: 0x06015BA0 RID: 88992 RVA: 0x0057AF5C File Offset: 0x0057915C
	[NullableContext(2)]
	protected override string GetRefreshTips(bool isEmpty)
	{
		string text = null;
		if (!isEmpty)
		{
			text = "Text_FuncToolsSwitchPC_Text";
		}
		base.SetTipsActive(text != null);
		return text;
	}
}
