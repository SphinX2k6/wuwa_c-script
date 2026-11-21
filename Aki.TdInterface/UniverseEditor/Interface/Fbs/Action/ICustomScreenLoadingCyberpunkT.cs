using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B70 RID: 27504
	public class ICustomScreenLoadingCyberpunkT
	{
		// Token: 0x1700C9E1 RID: 51681
		// (get) Token: 0x0602F555 RID: 193877 RVA: 0x00675B62 File Offset: 0x00673D62
		// (set) Token: 0x0602F556 RID: 193878 RVA: 0x00675B6A File Offset: 0x00673D6A
		public ECustomScreenLoading Type { get; set; }

		// Token: 0x0602F557 RID: 193879 RVA: 0x00675B73 File Offset: 0x00673D73
		public ICustomScreenLoadingCyberpunkT()
		{
			this.Type = ECustomScreenLoading.Cyberpunk;
		}
	}
}
