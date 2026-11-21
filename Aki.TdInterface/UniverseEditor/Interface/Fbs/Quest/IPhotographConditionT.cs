using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043C2 RID: 17346
	public class IPhotographConditionT
	{
		// Token: 0x17007778 RID: 30584
		// (get) Token: 0x060189F5 RID: 100853 RVA: 0x00383371 File Offset: 0x00381571
		// (set) Token: 0x060189F6 RID: 100854 RVA: 0x00383379 File Offset: 0x00381579
		public string TidTip { get; set; }

		// Token: 0x17007779 RID: 30585
		// (get) Token: 0x060189F7 RID: 100855 RVA: 0x00383382 File Offset: 0x00381582
		// (set) Token: 0x060189F8 RID: 100856 RVA: 0x0038338A File Offset: 0x0038158A
		public TPhotographTargetUnion Target { get; set; }

		// Token: 0x1700777A RID: 30586
		// (get) Token: 0x060189F9 RID: 100857 RVA: 0x00383393 File Offset: 0x00381593
		// (set) Token: 0x060189FA RID: 100858 RVA: 0x0038339B File Offset: 0x0038159B
		public List<TPhotographSubTargetUnion> SubTargets { get; set; }

		// Token: 0x1700777B RID: 30587
		// (get) Token: 0x060189FB RID: 100859 RVA: 0x003833A4 File Offset: 0x003815A4
		// (set) Token: 0x060189FC RID: 100860 RVA: 0x003833AC File Offset: 0x003815AC
		public byte NullMask { get; set; }

		// Token: 0x060189FD RID: 100861 RVA: 0x003833B5 File Offset: 0x003815B5
		public IPhotographConditionT()
		{
			this.TidTip = null;
			this.Target = null;
			this.SubTargets = null;
			this.NullMask = 0;
		}
	}
}
