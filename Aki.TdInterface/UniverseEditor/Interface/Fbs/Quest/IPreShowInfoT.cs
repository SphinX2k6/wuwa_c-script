using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043F5 RID: 17397
	public class IPreShowInfoT
	{
		// Token: 0x170077E3 RID: 30691
		// (get) Token: 0x06018BA1 RID: 101281 RVA: 0x003863FB File Offset: 0x003845FB
		// (set) Token: 0x06018BA2 RID: 101282 RVA: 0x00386403 File Offset: 0x00384603
		public IAccessQuestConditionT PreShowCondition { get; set; }

		// Token: 0x170077E4 RID: 30692
		// (get) Token: 0x06018BA3 RID: 101283 RVA: 0x0038640C File Offset: 0x0038460C
		// (set) Token: 0x06018BA4 RID: 101284 RVA: 0x00386414 File Offset: 0x00384614
		public string TidPreShowDesc { get; set; }

		// Token: 0x06018BA5 RID: 101285 RVA: 0x0038641D File Offset: 0x0038461D
		public IPreShowInfoT()
		{
			this.PreShowCondition = null;
			this.TidPreShowDesc = null;
		}
	}
}
