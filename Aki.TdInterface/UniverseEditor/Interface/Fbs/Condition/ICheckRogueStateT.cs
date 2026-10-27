using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B15 RID: 19221
	public class ICheckRogueStateT
	{
		// Token: 0x17008B71 RID: 35697
		// (get) Token: 0x0601E3C0 RID: 123840 RVA: 0x0043D207 File Offset: 0x0043B407
		// (set) Token: 0x0601E3C1 RID: 123841 RVA: 0x0043D20F File Offset: 0x0043B40F
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x17008B72 RID: 35698
		// (get) Token: 0x0601E3C2 RID: 123842 RVA: 0x0043D218 File Offset: 0x0043B418
		// (set) Token: 0x0601E3C3 RID: 123843 RVA: 0x0043D220 File Offset: 0x0043B420
		public TRogueStateTypeUnion Config { get; set; }

		// Token: 0x0601E3C4 RID: 123844 RVA: 0x0043D229 File Offset: 0x0043B429
		public ICheckRogueStateT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.Config = null;
		}
	}
}
