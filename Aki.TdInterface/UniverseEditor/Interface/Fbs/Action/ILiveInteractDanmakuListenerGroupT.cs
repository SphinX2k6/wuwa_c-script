using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070FB RID: 28923
	public class ILiveInteractDanmakuListenerGroupT
	{
		// Token: 0x1700D3D2 RID: 54226
		// (get) Token: 0x060323BF RID: 205759 RVA: 0x006CB5A7 File Offset: 0x006C97A7
		// (set) Token: 0x060323C0 RID: 205760 RVA: 0x006CB5AF File Offset: 0x006C97AF
		public TLiveInteractDanmakuTriggerUnion Trigger { get; set; }

		// Token: 0x1700D3D3 RID: 54227
		// (get) Token: 0x060323C1 RID: 205761 RVA: 0x006CB5B8 File Offset: 0x006C97B8
		// (set) Token: 0x060323C2 RID: 205762 RVA: 0x006CB5C0 File Offset: 0x006C97C0
		public int DanmakuPoolId { get; set; }

		// Token: 0x1700D3D4 RID: 54228
		// (get) Token: 0x060323C3 RID: 205763 RVA: 0x006CB5C9 File Offset: 0x006C97C9
		// (set) Token: 0x060323C4 RID: 205764 RVA: 0x006CB5D1 File Offset: 0x006C97D1
		public int TriggerCount { get; set; }

		// Token: 0x1700D3D5 RID: 54229
		// (get) Token: 0x060323C5 RID: 205765 RVA: 0x006CB5DA File Offset: 0x006C97DA
		// (set) Token: 0x060323C6 RID: 205766 RVA: 0x006CB5E2 File Offset: 0x006C97E2
		public int MaxTriggerCount { get; set; }

		// Token: 0x060323C7 RID: 205767 RVA: 0x006CB5EB File Offset: 0x006C97EB
		public ILiveInteractDanmakuListenerGroupT()
		{
			this.Trigger = null;
			this.DanmakuPoolId = 0;
			this.TriggerCount = 0;
			this.MaxTriggerCount = 0;
		}
	}
}
