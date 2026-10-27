using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;

// Token: 0x02002920 RID: 10528
public class RouletteComponentMainExplore : RouletteComponentMain
{
	// Token: 0x06015B98 RID: 88984 RVA: 0x0057ADB5 File Offset: 0x00578FB5
	[return: Nullable(new byte[]
	{
		2,
		0,
		1
	})]
	protected override List<ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>> GetRouletteInfoMap()
	{
		return this.ViewProxy.GetExploreRouletteDataMap();
	}

	// Token: 0x06015B99 RID: 88985 RVA: 0x0057ADC4 File Offset: 0x00578FC4
	protected override EGridBehavior JudgeGridStateByData(int id, ERouletteGridType gridType)
	{
		bool flag = id != 0;
		bool flag2 = gridType == ERouletteGridType.EquipItem;
		EGridBehavior? egridBehavior = RouletteGridForbiddenSettings.CheckGridSpecialState(ERouletteViewType.Main, gridType, id);
		if (!flag && !flag2)
		{
			return EGridBehavior.Empty;
		}
		if (egridBehavior != null)
		{
			return egridBehavior.Value;
		}
		return EGridBehavior.Normal;
	}

	// Token: 0x06015B9A RID: 88986 RVA: 0x0057ADFC File Offset: 0x00578FFC
	protected override void RefreshRouletteItem()
	{
		base.SetTipsActive(false);
	}

	// Token: 0x06015B9B RID: 88987 RVA: 0x0057AE08 File Offset: 0x00579008
	[NullableContext(2)]
	protected override string GetRefreshTips(bool isEmpty)
	{
		string text = null;
		if (Info.Instance.IsInTouch())
		{
			text = (isEmpty ? "Text_ProbeToolFunctionNotice3_Text" : "Text_ExploreToolsSwitchMobile_Text");
		}
		else if (Info.Instance.IsInKeyBoard())
		{
			if (isEmpty)
			{
				text = null;
			}
			else
			{
				RouletteGridBase currentGrid = base.GetCurrentGrid();
				text = ((currentGrid != null && currentGrid.Data.UseType == EGridUseType.SwitchOnly) ? "Text_ExploreToolsSwitchPC_Text" : "Text_ExploreToolsSwitchPC_Text02");
			}
		}
		else if (Info.Instance.IsInGamepad())
		{
			RouletteGridBase currentGrid2 = base.GetCurrentGrid();
			bool flag = currentGrid2 == null || currentGrid2.Data.State != EGridBehavior.Normal;
			if (this.CurrentGridIndex != -1 && !flag)
			{
				RouletteGridBase currentGrid3 = base.GetCurrentGrid();
				text = ((currentGrid3 != null && currentGrid3.Data.UseType == EGridUseType.SwitchOnly) ? "Text_ExploreToolsSwitchPC_Text" : "Text_ExploreToolsSwitchPC_Text02");
			}
		}
		base.SetTipsActive(text != null);
		return text;
	}
}
