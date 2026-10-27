using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x02005906 RID: 22790
	[NullableContext(1)]
	[Nullable(0)]
	public class IInfrArchiveMenuItemData
	{
		// Token: 0x17008AD6 RID: 35542
		// (get) Token: 0x06039E03 RID: 237059 RVA: 0x00DBEF78 File Offset: 0x00DBD178
		// (set) Token: 0x06039E04 RID: 237060 RVA: 0x00DBEF80 File Offset: 0x00DBD180
		public InfrastructureDefine.EInfrArchiveTabType CardType { get; set; }

		// Token: 0x17008AD7 RID: 35543
		// (get) Token: 0x06039E05 RID: 237061 RVA: 0x00DBEF89 File Offset: 0x00DBD189
		// (set) Token: 0x06039E06 RID: 237062 RVA: 0x00DBEF91 File Offset: 0x00DBD191
		public string DesText { get; set; }
	}
}
