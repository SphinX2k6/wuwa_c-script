using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EB7 RID: 20151
	public class IAreaBounsT
	{
		// Token: 0x17009093 RID: 37011
		// (get) Token: 0x0601FBC4 RID: 129988 RVA: 0x0046AFD2 File Offset: 0x004691D2
		// (set) Token: 0x0601FBC5 RID: 129989 RVA: 0x0046AFDA File Offset: 0x004691DA
		public EWorldLevelBonus Type { get; set; }

		// Token: 0x0601FBC6 RID: 129990 RVA: 0x0046AFE3 File Offset: 0x004691E3
		public IAreaBounsT()
		{
			this.Type = EWorldLevelBonus.WorldLevelTable;
		}
	}
}
