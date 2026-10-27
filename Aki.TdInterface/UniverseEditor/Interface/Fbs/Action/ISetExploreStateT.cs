using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FED RID: 28653
	public class ISetExploreStateT
	{
		// Token: 0x1700D4C5 RID: 54469
		// (get) Token: 0x06032AAA RID: 207530 RVA: 0x006D5CF5 File Offset: 0x006D3EF5
		// (set) Token: 0x06032AAB RID: 207531 RVA: 0x006D5CFD File Offset: 0x006D3EFD
		public ITeleControlConfigT Config { get; set; }

		// Token: 0x06032AAC RID: 207532 RVA: 0x006D5D06 File Offset: 0x006D3F06
		public ISetExploreStateT()
		{
			this.Config = null;
		}
	}
}
