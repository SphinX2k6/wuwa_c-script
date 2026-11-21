using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B73 RID: 27507
	public class ICustomScreenLoadingTypeBaseT
	{
		// Token: 0x1700C9E4 RID: 51684
		// (get) Token: 0x0602F567 RID: 193895 RVA: 0x00675CDA File Offset: 0x00673EDA
		// (set) Token: 0x0602F568 RID: 193896 RVA: 0x00675CE2 File Offset: 0x00673EE2
		public ECustomScreenLoading Type { get; set; }

		// Token: 0x0602F569 RID: 193897 RVA: 0x00675CEB File Offset: 0x00673EEB
		public ICustomScreenLoadingTypeBaseT()
		{
			this.Type = ECustomScreenLoading.Cyberpunk;
		}
	}
}
