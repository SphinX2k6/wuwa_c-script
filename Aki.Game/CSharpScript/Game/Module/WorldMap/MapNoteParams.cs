using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x0200478F RID: 18319
	[NullableContext(1)]
	[Nullable(0)]
	public class MapNoteParams : IMapNoteParams
	{
		// Token: 0x170077DB RID: 30683
		// (get) Token: 0x0602FED1 RID: 196305 RVA: 0x00B19C52 File Offset: 0x00B17E52
		// (set) Token: 0x0602FED2 RID: 196306 RVA: 0x00B19C5A File Offset: 0x00B17E5A
		public EMapNoteId MapNoteId { get; set; }

		// Token: 0x170077DC RID: 30684
		// (get) Token: 0x0602FED3 RID: 196307 RVA: 0x00B19C63 File Offset: 0x00B17E63
		// (set) Token: 0x0602FED4 RID: 196308 RVA: 0x00B19C6B File Offset: 0x00B17E6B
		public Action<int> ClickCallBack { get; set; }

		// Token: 0x170077DD RID: 30685
		// (get) Token: 0x0602FED5 RID: 196309 RVA: 0x00B19C74 File Offset: 0x00B17E74
		// (set) Token: 0x0602FED6 RID: 196310 RVA: 0x00B19C7C File Offset: 0x00B17E7C
		public MapNote MapNoteConfig { get; set; }

		// Token: 0x170077DE RID: 30686
		// (get) Token: 0x0602FED7 RID: 196311 RVA: 0x00B19C85 File Offset: 0x00B17E85
		// (set) Token: 0x0602FED8 RID: 196312 RVA: 0x00B19C8D File Offset: 0x00B17E8D
		public int? MapMarkId { get; set; }

		// Token: 0x170077DF RID: 30687
		// (get) Token: 0x0602FED9 RID: 196313 RVA: 0x00B19C96 File Offset: 0x00B17E96
		// (set) Token: 0x0602FEDA RID: 196314 RVA: 0x00B19C9E File Offset: 0x00B17E9E
		[Nullable(2)]
		public string CustomDesc { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
