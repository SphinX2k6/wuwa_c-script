using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020036D3 RID: 14035
	[NullableContext(1)]
	[Nullable(0)]
	public class MapProgressItemData
	{
		// Token: 0x17004AD1 RID: 19153
		// (get) Token: 0x0602471E RID: 149278 RVA: 0x00A49D7D File Offset: 0x00A47F7D
		// (set) Token: 0x0602471F RID: 149279 RVA: 0x00A49D85 File Offset: 0x00A47F85
		public string TitleTextId { get; set; } = string.Empty;

		// Token: 0x17004AD2 RID: 19154
		// (get) Token: 0x06024720 RID: 149280 RVA: 0x00A49D8E File Offset: 0x00A47F8E
		// (set) Token: 0x06024721 RID: 149281 RVA: 0x00A49D96 File Offset: 0x00A47F96
		public string CountText { get; set; } = string.Empty;

		// Token: 0x17004AD3 RID: 19155
		// (get) Token: 0x06024722 RID: 149282 RVA: 0x00A49D9F File Offset: 0x00A47F9F
		// (set) Token: 0x06024723 RID: 149283 RVA: 0x00A49DA7 File Offset: 0x00A47FA7
		public bool Completed { get; set; }

		// Token: 0x17004AD4 RID: 19156
		// (get) Token: 0x06024724 RID: 149284 RVA: 0x00A49DB0 File Offset: 0x00A47FB0
		// (set) Token: 0x06024725 RID: 149285 RVA: 0x00A49DB8 File Offset: 0x00A47FB8
		[Nullable(2)]
		public string IconPath { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
