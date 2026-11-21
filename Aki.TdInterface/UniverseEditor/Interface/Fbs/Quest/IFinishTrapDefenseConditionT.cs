using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200428D RID: 17037
	public class IFinishTrapDefenseConditionT
	{
		// Token: 0x17007486 RID: 29830
		// (get) Token: 0x06017D68 RID: 97640 RVA: 0x00367DAD File Offset: 0x00365FAD
		// (set) Token: 0x06017D69 RID: 97641 RVA: 0x00367DB5 File Offset: 0x00365FB5
		public EChildQuest Type { get; set; }

		// Token: 0x17007487 RID: 29831
		// (get) Token: 0x06017D6A RID: 97642 RVA: 0x00367DBE File Offset: 0x00365FBE
		// (set) Token: 0x06017D6B RID: 97643 RVA: 0x00367DC6 File Offset: 0x00365FC6
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007488 RID: 29832
		// (get) Token: 0x06017D6C RID: 97644 RVA: 0x00367DCF File Offset: 0x00365FCF
		// (set) Token: 0x06017D6D RID: 97645 RVA: 0x00367DD7 File Offset: 0x00365FD7
		public TTrapDefenseConditionStepUnion Step { get; set; }

		// Token: 0x17007489 RID: 29833
		// (get) Token: 0x06017D6E RID: 97646 RVA: 0x00367DE0 File Offset: 0x00365FE0
		// (set) Token: 0x06017D6F RID: 97647 RVA: 0x00367DE8 File Offset: 0x00365FE8
		public TVarRefUnion Batch { get; set; }

		// Token: 0x1700748A RID: 29834
		// (get) Token: 0x06017D70 RID: 97648 RVA: 0x00367DF1 File Offset: 0x00365FF1
		// (set) Token: 0x06017D71 RID: 97649 RVA: 0x00367DF9 File Offset: 0x00365FF9
		public bool NeedArchive { get; set; }

		// Token: 0x1700748B RID: 29835
		// (get) Token: 0x06017D72 RID: 97650 RVA: 0x00367E02 File Offset: 0x00366002
		// (set) Token: 0x06017D73 RID: 97651 RVA: 0x00367E0A File Offset: 0x0036600A
		public byte NullMask { get; set; }

		// Token: 0x06017D74 RID: 97652 RVA: 0x00367E13 File Offset: 0x00366013
		public IFinishTrapDefenseConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Step = null;
			this.Batch = null;
			this.NeedArchive = false;
			this.NullMask = 0;
		}
	}
}
