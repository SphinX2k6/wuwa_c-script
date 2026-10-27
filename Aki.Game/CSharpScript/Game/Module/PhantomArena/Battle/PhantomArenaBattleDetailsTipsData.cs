using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle
{
	// Token: 0x02005239 RID: 21049
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleDetailsTipsData : IPhantomArenaBattleDetailsTipsData
	{
		// Token: 0x17008239 RID: 33337
		// (get) Token: 0x06035C5C RID: 220252 RVA: 0x00CB9EBC File Offset: 0x00CB80BC
		// (set) Token: 0x06035C5D RID: 220253 RVA: 0x00CB9EC4 File Offset: 0x00CB80C4
		public UUIItem AttachItem { get; set; }

		// Token: 0x1700823A RID: 33338
		// (get) Token: 0x06035C5E RID: 220254 RVA: 0x00CB9ECD File Offset: 0x00CB80CD
		// (set) Token: 0x06035C5F RID: 220255 RVA: 0x00CB9ED5 File Offset: 0x00CB80D5
		public UUIItem TriggerItem { get; set; }

		// Token: 0x1700823B RID: 33339
		// (get) Token: 0x06035C60 RID: 220256 RVA: 0x00CB9EDE File Offset: 0x00CB80DE
		// (set) Token: 0x06035C61 RID: 220257 RVA: 0x00CB9EE6 File Offset: 0x00CB80E6
		public EPhantomArenaBattleDetailsPositionType PositionType { get; set; }

		// Token: 0x1700823C RID: 33340
		// (get) Token: 0x06035C62 RID: 220258 RVA: 0x00CB9EEF File Offset: 0x00CB80EF
		// (set) Token: 0x06035C63 RID: 220259 RVA: 0x00CB9EF7 File Offset: 0x00CB80F7
		public EPhantomArenaBattleDetailsTipsShowType ShowType { get; set; }
	}
}
