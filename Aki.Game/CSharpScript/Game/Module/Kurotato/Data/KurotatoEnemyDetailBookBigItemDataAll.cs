using System;
using System.Collections.Generic;
using Aki.Config;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x02004770 RID: 18288
	public class KurotatoEnemyDetailBookBigItemDataAll : KurotatoEnemyDetailBookBigItemData
	{
		// Token: 0x17005C4C RID: 23628
		// (get) Token: 0x0602DEA2 RID: 188066 RVA: 0x00CDA070 File Offset: 0x00CD8270
		// (set) Token: 0x0602DEA3 RID: 188067 RVA: 0x00CDA078 File Offset: 0x00CD8278
		public int RiskType { get; set; }

		// Token: 0x0602DEA4 RID: 188068 RVA: 0x00CDA084 File Offset: 0x00CD8284
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
