using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059B2 RID: 22962
	public class IInitStateWuYinQuT
	{
		// Token: 0x1700A6BB RID: 42683
		// (get) Token: 0x0602571D RID: 153373 RVA: 0x00522DF2 File Offset: 0x00520FF2
		// (set) Token: 0x0602571E RID: 153374 RVA: 0x00522DFA File Offset: 0x00520FFA
		public EInitStateType Type { get; set; }

		// Token: 0x0602571F RID: 153375 RVA: 0x00522E03 File Offset: 0x00521003
		public IInitStateWuYinQuT()
		{
			this.Type = EInitStateType.Birth;
		}
	}
}
