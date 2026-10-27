using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D41 RID: 15681
	public class ICameraConditionT
	{
		// Token: 0x17006B92 RID: 27538
		// (get) Token: 0x06015ABF RID: 88767 RVA: 0x00320893 File Offset: 0x0031EA93
		// (set) Token: 0x06015AC0 RID: 88768 RVA: 0x0032089B File Offset: 0x0031EA9B
		public string TidTip { get; set; }

		// Token: 0x17006B93 RID: 27539
		// (get) Token: 0x06015AC1 RID: 88769 RVA: 0x003208A4 File Offset: 0x0031EAA4
		// (set) Token: 0x06015AC2 RID: 88770 RVA: 0x003208AC File Offset: 0x0031EAAC
		public IConditionGroupT Condition { get; set; }

		// Token: 0x06015AC3 RID: 88771 RVA: 0x003208B5 File Offset: 0x0031EAB5
		public ICameraConditionT()
		{
			this.TidTip = null;
			this.Condition = null;
		}
	}
}
