using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075CB RID: 30155
	public class IRemoveEntityDecorationT
	{
		// Token: 0x1700DDAD RID: 56749
		// (get) Token: 0x06034E70 RID: 216688 RVA: 0x0071C052 File Offset: 0x0071A252
		// (set) Token: 0x06034E71 RID: 216689 RVA: 0x0071C05A File Offset: 0x0071A25A
		public EEntityDecorationType Type { get; set; }

		// Token: 0x06034E72 RID: 216690 RVA: 0x0071C063 File Offset: 0x0071A263
		public IRemoveEntityDecorationT()
		{
			this.Type = EEntityDecorationType.Add;
		}
	}
}
