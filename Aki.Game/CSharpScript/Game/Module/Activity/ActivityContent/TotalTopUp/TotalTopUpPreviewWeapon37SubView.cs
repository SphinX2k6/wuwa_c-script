using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005FAE RID: 24494
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpPreviewWeapon37SubView : TotalTopUpPreviewSubViewBase
	{
		// Token: 0x0603E19E RID: 254366 RVA: 0x00EFF060 File Offset: 0x00EFD260
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.OnClickPreview))
			};
		}

		// Token: 0x0603E19F RID: 254367 RVA: 0x00EFF0C8 File Offset: 0x00EFD2C8
		public UniTask ShowPreviewAsync(ITotalTopUpPreviewViewParam param)
		{
			TotalTopUpPreviewWeapon37SubView.<ShowPreviewAsync>d__3 <ShowPreviewAsync>d__;
			<ShowPreviewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowPreviewAsync>d__.<>4__this = this;
			<ShowPreviewAsync>d__.param = param;
			<ShowPreviewAsync>d__.<>1__state = -1;
			<ShowPreviewAsync>d__.<>t__builder.Start<TotalTopUpPreviewWeapon37SubView.<ShowPreviewAsync>d__3>(ref <ShowPreviewAsync>d__);
			return <ShowPreviewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E1A0 RID: 254368 RVA: 0x00EFF113 File Offset: 0x00EFD313
		public override void ShowPreview(ITotalTopUpPreviewViewParam param)
		{
			this.ShowPreviewAsync(param).Forget();
		}

		// Token: 0x0603E1A1 RID: 254369 RVA: 0x00EFF124 File Offset: 0x00EFD324
		private void OnClickPreview()
		{
			List<WeaponDataBase> list = new List<WeaponDataBase>();
			foreach (int trialId in this.TrailIdList)
			{
				WeaponTrialData weaponTrialData = new WeaponTrialData();
				weaponTrialData.SetTrialId(trialId, true);
				list.Add(weaponTrialData);
			}
			IWeaponPreviewViewParam param = new WeaponPreviewViewParam
			{
				WeaponDataList = list.ToArray(),
				SelectedIndex = 0
			};
			UiManager.Instance.OpenView(EUiViewName.WeaponPreviewView, param, null);
		}

		// Token: 0x04020714 RID: 132884
		[Nullable(2)]
		private TotalTopUpRecharge37InfoItem RechargeInfo;

		// Token: 0x04020715 RID: 132885
		private List<int> TrailIdList = new List<int>();
	}
}
