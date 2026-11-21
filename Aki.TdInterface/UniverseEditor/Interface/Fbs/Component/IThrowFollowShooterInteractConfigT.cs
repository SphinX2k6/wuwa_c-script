using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006072 RID: 24690
	public class IThrowFollowShooterInteractConfigT
	{
		// Token: 0x1700B75B RID: 46939
		// (get) Token: 0x06029B8D RID: 170893 RVA: 0x005B2630 File Offset: 0x005B0830
		// (set) Token: 0x06029B8E RID: 170894 RVA: 0x005B2638 File Offset: 0x005B0838
		public float Radius { get; set; }

		// Token: 0x1700B75C RID: 46940
		// (get) Token: 0x06029B8F RID: 170895 RVA: 0x005B2641 File Offset: 0x005B0841
		// (set) Token: 0x06029B90 RID: 170896 RVA: 0x005B2649 File Offset: 0x005B0849
		public List<int> MatchIds { get; set; }

		// Token: 0x1700B75D RID: 46941
		// (get) Token: 0x06029B91 RID: 170897 RVA: 0x005B2652 File Offset: 0x005B0852
		// (set) Token: 0x06029B92 RID: 170898 RVA: 0x005B265A File Offset: 0x005B085A
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700B75E RID: 46942
		// (get) Token: 0x06029B93 RID: 170899 RVA: 0x005B2663 File Offset: 0x005B0863
		// (set) Token: 0x06029B94 RID: 170900 RVA: 0x005B266B File Offset: 0x005B086B
		public List<IConditionActionT> ArrivedConditionActions { get; set; }

		// Token: 0x1700B75F RID: 46943
		// (get) Token: 0x06029B95 RID: 170901 RVA: 0x005B2674 File Offset: 0x005B0874
		// (set) Token: 0x06029B96 RID: 170902 RVA: 0x005B267C File Offset: 0x005B087C
		public List<IConditionActionT> LeavedConditionActions { get; set; }

		// Token: 0x1700B760 RID: 46944
		// (get) Token: 0x06029B97 RID: 170903 RVA: 0x005B2685 File Offset: 0x005B0885
		// (set) Token: 0x06029B98 RID: 170904 RVA: 0x005B268D File Offset: 0x005B088D
		public byte NullMask { get; set; }

		// Token: 0x06029B99 RID: 170905 RVA: 0x005B2696 File Offset: 0x005B0896
		public IThrowFollowShooterInteractConfigT()
		{
			this.Radius = 0f;
			this.MatchIds = null;
			this.Offset = null;
			this.ArrivedConditionActions = null;
			this.LeavedConditionActions = null;
			this.NullMask = 0;
		}
	}
}
