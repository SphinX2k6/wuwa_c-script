using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004828 RID: 18472
	public class IScreenResourceOccupationDataT
	{
		// Token: 0x170080E6 RID: 32998
		// (get) Token: 0x0601B589 RID: 112009 RVA: 0x003DFB22 File Offset: 0x003DDD22
		// (set) Token: 0x0601B58A RID: 112010 RVA: 0x003DFB2A File Offset: 0x003DDD2A
		public EOccupationType Type { get; set; }

		// Token: 0x0601B58B RID: 112011 RVA: 0x003DFB33 File Offset: 0x003DDD33
		public IScreenResourceOccupationDataT()
		{
			this.Type = EOccupationType.Npc;
		}
	}
}
