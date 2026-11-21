using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020036C0 RID: 14016
	[NullableContext(1)]
	[Nullable(0)]
	public class MapNoteParams : IMapNoteParams
	{
		// Token: 0x17004A97 RID: 19095
		// (get) Token: 0x0602469C RID: 149148 RVA: 0x00A49B2E File Offset: 0x00A47D2E
		// (set) Token: 0x0602469D RID: 149149 RVA: 0x00A49B36 File Offset: 0x00A47D36
		public EMapNoteId MapNoteId { get; set; }

		// Token: 0x17004A98 RID: 19096
		// (get) Token: 0x0602469E RID: 149150 RVA: 0x00A49B3F File Offset: 0x00A47D3F
		// (set) Token: 0x0602469F RID: 149151 RVA: 0x00A49B47 File Offset: 0x00A47D47
		public Action<int> ClickCallBack { get; set; }

		// Token: 0x17004A99 RID: 19097
		// (get) Token: 0x060246A0 RID: 149152 RVA: 0x00A49B50 File Offset: 0x00A47D50
		// (set) Token: 0x060246A1 RID: 149153 RVA: 0x00A49B58 File Offset: 0x00A47D58
		public MapNote MapNoteConfig { get; set; }

		// Token: 0x17004A9A RID: 19098
		// (get) Token: 0x060246A2 RID: 149154 RVA: 0x00A49B61 File Offset: 0x00A47D61
		// (set) Token: 0x060246A3 RID: 149155 RVA: 0x00A49B69 File Offset: 0x00A47D69
		public int? MapMarkId { get; set; }

		// Token: 0x17004A9B RID: 19099
		// (get) Token: 0x060246A4 RID: 149156 RVA: 0x00A49B72 File Offset: 0x00A47D72
		// (set) Token: 0x060246A5 RID: 149157 RVA: 0x00A49B7A File Offset: 0x00A47D7A
		[Nullable(2)]
		public string CustomDesc { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
