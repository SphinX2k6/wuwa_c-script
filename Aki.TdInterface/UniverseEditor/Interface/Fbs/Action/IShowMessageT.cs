using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078B2 RID: 30898
	public class IShowMessageT
	{
		// Token: 0x1700E2AB RID: 58027
		// (get) Token: 0x060365F9 RID: 222713 RVA: 0x007478C1 File Offset: 0x00745AC1
		// (set) Token: 0x060365FA RID: 222714 RVA: 0x007478C9 File Offset: 0x00745AC9
		public string Content { get; set; }

		// Token: 0x060365FB RID: 222715 RVA: 0x007478D2 File Offset: 0x00745AD2
		public IShowMessageT()
		{
			this.Content = null;
		}
	}
}
