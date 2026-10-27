using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065B8 RID: 26040
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardViewModel : DockyardViewModelBase
	{
		// Token: 0x1700958B RID: 38283
		// (get) Token: 0x0604151E RID: 267550 RVA: 0x00FD47BA File Offset: 0x00FD29BA
		public virtual DockyardTrawlBackpackPanelModel BackpackPanelModel { [PreserveBaseOverrides] get; } = new DockyardTrawlBackpackPanelModel();

		// Token: 0x1700958C RID: 38284
		// (get) Token: 0x0604151F RID: 267551 RVA: 0x00FD47C2 File Offset: 0x00FD29C2
		public virtual DockyardTrawlListPanelModel ListPanelModel { [PreserveBaseOverrides] get; } = new DockyardTrawlListPanelModel();
	}
}
