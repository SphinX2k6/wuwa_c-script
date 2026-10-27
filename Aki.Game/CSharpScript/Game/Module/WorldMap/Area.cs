using System;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x02004781 RID: 18305
	public class Area : IArea
	{
		// Token: 0x17007783 RID: 30595
		// (get) Token: 0x0602FE1B RID: 196123 RVA: 0x00B19ADD File Offset: 0x00B17CDD
		// (set) Token: 0x0602FE1C RID: 196124 RVA: 0x00B19AE5 File Offset: 0x00B17CE5
		public double MinX { get; set; }

		// Token: 0x17007784 RID: 30596
		// (get) Token: 0x0602FE1D RID: 196125 RVA: 0x00B19AEE File Offset: 0x00B17CEE
		// (set) Token: 0x0602FE1E RID: 196126 RVA: 0x00B19AF6 File Offset: 0x00B17CF6
		public double MaxX { get; set; }

		// Token: 0x17007785 RID: 30597
		// (get) Token: 0x0602FE1F RID: 196127 RVA: 0x00B19AFF File Offset: 0x00B17CFF
		// (set) Token: 0x0602FE20 RID: 196128 RVA: 0x00B19B07 File Offset: 0x00B17D07
		public double MinY { get; set; }

		// Token: 0x17007786 RID: 30598
		// (get) Token: 0x0602FE21 RID: 196129 RVA: 0x00B19B10 File Offset: 0x00B17D10
		// (set) Token: 0x0602FE22 RID: 196130 RVA: 0x00B19B18 File Offset: 0x00B17D18
		public double MaxY { get; set; }
	}
}
