using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004F95 RID: 20373
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpPreviewWeapon37SubView : TotalTopUpPreviewSubViewBase
	{
		// Token: 0x06033138 RID: 209208 RVA: 0x00E50D1C File Offset: 0x00E4EF1C
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

		// Token: 0x06033139 RID: 209209 RVA: 0x00E50D84 File Offset: 0x00E4EF84
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

		// Token: 0x0603313A RID: 209210 RVA: 0x00E50DCF File Offset: 0x00E4EFCF
		public override void ShowPreview(ITotalTopUpPreviewViewParam param)
		{
			this.ShowPreviewAsync(param).Forget();
		}

		// Token: 0x0603313B RID: 209211 RVA: 0x00E50DE0 File Offset: 0x00E4EFE0
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

		// Token: 0x0401B1E6 RID: 111078
		[Nullable(2)]
		private TotalTopUpRecharge37InfoItem RechargeInfo;

		// Token: 0x0401B1E7 RID: 111079
		private List<int> TrailIdList = new List<int>();
	}
}
