using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D80 RID: 23936
	public class IConstraintValueTypeT
	{
		// Token: 0x1700B346 RID: 45894
		// (get) Token: 0x06028F34 RID: 167732 RVA: 0x0059FB96 File Offset: 0x0059DD96
		// (set) Token: 0x06028F35 RID: 167733 RVA: 0x0059FB9E File Offset: 0x0059DD9E
		public EConstraintValueType Type { get; set; }

		// Token: 0x06028F36 RID: 167734 RVA: 0x0059FBA7 File Offset: 0x0059DDA7
		public IConstraintValueTypeT()
		{
			this.Type = EConstraintValueType.Max;
		}
	}
}
