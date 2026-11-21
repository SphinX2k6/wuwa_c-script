using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020055CF RID: 21967
	public class DropCatchLevelData
	{
		// Token: 0x1700697B RID: 27003
		// (get) Token: 0x06036742 RID: 223042 RVA: 0x00F33F70 File Offset: 0x00F32170
		public bool IsUnlock
		{
			get
			{
				return this.UnlockTime <= TimeUtil.Instance.GetServerTime();
			}
		}

		// Token: 0x06036743 RID: 223043 RVA: 0x00F33F87 File Offset: 0x00F32187
		public EDropCatchLevelState? GetTargetStarState(int starIndex)
		{
			if (this.RewardStates == null || this.RewardStates.Count == 0)
			{
				return new EDropCatchLevelState?(EDropCatchLevelState.Lock);
			}
			return new EDropCatchLevelState?(this.RewardStates[starIndex]);
		}

		// Token: 0x1700697C RID: 27004
		// (get) Token: 0x06036744 RID: 223044 RVA: 0x00F33FB8 File Offset: 0x00F321B8
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

		// Token: 0x1700697D RID: 27005
		// (get) Token: 0x06036745 RID: 223045 RVA: 0x00F34024 File Offset: 0x00F32224
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

		// Token: 0x1700697E RID: 27006
		// (get) Token: 0x06036746 RID: 223046 RVA: 0x00F34090 File Offset: 0x00F32290
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

		// Token: 0x1700697F RID: 27007
		// (get) Token: 0x06036747 RID: 223047 RVA: 0x00F34104 File Offset: 0x00F32304
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

		// Token: 0x0401CBC6 RID: 117702
		public int ConfigId;

		// Token: 0x0401CBC7 RID: 117703
		public double UnlockTime;

		// Token: 0x0401CBC8 RID: 117704
		public int HighestScore;

		// Token: 0x0401CBC9 RID: 117705
		[Nullable(1)]
		public List<EDropCatchLevelState> RewardStates = new List<EDropCatchLevelState>();
	}
}
