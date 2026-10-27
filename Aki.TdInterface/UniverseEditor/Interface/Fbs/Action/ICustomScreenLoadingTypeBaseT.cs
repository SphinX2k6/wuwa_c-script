using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006505 RID: 25861
	public class ICustomScreenLoadingTypeBaseT
	{
		// Token: 0x1700C054 RID: 49236
		// (get) Token: 0x0602CDD1 RID: 183761 RVA: 0x00629A3A File Offset: 0x00627C3A
		// (set) Token: 0x0602CDD2 RID: 183762 RVA: 0x00629A42 File Offset: 0x00627C42
		public ECustomScreenLoading Type { get; set; }

		// Token: 0x0602CDD3 RID: 183763 RVA: 0x00629A4B File Offset: 0x00627C4B
		public ICustomScreenLoadingTypeBaseT()
		{
			this.Type = ECustomScreenLoading.Cyberpunk;
		}
	}
}
