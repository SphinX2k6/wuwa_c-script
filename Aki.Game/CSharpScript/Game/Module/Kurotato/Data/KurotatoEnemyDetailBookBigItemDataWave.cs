using System;
using Aki.Config;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x02004771 RID: 18289
	public class KurotatoEnemyDetailBookBigItemDataWave : KurotatoEnemyDetailBookBigItemData
	{
		// Token: 0x17005C4D RID: 23629
		// (get) Token: 0x0602DEA5 RID: 188069 RVA: 0x00CDA2C4 File Offset: 0x00CD84C4
		// (set) Token: 0x0602DEA6 RID: 188070 RVA: 0x00CDA2CC File Offset: 0x00CD84CC
		public int ThisWave { get; set; }

		// Token: 0x17005C4E RID: 23630
		// (get) Token: 0x0602DEA7 RID: 188071 RVA: 0x00CDA2D5 File Offset: 0x00CD84D5
		// (set) Token: 0x0602DEA8 RID: 188072 RVA: 0x00CDA2DD File Offset: 0x00CD84DD
		public EKurotatoWaveStatus WaveStatus { get; set; } = EKurotatoWaveStatus.NotCompleted;

		// Token: 0x17005C4F RID: 23631
		// (get) Token: 0x0602DEA9 RID: 188073 RVA: 0x00CDA2E6 File Offset: 0x00CD84E6
		// (set) Token: 0x0602DEAA RID: 188074 RVA: 0x00CDA2EE File Offset: 0x00CD84EE
		public bool IsHighDiff { get; set; }

		// Token: 0x0602DEAB RID: 188075 RVA: 0x00CDA2F8 File Offset: 0x00CD84F8
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
