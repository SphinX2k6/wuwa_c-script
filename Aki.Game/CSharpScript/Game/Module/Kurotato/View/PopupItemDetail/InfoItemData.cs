using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.PopupItemDetail
{
	// Token: 0x0200573A RID: 22330
	[NullableContext(1)]
	[Nullable(0)]
	public class InfoItemData : IInfoItemData
	{
		// Token: 0x17008868 RID: 34920
		// (get) Token: 0x06038C54 RID: 232532 RVA: 0x00D7A770 File Offset: 0x00D78970
		// (set) Token: 0x06038C55 RID: 232533 RVA: 0x00D7A778 File Offset: 0x00D78978
		public int Level { get; set; }

		// Token: 0x17008869 RID: 34921
		// (get) Token: 0x06038C56 RID: 232534 RVA: 0x00D7A781 File Offset: 0x00D78981
		// (set) Token: 0x06038C57 RID: 232535 RVA: 0x00D7A789 File Offset: 0x00D78989
		public string Description { get; set; } = string.Empty;

		// Token: 0x1700886A RID: 34922
		// (get) Token: 0x06038C58 RID: 232536 RVA: 0x00D7A792 File Offset: 0x00D78992
		// (set) Token: 0x06038C59 RID: 232537 RVA: 0x00D7A79A File Offset: 0x00D7899A
		public int BuildLevel { get; set; }

		// Token: 0x1700886B RID: 34923
		// (get) Token: 0x06038C5A RID: 232538 RVA: 0x00D7A7A3 File Offset: 0x00D789A3
		// (set) Token: 0x06038C5B RID: 232539 RVA: 0x00D7A7AB File Offset: 0x00D789AB
		public bool IsArrowLevel { get; set; }
	}
}
