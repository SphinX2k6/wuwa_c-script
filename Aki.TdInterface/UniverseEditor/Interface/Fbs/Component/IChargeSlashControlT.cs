using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054B8 RID: 21688
	public class IChargeSlashControlT
	{
		// Token: 0x17009AAA RID: 39594
		// (get) Token: 0x060222B3 RID: 139955 RVA: 0x004B5A71 File Offset: 0x004B3C71
		// (set) Token: 0x060222B4 RID: 139956 RVA: 0x004B5A79 File Offset: 0x004B3C79
		public ECurveControlType Type { get; set; }

		// Token: 0x17009AAB RID: 39595
		// (get) Token: 0x060222B5 RID: 139957 RVA: 0x004B5A82 File Offset: 0x004B3C82
		// (set) Token: 0x060222B6 RID: 139958 RVA: 0x004B5A8A File Offset: 0x004B3C8A
		public int UpHeight { get; set; }

		// Token: 0x17009AAC RID: 39596
		// (get) Token: 0x060222B7 RID: 139959 RVA: 0x004B5A93 File Offset: 0x004B3C93
		// (set) Token: 0x060222B8 RID: 139960 RVA: 0x004B5A9B File Offset: 0x004B3C9B
		public string UpCurvePath { get; set; }

		// Token: 0x060222B9 RID: 139961 RVA: 0x004B5AA4 File Offset: 0x004B3CA4
		public IChargeSlashControlT()
		{
			this.Type = ECurveControlType.ChargeSlash;
			this.UpHeight = 0;
			this.UpCurvePath = null;
		}
	}
}
