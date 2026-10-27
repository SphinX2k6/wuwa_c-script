using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007107 RID: 28935
	public class IShowTargetRangeT
	{
		// Token: 0x1700D718 RID: 55064
		// (get) Token: 0x060334BF RID: 210111 RVA: 0x006EA697 File Offset: 0x006E8897
		// (set) Token: 0x060334C0 RID: 210112 RVA: 0x006EA69F File Offset: 0x006E889F
		public List<int> RangeEntities { get; set; }

		// Token: 0x1700D719 RID: 55065
		// (get) Token: 0x060334C1 RID: 210113 RVA: 0x006EA6A8 File Offset: 0x006E88A8
		// (set) Token: 0x060334C2 RID: 210114 RVA: 0x006EA6B0 File Offset: 0x006E88B0
		public bool DelayShow { get; set; }

		// Token: 0x060334C3 RID: 210115 RVA: 0x006EA6B9 File Offset: 0x006E88B9
		public IShowTargetRangeT()
		{
			this.RangeEntities = null;
			this.DelayShow = false;
		}
	}
}
