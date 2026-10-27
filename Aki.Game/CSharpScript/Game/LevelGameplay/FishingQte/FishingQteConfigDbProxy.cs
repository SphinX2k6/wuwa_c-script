using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02006E2E RID: 28206
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingQteConfigDbProxy : IFishingQteConfig
	{
		// Token: 0x17009A13 RID: 39443
		// (get) Token: 0x06044BFF RID: 281599 RVA: 0x010F7641 File Offset: 0x010F5841
		// (set) Token: 0x06044C00 RID: 281600 RVA: 0x010F7649 File Offset: 0x010F5849
		public int Id { get; set; }

		// Token: 0x17009A14 RID: 39444
		// (get) Token: 0x06044C01 RID: 281601 RVA: 0x010F7652 File Offset: 0x010F5852
		// (set) Token: 0x06044C02 RID: 281602 RVA: 0x010F765A File Offset: 0x010F585A
		public List<int> RandomArea { get; set; }

		// Token: 0x17009A15 RID: 39445
		// (get) Token: 0x06044C03 RID: 281603 RVA: 0x010F7663 File Offset: 0x010F5863
		// (set) Token: 0x06044C04 RID: 281604 RVA: 0x010F766B File Offset: 0x010F586B
		public IntArray[] InvalidArea { get; set; }

		// Token: 0x17009A16 RID: 39446
		// (get) Token: 0x06044C05 RID: 281605 RVA: 0x010F7674 File Offset: 0x010F5874
		// (set) Token: 0x06044C06 RID: 281606 RVA: 0x010F767C File Offset: 0x010F587C
		public int MaxScore { get; set; }

		// Token: 0x17009A17 RID: 39447
		// (get) Token: 0x06044C07 RID: 281607 RVA: 0x010F7685 File Offset: 0x010F5885
		// (set) Token: 0x06044C08 RID: 281608 RVA: 0x010F768D File Offset: 0x010F588D
		public int HitAreaScore { get; set; }

		// Token: 0x17009A18 RID: 39448
		// (get) Token: 0x06044C09 RID: 281609 RVA: 0x010F7696 File Offset: 0x010F5896
		// (set) Token: 0x06044C0A RID: 281610 RVA: 0x010F769E File Offset: 0x010F589E
		public int PerfectSize { get; set; }

		// Token: 0x17009A19 RID: 39449
		// (get) Token: 0x06044C0B RID: 281611 RVA: 0x010F76A7 File Offset: 0x010F58A7
		// (set) Token: 0x06044C0C RID: 281612 RVA: 0x010F76AF File Offset: 0x010F58AF
		public Dictionary<int, int> PerfectAppearRate { get; set; }

		// Token: 0x17009A1A RID: 39450
		// (get) Token: 0x06044C0D RID: 281613 RVA: 0x010F76B8 File Offset: 0x010F58B8
		// (set) Token: 0x06044C0E RID: 281614 RVA: 0x010F76C0 File Offset: 0x010F58C0
		public int PerfectScore { get; set; }

		// Token: 0x17009A1B RID: 39451
		// (get) Token: 0x06044C0F RID: 281615 RVA: 0x010F76C9 File Offset: 0x010F58C9
		// (set) Token: 0x06044C10 RID: 281616 RVA: 0x010F76D1 File Offset: 0x010F58D1
		public Dictionary<int, int> CursorSpeed { get; set; }

		// Token: 0x17009A1C RID: 39452
		// (get) Token: 0x06044C11 RID: 281617 RVA: 0x010F76DA File Offset: 0x010F58DA
		// (set) Token: 0x06044C12 RID: 281618 RVA: 0x010F76E2 File Offset: 0x010F58E2
		public int HitColdTime { get; set; }

		// Token: 0x17009A1D RID: 39453
		// (get) Token: 0x06044C13 RID: 281619 RVA: 0x010F76EB File Offset: 0x010F58EB
		// (set) Token: 0x06044C14 RID: 281620 RVA: 0x010F76F3 File Offset: 0x010F58F3
		public int ScoreUp { get; set; }

		// Token: 0x17009A1E RID: 39454
		// (get) Token: 0x06044C15 RID: 281621 RVA: 0x010F76FC File Offset: 0x010F58FC
		// (set) Token: 0x06044C16 RID: 281622 RVA: 0x010F7704 File Offset: 0x010F5904
		public int MultiBoxGroup { get; set; }

		// Token: 0x17009A1F RID: 39455
		// (get) Token: 0x06044C17 RID: 281623 RVA: 0x010F770D File Offset: 0x010F590D
		// (set) Token: 0x06044C18 RID: 281624 RVA: 0x010F7715 File Offset: 0x010F5915
		public List<float> HiddenInterval { get; set; }

		// Token: 0x17009A20 RID: 39456
		// (get) Token: 0x06044C19 RID: 281625 RVA: 0x010F771E File Offset: 0x010F591E
		// (set) Token: 0x06044C1A RID: 281626 RVA: 0x010F7726 File Offset: 0x010F5926
		public Dictionary<int, int> RouletteRotateSpeed { get; set; }

		// Token: 0x17009A21 RID: 39457
		// (get) Token: 0x06044C1B RID: 281627 RVA: 0x010F772F File Offset: 0x010F592F
		// (set) Token: 0x06044C1C RID: 281628 RVA: 0x010F7737 File Offset: 0x010F5937
		public int MistakeScore { get; set; }

		// Token: 0x17009A22 RID: 39458
		// (get) Token: 0x06044C1D RID: 281629 RVA: 0x010F7740 File Offset: 0x010F5940
		// (set) Token: 0x06044C1E RID: 281630 RVA: 0x010F7748 File Offset: 0x010F5948
		public bool IsAnticlockwise { get; set; }

		// Token: 0x17009A23 RID: 39459
		// (get) Token: 0x06044C1F RID: 281631 RVA: 0x010F7751 File Offset: 0x010F5951
		// (set) Token: 0x06044C20 RID: 281632 RVA: 0x010F7759 File Offset: 0x010F5959
		public string Comment { get; set; }

		// Token: 0x17009A24 RID: 39460
		// (get) Token: 0x06044C21 RID: 281633 RVA: 0x010F7762 File Offset: 0x010F5962
		// (set) Token: 0x06044C22 RID: 281634 RVA: 0x010F776A File Offset: 0x010F596A
		public int RefreshType { get; set; }

		// Token: 0x06044C23 RID: 281635 RVA: 0x010F7774 File Offset: 0x010F5974
		public FishingQteConfigDbProxy(FishingQteConfig config)
		{
			this.Id = config.Id;
			this.RandomArea = config.RandomArea().ToList<int>();
			this.InvalidArea = config.InvalidArea();
			this.MaxScore = config.MaxScore;
			this.HitAreaScore = config.HitAreaScore;
			this.PerfectSize = config.PerfectSize;
			this.PerfectAppearRate = config.PerfectAppearRate();
			this.PerfectScore = config.PerfectScore;
			this.CursorSpeed = config.CursorSpeed();
			this.HitColdTime = config.HitColdTime;
			this.ScoreUp = config.ScoreUp;
			this.MultiBoxGroup = config.MultiBoxGroup;
			this.HiddenInterval = config.HiddenInterval().ToList<float>();
			this.RouletteRotateSpeed = config.RouletteRotateSpeed();
			this.MistakeScore = config.MistakeScore;
			this.IsAnticlockwise = config.IsAnticlockwise;
			this.Comment = config.Comment;
			this.RefreshType = config.RefreshType;
		}
	}
}
