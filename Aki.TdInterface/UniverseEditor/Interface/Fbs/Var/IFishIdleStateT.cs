using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E8D RID: 16013
	public class IFishIdleStateT
	{
		// Token: 0x17006C40 RID: 27712
		// (get) Token: 0x060159E0 RID: 88544 RVA: 0x0031D776 File Offset: 0x0031B976
		// (set) Token: 0x060159E1 RID: 88545 RVA: 0x0031D77E File Offset: 0x0031B97E
		public EFishState Type { get; set; }

		// Token: 0x17006C41 RID: 27713
		// (get) Token: 0x060159E2 RID: 88546 RVA: 0x0031D787 File Offset: 0x0031B987
		// (set) Token: 0x060159E3 RID: 88547 RVA: 0x0031D78F File Offset: 0x0031B98F
		public bool EnableFlee { get; set; }

		// Token: 0x17006C42 RID: 27714
		// (get) Token: 0x060159E4 RID: 88548 RVA: 0x0031D798 File Offset: 0x0031B998
		// (set) Token: 0x060159E5 RID: 88549 RVA: 0x0031D7A0 File Offset: 0x0031B9A0
		public float FleeRadius { get; set; }

		// Token: 0x17006C43 RID: 27715
		// (get) Token: 0x060159E6 RID: 88550 RVA: 0x0031D7A9 File Offset: 0x0031B9A9
		// (set) Token: 0x060159E7 RID: 88551 RVA: 0x0031D7B1 File Offset: 0x0031B9B1
		public bool UseRangeComponent { get; set; }

		// Token: 0x17006C44 RID: 27716
		// (get) Token: 0x060159E8 RID: 88552 RVA: 0x0031D7BA File Offset: 0x0031B9BA
		// (set) Token: 0x060159E9 RID: 88553 RVA: 0x0031D7C2 File Offset: 0x0031B9C2
		public byte NullMask { get; set; }

		// Token: 0x060159EA RID: 88554 RVA: 0x0031D7CB File Offset: 0x0031B9CB
		public IFishIdleStateT()
		{
			this.Type = EFishState.Idle;
			this.EnableFlee = false;
			this.FleeRadius = 0f;
			this.UseRangeComponent = false;
			this.NullMask = 0;
		}
	}
}
