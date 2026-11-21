using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EEB RID: 28395
	public class IForceOccupationsT
	{
		// Token: 0x1700D036 RID: 53302
		// (get) Token: 0x0603120F RID: 201231 RVA: 0x006A8FB7 File Offset: 0x006A71B7
		// (set) Token: 0x06031210 RID: 201232 RVA: 0x006A8FBF File Offset: 0x006A71BF
		public EOccupationActionType OccupationType { get; set; }

		// Token: 0x1700D037 RID: 53303
		// (get) Token: 0x06031211 RID: 201233 RVA: 0x006A8FC8 File Offset: 0x006A71C8
		// (set) Token: 0x06031212 RID: 201234 RVA: 0x006A8FD0 File Offset: 0x006A71D0
		public List<string> Occupations { get; set; }

		// Token: 0x06031213 RID: 201235 RVA: 0x006A8FD9 File Offset: 0x006A71D9
		public IForceOccupationsT()
		{
			this.OccupationType = EOccupationActionType.Request;
			this.Occupations = null;
		}
	}
}
