using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200640A RID: 25610
	public class IClientUiEventT
	{
		// Token: 0x1700BEB7 RID: 48823
		// (get) Token: 0x0602C509 RID: 181513 RVA: 0x0061529B File Offset: 0x0061349B
		// (set) Token: 0x0602C50A RID: 181514 RVA: 0x006152A3 File Offset: 0x006134A3
		public EClientEventTarget Type { get; set; }

		// Token: 0x1700BEB8 RID: 48824
		// (get) Token: 0x0602C50B RID: 181515 RVA: 0x006152AC File Offset: 0x006134AC
		// (set) Token: 0x0602C50C RID: 181516 RVA: 0x006152B4 File Offset: 0x006134B4
		public TClientEventUiUnion Ui { get; set; }

		// Token: 0x0602C50D RID: 181517 RVA: 0x006152BD File Offset: 0x006134BD
		public IClientUiEventT()
		{
			this.Type = EClientEventTarget.Self;
			this.Ui = null;
		}
	}
}
