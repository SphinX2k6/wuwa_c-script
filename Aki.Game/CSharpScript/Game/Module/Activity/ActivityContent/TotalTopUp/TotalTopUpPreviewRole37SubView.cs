using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005FA9 RID: 24489
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpPreviewRole37SubView : TotalTopUpPreviewSubViewBase
	{
		// Token: 0x0603E191 RID: 254353 RVA: 0x00EFEDD8 File Offset: 0x00EFCFD8
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

		// Token: 0x0603E192 RID: 254354 RVA: 0x00EFEE40 File Offset: 0x00EFD040
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

		// Token: 0x0603E193 RID: 254355 RVA: 0x00EFEE8B File Offset: 0x00EFD08B
		public override void ShowPreview(ITotalTopUpPreviewViewParam param)
		{
			this.ShowPreviewAsync(param).Forget();
		}

		// Token: 0x0603E194 RID: 254356 RVA: 0x00EFEE9C File Offset: 0x00EFD09C
		private void OnClickPreview()
		{
			RoleController.Instance.OpenRoleMainView(ERoleAgentType.Preview, 0, this.TrailIdList, null, null);
		}

		// Token: 0x0603E195 RID: 254357 RVA: 0x00EFEEC5 File Offset: 0x00EFD0C5
		private void OnClickHelp()
		{
			if (this.PropsItemId <= 0)
			{
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(this.PropsItemId, false, null);
		}

		// Token: 0x04020708 RID: 132872
		[Nullable(2)]
		private TotalTopUpRecharge37InfoItem RechargeInfo;

		// Token: 0x04020709 RID: 132873
		private List<int> TrailIdList = new List<int>();

		// Token: 0x0402070A RID: 132874
		private int PropsItemId;
	}
}
