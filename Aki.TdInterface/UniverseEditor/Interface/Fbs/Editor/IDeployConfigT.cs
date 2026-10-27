using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004851 RID: 18513
	public class IDeployConfigT
	{
		// Token: 0x170084EF RID: 34031
		// (get) Token: 0x0601CA74 RID: 117364 RVA: 0x0040D12B File Offset: 0x0040B32B
		// (set) Token: 0x0601CA75 RID: 117365 RVA: 0x0040D133 File Offset: 0x0040B333
		public bool IsShowDeploySettings { get; set; }

		// Token: 0x170084F0 RID: 34032
		// (get) Token: 0x0601CA76 RID: 117366 RVA: 0x0040D13C File Offset: 0x0040B33C
		// (set) Token: 0x0601CA77 RID: 117367 RVA: 0x0040D144 File Offset: 0x0040B344
		public bool IsEnableInputDeployFolder { get; set; }

		// Token: 0x170084F1 RID: 34033
		// (get) Token: 0x0601CA78 RID: 117368 RVA: 0x0040D14D File Offset: 0x0040B34D
		// (set) Token: 0x0601CA79 RID: 117369 RVA: 0x0040D155 File Offset: 0x0040B355
		public List<Record_Int_IEntityDeployConfigT> DefaultEntityDeployConfigByLevelId { get; set; }

		// Token: 0x170084F2 RID: 34034
		// (get) Token: 0x0601CA7A RID: 117370 RVA: 0x0040D15E File Offset: 0x0040B35E
		// (set) Token: 0x0601CA7B RID: 117371 RVA: 0x0040D166 File Offset: 0x0040B366
		public bool IsUseEntityDeployFolder { get; set; }

		// Token: 0x170084F3 RID: 34035
		// (get) Token: 0x0601CA7C RID: 117372 RVA: 0x0040D16F File Offset: 0x0040B36F
		// (set) Token: 0x0601CA7D RID: 117373 RVA: 0x0040D177 File Offset: 0x0040B377
		public List<Record_Int_IActorDeployConfigT> DefaultActorDeployConfigByLevelId { get; set; }

		// Token: 0x170084F4 RID: 34036
		// (get) Token: 0x0601CA7E RID: 117374 RVA: 0x0040D180 File Offset: 0x0040B380
		// (set) Token: 0x0601CA7F RID: 117375 RVA: 0x0040D188 File Offset: 0x0040B388
		public bool IsUseActorDeployFolder { get; set; }

		// Token: 0x170084F5 RID: 34037
		// (get) Token: 0x0601CA80 RID: 117376 RVA: 0x0040D191 File Offset: 0x0040B391
		// (set) Token: 0x0601CA81 RID: 117377 RVA: 0x0040D199 File Offset: 0x0040B399
		public bool IsUsePackId { get; set; }

		// Token: 0x170084F6 RID: 34038
		// (get) Token: 0x0601CA82 RID: 117378 RVA: 0x0040D1A2 File Offset: 0x0040B3A2
		// (set) Token: 0x0601CA83 RID: 117379 RVA: 0x0040D1AA File Offset: 0x0040B3AA
		public List<Record_Int_IntT> DefaultEntityPackIdByLevelId { get; set; }

		// Token: 0x170084F7 RID: 34039
		// (get) Token: 0x0601CA84 RID: 117380 RVA: 0x0040D1B3 File Offset: 0x0040B3B3
		// (set) Token: 0x0601CA85 RID: 117381 RVA: 0x0040D1BB File Offset: 0x0040B3BB
		public List<IComponentFieldModificationT> PostProcessComponents { get; set; }

		// Token: 0x0601CA86 RID: 117382 RVA: 0x0040D1C4 File Offset: 0x0040B3C4
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
