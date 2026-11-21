using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AAE RID: 27310
	public class ICloseSplineMovePatternT
	{
		// Token: 0x1700C89C RID: 51356
		// (get) Token: 0x0602EE13 RID: 192019 RVA: 0x006633BE File Offset: 0x006615BE
		// (set) Token: 0x0602EE14 RID: 192020 RVA: 0x006633C6 File Offset: 0x006615C6
		public ESplineMovePattern Type { get; set; }

		// Token: 0x1700C89D RID: 51357
		// (get) Token: 0x0602EE15 RID: 192021 RVA: 0x006633CF File Offset: 0x006615CF
		// (set) Token: 0x0602EE16 RID: 192022 RVA: 0x006633D7 File Offset: 0x006615D7
		public float GravitySwitchAngularVelocity { get; set; }

		// Token: 0x1700C89E RID: 51358
		// (get) Token: 0x0602EE17 RID: 192023 RVA: 0x006633E0 File Offset: 0x006615E0
		// (set) Token: 0x0602EE18 RID: 192024 RVA: 0x006633E8 File Offset: 0x006615E8
		public byte NullMask { get; set; }

		// Token: 0x0602EE19 RID: 192025 RVA: 0x006633F1 File Offset: 0x006615F1
		public ICloseSplineMovePatternT()
		{
			this.Type = ESplineMovePattern.PathLine;
			this.GravitySwitchAngularVelocity = 0f;
			this.NullMask = 0;
		}
	}
}
