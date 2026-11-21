using System;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B81 RID: 19329
	public class Record_String_IRunningFlowInfoT
	{
		// Token: 0x170088AA RID: 34986
		// (get) Token: 0x0601D6FA RID: 120570 RVA: 0x00422413 File Offset: 0x00420613
		// (set) Token: 0x0601D6FB RID: 120571 RVA: 0x0042241B File Offset: 0x0042061B
		public string Key { get; set; }

		// Token: 0x170088AB RID: 34987
		// (get) Token: 0x0601D6FC RID: 120572 RVA: 0x00422424 File Offset: 0x00420624
		// (set) Token: 0x0601D6FD RID: 120573 RVA: 0x0042242C File Offset: 0x0042062C
		public IRunningFlowInfoT Value { get; set; }

		// Token: 0x0601D6FE RID: 120574 RVA: 0x00422435 File Offset: 0x00420635
		public Record_String_IRunningFlowInfoT()
		{
			this.Key = null;
			this.Value = null;
		}
	}
}
