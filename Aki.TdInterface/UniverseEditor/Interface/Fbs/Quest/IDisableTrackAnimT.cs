using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DD7 RID: 15831
	public class IDisableTrackAnimT
	{
		// Token: 0x17006D54 RID: 27988
		// (get) Token: 0x060161BB RID: 90555 RVA: 0x003320ED File Offset: 0x003302ED
		// (set) Token: 0x060161BC RID: 90556 RVA: 0x003320F5 File Offset: 0x003302F5
		public IConditionGroupT Condition { get; set; }

		// Token: 0x060161BD RID: 90557 RVA: 0x003320FE File Offset: 0x003302FE
		public IDisableTrackAnimT()
		{
			this.Condition = null;
		}
	}
}
