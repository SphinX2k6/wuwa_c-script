using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;

namespace CSharpScript.Game.Module.PhantomArena.Battle
{
	// Token: 0x0200523E RID: 21054
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleLoadingInfo : IPhantomArenaBattleLoadingInfo
	{
		// Token: 0x17008250 RID: 33360
		// (get) Token: 0x06035C8D RID: 220301 RVA: 0x00CB9FA0 File Offset: 0x00CB81A0
		// (set) Token: 0x06035C8E RID: 220302 RVA: 0x00CB9FA8 File Offset: 0x00CB81A8
		public int Index { get; set; }

		// Token: 0x17008251 RID: 33361
		// (get) Token: 0x06035C8F RID: 220303 RVA: 0x00CB9FB1 File Offset: 0x00CB81B1
		// (set) Token: 0x06035C90 RID: 220304 RVA: 0x00CB9FB9 File Offset: 0x00CB81B9
		public bool IsMe { get; set; }

		// Token: 0x17008252 RID: 33362
		// (get) Token: 0x06035C91 RID: 220305 RVA: 0x00CB9FC2 File Offset: 0x00CB81C2
		// (set) Token: 0x06035C92 RID: 220306 RVA: 0x00CB9FCA File Offset: 0x00CB81CA
		public PhantomCardData CardData { get; set; }
	}
}
