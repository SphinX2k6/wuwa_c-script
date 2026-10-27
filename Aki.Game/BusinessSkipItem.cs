using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001300 RID: 4864
public class BusinessSkipItem : UiPanelBase
{
	// Token: 0x060086C9 RID: 34505 RVA: 0x001CC4E0 File Offset: 0x001CA6E0
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

	// Token: 0x060086CA RID: 34506 RVA: 0x001CC560 File Offset: 0x001CA760
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

	// Token: 0x060086CB RID: 34507 RVA: 0x001CC5B0 File Offset: 0x001CA7B0
	[NullableContext(1)]
	public void RegisterViewController(BusinessViewController vc)
	{
		this.Vc = vc;
	}

	// Token: 0x060086CC RID: 34508 RVA: 0x001CC5BC File Offset: 0x001CA7BC
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

	// Token: 0x04003C3E RID: 15422
	[Nullable(2)]
	private BusinessViewController Vc;

	// Token: 0x04003C3F RID: 15423
	private ValueTuple<EMoonChasingUnlockType, int> UnlockData;

	// Token: 0x02007938 RID: 31032
	private static class EComponentDefine
	{
		// Token: 0x04027EF9 RID: 163577
		public const int Tips = 0;

		// Token: 0x04027EFA RID: 163578
		public const int RoleIcon = 1;

		// Token: 0x04027EFB RID: 163579
		public const int Button = 2;
	}
}
