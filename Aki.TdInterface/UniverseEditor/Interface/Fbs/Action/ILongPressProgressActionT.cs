using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A54 RID: 27220
	public class ILongPressProgressActionT
	{
		// Token: 0x1700C9EF RID: 51695
		// (get) Token: 0x0602FA98 RID: 195224 RVA: 0x0067CA6B File Offset: 0x0067AC6B
		// (set) Token: 0x0602FA99 RID: 195225 RVA: 0x0067CA73 File Offset: 0x0067AC73
		public float Percentage { get; set; }

		// Token: 0x1700C9F0 RID: 51696
		// (get) Token: 0x0602FA9A RID: 195226 RVA: 0x0067CA7C File Offset: 0x0067AC7C
		// (set) Token: 0x0602FA9B RID: 195227 RVA: 0x0067CA84 File Offset: 0x0067AC84
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x0602FA9C RID: 195228 RVA: 0x0067CA8D File Offset: 0x0067AC8D
		public ILongPressProgressActionT()
		{
			this.Percentage = 0f;
			this.Actions = null;
		}
	}
}
