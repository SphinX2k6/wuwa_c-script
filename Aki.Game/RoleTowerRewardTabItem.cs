using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001CF9 RID: 7417
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerRewardTabItem : GridProxyAbstract<RoleTowerRewardTabData>
{
	// Token: 0x060125CF RID: 75215 RVA: 0x0056C098 File Offset: 0x0056A298
	public void SetClickCallback(Action<int> callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x060125D0 RID: 75216 RVA: 0x0056C0A4 File Offset: 0x0056A2A4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickTog))
		};
	}

	// Token: 0x060125D1 RID: 75217 RVA: 0x0056C137 File Offset: 0x0056A337
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x060125D2 RID: 75218 RVA: 0x0056C148 File Offset: 0x0056A348
	public override void Refresh(RoleTowerRewardTabData data, bool isSelected, int gridIndex)
	{
		this.TabId = data.TabId;
		RoleTowerRewardTab? rewardTabCfg = RoleTowerModel.Instance.GetRewardTabCfg(data.TabId);
		if (rewardTabCfg != null)
		{
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.ShowTextNew(rewardTabCfg.Value.Name);
			}
		}
		ValueTuple<int, int> rewardTabProgress = RoleTowerModel.Instance.GetRewardTabProgress(data.TabId);
		int item = rewardTabProgress.Item1;
		int item2 = rewardTabProgress.Item2;
		UUIText text2 = base.GetText(3);
		if (text2 != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 3);
			defaultInterpolatedStringHandler.AppendLiteral("<color=");
			defaultInterpolatedStringHandler.AppendFormatted("#ac8839");
			defaultInterpolatedStringHandler.AppendLiteral(">");
			defaultInterpolatedStringHandler.AppendFormatted<int>(item);
			defaultInterpolatedStringHandler.AppendLiteral("</color>/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(item2);
			text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		UUIItem item3 = base.GetItem(1);
		if (item3 != null)
		{
			item3.SetUIActive(this.HasCanReceive(data.TabId));
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(data.IsSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x060125D3 RID: 75219 RVA: 0x0056C25C File Offset: 0x0056A45C
	private bool HasCanReceive(int tabId)
	{
		foreach (RoleTowerReward roleTowerReward in RoleTowerModel.Instance.GetRewardCfgListByTab(tabId))
		{
			RoleTowerRewardData rewardState = RoleTowerModel.Instance.GetRewardState(roleTowerReward.Id);
			if (((rewardState != null) ? rewardState.State : ERoleTowerRewardState.UnFinish) == ERoleTowerRewardState.CanReceive)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060125D4 RID: 75220 RVA: 0x0056C2D0 File Offset: 0x0056A4D0
	private void OnClickTog(EToggleState check)
	{
		if (check == EToggleState.ETT_Checked)
		{
			Action<int> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.TabId);
		}
	}

	// Token: 0x060125D5 RID: 75221 RVA: 0x0056C2EC File Offset: 0x0056A4EC
	public override object GetKey(RoleTowerRewardTabData data, int displayIndex)
	{
		return data.TabId;
	}

	// Token: 0x0400A010 RID: 40976
	private const string NumColorHex = "#ac8839";

	// Token: 0x0400A011 RID: 40977
	private int TabId;

	// Token: 0x0400A012 RID: 40978
	[Nullable(2)]
	private Action<int> ClickCallback;

	// Token: 0x0200801A RID: 32794
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04029725 RID: 169765
		public const int TogItem = 0;

		// Token: 0x04029726 RID: 169766
		public const int PnlRedPoint = 1;

		// Token: 0x04029727 RID: 169767
		public const int TxtName = 2;

		// Token: 0x04029728 RID: 169768
		public const int TxtNum = 3;
	}
}
