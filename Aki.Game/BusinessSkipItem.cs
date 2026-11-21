using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020007B4 RID: 1972
public class BusinessSkipItem : UiPanelBase
{
	// Token: 0x06005A64 RID: 23140 RVA: 0x001D534C File Offset: 0x001D354C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnSkipToOther))
		};
	}

	// Token: 0x06005A65 RID: 23141 RVA: 0x001D53CC File Offset: 0x001D35CC
	private void OnSkipToOther()
	{
		if (this.UnlockData.Item1 != EMoonChasingUnlockType.Building)
		{
			if (this.UnlockData.Item1 == EMoonChasingUnlockType.BranchTask)
			{
				MoonChasingController.Instance.OpenTaskView(EMoonChasingTaskType.BranchLine, this.UnlockData.Item2, false);
			}
			return;
		}
		BusinessViewController vc = this.Vc;
		if (vc == null)
		{
			return;
		}
		vc.SkipToBuild();
	}

	// Token: 0x06005A66 RID: 23142 RVA: 0x001D541C File Offset: 0x001D361C
	[NullableContext(1)]
	public void RegisterViewController(BusinessViewController vc)
	{
		this.Vc = vc;
	}

	// Token: 0x06005A67 RID: 23143 RVA: 0x001D5428 File Offset: 0x001D3628
	public void Refresh()
	{
		ValueTuple<EMoonChasingUnlockType, int>? firstUnlockData = MoonChasingModel.Instance.GetFirstUnlockData();
		if (firstUnlockData == null)
		{
			return;
		}
		string textStringId = "";
		this.UnlockData = firstUnlockData.Value;
		if (this.UnlockData.Item1 == EMoonChasingUnlockType.Building)
		{
			textStringId = "Moonfiesta_PartnerTip2";
		}
		else if (this.UnlockData.Item1 == EMoonChasingUnlockType.BranchTask)
		{
			textStringId = "Moonfiesta_PartnerTip1";
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textStringId, Array.Empty<object>());
	}

	// Token: 0x04003CD6 RID: 15574
	[Nullable(2)]
	private BusinessViewController Vc;

	// Token: 0x04003CD7 RID: 15575
	private ValueTuple<EMoonChasingUnlockType, int> UnlockData;

	// Token: 0x02006AC2 RID: 27330
	private static class EComponentDefine
	{
		// Token: 0x04023226 RID: 143910
		public const int Tips = 0;

		// Token: 0x04023227 RID: 143911
		public const int RoleIcon = 1;

		// Token: 0x04023228 RID: 143912
		public const int Button = 2;
	}
}
