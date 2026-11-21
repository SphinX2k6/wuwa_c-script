using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;

// Token: 0x02001E9B RID: 7835
public class RouletteComponentMainExplore : RouletteComponentMain
{
	// Token: 0x0601359C RID: 79260 RVA: 0x005A5D31 File Offset: 0x005A3F31
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

	// Token: 0x0601359D RID: 79261 RVA: 0x005A5D40 File Offset: 0x005A3F40
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

	// Token: 0x0601359E RID: 79262 RVA: 0x005A5D78 File Offset: 0x005A3F78
	protected override void RefreshRouletteItem()
	{
		base.SetTipsActive(false);
	}

	// Token: 0x0601359F RID: 79263 RVA: 0x005A5D84 File Offset: 0x005A3F84
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
