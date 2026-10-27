using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02005575 RID: 21877
	public class MapConstructorParams : IMapConstructorParams
	{
		// Token: 0x1700862C RID: 34348
		// (get) Token: 0x06037C50 RID: 228432 RVA: 0x00D3907F File Offset: 0x00D3727F
		// (set) Token: 0x06037C51 RID: 228433 RVA: 0x00D39087 File Offset: 0x00D37287
		public int InstanceId { get; set; }

		// Token: 0x1700862D RID: 34349
		// (get) Token: 0x06037C52 RID: 228434 RVA: 0x00D39090 File Offset: 0x00D37290
		// (set) Token: 0x06037C53 RID: 228435 RVA: 0x00D39098 File Offset: 0x00D37298
		public EMapType MapType { get; set; }

		// Token: 0x1700862E RID: 34350
		// (get) Token: 0x06037C54 RID: 228436 RVA: 0x00D390A1 File Offset: 0x00D372A1
		// (set) Token: 0x06037C55 RID: 228437 RVA: 0x00D390A9 File Offset: 0x00D372A9
		public float MapDefaultScale { get; set; }

		// Token: 0x1700862F RID: 34351
		// (get) Token: 0x06037C56 RID: 228438 RVA: 0x00D390B2 File Offset: 0x00D372B2
		// (set) Token: 0x06037C57 RID: 228439 RVA: 0x00D390BA File Offset: 0x00D372BA
		public EMapGravityDirection? Gravity { get; set; }

		// Token: 0x17008630 RID: 34352
		// (get) Token: 0x06037C58 RID: 228440 RVA: 0x00D390C3 File Offset: 0x00D372C3
		// (set) Token: 0x06037C59 RID: 228441 RVA: 0x00D390CB File Offset: 0x00D372CB
		public float? MarkScale { get; set; }

		// Token: 0x17008631 RID: 34353
		// (get) Token: 0x06037C5A RID: 228442 RVA: 0x00D390D4 File Offset: 0x00D372D4
		// (set) Token: 0x06037C5B RID: 228443 RVA: 0x00D390DC File Offset: 0x00D372DC
		public float? ClickRange { get; set; }

		// Token: 0x17008632 RID: 34354
		// (get) Token: 0x06037C5C RID: 228444 RVA: 0x00D390E5 File Offset: 0x00D372E5
		// (set) Token: 0x06037C5D RID: 228445 RVA: 0x00D390ED File Offset: 0x00D372ED
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<string, UTexture> PreloadTiles { [return: Nullable(new byte[]
		{
			2,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1
		})] set; }
	}
}
