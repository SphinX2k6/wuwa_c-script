using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CDB RID: 27867
	public class IEnableHostilityT
	{
		// Token: 0x1700CC63 RID: 52323
		// (get) Token: 0x06030094 RID: 196756 RVA: 0x0068937B File Offset: 0x0068757B
		// (set) Token: 0x06030095 RID: 196757 RVA: 0x00689383 File Offset: 0x00687583
		public bool IsEnable { get; set; }

		// Token: 0x1700CC64 RID: 52324
		// (get) Token: 0x06030096 RID: 196758 RVA: 0x0068938C File Offset: 0x0068758C
		// (set) Token: 0x06030097 RID: 196759 RVA: 0x00689394 File Offset: 0x00687594
		public List<int> EntityIds { get; set; }

		// Token: 0x06030098 RID: 196760 RVA: 0x0068939D File Offset: 0x0068759D
		public IEnableHostilityT()
		{
			this.IsEnable = false;
			this.EntityIds = null;
		}
	}
}
