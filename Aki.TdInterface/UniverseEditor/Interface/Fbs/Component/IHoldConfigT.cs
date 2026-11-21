using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005934 RID: 22836
	public class IHoldConfigT
	{
		// Token: 0x1700A59F RID: 42399
		// (get) Token: 0x06025238 RID: 152120 RVA: 0x00518B03 File Offset: 0x00516D03
		// (set) Token: 0x06025239 RID: 152121 RVA: 0x00518B0B File Offset: 0x00516D0B
		public int HoldSwingFreq { get; set; }

		// Token: 0x1700A5A0 RID: 42400
		// (get) Token: 0x0602523A RID: 152122 RVA: 0x00518B14 File Offset: 0x00516D14
		// (set) Token: 0x0602523B RID: 152123 RVA: 0x00518B1C File Offset: 0x00516D1C
		public int HoldAngularVelocity { get; set; }

		// Token: 0x1700A5A1 RID: 42401
		// (get) Token: 0x0602523C RID: 152124 RVA: 0x00518B25 File Offset: 0x00516D25
		// (set) Token: 0x0602523D RID: 152125 RVA: 0x00518B2D File Offset: 0x00516D2D
		public IVectorInfoT HoldRotation { get; set; }

		// Token: 0x1700A5A2 RID: 42402
		// (get) Token: 0x0602523E RID: 152126 RVA: 0x00518B36 File Offset: 0x00516D36
		// (set) Token: 0x0602523F RID: 152127 RVA: 0x00518B3E File Offset: 0x00516D3E
		public IVectorInfoT HoldOffset { get; set; }

		// Token: 0x1700A5A3 RID: 42403
		// (get) Token: 0x06025240 RID: 152128 RVA: 0x00518B47 File Offset: 0x00516D47
		// (set) Token: 0x06025241 RID: 152129 RVA: 0x00518B4F File Offset: 0x00516D4F
		public IVectorInfoT SecondaryOffset { get; set; }

		// Token: 0x1700A5A4 RID: 42404
		// (get) Token: 0x06025242 RID: 152130 RVA: 0x00518B58 File Offset: 0x00516D58
		// (set) Token: 0x06025243 RID: 152131 RVA: 0x00518B60 File Offset: 0x00516D60
		public int HoldSwingRange { get; set; }

		// Token: 0x1700A5A5 RID: 42405
		// (get) Token: 0x06025244 RID: 152132 RVA: 0x00518B69 File Offset: 0x00516D69
		// (set) Token: 0x06025245 RID: 152133 RVA: 0x00518B71 File Offset: 0x00516D71
		public string HoldCameraShake { get; set; }

		// Token: 0x1700A5A6 RID: 42406
		// (get) Token: 0x06025246 RID: 152134 RVA: 0x00518B7A File Offset: 0x00516D7A
		// (set) Token: 0x06025247 RID: 152135 RVA: 0x00518B82 File Offset: 0x00516D82
		public string HoldCameraStateTag { get; set; }

		// Token: 0x06025248 RID: 152136 RVA: 0x00518B8B File Offset: 0x00516D8B
		public IHoldConfigT()
		{
			this.HoldSwingFreq = 0;
			this.HoldAngularVelocity = 0;
			this.HoldRotation = null;
			this.HoldOffset = null;
			this.SecondaryOffset = null;
			this.HoldSwingRange = 0;
			this.HoldCameraShake = null;
			this.HoldCameraStateTag = null;
		}
	}
}
