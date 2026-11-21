using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006890 RID: 26768
	public class IBpActorFuncTypeBaseT
	{
		// Token: 0x1700C4BA RID: 50362
		// (get) Token: 0x0602DC31 RID: 187441 RVA: 0x006417B6 File Offset: 0x0063F9B6
		// (set) Token: 0x0602DC32 RID: 187442 RVA: 0x006417BE File Offset: 0x0063F9BE
		public EBpActorFuncType Type { get; set; }

		// Token: 0x0602DC33 RID: 187443 RVA: 0x006417C7 File Offset: 0x0063F9C7
		public IBpActorFuncTypeBaseT()
		{
			this.Type = EBpActorFuncType.CarPaintChange;
		}
	}
}
