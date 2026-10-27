using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200402C RID: 16428
	public class IQuestScheduleMultiBtTreeVarT
	{
		// Token: 0x17007397 RID: 29591
		// (get) Token: 0x06017C32 RID: 97330 RVA: 0x0036DBBD File Offset: 0x0036BDBD
		// (set) Token: 0x06017C33 RID: 97331 RVA: 0x0036DBC5 File Offset: 0x0036BDC5
		public EQuestScheduleType Type { get; set; }

		// Token: 0x17007398 RID: 29592
		// (get) Token: 0x06017C34 RID: 97332 RVA: 0x0036DBCE File Offset: 0x0036BDCE
		// (set) Token: 0x06017C35 RID: 97333 RVA: 0x0036DBD6 File Offset: 0x0036BDD6
		public List<TVarRefUnion> Vars { get; set; }

		// Token: 0x17007399 RID: 29593
		// (get) Token: 0x06017C36 RID: 97334 RVA: 0x0036DBDF File Offset: 0x0036BDDF
		// (set) Token: 0x06017C37 RID: 97335 RVA: 0x0036DBE7 File Offset: 0x0036BDE7
		public IWordArtConfigT ShowAsWordArt { get; set; }

		// Token: 0x06017C38 RID: 97336 RVA: 0x0036DBF0 File Offset: 0x0036BDF0
		public IQuestScheduleMultiBtTreeVarT()
		{
			this.Type = EQuestScheduleType.None;
			this.Vars = null;
			this.ShowAsWordArt = null;
		}
	}
}
