using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007044 RID: 28740
	public class IInteractiveItemsFunctionT
	{
		// Token: 0x1700D268 RID: 53864
		// (get) Token: 0x06031CF8 RID: 204024 RVA: 0x006BDF98 File Offset: 0x006BC198
		// (set) Token: 0x06031CF9 RID: 204025 RVA: 0x006BDFA0 File Offset: 0x006BC1A0
		public EEnableFunctionType Type { get; set; }

		// Token: 0x1700D269 RID: 53865
		// (get) Token: 0x06031CFA RID: 204026 RVA: 0x006BDFA9 File Offset: 0x006BC1A9
		// (set) Token: 0x06031CFB RID: 204027 RVA: 0x006BDFB1 File Offset: 0x006BC1B1
		public bool Enable { get; set; }

		// Token: 0x06031CFC RID: 204028 RVA: 0x006BDFBA File Offset: 0x006BC1BA
		public IInteractiveItemsFunctionT()
		{
			this.Type = EEnableFunctionType.TeleportDungeon;
			this.Enable = false;
		}
	}
}
