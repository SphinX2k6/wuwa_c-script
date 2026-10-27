using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DA1 RID: 23969
	public class IElementalBoxConfigT
	{
		// Token: 0x1700B382 RID: 45954
		// (get) Token: 0x06029060 RID: 168032 RVA: 0x005A23C4 File Offset: 0x005A05C4
		// (set) Token: 0x06029061 RID: 168033 RVA: 0x005A23CC File Offset: 0x005A05CC
		public int Id { get; set; }

		// Token: 0x1700B383 RID: 45955
		// (get) Token: 0x06029062 RID: 168034 RVA: 0x005A23D5 File Offset: 0x005A05D5
		// (set) Token: 0x06029063 RID: 168035 RVA: 0x005A23DD File Offset: 0x005A05DD
		public string Desc { get; set; }

		// Token: 0x1700B384 RID: 45956
		// (get) Token: 0x06029064 RID: 168036 RVA: 0x005A23E6 File Offset: 0x005A05E6
		// (set) Token: 0x06029065 RID: 168037 RVA: 0x005A23EE File Offset: 0x005A05EE
		public EElementalType ElementalType { get; set; }

		// Token: 0x1700B385 RID: 45957
		// (get) Token: 0x06029066 RID: 168038 RVA: 0x005A23F7 File Offset: 0x005A05F7
		// (set) Token: 0x06029067 RID: 168039 RVA: 0x005A23FF File Offset: 0x005A05FF
		public int Priority { get; set; }

		// Token: 0x1700B386 RID: 45958
		// (get) Token: 0x06029068 RID: 168040 RVA: 0x005A2408 File Offset: 0x005A0608
		// (set) Token: 0x06029069 RID: 168041 RVA: 0x005A2410 File Offset: 0x005A0610
		public string InitState { get; set; }

		// Token: 0x1700B387 RID: 45959
		// (get) Token: 0x0602906A RID: 168042 RVA: 0x005A2419 File Offset: 0x005A0619
		// (set) Token: 0x0602906B RID: 168043 RVA: 0x005A2421 File Offset: 0x005A0621
		public string CustomBoxPrefab { get; set; }

		// Token: 0x0602906C RID: 168044 RVA: 0x005A242A File Offset: 0x005A062A
		public IElementalBoxConfigT()
		{
			this.Id = 0;
			this.Desc = null;
			this.ElementalType = EElementalType.Fire;
			this.Priority = 0;
			this.InitState = null;
			this.CustomBoxPrefab = null;
		}
	}
}
