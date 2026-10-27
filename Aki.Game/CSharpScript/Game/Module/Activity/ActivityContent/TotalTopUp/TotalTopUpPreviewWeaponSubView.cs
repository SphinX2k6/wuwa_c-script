using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005FB0 RID: 24496
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpPreviewWeaponSubView : TotalTopUpPreviewSubViewBase
	{
		// Token: 0x0603E1A3 RID: 254371 RVA: 0x00EFF1CC File Offset: 0x00EFD3CC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickCheck))
			};
		}

		// Token: 0x0603E1A4 RID: 254372 RVA: 0x00EFF21D File Offset: 0x00EFD41D
		public override void ShowPreview(ITotalTopUpPreviewViewParam param)
		{
			if (param == null)
			{
				return;
			}
			TotalTopUpRewardData rewardData = param.RewardData;
			if (((rewardData != null) ? rewardData.TotalTopUpWeaponPackageData : null) == null)
			{
				return;
			}
			this.TrailIdList = new List<int>(param.RewardData.TotalTopUpWeaponPackageData.WeaponTrialIdList);
		}

		// Token: 0x0603E1A5 RID: 254373 RVA: 0x00EFF254 File Offset: 0x00EFD454
		private void OnClickCheck()
		{
			List<WeaponDataBase> list = new List<WeaponDataBase>();
			foreach (int num in this.TrailIdList)
			{
				WeaponTrialData weaponTrialData = new WeaponTrialData();
				weaponTrialData.SetTrialId(num, true);
				list.Add(weaponTrialData);
				string message = "预览武器试用ID";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TrialId", num);
				TotalTopUpUtil.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			WeaponPreviewViewParam param = new WeaponPreviewViewParam
			{
				WeaponDataList = list.ToArray(),
				SelectedIndex = 0
			};
			UiManager.Instance.OpenView(EUiViewName.WeaponPreviewView, param, null);
		}

		// Token: 0x04020718 RID: 132888
		private List<int> TrailIdList = new List<int>();
	}
}
