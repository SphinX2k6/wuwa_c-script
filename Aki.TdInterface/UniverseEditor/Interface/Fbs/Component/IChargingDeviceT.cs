using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F8F RID: 20367
	public class IChargingDeviceT
	{
		// Token: 0x17009355 RID: 37717
		// (get) Token: 0x060205DB RID: 132571 RVA: 0x00480D9A File Offset: 0x0047EF9A
		// (set) Token: 0x060205DC RID: 132572 RVA: 0x00480DA2 File Offset: 0x0047EFA2
		public EProgressBarControlType Type { get; set; }

		// Token: 0x17009356 RID: 37718
		// (get) Token: 0x060205DD RID: 132573 RVA: 0x00480DAB File Offset: 0x0047EFAB
		// (set) Token: 0x060205DE RID: 132574 RVA: 0x00480DB3 File Offset: 0x0047EFB3
		public int MaxValue { get; set; }

		// Token: 0x17009357 RID: 37719
		// (get) Token: 0x060205DF RID: 132575 RVA: 0x00480DBC File Offset: 0x0047EFBC
		// (set) Token: 0x060205E0 RID: 132576 RVA: 0x00480DC4 File Offset: 0x0047EFC4
		public int InitValue { get; set; }

		// Token: 0x17009358 RID: 37720
		// (get) Token: 0x060205E1 RID: 132577 RVA: 0x00480DCD File Offset: 0x0047EFCD
		// (set) Token: 0x060205E2 RID: 132578 RVA: 0x00480DD5 File Offset: 0x0047EFD5
		public int ProgressPerformanceAttribute { get; set; }

		// Token: 0x17009359 RID: 37721
		// (get) Token: 0x060205E3 RID: 132579 RVA: 0x00480DDE File Offset: 0x0047EFDE
		// (set) Token: 0x060205E4 RID: 132580 RVA: 0x00480DE6 File Offset: 0x0047EFE6
		public int IncreaseSpeed { get; set; }

		// Token: 0x1700935A RID: 37722
		// (get) Token: 0x060205E5 RID: 132581 RVA: 0x00480DEF File Offset: 0x0047EFEF
		// (set) Token: 0x060205E6 RID: 132582 RVA: 0x00480DF7 File Offset: 0x0047EFF7
		public int HitExtraValue { get; set; }

		// Token: 0x1700935B RID: 37723
		// (get) Token: 0x060205E7 RID: 132583 RVA: 0x00480E00 File Offset: 0x0047F000
		// (set) Token: 0x060205E8 RID: 132584 RVA: 0x00480E08 File Offset: 0x0047F008
		public byte NullMask { get; set; }

		// Token: 0x060205E9 RID: 132585 RVA: 0x00480E11 File Offset: 0x0047F011
		public IChargingDeviceT()
		{
			this.Type = EProgressBarControlType.CaptureStrategicPoint;
			this.MaxValue = 0;
			this.InitValue = 0;
			this.ProgressPerformanceAttribute = 0;
			this.IncreaseSpeed = 0;
			this.HitExtraValue = 0;
			this.NullMask = 0;
		}
	}
}
