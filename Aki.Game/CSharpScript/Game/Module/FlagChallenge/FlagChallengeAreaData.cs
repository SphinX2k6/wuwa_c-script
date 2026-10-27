using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A24 RID: 23076
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeAreaData
	{
		// Token: 0x0603A891 RID: 239761 RVA: 0x00DEECAC File Offset: 0x00DECEAC
		public FlagChallengeAreaData(int id, int activityId)
		{
			this.Id = id;
			this.ActivityId = activityId;
			this.Config = FlagChallengeConfig.Instance.GetAreaConfig(id).Value;
		}

		// Token: 0x0603A892 RID: 239762 RVA: 0x00DEECE6 File Offset: 0x00DECEE6
		public int GetLevelId()
		{
			return this.Config.LevelId;
		}

		// Token: 0x0603A893 RID: 239763 RVA: 0x00DEECF3 File Offset: 0x00DECEF3
		public int[] GetStrongholds()
		{
			return this.Config.Strongholds();
		}

		// Token: 0x0603A894 RID: 239764 RVA: 0x00DEED00 File Offset: 0x00DECF00
		public int[] GetRecommendLevel()
		{
			return this.Config.RecommendLevels();
		}

		// Token: 0x0603A895 RID: 239765 RVA: 0x00DEED0D File Offset: 0x00DECF0D
		public int GetAreaItemPos()
		{
			return this.Config.UiPos;
		}

		// Token: 0x0401E7BC RID: 124860
		public readonly int ActivityId;

		// Token: 0x0401E7BD RID: 124861
		public readonly int Id;

		// Token: 0x0401E7BE RID: 124862
		public FlagChallengeArea Config;
	}
}
