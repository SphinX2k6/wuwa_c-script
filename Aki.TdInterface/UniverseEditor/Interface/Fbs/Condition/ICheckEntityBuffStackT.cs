using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049FB RID: 18939
	public class ICheckEntityBuffStackT
	{
		// Token: 0x170088FE RID: 35070
		// (get) Token: 0x0601D998 RID: 121240 RVA: 0x0042A5C5 File Offset: 0x004287C5
		// (set) Token: 0x0601D999 RID: 121241 RVA: 0x0042A5CD File Offset: 0x004287CD
		public ECondition Type { get; set; }

		// Token: 0x170088FF RID: 35071
		// (get) Token: 0x0601D99A RID: 121242 RVA: 0x0042A5D6 File Offset: 0x004287D6
		// (set) Token: 0x0601D99B RID: 121243 RVA: 0x0042A5DE File Offset: 0x004287DE
		public IMonsterBuffContainerT Target { get; set; }

		// Token: 0x17008900 RID: 35072
		// (get) Token: 0x0601D99C RID: 121244 RVA: 0x0042A5E7 File Offset: 0x004287E7
		// (set) Token: 0x0601D99D RID: 121245 RVA: 0x0042A5EF File Offset: 0x004287EF
		public long BuffId { get; set; }

		// Token: 0x17008901 RID: 35073
		// (get) Token: 0x0601D99E RID: 121246 RVA: 0x0042A5F8 File Offset: 0x004287F8
		// (set) Token: 0x0601D99F RID: 121247 RVA: 0x0042A600 File Offset: 0x00428800
		public ECompare Compare { get; set; }

		// Token: 0x17008902 RID: 35074
		// (get) Token: 0x0601D9A0 RID: 121248 RVA: 0x0042A609 File Offset: 0x00428809
		// (set) Token: 0x0601D9A1 RID: 121249 RVA: 0x0042A611 File Offset: 0x00428811
		public int Stack { get; set; }

		// Token: 0x0601D9A2 RID: 121250 RVA: 0x0042A61A File Offset: 0x0042881A
		public ICheckEntityBuffStackT()
		{
			this.Type = ECondition.CompareVar;
			this.Target = null;
			this.BuffId = 0L;
			this.Compare = ECompare.Eq;
			this.Stack = 0;
		}
	}
}
