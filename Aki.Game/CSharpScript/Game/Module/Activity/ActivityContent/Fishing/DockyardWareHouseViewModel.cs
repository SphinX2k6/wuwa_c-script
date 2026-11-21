using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005552 RID: 21842
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardWareHouseViewModel : DockyardWareHouseViewModelBase
	{
		// Token: 0x170068F7 RID: 26871
		// (get) Token: 0x060362CD RID: 221901 RVA: 0x00F1EB9E File Offset: 0x00F1CD9E
		public virtual DockyardWareHouseBackpackPanelModel BackpackPanelModel { [PreserveBaseOverrides] get; } = new DockyardWareHouseBackpackPanelModel();

		// Token: 0x170068F8 RID: 26872
		// (get) Token: 0x060362CE RID: 221902 RVA: 0x00F1EBA6 File Offset: 0x00F1CDA6
		public virtual DockyardWareHouseListPanelModel ListPanelModel { [PreserveBaseOverrides] get; } = new DockyardWareHouseListPanelModel();

		// Token: 0x170068F9 RID: 26873
		// (get) Token: 0x060362CF RID: 221903 RVA: 0x00F1EBAE File Offset: 0x00F1CDAE
		protected override CabinType RequestCabinType { get; } = 1;

		// Token: 0x060362D1 RID: 221905 RVA: 0x00F1EBDB File Offset: 0x00F1CDDB
		protected override void OnInit()
		{
			this.ViewTitle = "Fishing_CageText4";
		}

		// Token: 0x060362D2 RID: 221906 RVA: 0x00F1EBE8 File Offset: 0x00F1CDE8
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

		// Token: 0x060362D3 RID: 221907 RVA: 0x00F1EC1C File Offset: 0x00F1CE1C
		public override UniTask BeforeStartAsync()
		{
			DockyardWareHouseViewModel.<BeforeStartAsync>d__13 <BeforeStartAsync>d__;
			<BeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<BeforeStartAsync>d__.<>4__this = this;
			<BeforeStartAsync>d__.<>1__state = -1;
			<BeforeStartAsync>d__.<>t__builder.Start<DockyardWareHouseViewModel.<BeforeStartAsync>d__13>(ref <BeforeStartAsync>d__);
			return <BeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060362D4 RID: 221908 RVA: 0x00F1EC5F File Offset: 0x00F1CE5F
		[NullableContext(2)]
		public override DockyardItemBlockOriginalData GetItemBlockData(int id)
		{
			return DockyardModel.Instance.GetItemBlockData(id);
		}

		// Token: 0x0401C962 RID: 117090
		public bool InGameplayFlow;
	}
}
