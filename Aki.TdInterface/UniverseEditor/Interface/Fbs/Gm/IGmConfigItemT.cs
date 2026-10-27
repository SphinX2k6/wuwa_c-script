using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004661 RID: 18017
	public class IGmConfigItemT
	{
		// Token: 0x17007FDF RID: 32735
		// (get) Token: 0x0601B559 RID: 111961 RVA: 0x003E3304 File Offset: 0x003E1504
		// (set) Token: 0x0601B55A RID: 111962 RVA: 0x003E330C File Offset: 0x003E150C
		public string CnName { get; set; }

		// Token: 0x17007FE0 RID: 32736
		// (get) Token: 0x0601B55B RID: 111963 RVA: 0x003E3315 File Offset: 0x003E1515
		// (set) Token: 0x0601B55C RID: 111964 RVA: 0x003E331D File Offset: 0x003E151D
		public EGmType GmType { get; set; }

		// Token: 0x17007FE1 RID: 32737
		// (get) Token: 0x0601B55D RID: 111965 RVA: 0x003E3326 File Offset: 0x003E1526
		// (set) Token: 0x0601B55E RID: 111966 RVA: 0x003E332E File Offset: 0x003E152E
		public EGmSubType GmSubType { get; set; }

		// Token: 0x17007FE2 RID: 32738
		// (get) Token: 0x0601B55F RID: 111967 RVA: 0x003E3337 File Offset: 0x003E1537
		// (set) Token: 0x0601B560 RID: 111968 RVA: 0x003E333F File Offset: 0x003E153F
		public TParseType ParseType { get; set; }

		// Token: 0x17007FE3 RID: 32739
		// (get) Token: 0x0601B561 RID: 111969 RVA: 0x003E3348 File Offset: 0x003E1548
		// (set) Token: 0x0601B562 RID: 111970 RVA: 0x003E3350 File Offset: 0x003E1550
		public string Code { get; set; }

		// Token: 0x17007FE4 RID: 32740
		// (get) Token: 0x0601B563 RID: 111971 RVA: 0x003E3359 File Offset: 0x003E1559
		// (set) Token: 0x0601B564 RID: 111972 RVA: 0x003E3361 File Offset: 0x003E1561
		public bool Hide { get; set; }

		// Token: 0x17007FE5 RID: 32741
		// (get) Token: 0x0601B565 RID: 111973 RVA: 0x003E336A File Offset: 0x003E156A
		// (set) Token: 0x0601B566 RID: 111974 RVA: 0x003E3372 File Offset: 0x003E1572
		public byte NullMask { get; set; }

		// Token: 0x0601B567 RID: 111975 RVA: 0x003E337B File Offset: 0x003E157B
		public IGmConfigItemT()
		{
			this.CnName = null;
			this.GmType = EGmType.Quest;
			this.GmSubType = EGmSubType.Process;
			this.ParseType = TParseType.Client;
			this.Code = null;
			this.Hide = false;
			this.NullMask = 0;
		}
	}
}
