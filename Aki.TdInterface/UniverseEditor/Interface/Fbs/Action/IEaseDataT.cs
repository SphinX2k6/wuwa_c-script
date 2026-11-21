using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C96 RID: 27798
	public class IEaseDataT
	{
		// Token: 0x1700CBE3 RID: 52195
		// (get) Token: 0x0602FE58 RID: 196184 RVA: 0x00685584 File Offset: 0x00683784
		// (set) Token: 0x0602FE59 RID: 196185 RVA: 0x0068558C File Offset: 0x0068378C
		public EEaseType Type { get; set; }

		// Token: 0x1700CBE4 RID: 52196
		// (get) Token: 0x0602FE5A RID: 196186 RVA: 0x00685595 File Offset: 0x00683795
		// (set) Token: 0x0602FE5B RID: 196187 RVA: 0x0068559D File Offset: 0x0068379D
		public float Duration { get; set; }

		// Token: 0x0602FE5C RID: 196188 RVA: 0x006855A6 File Offset: 0x006837A6
		public IEaseDataT()
		{
			this.Type = EEaseType.Linear;
			this.Duration = 0f;
		}
	}
}
