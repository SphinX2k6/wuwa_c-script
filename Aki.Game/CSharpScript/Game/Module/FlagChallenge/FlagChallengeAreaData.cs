using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A00 RID: 18944
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeAreaData
	{
		// Token: 0x0602F7DA RID: 194522 RVA: 0x00D3F230 File Offset: 0x00D3D430
		public FlagChallengeAreaData(int id, int activityId)
		{
			this.Id = id;
			this.ActivityId = activityId;
			this.Config = FlagChallengeConfig.Instance.GetAreaConfig(id).Value;
		}

		// Token: 0x0602F7DB RID: 194523 RVA: 0x00D3F26A File Offset: 0x00D3D46A
		public int GetLevelId()
		{
			return this.Config.LevelId;
		}

		// Token: 0x0602F7DC RID: 194524 RVA: 0x00D3F277 File Offset: 0x00D3D477
		public int[] GetStrongholds()
		{
			return this.Config.Strongholds();
		}

		// Token: 0x0602F7DD RID: 194525 RVA: 0x00D3F284 File Offset: 0x00D3D484
		public int[] GetRecommendLevel()
		{
			return this.Config.RecommendLevels();
		}

		// Token: 0x0602F7DE RID: 194526 RVA: 0x00D3F291 File Offset: 0x00D3D491
		public int GetAreaItemPos()
		{
			return this.Config.UiPos;
		}

		// Token: 0x04019263 RID: 103011
		public readonly int ActivityId;

		// Token: 0x04019264 RID: 103012
		public readonly int Id;

		// Token: 0x04019265 RID: 103013
		public FlagChallengeArea Config;
	}
}
