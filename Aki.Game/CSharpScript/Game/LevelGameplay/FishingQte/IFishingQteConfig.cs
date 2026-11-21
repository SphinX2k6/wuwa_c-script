using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02005FAD RID: 24493
	[NullableContext(1)]
	public interface IFishingQteConfig
	{
		// Token: 0x17006F04 RID: 28420
		// (get) Token: 0x0603AD44 RID: 240964
		// (set) Token: 0x0603AD45 RID: 240965
		int Id { get; set; }

		// Token: 0x17006F05 RID: 28421
		// (get) Token: 0x0603AD46 RID: 240966
		// (set) Token: 0x0603AD47 RID: 240967
		List<int> RandomArea { get; set; }

		// Token: 0x17006F06 RID: 28422
		// (get) Token: 0x0603AD48 RID: 240968
		// (set) Token: 0x0603AD49 RID: 240969
		List<List<int>> InvalidArea { get; set; }

		// Token: 0x17006F07 RID: 28423
		// (get) Token: 0x0603AD4A RID: 240970
		// (set) Token: 0x0603AD4B RID: 240971
		int MaxScore { get; set; }

		// Token: 0x17006F08 RID: 28424
		// (get) Token: 0x0603AD4C RID: 240972
		// (set) Token: 0x0603AD4D RID: 240973
		int HitAreaScore { get; set; }

		// Token: 0x17006F09 RID: 28425
		// (get) Token: 0x0603AD4E RID: 240974
		// (set) Token: 0x0603AD4F RID: 240975
		int PerfectSize { get; set; }

		// Token: 0x17006F0A RID: 28426
		// (get) Token: 0x0603AD50 RID: 240976
		// (set) Token: 0x0603AD51 RID: 240977
		Dictionary<int, int> PerfectAppearRate { get; set; }

		// Token: 0x17006F0B RID: 28427
		// (get) Token: 0x0603AD52 RID: 240978
		// (set) Token: 0x0603AD53 RID: 240979
		int PerfectScore { get; set; }

		// Token: 0x17006F0C RID: 28428
		// (get) Token: 0x0603AD54 RID: 240980
		// (set) Token: 0x0603AD55 RID: 240981
		Dictionary<int, int> CursorSpeed { get; set; }

		// Token: 0x17006F0D RID: 28429
		// (get) Token: 0x0603AD56 RID: 240982
		// (set) Token: 0x0603AD57 RID: 240983
		int HitColdTime { get; set; }

		// Token: 0x17006F0E RID: 28430
		// (get) Token: 0x0603AD58 RID: 240984
		// (set) Token: 0x0603AD59 RID: 240985
		int ScoreUp { get; set; }

		// Token: 0x17006F0F RID: 28431
		// (get) Token: 0x0603AD5A RID: 240986
		// (set) Token: 0x0603AD5B RID: 240987
		int MultiBoxGroup { get; set; }

		// Token: 0x17006F10 RID: 28432
		// (get) Token: 0x0603AD5C RID: 240988
		// (set) Token: 0x0603AD5D RID: 240989
		List<float> HiddenInterval { get; set; }

		// Token: 0x17006F11 RID: 28433
		// (get) Token: 0x0603AD5E RID: 240990
		// (set) Token: 0x0603AD5F RID: 240991
		Dictionary<int, int> RouletteRotateSpeed { get; set; }

		// Token: 0x17006F12 RID: 28434
		// (get) Token: 0x0603AD60 RID: 240992
		// (set) Token: 0x0603AD61 RID: 240993
		int MistakeScore { get; set; }

		// Token: 0x17006F13 RID: 28435
		// (get) Token: 0x0603AD62 RID: 240994
		// (set) Token: 0x0603AD63 RID: 240995
		bool IsAnticlockwise { get; set; }

		// Token: 0x17006F14 RID: 28436
		// (get) Token: 0x0603AD64 RID: 240996
		// (set) Token: 0x0603AD65 RID: 240997
		string Comment { get; set; }

		// Token: 0x17006F15 RID: 28437
		// (get) Token: 0x0603AD66 RID: 240998
		// (set) Token: 0x0603AD67 RID: 240999
		int RefreshType { get; set; }
	}
}
