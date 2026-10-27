using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x0200667F RID: 26239
	public class DropCatchLevelData
	{
		// Token: 0x1700963C RID: 38460
		// (get) Token: 0x06041BF6 RID: 269302 RVA: 0x00FF2B68 File Offset: 0x00FF0D68
		public bool IsUnlock
		{
			get
			{
				return this.UnlockTime <= TimeUtil.Instance.GetServerTime();
			}
		}

		// Token: 0x06041BF7 RID: 269303 RVA: 0x00FF2B7F File Offset: 0x00FF0D7F
		public EDropCatchLevelState? GetTargetStarState(int starIndex)
		{
			if (this.RewardStates == null || this.RewardStates.Count == 0)
			{
				return new EDropCatchLevelState?(EDropCatchLevelState.Lock);
			}
			return new EDropCatchLevelState?(this.RewardStates[starIndex]);
		}

		// Token: 0x1700963D RID: 38461
		// (get) Token: 0x06041BF8 RID: 269304 RVA: 0x00FF2BB0 File Offset: 0x00FF0DB0
		public bool IsAllRewarded
		{
			get
			{
				if (this.RewardStates == null || this.RewardStates.Count == 0)
				{
					return false;
				}
				using (List<EDropCatchLevelState>.Enumerator enumerator = this.RewardStates.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current != EDropCatchLevelState.Rewarded)
						{
							return false;
						}
					}
				}
				return true;
			}
		}

		// Token: 0x1700963E RID: 38462
		// (get) Token: 0x06041BF9 RID: 269305 RVA: 0x00FF2C1C File Offset: 0x00FF0E1C
		public bool IsAllStar
		{
			get
			{
				if (this.RewardStates == null || this.RewardStates.Count == 0)
				{
					return false;
				}
				using (List<EDropCatchLevelState>.Enumerator enumerator = this.RewardStates.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current == EDropCatchLevelState.Lock)
						{
							return false;
						}
					}
				}
				return true;
			}
		}

		// Token: 0x1700963F RID: 38463
		// (get) Token: 0x06041BFA RID: 269306 RVA: 0x00FF2C88 File Offset: 0x00FF0E88
		public bool HasAnyStar
		{
			get
			{
				if (this.RewardStates == null || this.RewardStates.Count == 0)
				{
					return false;
				}
				foreach (EDropCatchLevelState edropCatchLevelState in this.RewardStates)
				{
					if (edropCatchLevelState == EDropCatchLevelState.Unlock || edropCatchLevelState == EDropCatchLevelState.Rewarded)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x17009640 RID: 38464
		// (get) Token: 0x06041BFB RID: 269307 RVA: 0x00FF2CFC File Offset: 0x00FF0EFC
		public bool CanReceiveReward
		{
			get
			{
				if (this.RewardStates == null || this.RewardStates.Count == 0)
				{
					return false;
				}
				using (List<EDropCatchLevelState>.Enumerator enumerator = this.RewardStates.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current == EDropCatchLevelState.Unlock)
						{
							return true;
						}
					}
				}
				return false;
			}
		}

		// Token: 0x0402236D RID: 140141
		public int ConfigId;

		// Token: 0x0402236E RID: 140142
		public double UnlockTime;

		// Token: 0x0402236F RID: 140143
		public int HighestScore;

		// Token: 0x04022370 RID: 140144
		[Nullable(1)]
		public List<EDropCatchLevelState> RewardStates = new List<EDropCatchLevelState>();
	}
}
