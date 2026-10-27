using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A73 RID: 14963
	public class IBvbNpcHpT
	{
		// Token: 0x17006686 RID: 26246
		// (get) Token: 0x06014495 RID: 83093 RVA: 0x002F6546 File Offset: 0x002F4746
		// (set) Token: 0x06014496 RID: 83094 RVA: 0x002F654E File Offset: 0x002F474E
		public ESystemVarName Type { get; set; }

		// Token: 0x06014497 RID: 83095 RVA: 0x002F6557 File Offset: 0x002F4757
		public IBvbNpcHpT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
