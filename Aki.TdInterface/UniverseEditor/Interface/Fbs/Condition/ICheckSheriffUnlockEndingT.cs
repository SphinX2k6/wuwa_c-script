using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B27 RID: 19239
	public class ICheckSheriffUnlockEndingT
	{
		// Token: 0x17008B93 RID: 35731
		// (get) Token: 0x0601E452 RID: 123986 RVA: 0x0043E29A File Offset: 0x0043C49A
		// (set) Token: 0x0601E453 RID: 123987 RVA: 0x0043E2A2 File Offset: 0x0043C4A2
		public ECondition Type { get; set; }

		// Token: 0x17008B94 RID: 35732
		// (get) Token: 0x0601E454 RID: 123988 RVA: 0x0043E2AB File Offset: 0x0043C4AB
		// (set) Token: 0x0601E455 RID: 123989 RVA: 0x0043E2B3 File Offset: 0x0043C4B3
		public int AnomalyId { get; set; }

		// Token: 0x17008B95 RID: 35733
		// (get) Token: 0x0601E456 RID: 123990 RVA: 0x0043E2BC File Offset: 0x0043C4BC
		// (set) Token: 0x0601E457 RID: 123991 RVA: 0x0043E2C4 File Offset: 0x0043C4C4
		public int EndingId { get; set; }

		// Token: 0x0601E458 RID: 123992 RVA: 0x0043E2CD File Offset: 0x0043C4CD
		public ICheckSheriffUnlockEndingT()
		{
			this.Type = ECondition.CompareVar;
			this.AnomalyId = 0;
			this.EndingId = 0;
		}
	}
}
