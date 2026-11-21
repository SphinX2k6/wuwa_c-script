using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041FD RID: 16893
	public class IDarkTideSystemConfigT
	{
		// Token: 0x17007306 RID: 29446
		// (get) Token: 0x06017722 RID: 96034 RVA: 0x0035967F File Offset: 0x0035787F
		// (set) Token: 0x06017723 RID: 96035 RVA: 0x00359687 File Offset: 0x00357887
		public EEnableSystemType Type { get; set; }

		// Token: 0x17007307 RID: 29447
		// (get) Token: 0x06017724 RID: 96036 RVA: 0x00359690 File Offset: 0x00357890
		// (set) Token: 0x06017725 RID: 96037 RVA: 0x00359698 File Offset: 0x00357898
		public IDarkTideBossEventModuleT Module { get; set; }

		// Token: 0x06017726 RID: 96038 RVA: 0x003596A1 File Offset: 0x003578A1
		public IDarkTideSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
			this.Module = null;
		}
	}
}
