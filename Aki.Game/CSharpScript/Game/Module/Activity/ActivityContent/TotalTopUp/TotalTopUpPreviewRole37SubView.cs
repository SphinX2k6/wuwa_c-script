using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004F90 RID: 20368
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpPreviewRole37SubView : TotalTopUpPreviewSubViewBase
	{
		// Token: 0x0603312B RID: 209195 RVA: 0x00E50A94 File Offset: 0x00E4EC94
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

		// Token: 0x0603312C RID: 209196 RVA: 0x00E50AFC File Offset: 0x00E4ECFC
		public UniTask ShowPreviewAsync(ITotalTopUpPreviewViewParam param)
		{
			TotalTopUpPreviewRole37SubView.<ShowPreviewAsync>d__4 <ShowPreviewAsync>d__;
			<ShowPreviewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowPreviewAsync>d__.<>4__this = this;
			<ShowPreviewAsync>d__.param = param;
			<ShowPreviewAsync>d__.<>1__state = -1;
			<ShowPreviewAsync>d__.<>t__builder.Start<TotalTopUpPreviewRole37SubView.<ShowPreviewAsync>d__4>(ref <ShowPreviewAsync>d__);
			return <ShowPreviewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603312D RID: 209197 RVA: 0x00E50B47 File Offset: 0x00E4ED47
		public override void ShowPreview(ITotalTopUpPreviewViewParam param)
		{
			this.ShowPreviewAsync(param).Forget();
		}

		// Token: 0x0603312E RID: 209198 RVA: 0x00E50B58 File Offset: 0x00E4ED58
		private void OnClickPreview()
		{
			RoleController.Instance.OpenRoleMainView(ERoleAgentType.Preview, 0, this.TrailIdList, null, null);
		}

		// Token: 0x0603312F RID: 209199 RVA: 0x00E50B81 File Offset: 0x00E4ED81
		private void OnClickHelp()
		{
			if (this.PropsItemId <= 0)
			{
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(this.PropsItemId, false, null, false);
		}

		// Token: 0x0401B1DA RID: 111066
		[Nullable(2)]
		private TotalTopUpRecharge37InfoItem RechargeInfo;

		// Token: 0x0401B1DB RID: 111067
		private List<int> TrailIdList = new List<int>();

		// Token: 0x0401B1DC RID: 111068
		private int PropsItemId;
	}
}
