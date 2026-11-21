using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A0B RID: 14859
	[NullableContext(1)]
	public interface ITrapDefenseDifficultyLevelInfo
	{
		// Token: 0x17004E3F RID: 20031
		// (get) Token: 0x060263B2 RID: 156594
		ETrapDefenseDifficultyLevel DifficultyLevel { get; }

		// Token: 0x17004E40 RID: 20032
		// (get) Token: 0x060263B3 RID: 156595
		string NameKey { get; }

		// Token: 0x17004E41 RID: 20033
		// (get) Token: 0x060263B4 RID: 156596
		string NameBgKey { get; }

		// Token: 0x17004E42 RID: 20034
		// (get) Token: 0x060263B5 RID: 156597
		string BgKey { get; }

		// Token: 0x17004E43 RID: 20035
		// (get) Token: 0x060263B6 RID: 156598
		string BgLightKey { get; }

		// Token: 0x17004E44 RID: 20036
		// (get) Token: 0x060263B7 RID: 156599
		string BgTitleKey { get; }

		// Token: 0x17004E45 RID: 20037
		// (get) Token: 0x060263B8 RID: 156600
		string BgFlowerColor { get; }

		// Token: 0x17004E46 RID: 20038
		// (get) Token: 0x060263B9 RID: 156601
		string ArtTextShadowColor { get; }
	}
}
