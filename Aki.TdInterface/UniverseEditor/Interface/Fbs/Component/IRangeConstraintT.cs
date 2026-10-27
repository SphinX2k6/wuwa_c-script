using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005800 RID: 22528
	public class IRangeConstraintT
	{
		// Token: 0x1700A850 RID: 43088
		// (get) Token: 0x06025E01 RID: 155137 RVA: 0x005394AE File Offset: 0x005376AE
		// (set) Token: 0x06025E02 RID: 155138 RVA: 0x005394B6 File Offset: 0x005376B6
		public ERangeConstraint Type { get; set; }

		// Token: 0x06025E03 RID: 155139 RVA: 0x005394BF File Offset: 0x005376BF
		public IRangeConstraintT()
		{
			this.Type = ERangeConstraint.SearchSpawnMonsterPoint;
		}
	}
}
