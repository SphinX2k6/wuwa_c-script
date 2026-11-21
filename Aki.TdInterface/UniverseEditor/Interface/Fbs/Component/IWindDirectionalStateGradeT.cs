using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006194 RID: 24980
	public class IWindDirectionalStateGradeT
	{
		// Token: 0x1700BA4E RID: 47694
		// (get) Token: 0x0602A753 RID: 173907 RVA: 0x005CABE9 File Offset: 0x005C8DE9
		// (set) Token: 0x0602A754 RID: 173908 RVA: 0x005CABF1 File Offset: 0x005C8DF1
		public string State { get; set; }

		// Token: 0x1700BA4F RID: 47695
		// (get) Token: 0x0602A755 RID: 173909 RVA: 0x005CABFA File Offset: 0x005C8DFA
		// (set) Token: 0x0602A756 RID: 173910 RVA: 0x005CAC02 File Offset: 0x005C8E02
		public float Speed { get; set; }

		// Token: 0x1700BA50 RID: 47696
		// (get) Token: 0x0602A757 RID: 173911 RVA: 0x005CAC0B File Offset: 0x005C8E0B
		// (set) Token: 0x0602A758 RID: 173912 RVA: 0x005CAC13 File Offset: 0x005C8E13
		public float Strength { get; set; }

		// Token: 0x0602A759 RID: 173913 RVA: 0x005CAC1C File Offset: 0x005C8E1C
		public IWindDirectionalStateGradeT()
		{
			this.State = null;
			this.Speed = 0f;
			this.Strength = 0f;
		}
	}
}
