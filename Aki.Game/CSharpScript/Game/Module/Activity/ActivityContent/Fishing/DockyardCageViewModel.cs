using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200659E RID: 26014
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardCageViewModel : DockyardWareHouseViewModelBase
	{
		// Token: 0x1700956D RID: 38253
		// (get) Token: 0x0604139E RID: 267166 RVA: 0x00FCE66D File Offset: 0x00FCC86D
		public virtual DockyardCageBackpackPanelModel BackpackPanelModel { [PreserveBaseOverrides] get; } = new DockyardCageBackpackPanelModel();

		// Token: 0x1700956E RID: 38254
		// (get) Token: 0x0604139F RID: 267167 RVA: 0x00FCE675 File Offset: 0x00FCC875
		public virtual DockyardCageListPanelModel ListPanelModel { [PreserveBaseOverrides] get; } = new DockyardCageListPanelModel();

		// Token: 0x1700956F RID: 38255
		// (get) Token: 0x060413A0 RID: 267168 RVA: 0x00FCE67D File Offset: 0x00FCC87D
		protected override CabinType RequestCabinType { get; } = 3;

		// Token: 0x17009570 RID: 38256
		// (get) Token: 0x060413A1 RID: 267169 RVA: 0x00FCE685 File Offset: 0x00FCC885
		protected override int RequestId
		{
			get
			{
				return this.ConfigId;
			}
		}

		// Token: 0x060413A2 RID: 267170 RVA: 0x00FCE68D File Offset: 0x00FCC88D
		protected override void OnInit()
		{
			this.ViewTitle = "Fishing_CageText3";
			this.BackpackPanelModel.Init(this.ConfigId);
			this.ListPanelModel.Init(this.ConfigId);
		}

		// Token: 0x060413A3 RID: 267171 RVA: 0x00FCE6BC File Offset: 0x00FCC8BC
		public override DockyardItemBlockOriginalData GetItemBlockData(int id)
		{
			DockyardItemBlockOriginalData itemBlockData = DockyardModel.Instance.GetItemBlockData(id);
			if (itemBlockData != null)
			{
				return itemBlockData;
			}
			return FishingModel.Instance.GetDataByCage(this.ConfigId, id);
		}

		// Token: 0x04021F51 RID: 139089
		public int ConfigId;
	}
}
