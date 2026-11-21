using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CC9 RID: 7369
public class RoleTowerBossTipsView : UiViewBase
{
	// Token: 0x060123F4 RID: 74740 RVA: 0x005613F9 File Offset: 0x0055F5F9
	[NullableContext(1)]
	public RoleTowerBossTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060123F5 RID: 74741 RVA: 0x00561402 File Offset: 0x0055F602
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x060123F6 RID: 74742 RVA: 0x00561425 File Offset: 0x0055F625
	protected override void OnStart()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.AddSequenceFinishEvent("Start", delegate(string _)
		{
			base.CloseMe(null);
		}, false);
	}

	// Token: 0x060123F7 RID: 74743 RVA: 0x00561449 File Offset: 0x0055F649
	protected override void OnBeforeShow()
	{
		this.RefreshTips();
	}

	// Token: 0x060123F8 RID: 74744 RVA: 0x00561454 File Offset: 0x0055F654
	private void RefreshTips()
	{
		IRoleTowerStrongEnemyWarning roleTowerStrongEnemyWarning = this.OpenParam as IRoleTowerStrongEnemyWarning;
		string text = (roleTowerStrongEnemyWarning != null) ? roleTowerStrongEnemyWarning.TidMainText : null;
		if (string.IsNullOrEmpty(text))
		{
			RoleTowerBranch? branchCfg = RoleTowerModel.Instance.GetBranchCfg(RoleTowerModel.Instance.GetSelectBranchId());
			if (branchCfg != null)
			{
				UUIText text2 = base.GetText(0);
				if (text2 == null)
				{
					return;
				}
				text2.ShowTextNew(branchCfg.Value.BranchTitle);
			}
			return;
		}
		UUIText text3 = base.GetText(0);
		if (text3 == null)
		{
			return;
		}
		text3.ShowTextNew(text);
	}

	// Token: 0x02007FB9 RID: 32697
	private static class EChildType
	{
		// Token: 0x0402952B RID: 169259
		public const int TxtTitle = 0;
	}
}
