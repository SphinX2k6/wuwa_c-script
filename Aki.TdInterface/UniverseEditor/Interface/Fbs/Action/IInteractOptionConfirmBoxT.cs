using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200704A RID: 28746
	public class IInteractOptionConfirmBoxT
	{
		// Token: 0x1700D28F RID: 53903
		// (get) Token: 0x06031D7B RID: 204155 RVA: 0x006BF581 File Offset: 0x006BD781
		// (set) Token: 0x06031D7C RID: 204156 RVA: 0x006BF589 File Offset: 0x006BD789
		public TInteractOptionConfirmBoxOptionUnion Type { get; set; }

		// Token: 0x06031D7D RID: 204157 RVA: 0x006BF592 File Offset: 0x006BD792
		public IInteractOptionConfirmBoxT()
		{
			this.Type = null;
		}
	}
}
