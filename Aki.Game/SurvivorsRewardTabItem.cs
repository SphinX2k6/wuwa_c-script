using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002098 RID: 8344
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsRewardTabItem : GridProxyAbstract<SurvivorRewardTaskTabData>
{
	// Token: 0x06014902 RID: 84226 RVA: 0x005FE3F4 File Offset: 0x005FC5F4
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

	// Token: 0x06014903 RID: 84227 RVA: 0x005FE474 File Offset: 0x005FC674
	public void SetToggleState(bool bSelect, bool bFire)
	{
		EToggleState state = bSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(1).SetToggleState(state, bFire, false, false);
	}

	// Token: 0x06014904 RID: 84228 RVA: 0x005FE49A File Offset: 0x005FC69A
	private void SetRedDotVisible(bool bVisible)
	{
		base.GetItem(2).SetUIActive(bVisible);
	}

	// Token: 0x06014905 RID: 84229 RVA: 0x005FE4AC File Offset: 0x005FC6AC
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

	// Token: 0x06014906 RID: 84230 RVA: 0x005FE502 File Offset: 0x005FC702
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

	// Token: 0x06014907 RID: 84231 RVA: 0x005FE531 File Offset: 0x005FC731
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

	// Token: 0x06014908 RID: 84232 RVA: 0x005FE553 File Offset: 0x005FC753
	public override object GetKey(SurvivorRewardTaskTabData data, int displayIndex)
	{
		return data.Type;
	}

	// Token: 0x0400AE91 RID: 44689
	[Nullable(2)]
	private SurvivorRewardTaskTabData TabData;
}
