using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.SubViews.CommonGamePlay
{
	// Token: 0x0200376F RID: 14191
	[NullableContext(2)]
	[Nullable(0)]
	public class MapMoraleLvItemData : IMapMoraleLvItemData
	{
		// Token: 0x17004BBF RID: 19391
		// (get) Token: 0x06024E35 RID: 151093 RVA: 0x00A6C523 File Offset: 0x00A6A723
		// (set) Token: 0x06024E36 RID: 151094 RVA: 0x00A6C52B File Offset: 0x00A6A72B
		[Nullable(1)]
		public string TitleId { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17004BC0 RID: 19392
		// (get) Token: 0x06024E37 RID: 151095 RVA: 0x00A6C534 File Offset: 0x00A6A734
		// (set) Token: 0x06024E38 RID: 151096 RVA: 0x00A6C53C File Offset: 0x00A6A73C
		public int Lv { get; set; }

		// Token: 0x17004BC1 RID: 19393
		// (get) Token: 0x06024E39 RID: 151097 RVA: 0x00A6C545 File Offset: 0x00A6A745
		// (set) Token: 0x06024E3A RID: 151098 RVA: 0x00A6C54D File Offset: 0x00A6A74D
		public string LvColor { get; set; }

		// Token: 0x17004BC2 RID: 19394
		// (get) Token: 0x06024E3B RID: 151099 RVA: 0x00A6C556 File Offset: 0x00A6A756
		// (set) Token: 0x06024E3C RID: 151100 RVA: 0x00A6C55E File Offset: 0x00A6A75E
		public string BgColor { get; set; }
	}
}
