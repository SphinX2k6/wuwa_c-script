using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay
{
	// Token: 0x020066F0 RID: 26352
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayViewModel
	{
		// Token: 0x06041DA0 RID: 269728 RVA: 0x00FF8600 File Offset: 0x00FF6800
		public int GetCurGameplayId()
		{
			return this.CurGameplayId;
		}

		// Token: 0x06041DA1 RID: 269729 RVA: 0x00FF8608 File Offset: 0x00FF6808
		public void SetCurGameplayId(int gameplayId)
		{
			this.CurGameplayId = gameplayId;
			this.ScoreLevels.Clear();
			DropCatchGameplay? dropCatchGameplayById = DropCatchConfig.Instance.GetDropCatchGameplayById(gameplayId);
			if (dropCatchGameplayById == null)
			{
				return;
			}
			foreach (int id in dropCatchGameplayById.Value.RewardIds())
			{
				DropCatchReward? dropCatchReward;
				this.ScoreLevels.Add((float)((DropCatchConfig.Instance.GetDropCatchRewardById(id) != null) ? dropCatchReward.GetValueOrDefault().Score : 0));
			}
		}

		// Token: 0x06041DA2 RID: 269730 RVA: 0x00FF8696 File Offset: 0x00FF6896
		public void AddScore(float score)
		{
			this.CurScore += score;
		}

		// Token: 0x06041DA3 RID: 269731 RVA: 0x00FF86A6 File Offset: 0x00FF68A6
		public float GetCurScore()
		{
			return this.CurScore;
		}

		// Token: 0x06041DA4 RID: 269732 RVA: 0x00FF86AE File Offset: 0x00FF68AE
		public Dictionary<int, int> GetDropItemRecord()
		{
			return this.DropItemRecord;
		}

		// Token: 0x06041DA5 RID: 269733 RVA: 0x00FF86B8 File Offset: 0x00FF68B8
		public void AddDropItemRecord(int itemId)
		{
			int num;
			this.DropItemRecord.TryGetValue(itemId, out num);
			num++;
			if (this.DropItemRecord.ContainsKey(itemId))
			{
				this.DropItemRecord[itemId] = num;
				return;
			}
			this.DropItemRecord.Add(itemId, num);
		}

		// Token: 0x06041DA6 RID: 269734 RVA: 0x00FF8701 File Offset: 0x00FF6901
		public List<float> GetScoreLevels()
		{
			return this.ScoreLevels;
		}

		// Token: 0x06041DA7 RID: 269735 RVA: 0x00FF8709 File Offset: 0x00FF6909
		public string GetGameplayTimeStamp()
		{
			return this.GameplayTimeStamp;
		}

		// Token: 0x06041DA8 RID: 269736 RVA: 0x00FF8711 File Offset: 0x00FF6911
		public void SetGameplayTimeStamp(string timestamp)
		{
			this.GameplayTimeStamp = timestamp;
		}

		// Token: 0x06041DA9 RID: 269737 RVA: 0x00FF871A File Offset: 0x00FF691A
		public void AddSkillTimes()
		{
			this.SkillTimes += 1f;
		}

		// Token: 0x06041DAA RID: 269738 RVA: 0x00FF872E File Offset: 0x00FF692E
		public float GetSkillTimes()
		{
			return this.SkillTimes;
		}

		// Token: 0x06041DAB RID: 269739 RVA: 0x00FF8736 File Offset: 0x00FF6936
		public void AddAddTime(float time)
		{
			this.AddTime += time;
		}

		// Token: 0x06041DAC RID: 269740 RVA: 0x00FF8746 File Offset: 0x00FF6946
		public float GetAddTime()
		{
			return this.AddTime;
		}

		// Token: 0x06041DAD RID: 269741 RVA: 0x00FF874E File Offset: 0x00FF694E
		public void Reset()
		{
			this.CurScore = 0f;
			this.DropItemRecord.Clear();
			this.GameplayTimeStamp = "";
			this.SkillTimes = 0f;
			this.AddTime = 0f;
		}

		// Token: 0x040224CA RID: 140490
		private int CurGameplayId;

		// Token: 0x040224CB RID: 140491
		private float CurScore;

		// Token: 0x040224CC RID: 140492
		private readonly Dictionary<int, int> DropItemRecord = new Dictionary<int, int>();

		// Token: 0x040224CD RID: 140493
		private readonly List<float> ScoreLevels = new List<float>();

		// Token: 0x040224CE RID: 140494
		private string GameplayTimeStamp = "";

		// Token: 0x040224CF RID: 140495
		private float SkillTimes;

		// Token: 0x040224D0 RID: 140496
		private float AddTime;
	}
}
