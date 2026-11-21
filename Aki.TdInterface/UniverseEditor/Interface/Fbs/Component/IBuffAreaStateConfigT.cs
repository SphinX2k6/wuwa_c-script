using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200545E RID: 21598
	public class IBuffAreaStateConfigT
	{
		// Token: 0x17009993 RID: 39315
		// (get) Token: 0x06021EA8 RID: 138920 RVA: 0x004ACC9F File Offset: 0x004AAE9F
		// (set) Token: 0x06021EA9 RID: 138921 RVA: 0x004ACCA7 File Offset: 0x004AAEA7
		public string State { get; set; }

		// Token: 0x17009994 RID: 39316
		// (get) Token: 0x06021EAA RID: 138922 RVA: 0x004ACCB0 File Offset: 0x004AAEB0
		// (set) Token: 0x06021EAB RID: 138923 RVA: 0x004ACCB8 File Offset: 0x004AAEB8
		public List<long> BuffIds { get; set; }

		// Token: 0x17009995 RID: 39317
		// (get) Token: 0x06021EAC RID: 138924 RVA: 0x004ACCC1 File Offset: 0x004AAEC1
		// (set) Token: 0x06021EAD RID: 138925 RVA: 0x004ACCC9 File Offset: 0x004AAEC9
		public IConditionGroupT Condition { get; set; }

		// Token: 0x06021EAE RID: 138926 RVA: 0x004ACCD2 File Offset: 0x004AAED2
		public IBuffAreaStateConfigT()
		{
			this.State = null;
			this.BuffIds = null;
			this.Condition = null;
		}
	}
}
