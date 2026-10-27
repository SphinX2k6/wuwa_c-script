using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068F2 RID: 26866
	public class IHideMapMarkT
	{
		// Token: 0x1700C757 RID: 51031
		// (get) Token: 0x0602EDED RID: 191981 RVA: 0x00664DD8 File Offset: 0x00662FD8
		// (set) Token: 0x0602EDEE RID: 191982 RVA: 0x00664DE0 File Offset: 0x00662FE0
		public EMapMarkState Type { get; set; }

		// Token: 0x1700C758 RID: 51032
		// (get) Token: 0x0602EDEF RID: 191983 RVA: 0x00664DE9 File Offset: 0x00662FE9
		// (set) Token: 0x0602EDF0 RID: 191984 RVA: 0x00664DF1 File Offset: 0x00662FF1
		public int MarkId { get; set; }

		// Token: 0x0602EDF1 RID: 191985 RVA: 0x00664DFA File Offset: 0x00662FFA
		public IHideMapMarkT()
		{
			this.Type = EMapMarkState.Show;
			this.MarkId = 0;
		}
	}
}
