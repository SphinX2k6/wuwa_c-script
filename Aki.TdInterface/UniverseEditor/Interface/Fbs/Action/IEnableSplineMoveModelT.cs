using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D02 RID: 27906
	public class IEnableSplineMoveModelT
	{
		// Token: 0x1700CCC5 RID: 52421
		// (get) Token: 0x0603020C RID: 197132 RVA: 0x0068BD09 File Offset: 0x00689F09
		// (set) Token: 0x0603020D RID: 197133 RVA: 0x0068BD11 File Offset: 0x00689F11
		public TSplineMoveModelUnion Config { get; set; }

		// Token: 0x0603020E RID: 197134 RVA: 0x0068BD1A File Offset: 0x00689F1A
		public IEnableSplineMoveModelT()
		{
			this.Config = null;
		}
	}
}
