using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay
{
	// Token: 0x02005640 RID: 22080
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayViewModel
	{
		// Token: 0x060368EC RID: 223468 RVA: 0x00F399F4 File Offset: 0x00F37BF4
		public int GetCurGameplayId()
		{
			return this.CurGameplayId;
		}

		// Token: 0x060368ED RID: 223469 RVA: 0x00F399FC File Offset: 0x00F37BFC
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

		// Token: 0x060368EE RID: 223470 RVA: 0x00F39A8A File Offset: 0x00F37C8A
		public void AddScore(float score)
		{
			this.CurScore += score;
		}

		// Token: 0x060368EF RID: 223471 RVA: 0x00F39A9A File Offset: 0x00F37C9A
		public float GetCurScore()
		{
			return this.CurScore;
		}

		// Token: 0x060368F0 RID: 223472 RVA: 0x00F39AA2 File Offset: 0x00F37CA2
		public Dictionary<int, int> GetDropItemRecord()
		{
			return this.DropItemRecord;
		}

		// Token: 0x060368F1 RID: 223473 RVA: 0x00F39AAC File Offset: 0x00F37CAC
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

		// Token: 0x060368F2 RID: 223474 RVA: 0x00F39AF5 File Offset: 0x00F37CF5
		public List<float> GetScoreLevels()
		{
			return this.ScoreLevels;
		}

		// Token: 0x060368F3 RID: 223475 RVA: 0x00F39AFD File Offset: 0x00F37CFD
		public string GetGameplayTimeStamp()
		{
			return this.GameplayTimeStamp;
		}

		// Token: 0x060368F4 RID: 223476 RVA: 0x00F39B05 File Offset: 0x00F37D05
		public void SetGameplayTimeStamp(string timestamp)
		{
			this.GameplayTimeStamp = timestamp;
		}

		// Token: 0x060368F5 RID: 223477 RVA: 0x00F39B0E File Offset: 0x00F37D0E
		public void AddSkillTimes()
		{
			this.SkillTimes += 1f;
		}

		// Token: 0x060368F6 RID: 223478 RVA: 0x00F39B22 File Offset: 0x00F37D22
		public float GetSkillTimes()
		{
			return this.SkillTimes;
		}

		// Token: 0x060368F7 RID: 223479 RVA: 0x00F39B2A File Offset: 0x00F37D2A
		public void AddAddTime(float time)
		{
			this.AddTime += time;
		}

		// Token: 0x060368F8 RID: 223480 RVA: 0x00F39B3A File Offset: 0x00F37D3A
		public float GetAddTime()
		{
			return this.AddTime;
		}

		// Token: 0x060368F9 RID: 223481 RVA: 0x00F39B42 File Offset: 0x00F37D42
		public void Reset()
		{
			this.CurScore = 0f;
			this.DropItemRecord.Clear();
			this.GameplayTimeStamp = "";
			this.SkillTimes = 0f;
			this.AddTime = 0f;
		}

		// Token: 0x0401CD23 RID: 118051
		private int CurGameplayId;

		// Token: 0x0401CD24 RID: 118052
		private float CurScore;

		// Token: 0x0401CD25 RID: 118053
		private readonly Dictionary<int, int> DropItemRecord = new Dictionary<int, int>();

		// Token: 0x0401CD26 RID: 118054
		private readonly List<float> ScoreLevels = new List<float>();

		// Token: 0x0401CD27 RID: 118055
		private string GameplayTimeStamp = "";

		// Token: 0x0401CD28 RID: 118056
		private float SkillTimes;

		// Token: 0x0401CD29 RID: 118057
		private float AddTime;
	}
}
