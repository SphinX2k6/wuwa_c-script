using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005606 RID: 22022
	public class INoiseRemovalComponentT
	{
		// Token: 0x1700A2F5 RID: 41717
		// (get) Token: 0x060248BD RID: 149693 RVA: 0x0050B2CD File Offset: 0x005094CD
		// (set) Token: 0x060248BE RID: 149694 RVA: 0x0050B2D5 File Offset: 0x005094D5
		public bool Disabled { get; set; }

		// Token: 0x1700A2F6 RID: 41718
		// (get) Token: 0x060248BF RID: 149695 RVA: 0x0050B2DE File Offset: 0x005094DE
		// (set) Token: 0x060248C0 RID: 149696 RVA: 0x0050B2E6 File Offset: 0x005094E6
		public List<INoiseRemovalNodeT> Nodes { get; set; }

		// Token: 0x1700A2F7 RID: 41719
		// (get) Token: 0x060248C1 RID: 149697 RVA: 0x0050B2EF File Offset: 0x005094EF
		// (set) Token: 0x060248C2 RID: 149698 RVA: 0x0050B2F7 File Offset: 0x005094F7
		public string CompleteState { get; set; }

		// Token: 0x1700A2F8 RID: 41720
		// (get) Token: 0x060248C3 RID: 149699 RVA: 0x0050B300 File Offset: 0x00509500
		// (set) Token: 0x060248C4 RID: 149700 RVA: 0x0050B308 File Offset: 0x00509508
		public TNoiseRemovalBoarderUnion NoiseRemovalBoarder { get; set; }

		// Token: 0x1700A2F9 RID: 41721
		// (get) Token: 0x060248C5 RID: 149701 RVA: 0x0050B311 File Offset: 0x00509511
		// (set) Token: 0x060248C6 RID: 149702 RVA: 0x0050B319 File Offset: 0x00509519
		public int RotationAngle { get; set; }

		// Token: 0x1700A2FA RID: 41722
		// (get) Token: 0x060248C7 RID: 149703 RVA: 0x0050B322 File Offset: 0x00509522
		// (set) Token: 0x060248C8 RID: 149704 RVA: 0x0050B32A File Offset: 0x0050952A
		public byte NullMask { get; set; }

		// Token: 0x060248C9 RID: 149705 RVA: 0x0050B333 File Offset: 0x00509533
		public INoiseRemovalComponentT()
		{
			this.Disabled = false;
			this.Nodes = null;
			this.CompleteState = null;
			this.NoiseRemovalBoarder = null;
			this.RotationAngle = 0;
			this.NullMask = 0;
		}
	}
}
