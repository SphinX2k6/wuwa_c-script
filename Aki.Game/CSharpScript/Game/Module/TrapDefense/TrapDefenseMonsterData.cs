using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039D5 RID: 14805
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseMonsterData
	{
		// Token: 0x0602626A RID: 156266 RVA: 0x00AB3962 File Offset: 0x00AB1B62
		public static TrapDefenseMonsterData Create(TrapDefenseMonster config)
		{
			TrapDefenseMonsterData trapDefenseMonsterData = new TrapDefenseMonsterData(config.Id);
			trapDefenseMonsterData.Config = config;
			trapDefenseMonsterData.Init();
			return trapDefenseMonsterData;
		}

		// Token: 0x0602626B RID: 156267 RVA: 0x00AB397D File Offset: 0x00AB1B7D
		private TrapDefenseMonsterData(int id)
		{
			this.Id = id;
		}

		// Token: 0x0602626C RID: 156268 RVA: 0x00AB39A4 File Offset: 0x00AB1BA4
		private void Init()
		{
			this.ConfigType = TrapDefenseConfig.Instance.GetMonsterTypeConfigById(this.Config.MonsterType).Value;
			this.IconPath = this.ConfigType.Icon;
			this.NameKey = this.Config.Name;
			this.SortId = this.Config.Sort;
		}

		// Token: 0x0602626D RID: 156269 RVA: 0x00AB3A08 File Offset: 0x00AB1C08
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

		// Token: 0x0602626E RID: 156270 RVA: 0x00AB3A9C File Offset: 0x00AB1C9C
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

		// Token: 0x0602626F RID: 156271 RVA: 0x00AB3AF4 File Offset: 0x00AB1CF4
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

		// Token: 0x06026270 RID: 156272 RVA: 0x00AB3B4C File Offset: 0x00AB1D4C
		[NullableContext(2)]
		public TrapDefenseMonsterTypeData GetRiskData()
		{
			int riskType = this.ConfigType.RiskType;
			return TrapDefenseModel.Instance.ViewModelMonster.MonsterTypeDataMap.GetValueOrDefault(riskType);
		}

		// Token: 0x06026271 RID: 156273 RVA: 0x00AB3B7A File Offset: 0x00AB1D7A
		public bool IsBoss()
		{
			return this.ConfigType.RiskType == 3;
		}

		// Token: 0x06026272 RID: 156274 RVA: 0x00AB3B8C File Offset: 0x00AB1D8C
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

		// Token: 0x06026273 RID: 156275 RVA: 0x00AB3BE4 File Offset: 0x00AB1DE4
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

		// Token: 0x06026274 RID: 156276 RVA: 0x00AB3C44 File Offset: 0x00AB1E44
		public List<ITrapDefenseAttrItemData> GetAttrDataShowList()
		{
			int simpleCombatSubtypeId = this.Config.SimpleCombatSubtypeId;
			int templateId = this.ConfigType.TemplateId;
			KSCBaseProperty? buffData = TrapDefenseModel.Instance.ViewModelBuildingDevelop.GetBuffData(templateId, simpleCombatSubtypeId);
			if (buffData != null)
			{
				KSCBaseProperty valueOrDefault = buffData.GetValueOrDefault();
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
					int num;
					string value3 = valueOrDefault.TryGetMember(attrShow.Value.Key, out num) ? num.ToString() : ("UnFind-" + attrShow.Value.Key);
					list.Add(new TrapDefenseAttrItemData
					{
						NameKey = attrShow.Value.Name,
						IconPath = attrShow.Value.Icon,
						Value = value3
					});
				}
				return list;
			}
			return new List<ITrapDefenseAttrItemData>();
		}

		// Token: 0x06026275 RID: 156277 RVA: 0x00AB3E70 File Offset: 0x00AB2070
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

		// Token: 0x06026276 RID: 156278 RVA: 0x00AB3EF8 File Offset: 0x00AB20F8
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

		// Token: 0x06026277 RID: 156279 RVA: 0x00AB3FA8 File Offset: 0x00AB21A8
		public void SetIsInTheInstance(bool isIn)
		{
			this.InTheInstance = isIn;
		}

		// Token: 0x04014EF8 RID: 85752
		public int Id;

		// Token: 0x04014EF9 RID: 85753
		public string IconPath = "";

		// Token: 0x04014EFA RID: 85754
		public int QualityId;

		// Token: 0x04014EFB RID: 85755
		public string NameKey = "";

		// Token: 0x04014EFC RID: 85756
		public TrapDefenseMonster Config;

		// Token: 0x04014EFD RID: 85757
		public TrapDefenseMonsterType ConfigType;

		// Token: 0x04014EFE RID: 85758
		public bool InTheInstance;

		// Token: 0x04014EFF RID: 85759
		public int SortId;
	}
}
