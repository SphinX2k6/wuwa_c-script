using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F99 RID: 20377
	public class ICheckMechStateT
	{
		// Token: 0x170091BC RID: 37308
		// (get) Token: 0x0601FBEF RID: 130031 RVA: 0x0046955B File Offset: 0x0046775B
		// (set) Token: 0x0601FBF0 RID: 130032 RVA: 0x00469563 File Offset: 0x00467763
		public ECondition Type { get; set; }

		// Token: 0x170091BD RID: 37309
		// (get) Token: 0x0601FBF1 RID: 130033 RVA: 0x0046956C File Offset: 0x0046776C
		// (set) Token: 0x0601FBF2 RID: 130034 RVA: 0x00469574 File Offset: 0x00467774
		public ICheckPlayerInMechT Condition { get; set; }

		// Token: 0x0601FBF3 RID: 130035 RVA: 0x0046957D File Offset: 0x0046777D
		public ICheckMechStateT()
		{
			this.Type = ECondition.CompareVar;
			this.Condition = null;
		}
	}
}
