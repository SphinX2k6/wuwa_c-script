using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200714C RID: 29004
	public class ILiveUiShowConfigT
	{
		// Token: 0x1700D448 RID: 54344
		// (get) Token: 0x06032630 RID: 206384 RVA: 0x006CFAB2 File Offset: 0x006CDCB2
		// (set) Token: 0x06032631 RID: 206385 RVA: 0x006CFABA File Offset: 0x006CDCBA
		public ELiveUiType Type { get; set; }

		// Token: 0x06032632 RID: 206386 RVA: 0x006CFAC3 File Offset: 0x006CDCC3
		public ILiveUiShowConfigT()
		{
			this.Type = ELiveUiType.Start;
		}
	}
}
