using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002721 RID: 10017
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RacingBetsRewardTabItem : GridProxyAbstract<RacingBetsGroupRewardData>
{
	// Token: 0x06014870 RID: 84080 RVA: 0x0052EE1C File Offset: 0x0052D01C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickTabToggle))
		};
	}

	// Token: 0x06014871 RID: 84081 RVA: 0x0052EE99 File Offset: 0x0052D099
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanExecuteToggleChange));
	}

	// Token: 0x06014872 RID: 84082 RVA: 0x0052EEBD File Offset: 0x0052D0BD
	public override void Refresh(RacingBetsGroupRewardData data, bool isSelected, int gridIndex)
	{
		this.GroupRewardData = data;
		this.RefreshItem();
	}

	// Token: 0x06014873 RID: 84083 RVA: 0x0052EECC File Offset: 0x0052D0CC
	public void RefreshItem()
	{
		if (this.GroupRewardData == null)
		{
			return;
		}
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.ShowTextNew(this.TabNameKeyList[this.GroupRewardData.Id - 1]);
		}
		this.RefreshRedDot();
	}

	// Token: 0x06014874 RID: 84084 RVA: 0x0052EF04 File Offset: 0x0052D104
	private void RefreshRedDot()
	{
		bool uiactive = false;
		using (List<RacingBetsRewardData>.Enumerator enumerator = this.GroupRewardData.GetRewardDataList().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.CanReceiveReward())
				{
					uiactive = true;
					break;
				}
			}
		}
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(uiactive);
	}

	// Token: 0x06014875 RID: 84085 RVA: 0x0052EF74 File Offset: 0x0052D174
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06014876 RID: 84086 RVA: 0x0052EF8B File Offset: 0x0052D18B
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06014877 RID: 84087 RVA: 0x0052EFA2 File Offset: 0x0052D1A2
	public void BindClickToggleCallBack(Action<RacingBetsGroupRewardData> toggleCallBack)
	{
		this.ClickToggleCallBack = toggleCallBack;
	}

	// Token: 0x06014878 RID: 84088 RVA: 0x0052EFAB File Offset: 0x0052D1AB
	private void OnClickTabToggle(EToggleState toggleState)
	{
		Action<RacingBetsGroupRewardData> clickToggleCallBack = this.ClickToggleCallBack;
		if (clickToggleCallBack == null)
		{
			return;
		}
		clickToggleCallBack(this.GroupRewardData);
	}

	// Token: 0x06014879 RID: 84089 RVA: 0x0052EFC3 File Offset: 0x0052D1C3
	private bool CanExecuteToggleChange()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		return extendToggle == null || extendToggle.GetToggleState() != EToggleState.ETT_Checked;
	}

	// Token: 0x04009A60 RID: 39520
	private RacingBetsGroupRewardData GroupRewardData;

	// Token: 0x04009A61 RID: 39521
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Action<RacingBetsGroupRewardData> ClickToggleCallBack;

	// Token: 0x04009A62 RID: 39522
	private readonly string[] TabNameKeyList = new string[]
	{
		"Dango_RewardPage_RewardType_1",
		"Dango_CurrencyPage_DailyTask",
		"Dango_RewardPage_RewardType_2"
	};

	// Token: 0x02008D76 RID: 36214
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402DE64 RID: 188004
		public const int TabToggle = 0;

		// Token: 0x0402DE65 RID: 188005
		public const int TabName = 1;

		// Token: 0x0402DE66 RID: 188006
		public const int RedDotItem = 2;
	}
}
