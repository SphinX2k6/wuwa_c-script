using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A2D RID: 18989
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseMonsterData
	{
		// Token: 0x060314DA RID: 201946 RVA: 0x00B6F9DB File Offset: 0x00B6DBDB
		public static TrapDefenseMonsterData Create(TrapDefenseMonster config)
		{
			TrapDefenseMonsterData trapDefenseMonsterData = new TrapDefenseMonsterData(config.Id);
			trapDefenseMonsterData.Config = config;
			trapDefenseMonsterData.Init();
			return trapDefenseMonsterData;
		}

		// Token: 0x060314DB RID: 201947 RVA: 0x00B6F9F6 File Offset: 0x00B6DBF6
		private TrapDefenseMonsterData(int id)
		{
			this.Id = id;
		}

		// Token: 0x060314DC RID: 201948 RVA: 0x00B6FA1C File Offset: 0x00B6DC1C
		private void Init()
		{
			this.ConfigType = TrapDefenseConfig.Instance.GetMonsterTypeConfigById(this.Config.MonsterType).Value;
			this.IconPath = this.ConfigType.Icon;
			this.NameKey = this.Config.Name;
			this.SortId = this.Config.Sort;
		}

		// Token: 0x060314DD RID: 201949 RVA: 0x00B6FA80 File Offset: 0x00B6DC80
		public string GetShowActorLabelStr()
		{
			int id = this.Id;
			int simpleCombatSubtypeId = this.Config.SimpleCombatSubtypeId;
			int templateId = this.ConfigType.TemplateId;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 4);
			defaultInterpolatedStringHandler.AppendLiteral("Monster_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(id);
			defaultInterpolatedStringHandler.AppendLiteral("_tId-");
			defaultInterpolatedStringHandler.AppendFormatted<int>(templateId);
			defaultInterpolatedStringHandler.AppendLiteral("_subId-");
			defaultInterpolatedStringHandler.AppendFormatted<int>(simpleCombatSubtypeId);
			defaultInterpolatedStringHandler.AppendLiteral("_inInst-");
			defaultInterpolatedStringHandler.AppendFormatted<bool>(this.InTheInstance);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060314DE RID: 201950 RVA: 0x00B6FB14 File Offset: 0x00B6DD14
		public string GetQualityPathDesc()
		{
			TrapDefenseMonsterTypeData riskData = this.GetRiskData();
			string result;
			if ((result = ((riskData != null) ? riskData.Config.DescQualityPath : null)) == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
				defaultInterpolatedStringHandler.AppendLiteral("RiskType-QualityDesc-");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.ConfigType.RiskType);
				result = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			return result;
		}

		// Token: 0x060314DF RID: 201951 RVA: 0x00B6FB6C File Offset: 0x00B6DD6C
		public string GetQualityPathGrid()
		{
			TrapDefenseMonsterTypeData riskData = this.GetRiskData();
			string result;
			if ((result = ((riskData != null) ? riskData.Config.GridQualityPath : null)) == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
				defaultInterpolatedStringHandler.AppendLiteral("RiskType-QualityGrid-");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.ConfigType.RiskType);
				result = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			return result;
		}

		// Token: 0x060314E0 RID: 201952 RVA: 0x00B6FBC4 File Offset: 0x00B6DDC4
		[NullableContext(2)]
		public TrapDefenseMonsterTypeData GetRiskData()
		{
			int riskType = this.ConfigType.RiskType;
			return TrapDefenseModel.Instance.ViewModelMonster.MonsterTypeDataMap.GetValueOrDefault(riskType);
		}

		// Token: 0x060314E1 RID: 201953 RVA: 0x00B6FBF2 File Offset: 0x00B6DDF2
		public bool IsBoss()
		{
			return this.ConfigType.RiskType == 3;
		}

		// Token: 0x060314E2 RID: 201954 RVA: 0x00B6FC04 File Offset: 0x00B6DE04
		public string GetRiskTypeNameKey()
		{
			TrapDefenseMonsterTypeData riskData = this.GetRiskData();
			string result;
			if ((result = ((riskData != null) ? riskData.Config.Name : null)) == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
				defaultInterpolatedStringHandler.AppendLiteral("RiskType-Name-");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.ConfigType.RiskType);
				result = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			return result;
		}

		// Token: 0x060314E3 RID: 201955 RVA: 0x00B6FC5C File Offset: 0x00B6DE5C
		public string GetBodyTypeNameKey()
		{
			Dictionary<int, TrapDefenseMonsterBody> monsterBodyMap = TrapDefenseModel.Instance.ViewModelMonster.GetMonsterBodyMap();
			int bodyType = this.ConfigType.BodyType;
			TrapDefenseMonsterBody trapDefenseMonsterBody;
			if (!monsterBodyMap.TryGetValue(bodyType, out trapDefenseMonsterBody))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
				defaultInterpolatedStringHandler.AppendLiteral("BodyType-Name-");
				defaultInterpolatedStringHandler.AppendFormatted<int>(bodyType);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			return trapDefenseMonsterBody.Name;
		}

		// Token: 0x060314E4 RID: 201956 RVA: 0x00B6FCBC File Offset: 0x00B6DEBC
		public List<ITrapDefenseAttrItemData> GetAttrDataShowList()
		{
			int simpleCombatSubtypeId = this.Config.SimpleCombatSubtypeId;
			int templateId = this.ConfigType.TemplateId;
			KSCBaseProperty? buffData = TrapDefenseModel.Instance.ViewModelBuildingDevelop.GetBuffData(templateId, simpleCombatSubtypeId);
			if (buffData == null)
			{
				return new List<ITrapDefenseAttrItemData>();
			}
			List<ITrapDefenseAttrItemData> list = new List<ITrapDefenseAttrItemData>();
			foreach (int id in this.Config.AttrShowIter())
			{
				TrapDefenseAttributeShow? attrShow = TrapDefenseConfig.Instance.GetAttrShow(id);
				if (!StringUtils.IsEmpty(attrShow.Value.ToMonster))
				{
					PropertyInfo property = this.Config.GetType().GetProperty(attrShow.Value.ToMonster, BindingFlags.Instance | BindingFlags.Public);
					string text;
					if (!(property != null))
					{
						text = "UnFind-" + attrShow.Value.ToMonster;
					}
					else
					{
						object value = property.GetValue(this.Config);
						text = (((value != null) ? value.ToString() : null) ?? ("UnFind-" + attrShow.Value.ToMonster));
					}
					string value2 = text;
					list.Add(new TrapDefenseAttrItemData
					{
						NameKey = attrShow.Value.Name,
						IconPath = attrShow.Value.Icon,
						Value = value2
					});
					return list;
				}
				PropertyInfo property2 = buffData.GetType().GetProperty(attrShow.Value.Key, BindingFlags.Instance | BindingFlags.Public);
				string text2;
				if (!(property2 != null))
				{
					text2 = "UnFind-" + attrShow.Value.Key;
				}
				else
				{
					object value3 = property2.GetValue(buffData);
					text2 = (((value3 != null) ? value3.ToString() : null) ?? ("UnFind-" + attrShow.Value.Key));
				}
				string value4 = text2;
				list.Add(new TrapDefenseAttrItemData
				{
					NameKey = attrShow.Value.Name,
					IconPath = attrShow.Value.Icon,
					Value = value4
				});
			}
			return list;
		}

		// Token: 0x060314E5 RID: 201957 RVA: 0x00B6FF20 File Offset: 0x00B6E120
		public List<ITrapDefenseAttrItemData> GetTagDataShowList()
		{
			Dictionary<int, TrapDefenseMonsterTag> monsterTagMap = TrapDefenseModel.Instance.ViewModelMonster.GetMonsterTagMap();
			List<ITrapDefenseAttrItemData> list = new List<ITrapDefenseAttrItemData>();
			for (int i = 0; i < this.Config.TagLength; i++)
			{
				TrapDefenseMonsterTag trapDefenseMonsterTag = monsterTagMap[this.Config.Tag(i)];
				TrapDefenseAttrItemData item = new TrapDefenseAttrItemData
				{
					IconPath = trapDefenseMonsterTag.Icon,
					NameKey = trapDefenseMonsterTag.Name,
					Value = this.Config.TagDesc(i)
				};
				list.Add(item);
			}
			return list;
		}

		// Token: 0x060314E6 RID: 201958 RVA: 0x00B6FFA8 File Offset: 0x00B6E1A8
		public List<string> GetGridTagPathList()
		{
			List<ITrapDefenseAttrItemData> tagDataShowList = this.GetTagDataShowList();
			if (tagDataShowList.Count > 0)
			{
				List<string> list = new List<string>();
				foreach (ITrapDefenseAttrItemData trapDefenseAttrItemData in tagDataShowList)
				{
					list.Add(trapDefenseAttrItemData.IconPath);
				}
				return list;
			}
			UiResourceConfig instance = UiResourceConfig.Instance;
			string item = ((instance != null) ? instance.GetResourcePath(ETrapDefenseResKey.MonsterTagUnStateIcon.ToString()) : null) ?? ETrapDefenseResKey.MonsterTagUnStateIcon.ToString();
			return new List<string>
			{
				item
			};
		}

		// Token: 0x060314E7 RID: 201959 RVA: 0x00B70058 File Offset: 0x00B6E258
		public void SetIsInTheInstance(bool isIn)
		{
			this.InTheInstance = isIn;
		}

		// Token: 0x0401A5A3 RID: 107939
		public int Id;

		// Token: 0x0401A5A4 RID: 107940
		public string IconPath = "";

		// Token: 0x0401A5A5 RID: 107941
		public int QualityId;

		// Token: 0x0401A5A6 RID: 107942
		public string NameKey = "";

		// Token: 0x0401A5A7 RID: 107943
		public TrapDefenseMonster Config;

		// Token: 0x0401A5A8 RID: 107944
		public TrapDefenseMonsterType ConfigType;

		// Token: 0x0401A5A9 RID: 107945
		public bool InTheInstance;

		// Token: 0x0401A5AA RID: 107946
		public int SortId;
	}
}
