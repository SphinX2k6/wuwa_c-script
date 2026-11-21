using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077B6 RID: 30646
	public class ISetExploreStateT
	{
		// Token: 0x1700E099 RID: 57497
		// (get) Token: 0x06035D10 RID: 220432 RVA: 0x00735939 File Offset: 0x00733B39
		// (set) Token: 0x06035D11 RID: 220433 RVA: 0x00735941 File Offset: 0x00733B41
		public ITeleControlConfigT Config { get; set; }

		// Token: 0x06035D12 RID: 220434 RVA: 0x0073594A File Offset: 0x00733B4A
		public ISetExploreStateT()
		{
			this.Config = null;
		}
	}
}
