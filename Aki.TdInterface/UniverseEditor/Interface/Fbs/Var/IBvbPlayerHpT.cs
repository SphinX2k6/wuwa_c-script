using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E57 RID: 15959
	public class IBvbPlayerHpT
	{
		// Token: 0x17006BBF RID: 27583
		// (get) Token: 0x060157E7 RID: 88039 RVA: 0x00319B9A File Offset: 0x00317D9A
		// (set) Token: 0x060157E8 RID: 88040 RVA: 0x00319BA2 File Offset: 0x00317DA2
		public ESystemVarName Type { get; set; }

		// Token: 0x060157E9 RID: 88041 RVA: 0x00319BAB File Offset: 0x00317DAB
		public IBvbPlayerHpT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
