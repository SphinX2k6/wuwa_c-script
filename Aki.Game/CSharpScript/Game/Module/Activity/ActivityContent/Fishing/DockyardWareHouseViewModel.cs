using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065D4 RID: 26068
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardWareHouseViewModel : DockyardWareHouseViewModelBase
	{
		// Token: 0x17009595 RID: 38293
		// (get) Token: 0x06041608 RID: 267784 RVA: 0x00FD7B5E File Offset: 0x00FD5D5E
		public virtual DockyardWareHouseBackpackPanelModel BackpackPanelModel { [PreserveBaseOverrides] get; } = new DockyardWareHouseBackpackPanelModel();

		// Token: 0x17009596 RID: 38294
		// (get) Token: 0x06041609 RID: 267785 RVA: 0x00FD7B66 File Offset: 0x00FD5D66
		public virtual DockyardWareHouseListPanelModel ListPanelModel { [PreserveBaseOverrides] get; } = new DockyardWareHouseListPanelModel();

		// Token: 0x17009597 RID: 38295
		// (get) Token: 0x0604160A RID: 267786 RVA: 0x00FD7B6E File Offset: 0x00FD5D6E
		protected override CabinType RequestCabinType { get; } = 1;

		// Token: 0x0604160C RID: 267788 RVA: 0x00FD7B9B File Offset: 0x00FD5D9B
		protected override void OnInit()
		{
			this.ViewTitle = "Fishing_CageText4";
		}

		// Token: 0x0604160D RID: 267789 RVA: 0x00FD7BA8 File Offset: 0x00FD5DA8
		protected override void OnCloseClick()
		{
			if (!this.InGameplayFlow)
			{
				FishingController.Instance.ShowConfirmBoxAndRequestFishingExit(delegate(bool success)
				{
					if (success)
					{
						DockyardWareHouseView view2 = this.View;
						if (view2 == null)
						{
							return;
						}
						view2.CloseMe(null);
					}
				});
				return;
			}
			DockyardWareHouseView view = this.View;
			if (view == null)
			{
				return;
			}
			view.CloseMe(null);
		}

		// Token: 0x0604160E RID: 267790 RVA: 0x00FD7BDC File Offset: 0x00FD5DDC
		public override UniTask BeforeStartAsync()
		{
			DockyardWareHouseViewModel.<BeforeStartAsync>d__13 <BeforeStartAsync>d__;
			<BeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<BeforeStartAsync>d__.<>4__this = this;
			<BeforeStartAsync>d__.<>1__state = -1;
			<BeforeStartAsync>d__.<>t__builder.Start<DockyardWareHouseViewModel.<BeforeStartAsync>d__13>(ref <BeforeStartAsync>d__);
			return <BeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604160F RID: 267791 RVA: 0x00FD7C1F File Offset: 0x00FD5E1F
		[NullableContext(2)]
		public override DockyardItemBlockOriginalData GetItemBlockData(int id)
		{
			return DockyardModel.Instance.GetItemBlockData(id);
		}

		// Token: 0x04022031 RID: 139313
		public bool InGameplayFlow;
	}
}
