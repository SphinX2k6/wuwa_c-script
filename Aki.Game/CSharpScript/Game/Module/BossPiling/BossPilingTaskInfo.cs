using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02005BFC RID: 23548
	public class BossPilingTaskInfo : IBossPilingTaskInfo
	{
		// Token: 0x17008D75 RID: 36213
		// (get) Token: 0x0603B846 RID: 243782 RVA: 0x00E32084 File Offset: 0x00E30284
		// (set) Token: 0x0603B847 RID: 243783 RVA: 0x00E3208C File Offset: 0x00E3028C
		public int Id { get; set; }

		// Token: 0x17008D76 RID: 36214
		// (get) Token: 0x0603B848 RID: 243784 RVA: 0x00E32095 File Offset: 0x00E30295
		// (set) Token: 0x0603B849 RID: 243785 RVA: 0x00E3209D File Offset: 0x00E3029D
		public int Current { get; set; }

		// Token: 0x17008D77 RID: 36215
		// (get) Token: 0x0603B84A RID: 243786 RVA: 0x00E320A6 File Offset: 0x00E302A6
		// (set) Token: 0x0603B84B RID: 243787 RVA: 0x00E320AE File Offset: 0x00E302AE
		public int Target { get; set; }

		// Token: 0x17008D78 RID: 36216
		// (get) Token: 0x0603B84C RID: 243788 RVA: 0x00E320B7 File Offset: 0x00E302B7
		// (set) Token: 0x0603B84D RID: 243789 RVA: 0x00E320BF File Offset: 0x00E302BF
		public ConditionTaskState Status { get; set; }
	}
}
