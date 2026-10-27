using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058C8 RID: 22728
	public class ISceneItemLifeCycleComponentT
	{
		// Token: 0x1700AA2E RID: 43566
		// (get) Token: 0x060265B6 RID: 157110 RVA: 0x0054942F File Offset: 0x0054762F
		// (set) Token: 0x060265B7 RID: 157111 RVA: 0x00549437 File Offset: 0x00547637
		public bool Disabled { get; set; }

		// Token: 0x1700AA2F RID: 43567
		// (get) Token: 0x060265B8 RID: 157112 RVA: 0x00549440 File Offset: 0x00547640
		// (set) Token: 0x060265B9 RID: 157113 RVA: 0x00549448 File Offset: 0x00547648
		public ICreateStageConfigT CreateStageConfig { get; set; }

		// Token: 0x1700AA30 RID: 43568
		// (get) Token: 0x060265BA RID: 157114 RVA: 0x00549451 File Offset: 0x00547651
		// (set) Token: 0x060265BB RID: 157115 RVA: 0x00549459 File Offset: 0x00547659
		public IDestroyStageConfigT DestroyStageConfig { get; set; }

		// Token: 0x1700AA31 RID: 43569
		// (get) Token: 0x060265BC RID: 157116 RVA: 0x00549462 File Offset: 0x00547662
		// (set) Token: 0x060265BD RID: 157117 RVA: 0x0054946A File Offset: 0x0054766A
		public byte NullMask { get; set; }

		// Token: 0x060265BE RID: 157118 RVA: 0x00549473 File Offset: 0x00547673
		public ISceneItemLifeCycleComponentT()
		{
			this.Disabled = false;
			this.CreateStageConfig = null;
			this.DestroyStageConfig = null;
			this.NullMask = 0;
		}
	}
}
