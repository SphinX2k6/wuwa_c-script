using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001E9C RID: 7836
public class RouletteComponentMainFunction : RouletteComponentMain
{
	// Token: 0x060135A1 RID: 79265 RVA: 0x005A5E70 File Offset: 0x005A4070
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

	// Token: 0x060135A2 RID: 79266 RVA: 0x005A5E9C File Offset: 0x005A409C
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

	// Token: 0x060135A3 RID: 79267 RVA: 0x005A5ECC File Offset: 0x005A40CC
	protected override void RefreshRouletteItem()
	{
		base.SetTipsActive(true);
	}

	// Token: 0x060135A4 RID: 79268 RVA: 0x005A5ED8 File Offset: 0x005A40D8
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
