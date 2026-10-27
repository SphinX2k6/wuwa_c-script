using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F2C RID: 20268
	public class IBuffAreaStateConfigT
	{
		// Token: 0x17009211 RID: 37393
		// (get) Token: 0x06020138 RID: 131384 RVA: 0x0047690B File Offset: 0x00474B0B
		// (set) Token: 0x06020139 RID: 131385 RVA: 0x00476913 File Offset: 0x00474B13
		public string State { get; set; }

		// Token: 0x17009212 RID: 37394
		// (get) Token: 0x0602013A RID: 131386 RVA: 0x0047691C File Offset: 0x00474B1C
		// (set) Token: 0x0602013B RID: 131387 RVA: 0x00476924 File Offset: 0x00474B24
		public List<long> BuffIds { get; set; }

		// Token: 0x17009213 RID: 37395
		// (get) Token: 0x0602013C RID: 131388 RVA: 0x0047692D File Offset: 0x00474B2D
		// (set) Token: 0x0602013D RID: 131389 RVA: 0x00476935 File Offset: 0x00474B35
		public IConditionGroupT Condition { get; set; }

		// Token: 0x0602013E RID: 131390 RVA: 0x0047693E File Offset: 0x00474B3E
		public IBuffAreaStateConfigT()
		{
			this.State = null;
			this.BuffIds = null;
			this.Condition = null;
		}
	}
}
