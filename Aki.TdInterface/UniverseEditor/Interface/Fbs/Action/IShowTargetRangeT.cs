using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078D3 RID: 30931
	public class IShowTargetRangeT
	{
		// Token: 0x1700E2FB RID: 58107
		// (get) Token: 0x06036761 RID: 223073 RVA: 0x0074ACA3 File Offset: 0x00748EA3
		// (set) Token: 0x06036762 RID: 223074 RVA: 0x0074ACAB File Offset: 0x00748EAB
		public List<int> RangeEntities { get; set; }

		// Token: 0x1700E2FC RID: 58108
		// (get) Token: 0x06036763 RID: 223075 RVA: 0x0074ACB4 File Offset: 0x00748EB4
		// (set) Token: 0x06036764 RID: 223076 RVA: 0x0074ACBC File Offset: 0x00748EBC
		public bool DelayShow { get; set; }

		// Token: 0x06036765 RID: 223077 RVA: 0x0074ACC5 File Offset: 0x00748EC5
		public IShowTargetRangeT()
		{
			this.RangeEntities = null;
			this.DelayShow = false;
		}
	}
}
