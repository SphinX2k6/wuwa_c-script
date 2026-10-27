using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F70 RID: 28528
	public class ISendClientEventT
	{
		// Token: 0x1700D3EE RID: 54254
		// (get) Token: 0x06032673 RID: 206451 RVA: 0x006CDD73 File Offset: 0x006CBF73
		// (set) Token: 0x06032674 RID: 206452 RVA: 0x006CDD7B File Offset: 0x006CBF7B
		public string EventName { get; set; }

		// Token: 0x1700D3EF RID: 54255
		// (get) Token: 0x06032675 RID: 206453 RVA: 0x006CDD84 File Offset: 0x006CBF84
		// (set) Token: 0x06032676 RID: 206454 RVA: 0x006CDD8C File Offset: 0x006CBF8C
		public TClientEventUnion Target { get; set; }

		// Token: 0x06032677 RID: 206455 RVA: 0x006CDD95 File Offset: 0x006CBF95
		public ISendClientEventT()
		{
			this.EventName = null;
			this.Target = null;
		}
	}
}
