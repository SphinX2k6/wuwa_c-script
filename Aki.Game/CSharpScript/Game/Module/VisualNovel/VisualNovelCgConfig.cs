using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037AF RID: 14255
	[NullableContext(1)]
	[Nullable(0)]
	public struct VisualNovelCgConfig
	{
		// Token: 0x17004C48 RID: 19528
		// (get) Token: 0x0602518B RID: 151947 RVA: 0x00A77BE3 File Offset: 0x00A75DE3
		// (set) Token: 0x0602518C RID: 151948 RVA: 0x00A77BEB File Offset: 0x00A75DEB
		public string Type { readonly get; set; }

		// Token: 0x17004C49 RID: 19529
		// (get) Token: 0x0602518D RID: 151949 RVA: 0x00A77BF4 File Offset: 0x00A75DF4
		// (set) Token: 0x0602518E RID: 151950 RVA: 0x00A77BFC File Offset: 0x00A75DFC
		public string PicPath { readonly get; set; }

		// Token: 0x17004C4A RID: 19530
		// (get) Token: 0x0602518F RID: 151951 RVA: 0x00A77C05 File Offset: 0x00A75E05
		// (set) Token: 0x06025190 RID: 151952 RVA: 0x00A77C0D File Offset: 0x00A75E0D
		public string PicPathMaleVariant { readonly get; set; }

		// Token: 0x17004C4B RID: 19531
		// (get) Token: 0x06025191 RID: 151953 RVA: 0x00A77C16 File Offset: 0x00A75E16
		// (set) Token: 0x06025192 RID: 151954 RVA: 0x00A77C1E File Offset: 0x00A75E1E
		public string PrefabPath { readonly get; set; }

		// Token: 0x17004C4C RID: 19532
		// (get) Token: 0x06025193 RID: 151955 RVA: 0x00A77C27 File Offset: 0x00A75E27
		// (set) Token: 0x06025194 RID: 151956 RVA: 0x00A77C2F File Offset: 0x00A75E2F
		public string PrefabPathMaleVariant { readonly get; set; }
	}
}
