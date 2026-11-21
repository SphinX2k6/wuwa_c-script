using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EAC RID: 28332
	public class IFlowTemplateInitialLookAtT
	{
		// Token: 0x1700CFD4 RID: 53204
		// (get) Token: 0x06031041 RID: 200769 RVA: 0x006A5FFB File Offset: 0x006A41FB
		// (set) Token: 0x06031042 RID: 200770 RVA: 0x006A6003 File Offset: 0x006A4203
		public int ActorIndex { get; set; }

		// Token: 0x1700CFD5 RID: 53205
		// (get) Token: 0x06031043 RID: 200771 RVA: 0x006A600C File Offset: 0x006A420C
		// (set) Token: 0x06031044 RID: 200772 RVA: 0x006A6014 File Offset: 0x006A4214
		public TActorLookAtDataUnion Target { get; set; }

		// Token: 0x06031045 RID: 200773 RVA: 0x006A601D File Offset: 0x006A421D
		public IFlowTemplateInitialLookAtT()
		{
			this.ActorIndex = 0;
			this.Target = null;
		}
	}
}
