using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004F92 RID: 20370
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpPreviewRoleSubView : TotalTopUpPreviewSubViewBase
	{
		// Token: 0x06033131 RID: 209201 RVA: 0x00E50BB4 File Offset: 0x00E4EDB4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickCheckItem)),
				new ValueTuple<int, Delegate>(1, new Action(this.OnClickCheckRole))
			};
		}

		// Token: 0x06033132 RID: 209202 RVA: 0x00E50C34 File Offset: 0x00E4EE34
		public override void ShowPreview(ITotalTopUpPreviewViewParam param)
		{
			if (param == null)
			{
				return;
			}
			TotalTopUpRewardData rewardData = param.RewardData;
			if (((rewardData != null) ? rewardData.TotalTopUpRolePackageData : null) == null)
			{
				return;
			}
			TotalTopUpRolePackageData totalTopUpRolePackageData = param.RewardData.TotalTopUpRolePackageData;
			this.TrailIdList = new List<int>(totalTopUpRolePackageData.RoleTrialIdList);
			this.PropsItemId = totalTopUpRolePackageData.ItemId;
		}

		// Token: 0x06033133 RID: 209203 RVA: 0x00E50C83 File Offset: 0x00E4EE83
		private void OnClickCheckItem()
		{
			ItemController.Instance.OpenItemTipsByItemId(this.PropsItemId, false, null, false);
		}

		// Token: 0x06033134 RID: 209204 RVA: 0x00E50C98 File Offset: 0x00E4EE98
		private void OnClickCheckRole()
		{
			RoleController.Instance.OpenRoleMainView(ERoleAgentType.Preview, 0, this.TrailIdList, null, null);
		}

		// Token: 0x0401B1E0 RID: 111072
		private List<int> TrailIdList = new List<int>();

		// Token: 0x0401B1E1 RID: 111073
		private int PropsItemId;
	}
}
