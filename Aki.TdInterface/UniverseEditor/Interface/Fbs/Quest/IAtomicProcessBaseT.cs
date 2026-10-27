using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D1A RID: 15642
	public class IAtomicProcessBaseT
	{
		// Token: 0x17006B50 RID: 27472
		// (get) Token: 0x06015963 RID: 88419 RVA: 0x0031E0A2 File Offset: 0x0031C2A2
		// (set) Token: 0x06015964 RID: 88420 RVA: 0x0031E0AA File Offset: 0x0031C2AA
		public EAtomicProcess Type { get; set; }

		// Token: 0x06015965 RID: 88421 RVA: 0x0031E0B3 File Offset: 0x0031C2B3
		public IAtomicProcessBaseT()
		{
			this.Type = EAtomicProcess.StoveCoreFall;
		}
	}
}
