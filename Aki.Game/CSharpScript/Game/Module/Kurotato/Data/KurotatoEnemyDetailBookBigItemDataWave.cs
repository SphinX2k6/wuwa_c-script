using System;
using Aki.Config;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x0200579A RID: 22426
	public class KurotatoEnemyDetailBookBigItemDataWave : KurotatoEnemyDetailBookBigItemData
	{
		// Token: 0x17008885 RID: 34949
		// (get) Token: 0x06038F95 RID: 233365 RVA: 0x00D8B548 File Offset: 0x00D89748
		// (set) Token: 0x06038F96 RID: 233366 RVA: 0x00D8B550 File Offset: 0x00D89750
		public int ThisWave { get; set; }

		// Token: 0x17008886 RID: 34950
		// (get) Token: 0x06038F97 RID: 233367 RVA: 0x00D8B559 File Offset: 0x00D89759
		// (set) Token: 0x06038F98 RID: 233368 RVA: 0x00D8B561 File Offset: 0x00D89761
		public EKurotatoWaveStatus WaveStatus { get; set; } = EKurotatoWaveStatus.NotCompleted;

		// Token: 0x17008887 RID: 34951
		// (get) Token: 0x06038F99 RID: 233369 RVA: 0x00D8B56A File Offset: 0x00D8976A
		// (set) Token: 0x06038F9A RID: 233370 RVA: 0x00D8B572 File Offset: 0x00D89772
		public bool IsHighDiff { get; set; }

		// Token: 0x06038F9B RID: 233371 RVA: 0x00D8B57C File Offset: 0x00D8977C
		public KurotatoEnemyDetailBookBigItemDataWave(int targetLevel, int thisWave, int curWave = 0)
		{
			base.TabAllOrWave = EKurotatoEnemyDetailBookTabAllOrWave.Wave;
			base.TargetLevel = targetLevel;
			this.ThisWave = thisWave;
			if (thisWave == curWave)
			{
				this.WaveStatus = EKurotatoWaveStatus.Current;
			}
			else if (thisWave < curWave)
			{
				this.WaveStatus = EKurotatoWaveStatus.Completed;
			}
			else
			{
				this.WaveStatus = EKurotatoWaveStatus.NotCompleted;
			}
			KurotatoWave? monsterByLevelIdAndWaveId = KurotatoConfig.Instance.GetMonsterByLevelIdAndWaveId(targetLevel, thisWave);
			if (monsterByLevelIdAndWaveId != null)
			{
				KurotatoWave value = monsterByLevelIdAndWaveId.Value;
				int monsterSpawnGroupLength = value.MonsterSpawnGroupLength;
				for (int i = 0; i < monsterSpawnGroupLength; i++)
				{
					int spawnId = value.MonsterSpawnGroup(i);
					KurotatoSpawn? spawnById = KurotatoConfig.Instance.GetSpawnById(spawnId);
					if (spawnById != null)
					{
						int monsterIdsLength = spawnById.Value.MonsterIdsLength;
						for (int j = 0; j < monsterIdsLength; j++)
						{
							int num = spawnById.Value.MonsterIds(j);
							KurotatoMonsterType? monsterTypeById = KurotatoConfig.Instance.GetMonsterTypeById(num);
							if ((monsterTypeById == null || monsterTypeById.GetValueOrDefault().RiskType != 4) && (monsterTypeById == null || monsterTypeById.GetValueOrDefault().RiskType != 5))
							{
								if (this.WaveMonsterIdToNum.ContainsKey(num))
								{
									this.WaveMonsterIdToNum[num] = this.WaveMonsterIdToNum[num] + 1;
								}
								else
								{
									this.WaveMonsterIdToNum[num] = 1;
								}
							}
						}
					}
				}
				foreach (int monsterId in this.WaveMonsterIdToNum.Keys)
				{
					KurotatoMonster? monsterConfigById = KurotatoConfig.Instance.GetMonsterConfigById(monsterId);
					if (monsterConfigById != null && !monsterConfigById.Value.IsHideInBook)
					{
						this.MonsterGridItemDataList.Add(new KurotatoEnemyData(monsterId, 1));
					}
				}
			}
			this.MonsterGridItemDataList.Sort((KurotatoEnemyData a, KurotatoEnemyData b) => b.RiskType - a.RiskType);
		}
	}
}
