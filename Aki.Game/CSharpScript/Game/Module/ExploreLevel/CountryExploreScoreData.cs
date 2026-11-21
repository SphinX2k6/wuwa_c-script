using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Area;

namespace CSharpScript.Game.Module.ExploreLevel
{
	// Token: 0x02004A69 RID: 19049
	public class CountryExploreScoreData
	{
		// Token: 0x0602FAB4 RID: 195252 RVA: 0x00D4CA11 File Offset: 0x00D4AC11
		public void Initialize(int countryId, int areaId, int progress, int lastProgress, int score)
		{
			this.CountryId = countryId;
			this.AreaId = areaId;
			this.Progress = progress;
			this.LastProgress = lastProgress;
			this.Score = score;
			this.IsReceived = false;
			this.AreaConfig = CSharpScript.Game.Module.Area.AreaConfig.Instance.GetAreaInfo(areaId);
		}

		// Token: 0x0602FAB5 RID: 195253 RVA: 0x00D4CA50 File Offset: 0x00D4AC50
		public void SetReceived(bool bReceived)
		{
			this.IsReceived = bReceived;
		}

		// Token: 0x0602FAB6 RID: 195254 RVA: 0x00D4CA59 File Offset: 0x00D4AC59
		public bool GetIsReceived()
		{
			return this.IsReceived;
		}

		// Token: 0x0602FAB7 RID: 195255 RVA: 0x00D4CA64 File Offset: 0x00D4AC64
		[NullableContext(1)]
		public string GetAreaNameTextId()
		{
			return this.AreaConfig.Value.Title;
		}

		// Token: 0x0602FAB8 RID: 195256 RVA: 0x00D4CA84 File Offset: 0x00D4AC84
		public Area? GetAreaConfig()
		{
			return this.AreaConfig;
		}

		// Token: 0x0602FAB9 RID: 195257 RVA: 0x00D4CA8C File Offset: 0x00D4AC8C
		public bool CanReceive()
		{
			return this.GetAreaProgress() >= this.Progress && !this.IsReceived;
		}

		// Token: 0x0602FABA RID: 195258 RVA: 0x00D4CAA7 File Offset: 0x00D4ACA7
		public int GetAreaProgress()
		{
			return ExploreProgressModel.Instance.GetExploreAreaData(this.AreaId).GetProgress();
		}

		// Token: 0x04019501 RID: 103681
		public int CountryId;

		// Token: 0x04019502 RID: 103682
		public int AreaId;

		// Token: 0x04019503 RID: 103683
		public int Progress;

		// Token: 0x04019504 RID: 103684
		public int LastProgress;

		// Token: 0x04019505 RID: 103685
		public int Score;

		// Token: 0x04019506 RID: 103686
		private bool IsReceived;

		// Token: 0x04019507 RID: 103687
		private Area? AreaConfig;
	}
}
