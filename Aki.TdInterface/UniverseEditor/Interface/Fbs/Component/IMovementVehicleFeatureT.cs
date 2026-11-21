using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B80 RID: 23424
	public class IMovementVehicleFeatureT
	{
		// Token: 0x1700AB3A RID: 43834
		// (get) Token: 0x060269A6 RID: 158118 RVA: 0x00549643 File Offset: 0x00547843
		// (set) Token: 0x060269A7 RID: 158119 RVA: 0x0054964B File Offset: 0x0054784B
		public EVehicleFeatureFlag Type { get; set; }

		// Token: 0x1700AB3B RID: 43835
		// (get) Token: 0x060269A8 RID: 158120 RVA: 0x00549654 File Offset: 0x00547854
		// (set) Token: 0x060269A9 RID: 158121 RVA: 0x0054965C File Offset: 0x0054785C
		public int MoveSpline { get; set; }

		// Token: 0x1700AB3C RID: 43836
		// (get) Token: 0x060269AA RID: 158122 RVA: 0x00549665 File Offset: 0x00547865
		// (set) Token: 0x060269AB RID: 158123 RVA: 0x0054966D File Offset: 0x0054786D
		public IMovementPerformConfigT MovePerformConfig { get; set; }

		// Token: 0x1700AB3D RID: 43837
		// (get) Token: 0x060269AC RID: 158124 RVA: 0x00549676 File Offset: 0x00547876
		// (set) Token: 0x060269AD RID: 158125 RVA: 0x0054967E File Offset: 0x0054787E
		public byte NullMask { get; set; }

		// Token: 0x060269AE RID: 158126 RVA: 0x00549687 File Offset: 0x00547887
		public IMovementVehicleFeatureT()
		{
			this.Type = EVehicleFeatureFlag.None;
			this.MoveSpline = 0;
			this.MovePerformConfig = null;
			this.NullMask = 0;
		}
	}
}
