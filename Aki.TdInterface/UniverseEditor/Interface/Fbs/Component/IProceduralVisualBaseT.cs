using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D98 RID: 23960
	public class IProceduralVisualBaseT
	{
		// Token: 0x1700B055 RID: 45141
		// (get) Token: 0x06027E75 RID: 163445 RVA: 0x0057524B File Offset: 0x0057344B
		// (set) Token: 0x06027E76 RID: 163446 RVA: 0x00575253 File Offset: 0x00573453
		public EProceduralVisualType Type { get; set; }

		// Token: 0x1700B056 RID: 45142
		// (get) Token: 0x06027E77 RID: 163447 RVA: 0x0057525C File Offset: 0x0057345C
		// (set) Token: 0x06027E78 RID: 163448 RVA: 0x00575264 File Offset: 0x00573464
		public IConditionGroupT Condition { get; set; }

		// Token: 0x06027E79 RID: 163449 RVA: 0x0057526D File Offset: 0x0057346D
		public IProceduralVisualBaseT()
		{
			this.Type = EProceduralVisualType.LookAt;
			this.Condition = null;
		}
	}
}
