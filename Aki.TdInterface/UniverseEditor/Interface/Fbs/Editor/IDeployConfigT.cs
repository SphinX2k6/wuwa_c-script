using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CB9 RID: 19641
	public class IDeployConfigT
	{
		// Token: 0x17008B3A RID: 35642
		// (get) Token: 0x0601E271 RID: 123505 RVA: 0x00439A7B File Offset: 0x00437C7B
		// (set) Token: 0x0601E272 RID: 123506 RVA: 0x00439A83 File Offset: 0x00437C83
		public bool IsShowDeploySettings { get; set; }

		// Token: 0x17008B3B RID: 35643
		// (get) Token: 0x0601E273 RID: 123507 RVA: 0x00439A8C File Offset: 0x00437C8C
		// (set) Token: 0x0601E274 RID: 123508 RVA: 0x00439A94 File Offset: 0x00437C94
		public bool IsEnableInputDeployFolder { get; set; }

		// Token: 0x17008B3C RID: 35644
		// (get) Token: 0x0601E275 RID: 123509 RVA: 0x00439A9D File Offset: 0x00437C9D
		// (set) Token: 0x0601E276 RID: 123510 RVA: 0x00439AA5 File Offset: 0x00437CA5
		public List<Record_Int_IEntityDeployConfigT> DefaultEntityDeployConfigByLevelId { get; set; }

		// Token: 0x17008B3D RID: 35645
		// (get) Token: 0x0601E277 RID: 123511 RVA: 0x00439AAE File Offset: 0x00437CAE
		// (set) Token: 0x0601E278 RID: 123512 RVA: 0x00439AB6 File Offset: 0x00437CB6
		public bool IsUseEntityDeployFolder { get; set; }

		// Token: 0x17008B3E RID: 35646
		// (get) Token: 0x0601E279 RID: 123513 RVA: 0x00439ABF File Offset: 0x00437CBF
		// (set) Token: 0x0601E27A RID: 123514 RVA: 0x00439AC7 File Offset: 0x00437CC7
		public List<Record_Int_IActorDeployConfigT> DefaultActorDeployConfigByLevelId { get; set; }

		// Token: 0x17008B3F RID: 35647
		// (get) Token: 0x0601E27B RID: 123515 RVA: 0x00439AD0 File Offset: 0x00437CD0
		// (set) Token: 0x0601E27C RID: 123516 RVA: 0x00439AD8 File Offset: 0x00437CD8
		public bool IsUseActorDeployFolder { get; set; }

		// Token: 0x17008B40 RID: 35648
		// (get) Token: 0x0601E27D RID: 123517 RVA: 0x00439AE1 File Offset: 0x00437CE1
		// (set) Token: 0x0601E27E RID: 123518 RVA: 0x00439AE9 File Offset: 0x00437CE9
		public bool IsUsePackId { get; set; }

		// Token: 0x17008B41 RID: 35649
		// (get) Token: 0x0601E27F RID: 123519 RVA: 0x00439AF2 File Offset: 0x00437CF2
		// (set) Token: 0x0601E280 RID: 123520 RVA: 0x00439AFA File Offset: 0x00437CFA
		public List<Record_Int_IntT> DefaultEntityPackIdByLevelId { get; set; }

		// Token: 0x17008B42 RID: 35650
		// (get) Token: 0x0601E281 RID: 123521 RVA: 0x00439B03 File Offset: 0x00437D03
		// (set) Token: 0x0601E282 RID: 123522 RVA: 0x00439B0B File Offset: 0x00437D0B
		public List<IComponentFieldModificationT> PostProcessComponents { get; set; }

		// Token: 0x0601E283 RID: 123523 RVA: 0x00439B14 File Offset: 0x00437D14
		public IDeployConfigT()
		{
			this.IsShowDeploySettings = false;
			this.IsEnableInputDeployFolder = false;
			this.DefaultEntityDeployConfigByLevelId = null;
			this.IsUseEntityDeployFolder = false;
			this.DefaultActorDeployConfigByLevelId = null;
			this.IsUseActorDeployFolder = false;
			this.IsUsePackId = false;
			this.DefaultEntityPackIdByLevelId = null;
			this.PostProcessComponents = null;
		}
	}
}
