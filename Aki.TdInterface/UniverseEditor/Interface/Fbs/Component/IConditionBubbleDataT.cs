using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200554E RID: 21838
	public class IConditionBubbleDataT
	{
		// Token: 0x17009C20 RID: 39968
		// (get) Token: 0x06022A65 RID: 141925 RVA: 0x004C5C43 File Offset: 0x004C3E43
		// (set) Token: 0x06022A66 RID: 141926 RVA: 0x004C5C4B File Offset: 0x004C3E4B
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17009C21 RID: 39969
		// (get) Token: 0x06022A67 RID: 141927 RVA: 0x004C5C54 File Offset: 0x004C3E54
		// (set) Token: 0x06022A68 RID: 141928 RVA: 0x004C5C5C File Offset: 0x004C3E5C
		public IBubbleDataT Flow { get; set; }

		// Token: 0x06022A69 RID: 141929 RVA: 0x004C5C65 File Offset: 0x004C3E65
		public IConditionBubbleDataT()
		{
			this.Condition = null;
			this.Flow = null;
		}
	}
}
