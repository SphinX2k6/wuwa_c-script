using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;

namespace CSharpScript.Game.Module.TrainingDegree
{
	// Token: 0x02003AA0 RID: 15008
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class TrainingDegreeModel : ModelBase
	{
		// Token: 0x060268DE RID: 157918 RVA: 0x00ACECD0 File Offset: 0x00ACCED0
		protected override bool OnInit()
		{
			this.NormalProcess = ConfigCommonParamById.GetFloatConfig("RoleTrainingDegreeNormal").GetValueOrDefault();
			this.TrainingSkillTypes = ConfigCommonParamById.GetIntArrayConfig("TrainingDegreeSkillTypes");
			foreach (QualityInfo qualityInfo in ConfigQualityInfoAll.GetConfigList(true))
			{
				this.TrainingWeightMap[qualityInfo.Id] = qualityInfo.TrainingWeight;
			}
			return true;
		}

		// Token: 0x060268DF RID: 157919 RVA: 0x00ACED58 File Offset: 0x00ACCF58
		protected override bool OnClear()
		{
			this.TrainingSkillTypes = null;
			this.TrainingWeightMap.Clear();
			return true;
		}

		// Token: 0x060268E0 RID: 157920 RVA: 0x00ACED70 File Offset: 0x00ACCF70
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public IReadOnlyList<TrainingData> GetTrainingDataList()
		{
			if (GameModeModel.Instance.IsMulti)
			{
				return null;
			}
			int trainingLevel = this.GetTrainingLevel();
			RoleTrainingDegree? roleTrainingDegreeConfig = RoleConfig.Instance.GetRoleTrainingDegreeConfig(trainingLevel);
			if (roleTrainingDegreeConfig == null)
			{
				return null;
			}
			bool flag = true;
			List<RoleDataBase> list = new List<RoleDataBase>();
			foreach (SceneTeamItem sceneTeamItem in SceneTeamModel.Instance.GetTeamItems(false))
			{
				int getConfigId = sceneTeamItem.GetConfigId;
				RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(getConfigId, true);
				if (roleDataById != null)
				{
					list.Add(roleDataById);
					if (!roleDataById.IsTrialRole())
					{
						flag = false;
					}
				}
			}
			if (flag)
			{
				return null;
			}
			List<float> list2 = new List<float>();
			List<float> list3 = new List<float>();
			List<float> list4 = new List<float>();
			List<float> list5 = new List<float>();
			int count = this.TrainingSkillTypes.Count;
			foreach (RoleDataBase roleDataBase in list)
			{
				int num2;
				int num = this.TrainingWeightMap.TryGetValue(roleDataBase.GetRoleConfig().QualityId, out num2) ? num2 : 1;
				list2.Add((float)(roleDataBase.GetLevelData().GetLevel() * num));
				float num3 = 0f;
				RoleSkillData skillData = roleDataBase.GetSkillData();
				foreach (Aki.Config.Skill skill in skillData.GetSkillList())
				{
					bool flag2 = false;
					for (int j = 0; j < this.TrainingSkillTypes.Count; j++)
					{
						if (this.TrainingSkillTypes[j] == skill.SkillType)
						{
							flag2 = true;
							break;
						}
					}
					if (flag2)
					{
						num3 += (float)skillData.GetSkillLevel(skill.Id);
					}
				}
				list3.Add(num3 / (float)count);
				WeaponDataBase weaponDataByRoleDataId = WeaponModel.Instance.GetWeaponDataByRoleDataId(roleDataBase.GetDataId(), true);
				float item = 0f;
				if (weaponDataByRoleDataId != null)
				{
					int num5;
					int num4 = this.TrainingWeightMap.TryGetValue(weaponDataByRoleDataId.GetWeaponConfig().Value.QualityId, out num5) ? num5 : 1;
					item = (float)(weaponDataByRoleDataId.GetLevel() * num4);
				}
				list4.Add(item);
				PhantomRoleEquipmentData battleDataById = PhantomBattleModel.Instance.GetBattleDataById(roleDataBase.GetRoleId());
				list5.Add((float)battleDataById.GetAverageEquipLevel());
			}
			int roleLevel = roleTrainingDegreeConfig.Value.RoleLevel;
			int skillLevel = roleTrainingDegreeConfig.Value.SkillLevel;
			int weaponLevel = roleTrainingDegreeConfig.Value.WeaponLevel;
			int equipLevel = roleTrainingDegreeConfig.Value.EquipLevel;
			List<TrainingData> list6 = new List<TrainingData>();
			foreach (ValueTuple<string, List<float>, int, string, ETrainingType> valueTuple in new ValueTuple<string, List<float>, int, string, ETrainingType>[]
			{
				new ValueTuple<string, List<float>, int, string, ETrainingType>("ReviveTrainingItemRoleLevel", list2, roleLevel, "SP_IconDeathLevel", ETrainingType.RoleLevel),
				new ValueTuple<string, List<float>, int, string, ETrainingType>("ReviveTrainingItemWeaponLevel", list4, weaponLevel, "SP_IconDeathWeapon", ETrainingType.WeaponLevel),
				new ValueTuple<string, List<float>, int, string, ETrainingType>("ReviveTrainingItemEquipLevel", list5, equipLevel, "SP_IconDeathVision", ETrainingType.EquipLevel),
				new ValueTuple<string, List<float>, int, string, ETrainingType>("ReviveTrainingItemSkillLevel", list3, skillLevel, "SP_IconDeathTree", ETrainingType.SkillLevel)
			})
			{
				string item2 = valueTuple.Item1;
				List<float> item3 = valueTuple.Item2;
				int item4 = valueTuple.Item3;
				string item5 = valueTuple.Item4;
				ETrainingType item6 = valueTuple.Item5;
				if (item4 > 0)
				{
					int count2 = item3.Count;
					if (count2 > 3)
					{
						item3.Sort((float a, float b) => b.CompareTo(a));
						item3.RemoveRange(3, count2 - 3);
					}
					float num6 = 0f;
					foreach (float num7 in item3)
					{
						num6 += num7;
					}
					num6 /= 3f;
					TrainingData trainingData = new TrainingData();
					trainingData.Icon = item5;
					trainingData.NameId = TextConfig.Instance.GetTextContentIdById(item2);
					float fillAmount = num6 / (float)item4;
					trainingData.FillAmount = fillAmount;
					trainingData.TrainingType = item6;
					list6.Add(trainingData);
				}
			}
			if (list6.Count <= 0)
			{
				return list6;
			}
			TrainingData trainingData2 = list6[0];
			foreach (TrainingData trainingData3 in list6)
			{
				if (trainingData3.FillAmount < trainingData2.FillAmount)
				{
					trainingData2 = trainingData3;
				}
			}
			if (trainingData2.FillAmount < this.NormalProcess)
			{
				trainingData2.TipsId = TextConfig.Instance.GetTextContentIdById("ReviveTrainingItemBad");
				trainingData2.BgColor = "6a2e2b";
			}
			foreach (TrainingData trainingData4 in list6)
			{
				trainingData4.FillAmount = MathUtils.Instance.Clamp(trainingData4.FillAmount, 0.2f, 1f);
			}
			return list6;
		}

		// Token: 0x060268E1 RID: 157921 RVA: 0x00ACF300 File Offset: 0x00ACD500
		private int GetTrainingLevel()
		{
			int curWorldLevel = WorldLevelModel.Instance.CurWorldLevel;
			WorldLevel? worldLevelConfig = WorldLevelConfig.Instance.GetWorldLevelConfig(curWorldLevel);
			if (worldLevelConfig == null)
			{
				return 1;
			}
			if (!GameModeController.Instance.IsInInstance())
			{
				return worldLevelConfig.Value.TrainingLevel;
			}
			InstanceDungeon? instanceDungeon = GameModeModel.Instance.InstanceDungeon;
			if (instanceDungeon == null)
			{
				return 1;
			}
			int recommendLevel = InstanceDungeonConfig.Instance.GetRecommendLevel(instanceDungeon.Value.Id, curWorldLevel);
			if (recommendLevel > 0)
			{
				return recommendLevel;
			}
			return worldLevelConfig.Value.TrainingLevel;
		}

		// Token: 0x17004EA2 RID: 20130
		// (get) Token: 0x060268E2 RID: 157922 RVA: 0x00ACF394 File Offset: 0x00ACD594
		public static TrainingDegreeModel Instance
		{
			get
			{
				return TrainingDegreeModel._Instance;
			}
		}

		// Token: 0x060268E3 RID: 157923 RVA: 0x00ACF39B File Offset: 0x00ACD59B
		public static TrainingDegreeModel GetOrCreateInstance()
		{
			if (TrainingDegreeModel._Instance == null)
			{
				TrainingDegreeModel.CreateInstance();
			}
			return TrainingDegreeModel._Instance;
		}

		// Token: 0x060268E4 RID: 157924 RVA: 0x00ACF3AF File Offset: 0x00ACD5AF
		public static bool CreateInstance()
		{
			if (TrainingDegreeModel._Instance != null)
			{
				return true;
			}
			TrainingDegreeModel._Instance = new TrainingDegreeModel();
			return true;
		}

		// Token: 0x060268E5 RID: 157925 RVA: 0x00ACF3C5 File Offset: 0x00ACD5C5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060268E6 RID: 157926 RVA: 0x00ACF3C7 File Offset: 0x00ACD5C7
		public static void ResetStaticDefaultValue()
		{
			TrainingDegreeModel._Instance = null;
		}

		// Token: 0x060268E7 RID: 157927 RVA: 0x00ACF3CF File Offset: 0x00ACD5CF
		static TrainingDegreeModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TrainingDegreeModel.CreateStaticDefaultValue), new Action(TrainingDegreeModel.ResetStaticDefaultValue));
		}

		// Token: 0x04015201 RID: 86529
		public const int MAX_ROLE_SIZE = 3;

		// Token: 0x04015202 RID: 86530
		public const float MIN_PROCESS = 0.2f;

		// Token: 0x04015203 RID: 86531
		private float NormalProcess;

		// Token: 0x04015204 RID: 86532
		[Nullable(2)]
		private IReadOnlyList<int> TrainingSkillTypes;

		// Token: 0x04015205 RID: 86533
		private readonly Dictionary<int, int> TrainingWeightMap = new Dictionary<int, int>();

		// Token: 0x04015206 RID: 86534
		[Nullable(2)]
		private static TrainingDegreeModel _Instance;
	}
}
