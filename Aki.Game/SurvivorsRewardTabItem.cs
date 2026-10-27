using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002B1C RID: 11036
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsRewardTabItem : GridProxyAbstract<SurvivorRewardTaskTabData>
{
	// Token: 0x06016ED1 RID: 93905 RVA: 0x005D1878 File Offset: 0x005CFA78
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnTabToggle))
		};
	}

	// Token: 0x06016ED2 RID: 93906 RVA: 0x005D18F8 File Offset: 0x005CFAF8
	public void SetToggleState(bool bSelect, bool bFire)
	{
		EToggleState state = bSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(1).SetToggleState(state, bFire, false, false);
	}

	// Token: 0x06016ED3 RID: 93907 RVA: 0x005D191E File Offset: 0x005CFB1E
	private void SetRedDotVisible(bool bVisible)
	{
		base.GetItem(2).SetUIActive(bVisible);
	}

	// Token: 0x06016ED4 RID: 93908 RVA: 0x005D1930 File Offset: 0x005CFB30
	public void RefreshRedDot()
	{
		SurvivorRewardTaskTabData tabData = this.TabData;
		bool? flag;
		if (tabData == null)
		{
			flag = null;
		}
		else
		{
			Func<SurvivorRewardTaskTabData, bool> refreshRedDot = tabData.RefreshRedDot;
			flag = ((refreshRedDot != null) ? new bool?(refreshRedDot(this.TabData)) : null);
		}
		bool? flag2 = flag;
		bool valueOrDefault = flag2.GetValueOrDefault();
		this.SetRedDotVisible(valueOrDefault);
	}

	// Token: 0x06016ED5 RID: 93909 RVA: 0x005D1986 File Offset: 0x005CFB86
	public override void Refresh(SurvivorRewardTaskTabData data, bool isSelected, int gridIndex)
	{
		this.TabData = data;
		if (data.NameTextId != null)
		{
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.ShowTextNew(data.NameTextId);
			}
		}
		this.RefreshRedDot();
	}

	// Token: 0x06016ED6 RID: 93910 RVA: 0x005D19B5 File Offset: 0x005CFBB5
	private void OnTabToggle(EToggleState state)
	{
		SurvivorRewardTaskTabData tabData = this.TabData;
		if (tabData == null)
		{
			return;
		}
		Action<SurvivorRewardTaskTabData> clickedCallback = tabData.ClickedCallback;
		if (clickedCallback == null)
		{
			return;
		}
		clickedCallback(this.TabData);
	}

	// Token: 0x06016ED7 RID: 93911 RVA: 0x005D19D7 File Offset: 0x005CFBD7
	public override object GetKey(SurvivorRewardTaskTabData data, int displayIndex)
	{
		return data.Type;
	}

	// Token: 0x0400AA8B RID: 43659
	[Nullable(2)]
	private SurvivorRewardTaskTabData TabData;
}
