using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006502 RID: 25858
	public class ICustomScreenLoadingCyberpunkT
	{
		// Token: 0x1700C051 RID: 49233
		// (get) Token: 0x0602CDBF RID: 183743 RVA: 0x006298C2 File Offset: 0x00627AC2
		// (set) Token: 0x0602CDC0 RID: 183744 RVA: 0x006298CA File Offset: 0x00627ACA
		public ECustomScreenLoading Type { get; set; }

		// Token: 0x0602CDC1 RID: 183745 RVA: 0x006298D3 File Offset: 0x00627AD3
		public ICustomScreenLoadingCyberpunkT()
		{
			this.Type = ECustomScreenLoading.Cyberpunk;
		}
	}
}
