using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A63 RID: 19043
	[NullableContext(1)]
	public interface ITrapDefenseDifficultyLevelInfo
	{
		// Token: 0x17007A92 RID: 31378
		// (get) Token: 0x06031622 RID: 202274
		ETrapDefenseDifficultyLevel DifficultyLevel { get; }

		// Token: 0x17007A93 RID: 31379
		// (get) Token: 0x06031623 RID: 202275
		string NameKey { get; }

		// Token: 0x17007A94 RID: 31380
		// (get) Token: 0x06031624 RID: 202276
		string NameBgKey { get; }

		// Token: 0x17007A95 RID: 31381
		// (get) Token: 0x06031625 RID: 202277
		string BgKey { get; }

		// Token: 0x17007A96 RID: 31382
		// (get) Token: 0x06031626 RID: 202278
		string BgLightKey { get; }

		// Token: 0x17007A97 RID: 31383
		// (get) Token: 0x06031627 RID: 202279
		string BgTitleKey { get; }

		// Token: 0x17007A98 RID: 31384
		// (get) Token: 0x06031628 RID: 202280
		string BgFlowerColor { get; }

		// Token: 0x17007A99 RID: 31385
		// (get) Token: 0x06031629 RID: 202281
		string ArtTextShadowColor { get; }
	}
}
