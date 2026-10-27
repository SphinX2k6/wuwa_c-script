using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063A5 RID: 25509
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingRiskConfigContext : IMowingRiskContextDisposable
	{
		// Token: 0x060402DA RID: 262874 RVA: 0x00F8A4AC File Offset: 0x00F886AC
		public MowingRiskConfigContext()
		{
			this.type2QualityData = new Dictionary<EMowingBuffType, IMowingRiskConfigQualityData>
			{
				{
					EMowingBuffType.BasicLow,
					new MowingRiskConfigQualityData
					{
						HexColor = EMowingBuffQualityHexColor.Blue,
						CfgQualityInfoId = InventoryDefine.EQuality.Blue,
						BackgroundResource = EMowingBuffIntroduceQualityBackground.Blue
					}
				},
				{
					EMowingBuffType.BasicHigh,
					new MowingRiskConfigQualityData
					{
						HexColor = EMowingBuffQualityHexColor.Purple,
						CfgQualityInfoId = InventoryDefine.EQuality.Purple,
						BackgroundResource = EMowingBuffIntroduceQualityBackground.Purple
					}
				},
				{
					EMowingBuffType.Super,
					new MowingRiskConfigQualityData
					{
						HexColor = EMowingBuffQualityHexColor.Gold,
						CfgQualityInfoId = InventoryDefine.EQuality.Orange,
						BackgroundResource = EMowingBuffIntroduceQualityBackground.Gold
					}
				}
			};
		}

		// Token: 0x060402DB RID: 262875 RVA: 0x00F8A545 File Offset: 0x00F88745
		public void Dispose()
		{
		}

		// Token: 0x060402DC RID: 262876 RVA: 0x00F8A548 File Offset: 0x00F88748
		public EMowingBuffQualityHexColor GetBuffHexColorById(int id)
		{
			RiskHarvestBuffGroup? config = ConfigRiskHarvestBuffGroupById.GetConfig(id, true);
			if (config == null)
			{
				return EMowingBuffQualityHexColor.Default;
			}
			IMowingRiskConfigQualityData mowingRiskConfigQualityData;
			if (!this.type2QualityData.TryGetValue((EMowingBuffType)config.Value.BuffType, out mowingRiskConfigQualityData))
			{
				return EMowingBuffQualityHexColor.Default;
			}
			return mowingRiskConfigQualityData.HexColor;
		}

		// Token: 0x060402DD RID: 262877 RVA: 0x00F8A598 File Offset: 0x00F88798
		public string GetBuffNameTextIdById(int id)
		{
			RiskHarvestBuffGroup? config = ConfigRiskHarvestBuffGroupById.GetConfig(id, true);
			return ((config != null) ? config.GetValueOrDefault().BuffName : null) ?? string.Empty;
		}

		// Token: 0x060402DE RID: 262878 RVA: 0x00F8A5D4 File Offset: 0x00F887D4
		public string GetBuffDescriptionTextIdById(int id)
		{
			RiskHarvestBuffGroup? config = ConfigRiskHarvestBuffGroupById.GetConfig(id, true);
			return ((config != null) ? config.GetValueOrDefault().BuffDesc : null) ?? string.Empty;
		}

		// Token: 0x060402DF RID: 262879 RVA: 0x00F8A610 File Offset: 0x00F88810
		public string[] GetBuffDescriptionArgsById(int id)
		{
			RiskHarvestBuffGroup? config = ConfigRiskHarvestBuffGroupById.GetConfig(id, true);
			return ((config != null) ? config.GetValueOrDefault().BuffFactors() : null) ?? Array.Empty<string>();
		}

		// Token: 0x060402E0 RID: 262880 RVA: 0x00F8A64C File Offset: 0x00F8884C
		public string GetBuffIconPathById(int id)
		{
			RiskHarvestBuffGroup? config = ConfigRiskHarvestBuffGroupById.GetConfig(id, true);
			return ((config != null) ? config.GetValueOrDefault().BuffIcon : null) ?? string.Empty;
		}

		// Token: 0x060402E1 RID: 262881 RVA: 0x00F8A688 File Offset: 0x00F88888
		public QualityInfo? GetBuffQualityInfoById(int id)
		{
			RiskHarvestBuffGroup? config = ConfigRiskHarvestBuffGroupById.GetConfig(id, true);
			if (config == null)
			{
				return null;
			}
			IMowingRiskConfigQualityData mowingRiskConfigQualityData;
			if (!this.type2QualityData.TryGetValue((EMowingBuffType)config.Value.BuffType, out mowingRiskConfigQualityData))
			{
				return null;
			}
			CommonConfig instance = CommonConfig.Instance;
			if (instance == null)
			{
				return null;
			}
			return instance.GetItemQualityById((int)mowingRiskConfigQualityData.CfgQualityInfoId);
		}

		// Token: 0x060402E2 RID: 262882 RVA: 0x00F8A6F8 File Offset: 0x00F888F8
		public string GetBuffQualityPathById(int id)
		{
			QualityInfo? buffQualityInfoById = this.GetBuffQualityInfoById(id);
			return ((buffQualityInfoById != null) ? buffQualityInfoById.GetValueOrDefault().MediumItemGridQualitySpritePath : null) ?? string.Empty;
		}

		// Token: 0x060402E3 RID: 262883 RVA: 0x00F8A734 File Offset: 0x00F88934
		public string GetNewBuffNameHexColorById(int id)
		{
			QualityInfo? buffQualityInfoById = this.GetBuffQualityInfoById(id);
			return ((buffQualityInfoById != null) ? buffQualityInfoById.GetValueOrDefault().TextColor : null) ?? EMowingBuffQualityHexColor.Default.ToString();
		}

		// Token: 0x060402E4 RID: 262884 RVA: 0x00F8A778 File Offset: 0x00F88978
		public string GetNewBuffQualityTexPathById(int id)
		{
			QualityInfo? buffQualityInfoById = this.GetBuffQualityInfoById(id);
			return ((buffQualityInfoById != null) ? buffQualityInfoById.GetValueOrDefault().TextureAcquireBg : null) ?? string.Empty;
		}

		// Token: 0x060402E5 RID: 262885 RVA: 0x00F8A7B4 File Offset: 0x00F889B4
		public string GetNewBuffQualityFlowTexPathById(int id)
		{
			QualityInfo? buffQualityInfoById = this.GetBuffQualityInfoById(id);
			return ((buffQualityInfoById != null) ? buffQualityInfoById.GetValueOrDefault().TextureAcquireFlow : null) ?? string.Empty;
		}

		// Token: 0x060402E6 RID: 262886 RVA: 0x00F8A7F0 File Offset: 0x00F889F0
		public bool IsNewBuffGoldenById(int id)
		{
			QualityInfo? buffQualityInfoById = this.GetBuffQualityInfoById(id);
			return buffQualityInfoById != null && buffQualityInfoById.GetValueOrDefault().Id == 5;
		}

		// Token: 0x060402E7 RID: 262887 RVA: 0x00F8A824 File Offset: 0x00F88A24
		public string GetBuffIntroduceBackgroundPath(int id)
		{
			RiskHarvestBuffGroup? config = ConfigRiskHarvestBuffGroupById.GetConfig(id, true);
			IMowingRiskConfigQualityData mowingRiskConfigQualityData;
			if (config == null || !this.type2QualityData.TryGetValue((EMowingBuffType)config.Value.BuffType, out mowingRiskConfigQualityData))
			{
				return string.Empty;
			}
			return UiResourceConfig.Instance.GetResourcePath(mowingRiskConfigQualityData.BackgroundResource.ToString());
		}

		// Token: 0x060402E8 RID: 262888 RVA: 0x00F8A884 File Offset: 0x00F88A84
		public int GetBuffMaxCountByArtifactId(int id)
		{
			RiskHarvestArtifact? config = ConfigRiskHarvestArtifactById.GetConfig(id, true);
			if (config == null)
			{
				return 0;
			}
			int[] array = config.Value.BasicBuffGroup();
			if (array.Length == 0)
			{
				return 0;
			}
			return array[array.Length - 1];
		}

		// Token: 0x060402E9 RID: 262889 RVA: 0x00F8A8C4 File Offset: 0x00F88AC4
		public int GetProgressLevel(int id, int count)
		{
			int[] array = this.GetArtifactConfig(id).BasicBuffGroup();
			int num = array[array.Length - 1];
			if (count >= num)
			{
				return array.Length;
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (count < array[i])
				{
					return i;
				}
			}
			return 0;
		}

		// Token: 0x060402EA RID: 262890 RVA: 0x00F8A908 File Offset: 0x00F88B08
		public float GetProgressOverallPercentage(int id, int count)
		{
			int[] array = this.GetArtifactConfig(id).BasicBuffGroup();
			int num = array[array.Length - 1];
			if (count >= num)
			{
				return 1f;
			}
			int progressLevel = this.GetProgressLevel(id, count);
			int num2 = (progressLevel > 0) ? array[progressLevel - 1] : 0;
			int num3 = array[progressLevel];
			return (float)(count - num2) / (float)(num3 - num2);
		}

		// Token: 0x060402EB RID: 262891 RVA: 0x00F8A960 File Offset: 0x00F88B60
		public float GetProgressPartialPercentage(int id, int count)
		{
			RiskHarvestArtifact artifactConfig = this.GetArtifactConfig(id);
			int[] array = artifactConfig.BasicBuffGroup();
			int num = array[array.Length - 1];
			if (count >= num)
			{
				return 1f;
			}
			int progressLevel = this.GetProgressLevel(id, count);
			float progressOverallPercentage = this.GetProgressOverallPercentage(id, count);
			int buffGroupLength = artifactConfig.BuffGroupLength;
			return (progressOverallPercentage + (float)progressLevel) / (float)buffGroupLength;
		}

		// Token: 0x060402EC RID: 262892 RVA: 0x00F8A9AC File Offset: 0x00F88BAC
		public RiskHarvestArtifact GetArtifactConfig(int artifactId)
		{
			return ConfigRiskHarvestArtifactById.GetConfig(artifactId, true).Value;
		}

		// Token: 0x060402ED RID: 262893 RVA: 0x00F8A9C8 File Offset: 0x00F88BC8
		public int GetBuffThresholdByArtifactIdAndIndex(int artifactId, int index)
		{
			return this.GetArtifactConfig(artifactId).BasicBuffGroup()[index];
		}

		// Token: 0x060402EE RID: 262894 RVA: 0x00F8A9E8 File Offset: 0x00F88BE8
		public int GetBuffIdByArtifactIdAndIndex(int artifactId, int index)
		{
			return this.GetArtifactConfig(artifactId).BuffGroup()[index];
		}

		// Token: 0x060402EF RID: 262895 RVA: 0x00F8AA06 File Offset: 0x00F88C06
		public RiskHarvestBuffGroup? GetBuffConfigById(int id)
		{
			return ConfigRiskHarvestBuffGroupById.GetConfig(id, true);
		}

		// Token: 0x060402F0 RID: 262896 RVA: 0x00F8AA10 File Offset: 0x00F88C10
		public EMowingBuffType? GetBuffTypeById(int id)
		{
			RiskHarvestBuffGroup? config = ConfigRiskHarvestBuffGroupById.GetConfig(id, true);
			if (config == null)
			{
				return null;
			}
			return new EMowingBuffType?((EMowingBuffType)config.Value.BuffType);
		}

		// Token: 0x060402F1 RID: 262897 RVA: 0x00F8AA4C File Offset: 0x00F88C4C
		public int? GetIdByInstanceId(int instanceId)
		{
			RiskHarvestInst? config = ConfigRiskHarvestInstByInstanceID.GetConfig(instanceId, true);
			if (config == null)
			{
				return null;
			}
			return new int?(config.GetValueOrDefault().Id);
		}

		// Token: 0x060402F2 RID: 262898 RVA: 0x00F8AA88 File Offset: 0x00F88C88
		public int GetInstanceRewardScoreById(int id)
		{
			if (ConfigRiskHarvestInstById.GetConfig(id, true) == null)
			{
				return 0;
			}
			RiskHarvestInst? riskHarvestInst;
			return riskHarvestInst.GetValueOrDefault().RewardScore;
		}

		// Token: 0x060402F3 RID: 262899 RVA: 0x00F8AAB8 File Offset: 0x00F88CB8
		public int GetScoreToUnlockById(int id)
		{
			RiskHarvestInst? config = ConfigRiskHarvestInstById.GetConfig(id, true);
			if (config == null)
			{
				return 0;
			}
			if (config.Value.UnlockInst != 0)
			{
				return config.Value.UnlockScore;
			}
			return 0;
		}

		// Token: 0x060402F4 RID: 262900 RVA: 0x00F8AAFC File Offset: 0x00F88CFC
		public bool IsSuperBuffByBuffId(int id)
		{
			return this.GetBuffTypeById(id).GetValueOrDefault() == EMowingBuffType.Super;
		}

		// Token: 0x060402F5 RID: 262901 RVA: 0x00F8AB1C File Offset: 0x00F88D1C
		public bool IsSuperBuffAvailable(int artifactId, int buffId, int basicBuffTotalCount)
		{
			if (!this.IsSuperBuffByBuffId(buffId))
			{
				return false;
			}
			RiskHarvestArtifact artifactConfig = this.GetArtifactConfig(artifactId);
			int[] array = artifactConfig.BasicBuffGroup();
			int[] array2 = artifactConfig.BuffGroup();
			for (int i = 0; i < array.Length; i++)
			{
				if (array2[i] == buffId && basicBuffTotalCount >= array[i])
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x1700936E RID: 37742
		// (get) Token: 0x060402F6 RID: 262902 RVA: 0x00F8AB6C File Offset: 0x00F88D6C
		// (set) Token: 0x060402F7 RID: 262903 RVA: 0x00F8ABE4 File Offset: 0x00F88DE4
		public Dictionary<int, bool> IsInstanceNewCache
		{
			get
			{
				Dictionary<int, bool> player = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.MowingRiskIsInstanceNew, null);
				if (player == null)
				{
					Dictionary<int, bool> dictionary = new Dictionary<int, bool>();
					IReadOnlyList<RiskHarvestInst> configList = ConfigRiskHarvestInstAll.GetConfigList(true);
					if (configList != null)
					{
						foreach (RiskHarvestInst riskHarvestInst in configList)
						{
							dictionary[riskHarvestInst.Id] = true;
						}
					}
					LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.MowingRiskIsInstanceNew, dictionary);
					return dictionary;
				}
				return player;
			}
			set
			{
				LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.MowingRiskIsInstanceNew, value);
			}
		}

		// Token: 0x060402F8 RID: 262904 RVA: 0x00F8ABEF File Offset: 0x00F88DEF
		public IReadOnlyList<RiskHarvestInst> GetRiskHarvestInstByActivityId(int activityId)
		{
			return ConfigRiskHarvestInstByActivityId.GetConfigList(activityId, true) ?? Array.Empty<RiskHarvestInst>();
		}

		// Token: 0x060402F9 RID: 262905 RVA: 0x00F8AC01 File Offset: 0x00F88E01
		public IReadOnlyList<RiskHarvestScoreReward> GetRiskHarvestScoreRewardByActivityId(int activityId)
		{
			return ConfigRiskHarvestScoreRewardByActivityId.GetConfigList(activityId, true) ?? Array.Empty<RiskHarvestScoreReward>();
		}

		// Token: 0x060402FA RID: 262906 RVA: 0x00F8AC13 File Offset: 0x00F88E13
		public IReadOnlyList<RiskHarvestBuffGroup> GetBuffConfigListByActivityId(int activityId)
		{
			return ConfigRiskHarvestBuffGroupByActivityId.GetConfigList(activityId, true) ?? Array.Empty<RiskHarvestBuffGroup>();
		}

		// Token: 0x040216C7 RID: 136903
		private Dictionary<EMowingBuffType, IMowingRiskConfigQualityData> type2QualityData;
	}
}
