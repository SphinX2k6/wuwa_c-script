using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02005FAF RID: 24495
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingQteConfigDbProxy : IFishingQteConfig
	{
		// Token: 0x17006F28 RID: 28456
		// (get) Token: 0x0603AD8D RID: 241037 RVA: 0x010A1CB7 File Offset: 0x0109FEB7
		// (set) Token: 0x0603AD8E RID: 241038 RVA: 0x010A1CBF File Offset: 0x0109FEBF
		public int Id { get; set; }

		// Token: 0x17006F29 RID: 28457
		// (get) Token: 0x0603AD8F RID: 241039 RVA: 0x010A1CC8 File Offset: 0x0109FEC8
		// (set) Token: 0x0603AD90 RID: 241040 RVA: 0x010A1CD0 File Offset: 0x0109FED0
		public List<int> RandomArea { get; set; }

		// Token: 0x17006F2A RID: 28458
		// (get) Token: 0x0603AD91 RID: 241041 RVA: 0x010A1CD9 File Offset: 0x0109FED9
		// (set) Token: 0x0603AD92 RID: 241042 RVA: 0x010A1CE1 File Offset: 0x0109FEE1
		public List<List<int>> InvalidArea { get; set; }

		// Token: 0x17006F2B RID: 28459
		// (get) Token: 0x0603AD93 RID: 241043 RVA: 0x010A1CEA File Offset: 0x0109FEEA
		// (set) Token: 0x0603AD94 RID: 241044 RVA: 0x010A1CF2 File Offset: 0x0109FEF2
		public int MaxScore { get; set; }

		// Token: 0x17006F2C RID: 28460
		// (get) Token: 0x0603AD95 RID: 241045 RVA: 0x010A1CFB File Offset: 0x0109FEFB
		// (set) Token: 0x0603AD96 RID: 241046 RVA: 0x010A1D03 File Offset: 0x0109FF03
		public int HitAreaScore { get; set; }

		// Token: 0x17006F2D RID: 28461
		// (get) Token: 0x0603AD97 RID: 241047 RVA: 0x010A1D0C File Offset: 0x0109FF0C
		// (set) Token: 0x0603AD98 RID: 241048 RVA: 0x010A1D14 File Offset: 0x0109FF14
		public int PerfectSize { get; set; }

		// Token: 0x17006F2E RID: 28462
		// (get) Token: 0x0603AD99 RID: 241049 RVA: 0x010A1D1D File Offset: 0x0109FF1D
		// (set) Token: 0x0603AD9A RID: 241050 RVA: 0x010A1D25 File Offset: 0x0109FF25
		public Dictionary<int, int> PerfectAppearRate { get; set; }

		// Token: 0x17006F2F RID: 28463
		// (get) Token: 0x0603AD9B RID: 241051 RVA: 0x010A1D2E File Offset: 0x0109FF2E
		// (set) Token: 0x0603AD9C RID: 241052 RVA: 0x010A1D36 File Offset: 0x0109FF36
		public int PerfectScore { get; set; }

		// Token: 0x17006F30 RID: 28464
		// (get) Token: 0x0603AD9D RID: 241053 RVA: 0x010A1D3F File Offset: 0x0109FF3F
		// (set) Token: 0x0603AD9E RID: 241054 RVA: 0x010A1D47 File Offset: 0x0109FF47
		public Dictionary<int, int> CursorSpeed { get; set; }

		// Token: 0x17006F31 RID: 28465
		// (get) Token: 0x0603AD9F RID: 241055 RVA: 0x010A1D50 File Offset: 0x0109FF50
		// (set) Token: 0x0603ADA0 RID: 241056 RVA: 0x010A1D58 File Offset: 0x0109FF58
		public int HitColdTime { get; set; }

		// Token: 0x17006F32 RID: 28466
		// (get) Token: 0x0603ADA1 RID: 241057 RVA: 0x010A1D61 File Offset: 0x0109FF61
		// (set) Token: 0x0603ADA2 RID: 241058 RVA: 0x010A1D69 File Offset: 0x0109FF69
		public int ScoreUp { get; set; }

		// Token: 0x17006F33 RID: 28467
		// (get) Token: 0x0603ADA3 RID: 241059 RVA: 0x010A1D72 File Offset: 0x0109FF72
		// (set) Token: 0x0603ADA4 RID: 241060 RVA: 0x010A1D7A File Offset: 0x0109FF7A
		public int MultiBoxGroup { get; set; }

		// Token: 0x17006F34 RID: 28468
		// (get) Token: 0x0603ADA5 RID: 241061 RVA: 0x010A1D83 File Offset: 0x0109FF83
		// (set) Token: 0x0603ADA6 RID: 241062 RVA: 0x010A1D8B File Offset: 0x0109FF8B
		public List<float> HiddenInterval { get; set; }

		// Token: 0x17006F35 RID: 28469
		// (get) Token: 0x0603ADA7 RID: 241063 RVA: 0x010A1D94 File Offset: 0x0109FF94
		// (set) Token: 0x0603ADA8 RID: 241064 RVA: 0x010A1D9C File Offset: 0x0109FF9C
		public Dictionary<int, int> RouletteRotateSpeed { get; set; }

		// Token: 0x17006F36 RID: 28470
		// (get) Token: 0x0603ADA9 RID: 241065 RVA: 0x010A1DA5 File Offset: 0x0109FFA5
		// (set) Token: 0x0603ADAA RID: 241066 RVA: 0x010A1DAD File Offset: 0x0109FFAD
		public int MistakeScore { get; set; }

		// Token: 0x17006F37 RID: 28471
		// (get) Token: 0x0603ADAB RID: 241067 RVA: 0x010A1DB6 File Offset: 0x0109FFB6
		// (set) Token: 0x0603ADAC RID: 241068 RVA: 0x010A1DBE File Offset: 0x0109FFBE
		public bool IsAnticlockwise { get; set; }

		// Token: 0x17006F38 RID: 28472
		// (get) Token: 0x0603ADAD RID: 241069 RVA: 0x010A1DC7 File Offset: 0x0109FFC7
		// (set) Token: 0x0603ADAE RID: 241070 RVA: 0x010A1DCF File Offset: 0x0109FFCF
		public string Comment { get; set; }

		// Token: 0x17006F39 RID: 28473
		// (get) Token: 0x0603ADAF RID: 241071 RVA: 0x010A1DD8 File Offset: 0x0109FFD8
		// (set) Token: 0x0603ADB0 RID: 241072 RVA: 0x010A1DE0 File Offset: 0x0109FFE0
		public int RefreshType { get; set; }

		// Token: 0x0603ADB1 RID: 241073 RVA: 0x010A1DEC File Offset: 0x0109FFEC
		public FishingQteConfigDbProxy(FishingQteConfig config)
		{
			this.Id = config.Id;
			this.RandomArea = new List<int>(config.RandomArea());
			this.InvalidArea = new List<List<int>>(config.InvalidAreaLength);
			foreach (IntArray intArray in config.InvalidAreaIter())
			{
				this.InvalidArea.Add(new List<int>(intArray.GetArrayIntArray()));
			}
			this.MaxScore = config.MaxScore;
			this.HitAreaScore = config.HitAreaScore;
			this.PerfectSize = config.PerfectSize;
			this.PerfectAppearRate = config.PerfectAppearRate();
			this.PerfectScore = config.PerfectScore;
			this.CursorSpeed = config.CursorSpeed();
			this.HitColdTime = config.HitColdTime;
			this.ScoreUp = config.ScoreUp;
			this.MultiBoxGroup = config.MultiBoxGroup;
			this.HiddenInterval = new List<float>(config.HiddenInterval());
			this.RouletteRotateSpeed = config.RouletteRotateSpeed();
			this.MistakeScore = config.MistakeScore;
			this.IsAnticlockwise = config.IsAnticlockwise;
			this.Comment = config.Comment;
			this.RefreshType = config.RefreshType;
		}
	}
}
