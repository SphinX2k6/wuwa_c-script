using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x02005323 RID: 21283
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingRiskConfigContext : IMowingRiskContextDisposable
	{
		// Token: 0x06034F9B RID: 216987 RVA: 0x00ED13E4 File Offset: 0x00ECF5E4
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

		// Token: 0x06034F9C RID: 216988 RVA: 0x00ED147D File Offset: 0x00ECF67D
		public void Dispose()
		{
		}

		// Token: 0x06034F9D RID: 216989 RVA: 0x00ED1480 File Offset: 0x00ECF680
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

		// Token: 0x06034F9E RID: 216990 RVA: 0x00ED14D0 File Offset: 0x00ECF6D0
		public string GetBuffNameTextIdById(int id)
		{
			RiskHarvestBuffGroup? config = ConfigRiskHarvestBuffGroupById.GetConfig(id, true);
			return ((config != null) ? config.GetValueOrDefault().BuffName : null) ?? string.Empty;
		}

		// Token: 0x06034F9F RID: 216991 RVA: 0x00ED150C File Offset: 0x00ECF70C
		public string GetBuffDescriptionTextIdById(int id)
		{
			RiskHarvestBuffGroup? config = ConfigRiskHarvestBuffGroupById.GetConfig(id, true);
			return ((config != null) ? config.GetValueOrDefault().BuffDesc : null) ?? string.Empty;
		}

		// Token: 0x06034FA0 RID: 216992 RVA: 0x00ED1548 File Offset: 0x00ECF748
		public string[] GetBuffDescriptionArgsById(int id)
		{
			RiskHarvestBuffGroup? config = ConfigRiskHarvestBuffGroupById.GetConfig(id, true);
			return ((config != null) ? config.GetValueOrDefault().BuffFactors() : null) ?? Array.Empty<string>();
		}

		// Token: 0x06034FA1 RID: 216993 RVA: 0x00ED1584 File Offset: 0x00ECF784
		public string GetBuffIconPathById(int id)
		{
			RiskHarvestBuffGroup? config = ConfigRiskHarvestBuffGroupById.GetConfig(id, true);
			return ((config != null) ? config.GetValueOrDefault().BuffIcon : null) ?? string.Empty;
		}

		// Token: 0x06034FA2 RID: 216994 RVA: 0x00ED15C0 File Offset: 0x00ECF7C0
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

		// Token: 0x06034FA3 RID: 216995 RVA: 0x00ED1630 File Offset: 0x00ECF830
		public string GetBuffQualityPathById(int id)
		{
			QualityInfo? buffQualityInfoById = this.GetBuffQualityInfoById(id);
			return ((buffQualityInfoById != null) ? buffQualityInfoById.GetValueOrDefault().MediumItemGridQualitySpritePath : null) ?? string.Empty;
		}

		// Token: 0x06034FA4 RID: 216996 RVA: 0x00ED166C File Offset: 0x00ECF86C
		public string GetNewBuffNameHexColorById(int id)
		{
			QualityInfo? buffQualityInfoById = this.GetBuffQualityInfoById(id);
			return ((buffQualityInfoById != null) ? buffQualityInfoById.GetValueOrDefault().TextColor : null) ?? EMowingBuffQualityHexColor.Default.ToString();
		}

		// Token: 0x06034FA5 RID: 216997 RVA: 0x00ED16B0 File Offset: 0x00ECF8B0
		public string GetNewBuffQualityTexPathById(int id)
		{
			QualityInfo? buffQualityInfoById = this.GetBuffQualityInfoById(id);
			return ((buffQualityInfoById != null) ? buffQualityInfoById.GetValueOrDefault().TextureAcquireBg : null) ?? string.Empty;
		}

		// Token: 0x06034FA6 RID: 216998 RVA: 0x00ED16EC File Offset: 0x00ECF8EC
		public string GetNewBuffQualityFlowTexPathById(int id)
		{
			QualityInfo? buffQualityInfoById = this.GetBuffQualityInfoById(id);
			return ((buffQualityInfoById != null) ? buffQualityInfoById.GetValueOrDefault().TextureAcquireFlow : null) ?? string.Empty;
		}

		// Token: 0x06034FA7 RID: 216999 RVA: 0x00ED1728 File Offset: 0x00ECF928
		public bool IsNewBuffGoldenById(int id)
		{
			QualityInfo? buffQualityInfoById = this.GetBuffQualityInfoById(id);
			return buffQualityInfoById != null && buffQualityInfoById.GetValueOrDefault().Id == 5;
		}

		// Token: 0x06034FA8 RID: 217000 RVA: 0x00ED175C File Offset: 0x00ECF95C
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

		// Token: 0x06034FA9 RID: 217001 RVA: 0x00ED17BC File Offset: 0x00ECF9BC
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

		// Token: 0x06034FAA RID: 217002 RVA: 0x00ED17FC File Offset: 0x00ECF9FC
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

		// Token: 0x06034FAB RID: 217003 RVA: 0x00ED1840 File Offset: 0x00ECFA40
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

		// Token: 0x06034FAC RID: 217004 RVA: 0x00ED1898 File Offset: 0x00ECFA98
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

		// Token: 0x06034FAD RID: 217005 RVA: 0x00ED18E4 File Offset: 0x00ECFAE4
		public RiskHarvestArtifact GetArtifactConfig(int artifactId)
		{
			return ConfigRiskHarvestArtifactById.GetConfig(artifactId, true).Value;
		}

		// Token: 0x06034FAE RID: 217006 RVA: 0x00ED1900 File Offset: 0x00ECFB00
		public int GetBuffThresholdByArtifactIdAndIndex(int artifactId, int index)
		{
			return this.GetArtifactConfig(artifactId).BasicBuffGroup()[index];
		}

		// Token: 0x06034FAF RID: 217007 RVA: 0x00ED1920 File Offset: 0x00ECFB20
		public int GetBuffIdByArtifactIdAndIndex(int artifactId, int index)
		{
			return this.GetArtifactConfig(artifactId).BuffGroup()[index];
		}

		// Token: 0x06034FB0 RID: 217008 RVA: 0x00ED193E File Offset: 0x00ECFB3E
		public RiskHarvestBuffGroup? GetBuffConfigById(int id)
		{
			return ConfigRiskHarvestBuffGroupById.GetConfig(id, true);
		}

		// Token: 0x06034FB1 RID: 217009 RVA: 0x00ED1948 File Offset: 0x00ECFB48
		public EMowingBuffType? GetBuffTypeById(int id)
		{
			RiskHarvestBuffGroup? config = ConfigRiskHarvestBuffGroupById.GetConfig(id, true);
			if (config == null)
			{
				return null;
			}
			return new EMowingBuffType?((EMowingBuffType)config.Value.BuffType);
		}

		// Token: 0x06034FB2 RID: 217010 RVA: 0x00ED1984 File Offset: 0x00ECFB84
		public int? GetIdByInstanceId(int instanceId)
		{
			RiskHarvestInst? config = ConfigRiskHarvestInstByInstanceID.GetConfig(instanceId, true);
			if (config == null)
			{
				return null;
			}
			return new int?(config.GetValueOrDefault().Id);
		}

		// Token: 0x06034FB3 RID: 217011 RVA: 0x00ED19C0 File Offset: 0x00ECFBC0
		public int GetInstanceRewardScoreById(int id)
		{
			if (ConfigRiskHarvestInstById.GetConfig(id, true) == null)
			{
				return 0;
			}
			RiskHarvestInst? riskHarvestInst;
			return riskHarvestInst.GetValueOrDefault().RewardScore;
		}

		// Token: 0x06034FB4 RID: 217012 RVA: 0x00ED19F0 File Offset: 0x00ECFBF0
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

		// Token: 0x06034FB5 RID: 217013 RVA: 0x00ED1A34 File Offset: 0x00ECFC34
		public bool IsSuperBuffByBuffId(int id)
		{
			return this.GetBuffTypeById(id).GetValueOrDefault() == EMowingBuffType.Super;
		}

		// Token: 0x06034FB6 RID: 217014 RVA: 0x00ED1A54 File Offset: 0x00ECFC54
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

		// Token: 0x170066D0 RID: 26320
		// (get) Token: 0x06034FB7 RID: 217015 RVA: 0x00ED1AA4 File Offset: 0x00ECFCA4
		// (set) Token: 0x06034FB8 RID: 217016 RVA: 0x00ED1B1C File Offset: 0x00ECFD1C
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

		// Token: 0x06034FB9 RID: 217017 RVA: 0x00ED1B27 File Offset: 0x00ECFD27
		public IReadOnlyList<RiskHarvestInst> GetRiskHarvestInstByActivityId(int activityId)
		{
			return ConfigRiskHarvestInstByActivityId.GetConfigList(activityId, true) ?? Array.Empty<RiskHarvestInst>();
		}

		// Token: 0x06034FBA RID: 217018 RVA: 0x00ED1B39 File Offset: 0x00ECFD39
		public IReadOnlyList<RiskHarvestScoreReward> GetRiskHarvestScoreRewardByActivityId(int activityId)
		{
			return ConfigRiskHarvestScoreRewardByActivityId.GetConfigList(activityId, true) ?? Array.Empty<RiskHarvestScoreReward>();
		}

		// Token: 0x06034FBB RID: 217019 RVA: 0x00ED1B4B File Offset: 0x00ECFD4B
		public IReadOnlyList<RiskHarvestBuffGroup> GetBuffConfigListByActivityId(int activityId)
		{
			return ConfigRiskHarvestBuffGroupByActivityId.GetConfigList(activityId, true) ?? Array.Empty<RiskHarvestBuffGroup>();
		}

		// Token: 0x0401BFF6 RID: 114678
		private Dictionary<EMowingBuffType, IMowingRiskConfigQualityData> type2QualityData;
	}
}
