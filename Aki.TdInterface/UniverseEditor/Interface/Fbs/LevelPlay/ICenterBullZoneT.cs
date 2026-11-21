using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048A9 RID: 18601
	public class ICenterBullZoneT
	{
		// Token: 0x1700815B RID: 33115
		// (get) Token: 0x0601B7C1 RID: 112577 RVA: 0x003E36FE File Offset: 0x003E18FE
		// (set) Token: 0x0601B7C2 RID: 112578 RVA: 0x003E3706 File Offset: 0x003E1906
		public EDartboardZoneType Type { get; set; }

		// Token: 0x0601B7C3 RID: 112579 RVA: 0x003E370F File Offset: 0x003E190F
		public ICenterBullZoneT()
		{
			this.Type = EDartboardZoneType.CenterBull;
		}
	}
}
