using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005536 RID: 21814
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardViewModel : DockyardViewModelBase
	{
		// Token: 0x170068ED RID: 26861
		// (get) Token: 0x060361E3 RID: 221667 RVA: 0x00F1B7F6 File Offset: 0x00F199F6
		public virtual DockyardTrawlBackpackPanelModel BackpackPanelModel { [PreserveBaseOverrides] get; } = new DockyardTrawlBackpackPanelModel();

		// Token: 0x170068EE RID: 26862
		// (get) Token: 0x060361E4 RID: 221668 RVA: 0x00F1B7FE File Offset: 0x00F199FE
		public virtual DockyardTrawlListPanelModel ListPanelModel { [PreserveBaseOverrides] get; } = new DockyardTrawlListPanelModel();
	}
}
