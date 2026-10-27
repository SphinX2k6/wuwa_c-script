using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005FAB RID: 24491
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpPreviewRoleSubView : TotalTopUpPreviewSubViewBase
	{
		// Token: 0x0603E197 RID: 254359 RVA: 0x00EFEEF8 File Offset: 0x00EFD0F8
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

		// Token: 0x0603E198 RID: 254360 RVA: 0x00EFEF78 File Offset: 0x00EFD178
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

		// Token: 0x0603E199 RID: 254361 RVA: 0x00EFEFC7 File Offset: 0x00EFD1C7
		private void OnClickCheckItem()
		{
			ItemController.Instance.OpenItemTipsByItemId(this.PropsItemId, false, null);
		}

		// Token: 0x0603E19A RID: 254362 RVA: 0x00EFEFDC File Offset: 0x00EFD1DC
		private void OnClickCheckRole()
		{
			RoleController.Instance.OpenRoleMainView(ERoleAgentType.Preview, 0, this.TrailIdList, null, null);
		}

		// Token: 0x0402070E RID: 132878
		private List<int> TrailIdList = new List<int>();

		// Token: 0x0402070F RID: 132879
		private int PropsItemId;
	}
}
