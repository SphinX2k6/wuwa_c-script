using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.TrapDefense;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x02004772 RID: 18290
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoEnemyData
	{
		// Token: 0x17005C50 RID: 23632
		// (get) Token: 0x0602DEAC RID: 188076 RVA: 0x00CDA51C File Offset: 0x00CD871C
		// (set) Token: 0x0602DEAD RID: 188077 RVA: 0x00CDA524 File Offset: 0x00CD8724
		public int MonsterId { get; set; }

		// Token: 0x17005C51 RID: 23633
		// (get) Token: 0x0602DEAE RID: 188078 RVA: 0x00CDA52D File Offset: 0x00CD872D
		// (set) Token: 0x0602DEAF RID: 188079 RVA: 0x00CDA535 File Offset: 0x00CD8735
		public int CountNum { get; set; } = 1;

		// Token: 0x17005C52 RID: 23634
		// (get) Token: 0x0602DEB0 RID: 188080 RVA: 0x00CDA53E File Offset: 0x00CD873E
		// (set) Token: 0x0602DEB1 RID: 188081 RVA: 0x00CDA546 File Offset: 0x00CD8746
		public string Name { get; set; } = "";

		// Token: 0x17005C53 RID: 23635
		// (get) Token: 0x0602DEB2 RID: 188082 RVA: 0x00CDA54F File Offset: 0x00CD874F
		// (set) Token: 0x0602DEB3 RID: 188083 RVA: 0x00CDA557 File Offset: 0x00CD8757
		public string Desc { get; set; } = "";

		// Token: 0x17005C54 RID: 23636
		// (get) Token: 0x0602DEB4 RID: 188084 RVA: 0x00CDA560 File Offset: 0x00CD8760
		// (set) Token: 0x0602DEB5 RID: 188085 RVA: 0x00CDA568 File Offset: 0x00CD8768
		public string IconPath { get; set; } = "";

		// Token: 0x17005C55 RID: 23637
		// (get) Token: 0x0602DEB6 RID: 188086 RVA: 0x00CDA571 File Offset: 0x00CD8771
		// (set) Token: 0x0602DEB7 RID: 188087 RVA: 0x00CDA579 File Offset: 0x00CD8779
		public int RiskType { get; set; }

		// Token: 0x17005C56 RID: 23638
		// (get) Token: 0x0602DEB8 RID: 188088 RVA: 0x00CDA582 File Offset: 0x00CD8782
		// (set) Token: 0x0602DEB9 RID: 188089 RVA: 0x00CDA58A File Offset: 0x00CD878A
		public int BodyType { get; set; }

		// Token: 0x17005C57 RID: 23639
		// (get) Token: 0x0602DEBA RID: 188090 RVA: 0x00CDA593 File Offset: 0x00CD8793
		// (set) Token: 0x0602DEBB RID: 188091 RVA: 0x00CDA59B File Offset: 0x00CD879B
		public KurotatoMonsterRisk? RiskTypeConfig { get; set; }

		// Token: 0x17005C58 RID: 23640
		// (get) Token: 0x0602DEBC RID: 188092 RVA: 0x00CDA5A4 File Offset: 0x00CD87A4
		// (set) Token: 0x0602DEBD RID: 188093 RVA: 0x00CDA5AC File Offset: 0x00CD87AC
		public KurotatoMonsterBody? BodyTypeConfig { get; set; }

		// Token: 0x17005C59 RID: 23641
		// (get) Token: 0x0602DEBE RID: 188094 RVA: 0x00CDA5B5 File Offset: 0x00CD87B5
		// (set) Token: 0x0602DEBF RID: 188095 RVA: 0x00CDA5BD File Offset: 0x00CD87BD
		public List<KurotatoEnemyBasePropertyData> BasePropertyDataList { get; set; } = new List<KurotatoEnemyBasePropertyData>();

		// Token: 0x17005C5A RID: 23642
		// (get) Token: 0x0602DEC0 RID: 188096 RVA: 0x00CDA5C6 File Offset: 0x00CD87C6
		// (set) Token: 0x0602DEC1 RID: 188097 RVA: 0x00CDA5CE File Offset: 0x00CD87CE
		public List<KurotatoEnemyCharacteristicData> CharacteristicDataList { get; set; } = new List<KurotatoEnemyCharacteristicData>();

		// Token: 0x0602DEC2 RID: 188098 RVA: 0x00CDA5D8 File Offset: 0x00CD87D8
		public KurotatoEnemyData(int monsterId, int countNum = 1)
		{
			this.MonsterId = monsterId;
			this.CountNum = countNum;
			KurotatoMonster? monsterConfigById = KurotatoConfig.Instance.GetMonsterConfigById(monsterId);
			KurotatoMonsterType? monsterTypeById = KurotatoConfig.Instance.GetMonsterTypeById(monsterId);
			if (monsterConfigById == null || monsterTypeById == null)
			{
				return;
			}
			this.Name = monsterConfigById.Value.Name;
			this.Desc = monsterConfigById.Value.Desc;
			this.IconPath = monsterTypeById.Value.Icon;
			this.RiskType = monsterTypeById.Value.RiskType;
			this.BodyType = monsterTypeById.Value.BodyType;
			this.RiskTypeConfig = KurotatoConfig.Instance.GetMonsterRiskConfig(this.RiskType);
			this.BodyTypeConfig = KurotatoConfig.Instance.GetBodyTypeConfig(this.BodyType);
			KSCBaseProperty? baseProperty = KurotatoConfig.Instance.GetBaseProperty(monsterConfigById.Value.BasicProperty);
			if (baseProperty != null)
			{
				int lifeMax = baseProperty.Value.LifeMax;
				int moveSpeed = baseProperty.Value.MoveSpeed;
				int atk = baseProperty.Value.Atk;
				if (lifeMax > 0)
				{
					this.BasePropertyDataList.Add(new KurotatoEnemyBasePropertyData(EKurotatoEnemyAttrType.LifeMax, lifeMax));
				}
				if (moveSpeed > 0)
				{
					this.BasePropertyDataList.Add(new KurotatoEnemyBasePropertyData(EKurotatoEnemyAttrType.MoveSpeed, moveSpeed));
				}
				if (atk > 0)
				{
					this.BasePropertyDataList.Add(new KurotatoEnemyBasePropertyData(EKurotatoEnemyAttrType.Attack, atk));
				}
			}
			int tagLength = monsterConfigById.Value.TagLength;
			for (int i = 0; i < tagLength; i++)
			{
				int id = monsterConfigById.Value.Tag(i);
				this.CharacteristicDataList.Add(new KurotatoEnemyCharacteristicData(id));
			}
		}

		// Token: 0x0602DEC3 RID: 188099 RVA: 0x00CDA7E8 File Offset: 0x00CD89E8
		public string GetQualityPathGrid()
		{
			return this.RiskTypeConfig.Value.GridQualityPath;
		}

		// Token: 0x0602DEC4 RID: 188100 RVA: 0x00CDA80C File Offset: 0x00CD8A0C
		public List<string> GetGridTagPathList()
		{
			KurotatoMonster? monsterConfigById = KurotatoConfig.Instance.GetMonsterConfigById(this.MonsterId);
			if (monsterConfigById == null)
			{
				return new List<string>();
			}
			int tagLength = monsterConfigById.Value.TagLength;
			List<string> list = new List<string>();
			for (int i = 0; i < tagLength; i++)
			{
				int tagId = monsterConfigById.Value.Tag(i);
				KurotatoMonsterTag? monsterTagById = KurotatoConfig.Instance.GetMonsterTagById(tagId);
				string text = ((monsterTagById != null) ? monsterTagById.GetValueOrDefault().Icon : null) ?? "";
				if (text != "")
				{
					list.Add(text);
				}
			}
			if (list.Count == 0)
			{
				UiResourceConfig instance = UiResourceConfig.Instance;
				string item = ((instance != null) ? instance.GetResourcePath(ETrapDefenseResKey.MonsterTagUnStateIcon.ToString()) : null) ?? "";
				return new List<string>
				{
					item
				};
			}
			return list;
		}

		// Token: 0x0602DEC5 RID: 188101 RVA: 0x00CDA900 File Offset: 0x00CD8B00
		public string GetRiskTypeText()
		{
			if (this.RiskTypeConfig == null)
			{
				return "";
			}
			return this.RiskTypeConfig.Value.Name;
		}

		// Token: 0x0602DEC6 RID: 188102 RVA: 0x00CDA93C File Offset: 0x00CD8B3C
		public string GetBodyTypeText()
		{
			if (this.BodyTypeConfig == null)
			{
				return "";
			}
			return this.BodyTypeConfig.Value.Name;
		}
	}
}
