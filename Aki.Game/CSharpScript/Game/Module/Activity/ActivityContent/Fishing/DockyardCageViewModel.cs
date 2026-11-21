using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200551C RID: 21788
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardCageViewModel : DockyardWareHouseViewModelBase
	{
		// Token: 0x170068CF RID: 26831
		// (get) Token: 0x06036063 RID: 221283 RVA: 0x00F15681 File Offset: 0x00F13881
		public virtual DockyardCageBackpackPanelModel BackpackPanelModel { [PreserveBaseOverrides] get; } = new DockyardCageBackpackPanelModel();

		// Token: 0x170068D0 RID: 26832
		// (get) Token: 0x06036064 RID: 221284 RVA: 0x00F15689 File Offset: 0x00F13889
		public virtual DockyardCageListPanelModel ListPanelModel { [PreserveBaseOverrides] get; } = new DockyardCageListPanelModel();

		// Token: 0x170068D1 RID: 26833
		// (get) Token: 0x06036065 RID: 221285 RVA: 0x00F15691 File Offset: 0x00F13891
		protected override CabinType RequestCabinType { get; } = 3;

		// Token: 0x170068D2 RID: 26834
		// (get) Token: 0x06036066 RID: 221286 RVA: 0x00F15699 File Offset: 0x00F13899
		protected override int RequestId
		{
			get
			{
				return this.ConfigId;
			}
		}

		// Token: 0x06036067 RID: 221287 RVA: 0x00F156A1 File Offset: 0x00F138A1
		protected override void OnInit()
		{
			this.ViewTitle = "Fishing_CageText3";
			this.BackpackPanelModel.Init(this.ConfigId);
			this.ListPanelModel.Init(this.ConfigId);
		}

		// Token: 0x06036068 RID: 221288 RVA: 0x00F156D0 File Offset: 0x00F138D0
		public override DockyardItemBlockOriginalData GetItemBlockData(int id)
		{
			DockyardItemBlockOriginalData itemBlockData = DockyardModel.Instance.GetItemBlockData(id);
			if (itemBlockData != null)
			{
				return itemBlockData;
			}
			return FishingModel.Instance.GetDataByCage(this.ConfigId, id);
		}

		// Token: 0x0401C882 RID: 116866
		public int ConfigId;
	}
}
