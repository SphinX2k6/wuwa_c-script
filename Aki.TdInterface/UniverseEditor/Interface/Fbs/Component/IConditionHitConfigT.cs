using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FF2 RID: 20466
	public class IConditionHitConfigT
	{
		// Token: 0x17009444 RID: 37956
		// (get) Token: 0x06020B5D RID: 133981 RVA: 0x0048C4D3 File Offset: 0x0048A6D3
		// (set) Token: 0x06020B5E RID: 133982 RVA: 0x0048C4DB File Offset: 0x0048A6DB
		public IConditionGroupT Conditions { get; set; }

		// Token: 0x17009445 RID: 37957
		// (get) Token: 0x06020B5F RID: 133983 RVA: 0x0048C4E4 File Offset: 0x0048A6E4
		// (set) Token: 0x06020B60 RID: 133984 RVA: 0x0048C4EC File Offset: 0x0048A6EC
		public string State { get; set; }

		// Token: 0x06020B61 RID: 133985 RVA: 0x0048C4F5 File Offset: 0x0048A6F5
		public IConditionHitConfigT()
		{
			this.Conditions = null;
			this.State = null;
		}
	}
}
