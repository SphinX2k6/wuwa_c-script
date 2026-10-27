using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Giant
{
	// Token: 0x02005965 RID: 22885
	public class GiantSystemCollectOpenParam : IGiantSystemCollectOpenParam
	{
		// Token: 0x17008B2A RID: 35626
		// (get) Token: 0x0603A11A RID: 237850 RVA: 0x00DCD81F File Offset: 0x00DCBA1F
		// (set) Token: 0x0603A11B RID: 237851 RVA: 0x00DCD827 File Offset: 0x00DCBA27
		public GiantEcoNetType EcoType { get; set; }

		// Token: 0x17008B2B RID: 35627
		// (get) Token: 0x0603A11C RID: 237852 RVA: 0x00DCD830 File Offset: 0x00DCBA30
		// (set) Token: 0x0603A11D RID: 237853 RVA: 0x00DCD838 File Offset: 0x00DCBA38
		public int IncId { get; set; }
	}
}
