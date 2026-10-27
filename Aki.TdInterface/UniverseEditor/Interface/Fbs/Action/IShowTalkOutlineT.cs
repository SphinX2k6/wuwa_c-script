using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007101 RID: 28929
	public class IShowTalkOutlineT
	{
		// Token: 0x1700D70F RID: 55055
		// (get) Token: 0x06033485 RID: 210053 RVA: 0x006EA0A0 File Offset: 0x006E82A0
		// (set) Token: 0x06033486 RID: 210054 RVA: 0x006EA0A8 File Offset: 0x006E82A8
		public int TextId { get; set; }

		// Token: 0x1700D710 RID: 55056
		// (get) Token: 0x06033487 RID: 210055 RVA: 0x006EA0B1 File Offset: 0x006E82B1
		// (set) Token: 0x06033488 RID: 210056 RVA: 0x006EA0B9 File Offset: 0x006E82B9
		public string TidOutline { get; set; }

		// Token: 0x1700D711 RID: 55057
		// (get) Token: 0x06033489 RID: 210057 RVA: 0x006EA0C2 File Offset: 0x006E82C2
		// (set) Token: 0x0603348A RID: 210058 RVA: 0x006EA0CA File Offset: 0x006E82CA
		public string PlotLineKey { get; set; }

		// Token: 0x0603348B RID: 210059 RVA: 0x006EA0D3 File Offset: 0x006E82D3
		public IShowTalkOutlineT()
		{
			this.TextId = 0;
			this.TidOutline = null;
			this.PlotLineKey = null;
		}
	}
}
