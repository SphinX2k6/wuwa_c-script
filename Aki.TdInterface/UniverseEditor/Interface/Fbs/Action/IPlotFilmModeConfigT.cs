using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074CF RID: 29903
	public class IPlotFilmModeConfigT
	{
		// Token: 0x1700DC05 RID: 56325
		// (get) Token: 0x060346B4 RID: 214708 RVA: 0x0070EF9C File Offset: 0x0070D19C
		// (set) Token: 0x060346B5 RID: 214709 RVA: 0x0070EFA4 File Offset: 0x0070D1A4
		public bool IsAdaptFilmAspectRatio { get; set; }

		// Token: 0x1700DC06 RID: 56326
		// (get) Token: 0x060346B6 RID: 214710 RVA: 0x0070EFAD File Offset: 0x0070D1AD
		// (set) Token: 0x060346B7 RID: 214711 RVA: 0x0070EFB5 File Offset: 0x0070D1B5
		public byte NullMask { get; set; }

		// Token: 0x060346B8 RID: 214712 RVA: 0x0070EFBE File Offset: 0x0070D1BE
		public IPlotFilmModeConfigT()
		{
			this.IsAdaptFilmAspectRatio = false;
			this.NullMask = 0;
		}
	}
}
