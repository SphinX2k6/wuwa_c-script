using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Area;

namespace CSharpScript.Game.Module.ExploreLevel
{
	// Token: 0x02005A8D RID: 23181
	public class CountryExploreScoreData
	{
		// Token: 0x0603AB6B RID: 240491 RVA: 0x00DFC47D File Offset: 0x00DFA67D
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

		// Token: 0x0603AB6C RID: 240492 RVA: 0x00DFC4BC File Offset: 0x00DFA6BC
		public void SetReceived(bool bReceived)
		{
			this.IsReceived = bReceived;
		}

		// Token: 0x0603AB6D RID: 240493 RVA: 0x00DFC4C5 File Offset: 0x00DFA6C5
		public bool GetIsReceived()
		{
			return this.IsReceived;
		}

		// Token: 0x0603AB6E RID: 240494 RVA: 0x00DFC4D0 File Offset: 0x00DFA6D0
		[NullableContext(1)]
		public string GetAreaNameTextId()
		{
			return this.AreaConfig.Value.Title;
		}

		// Token: 0x0603AB6F RID: 240495 RVA: 0x00DFC4F0 File Offset: 0x00DFA6F0
		public Area? GetAreaConfig()
		{
			return this.AreaConfig;
		}

		// Token: 0x0603AB70 RID: 240496 RVA: 0x00DFC4F8 File Offset: 0x00DFA6F8
		public bool CanReceive()
		{
			return this.GetAreaProgress() >= this.Progress && !this.IsReceived;
		}

		// Token: 0x0603AB71 RID: 240497 RVA: 0x00DFC513 File Offset: 0x00DFA713
		public int GetAreaProgress()
		{
			return ExploreProgressModel.Instance.GetExploreAreaData(this.AreaId).GetProgress();
		}

		// Token: 0x0401EA5A RID: 125530
		public int CountryId;

		// Token: 0x0401EA5B RID: 125531
		public int AreaId;

		// Token: 0x0401EA5C RID: 125532
		public int Progress;

		// Token: 0x0401EA5D RID: 125533
		public int LastProgress;

		// Token: 0x0401EA5E RID: 125534
		public int Score;

		// Token: 0x0401EA5F RID: 125535
		private bool IsReceived;

		// Token: 0x0401EA60 RID: 125536
		private Area? AreaConfig;
	}
}
