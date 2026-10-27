using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043C6 RID: 17350
	public class IScreenResourceOccupationDataT
	{
		// Token: 0x17007AAF RID: 31407
		// (get) Token: 0x06019DEE RID: 105966 RVA: 0x003B3E8A File Offset: 0x003B208A
		// (set) Token: 0x06019DEF RID: 105967 RVA: 0x003B3E92 File Offset: 0x003B2092
		public EOccupationType Type { get; set; }

		// Token: 0x06019DF0 RID: 105968 RVA: 0x003B3E9B File Offset: 0x003B209B
		public IScreenResourceOccupationDataT()
		{
			this.Type = EOccupationType.Npc;
		}
	}
}
