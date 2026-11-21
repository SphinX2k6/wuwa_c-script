using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055AB RID: 21931
	public class ICurveControlComponentT
	{
		// Token: 0x17009D0C RID: 40204
		// (get) Token: 0x06022E3B RID: 142907 RVA: 0x004CE081 File Offset: 0x004CC281
		// (set) Token: 0x06022E3C RID: 142908 RVA: 0x004CE089 File Offset: 0x004CC289
		public bool Disabled { get; set; }

		// Token: 0x17009D0D RID: 40205
		// (get) Token: 0x06022E3D RID: 142909 RVA: 0x004CE092 File Offset: 0x004CC292
		// (set) Token: 0x06022E3E RID: 142910 RVA: 0x004CE09A File Offset: 0x004CC29A
		public IChargeSlashControlT CurveControlConfig { get; set; }

		// Token: 0x17009D0E RID: 40206
		// (get) Token: 0x06022E3F RID: 142911 RVA: 0x004CE0A3 File Offset: 0x004CC2A3
		// (set) Token: 0x06022E40 RID: 142912 RVA: 0x004CE0AB File Offset: 0x004CC2AB
		public byte NullMask { get; set; }

		// Token: 0x06022E41 RID: 142913 RVA: 0x004CE0B4 File Offset: 0x004CC2B4
		public ICurveControlComponentT()
		{
			this.Disabled = false;
			this.CurveControlConfig = null;
			this.NullMask = 0;
		}
	}
}
