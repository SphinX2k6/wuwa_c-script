using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E07 RID: 24071
	public class IRangeConstraintT
	{
		// Token: 0x1700B174 RID: 45428
		// (get) Token: 0x06028321 RID: 164641 RVA: 0x0057F63A File Offset: 0x0057D83A
		// (set) Token: 0x06028322 RID: 164642 RVA: 0x0057F642 File Offset: 0x0057D842
		public ERangeConstraint Type { get; set; }

		// Token: 0x06028323 RID: 164643 RVA: 0x0057F64B File Offset: 0x0057D84B
		public IRangeConstraintT()
		{
			this.Type = ERangeConstraint.SearchSpawnMonsterPoint;
		}
	}
}
