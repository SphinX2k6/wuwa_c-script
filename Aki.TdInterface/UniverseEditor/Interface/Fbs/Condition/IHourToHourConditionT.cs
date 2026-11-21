using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005137 RID: 20791
	public class IHourToHourConditionT
	{
		// Token: 0x17009501 RID: 38145
		// (get) Token: 0x06020B31 RID: 133937 RVA: 0x00487F02 File Offset: 0x00486102
		// (set) Token: 0x06020B32 RID: 133938 RVA: 0x00487F0A File Offset: 0x0048610A
		public ECondition Type { get; set; }

		// Token: 0x17009502 RID: 38146
		// (get) Token: 0x06020B33 RID: 133939 RVA: 0x00487F13 File Offset: 0x00486113
		// (set) Token: 0x06020B34 RID: 133940 RVA: 0x00487F1B File Offset: 0x0048611B
		public IHourT Start { get; set; }

		// Token: 0x17009503 RID: 38147
		// (get) Token: 0x06020B35 RID: 133941 RVA: 0x00487F24 File Offset: 0x00486124
		// (set) Token: 0x06020B36 RID: 133942 RVA: 0x00487F2C File Offset: 0x0048612C
		public IHourT End { get; set; }

		// Token: 0x17009504 RID: 38148
		// (get) Token: 0x06020B37 RID: 133943 RVA: 0x00487F35 File Offset: 0x00486135
		// (set) Token: 0x06020B38 RID: 133944 RVA: 0x00487F3D File Offset: 0x0048613D
		public ECompare Compare { get; set; }

		// Token: 0x06020B39 RID: 133945 RVA: 0x00487F46 File Offset: 0x00486146
		public IHourToHourConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Start = null;
			this.End = null;
			this.Compare = ECompare.Eq;
		}
	}
}
