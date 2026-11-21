using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070E3 RID: 28899
	public class ILiveClearScConfigT
	{
		// Token: 0x1700D3A8 RID: 54184
		// (get) Token: 0x06032304 RID: 205572 RVA: 0x006CA23A File Offset: 0x006C843A
		// (set) Token: 0x06032305 RID: 205573 RVA: 0x006CA242 File Offset: 0x006C8442
		public ELiveScOperationType Type { get; set; }

		// Token: 0x06032306 RID: 205574 RVA: 0x006CA24B File Offset: 0x006C844B
		public ILiveClearScConfigT()
		{
			this.Type = ELiveScOperationType.Send;
		}
	}
}
