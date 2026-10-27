using System;
using System.Collections.Generic;
using Aki.Config;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x02005799 RID: 22425
	public class KurotatoEnemyDetailBookBigItemDataAll : KurotatoEnemyDetailBookBigItemData
	{
		// Token: 0x17008884 RID: 34948
		// (get) Token: 0x06038F92 RID: 233362 RVA: 0x00D8B2F4 File Offset: 0x00D894F4
		// (set) Token: 0x06038F93 RID: 233363 RVA: 0x00D8B2FC File Offset: 0x00D894FC
		public int RiskType { get; set; }

		// Token: 0x06038F94 RID: 233364 RVA: 0x00D8B308 File Offset: 0x00D89508
		public KurotatoEnemyDetailBookBigItemDataAll(int targetLevel, int riskType)
		{
			base.TabAllOrWave = EKurotatoEnemyDetailBookTabAllOrWave.All;
			base.TargetLevel = targetLevel;
			this.RiskType = riskType;
			List<KurotatoWave> waveByLevelId = KurotatoConfig.Instance.GetWaveByLevelId(targetLevel);
			if (waveByLevelId == null || waveByLevelId.Count == 0)
			{
				return;
			}
			foreach (KurotatoWave kurotatoWave in waveByLevelId)
			{
				if (kurotatoWave.WaveType != 1)
				{
					int monsterSpawnGroupLength = kurotatoWave.MonsterSpawnGroupLength;
					for (int i = 0; i < monsterSpawnGroupLength; i++)
					{
						int spawnId = kurotatoWave.MonsterSpawnGroup(i);
						KurotatoSpawn? spawnById = KurotatoConfig.Instance.GetSpawnById(spawnId);
						if (spawnById != null)
						{
							int monsterIdsLength = spawnById.Value.MonsterIdsLength;
							for (int j = 0; j < monsterIdsLength; j++)
							{
								int num = spawnById.Value.MonsterIds(j);
								if (!this.WaveMonsterIdToNum.ContainsKey(num))
								{
									KurotatoMonsterType? monsterTypeById = KurotatoConfig.Instance.GetMonsterTypeById(num);
									if ((monsterTypeById == null || monsterTypeById.GetValueOrDefault().RiskType != 4) && (monsterTypeById == null || monsterTypeById.GetValueOrDefault().RiskType != 5))
									{
										int? num2 = (monsterTypeById != null) ? new int?(monsterTypeById.GetValueOrDefault().RiskType) : null;
										int riskType2 = this.RiskType;
										if (num2.GetValueOrDefault() == riskType2 & num2 != null)
										{
											KurotatoMonster? monsterConfigById = KurotatoConfig.Instance.GetMonsterConfigById(num);
											if (monsterConfigById != null && !monsterConfigById.Value.IsHideInBook)
											{
												this.WaveMonsterIdToNum[num] = 1;
												this.MonsterGridItemDataList.Add(new KurotatoEnemyData(num, 1));
											}
										}
									}
								}
							}
						}
					}
				}
			}
			this.MonsterGridItemDataList.Sort((KurotatoEnemyData a, KurotatoEnemyData b) => b.RiskType - a.RiskType);
		}
	}
}
