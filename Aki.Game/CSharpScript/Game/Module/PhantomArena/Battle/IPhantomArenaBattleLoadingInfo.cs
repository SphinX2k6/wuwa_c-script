using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;

namespace CSharpScript.Game.Module.PhantomArena.Battle
{
	// Token: 0x0200523D RID: 21053
	[NullableContext(1)]
	public interface IPhantomArenaBattleLoadingInfo
	{
		// Token: 0x1700824D RID: 33357
		// (get) Token: 0x06035C87 RID: 220295
		// (set) Token: 0x06035C88 RID: 220296
		int Index { get; set; }

		// Token: 0x1700824E RID: 33358
		// (get) Token: 0x06035C89 RID: 220297
		// (set) Token: 0x06035C8A RID: 220298
		bool IsMe { get; set; }

		// Token: 0x1700824F RID: 33359
		// (get) Token: 0x06035C8B RID: 220299
		// (set) Token: 0x06035C8C RID: 220300
		PhantomCardData CardData { get; set; }
	}
}
