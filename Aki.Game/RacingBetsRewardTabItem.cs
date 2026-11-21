using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001C0C RID: 7180
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RacingBetsRewardTabItem : GridProxyAbstract<RacingBetsGroupRewardData>
{
	// Token: 0x06011D52 RID: 73042 RVA: 0x0053DB38 File Offset: 0x0053BD38
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

	// Token: 0x06011D53 RID: 73043 RVA: 0x0053DBB5 File Offset: 0x0053BDB5
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanExecuteToggleChange));
	}

	// Token: 0x06011D54 RID: 73044 RVA: 0x0053DBD9 File Offset: 0x0053BDD9
	public override void Refresh(RacingBetsGroupRewardData data, bool isSelected, int gridIndex)
	{
		this.GroupRewardData = data;
		this.RefreshItem();
	}

	// Token: 0x06011D55 RID: 73045 RVA: 0x0053DBE8 File Offset: 0x0053BDE8
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

	// Token: 0x06011D56 RID: 73046 RVA: 0x0053DC20 File Offset: 0x0053BE20
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

	// Token: 0x06011D57 RID: 73047 RVA: 0x0053DC90 File Offset: 0x0053BE90
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06011D58 RID: 73048 RVA: 0x0053DCA7 File Offset: 0x0053BEA7
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06011D59 RID: 73049 RVA: 0x0053DCBE File Offset: 0x0053BEBE
	public void BindClickToggleCallBack(Action<RacingBetsGroupRewardData> toggleCallBack)
	{
		this.ClickToggleCallBack = toggleCallBack;
	}

	// Token: 0x06011D5A RID: 73050 RVA: 0x0053DCC7 File Offset: 0x0053BEC7
	private void OnClickTabToggle(EToggleState toggleState)
	{
		Action<RacingBetsGroupRewardData> clickToggleCallBack = this.ClickToggleCallBack;
		if (clickToggleCallBack == null)
		{
			return;
		}
		clickToggleCallBack(this.GroupRewardData);
	}

	// Token: 0x06011D5B RID: 73051 RVA: 0x0053DCDF File Offset: 0x0053BEDF
	private bool CanExecuteToggleChange()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		return extendToggle == null || extendToggle.GetToggleState() != EToggleState.ETT_Checked;
	}

	// Token: 0x04009BB8 RID: 39864
	private RacingBetsGroupRewardData GroupRewardData;

	// Token: 0x04009BB9 RID: 39865
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Action<RacingBetsGroupRewardData> ClickToggleCallBack;

	// Token: 0x04009BBA RID: 39866
	private readonly string[] TabNameKeyList = new string[]
	{
		"Dango_RewardPage_RewardType_1",
		"Dango_CurrencyPage_DailyTask",
		"Dango_RewardPage_RewardType_2"
	};

	// Token: 0x02007EFF RID: 32511
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402917B RID: 168315
		public const int TabToggle = 0;

		// Token: 0x0402917C RID: 168316
		public const int TabName = 1;

		// Token: 0x0402917D RID: 168317
		public const int RedDotItem = 2;
	}
}
