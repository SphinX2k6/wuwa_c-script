using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042A2 RID: 17058
	public class IFlipperSystemConfigT
	{
		// Token: 0x170074A4 RID: 29860
		// (get) Token: 0x06017E07 RID: 97799 RVA: 0x00368FF3 File Offset: 0x003671F3
		// (set) Token: 0x06017E08 RID: 97800 RVA: 0x00368FFB File Offset: 0x003671FB
		public EEnableSystemType Type { get; set; }

		// Token: 0x170074A5 RID: 29861
		// (get) Token: 0x06017E09 RID: 97801 RVA: 0x00369004 File Offset: 0x00367204
		// (set) Token: 0x06017E0A RID: 97802 RVA: 0x0036900C File Offset: 0x0036720C
		public List<IFlipperSystemVarT> Vars { get; set; }

		// Token: 0x06017E0B RID: 97803 RVA: 0x00369015 File Offset: 0x00367215
		public IFlipperSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
			this.Vars = null;
		}
	}
}
