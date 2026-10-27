using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.TrapDefense;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x0200579B RID: 22427
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoEnemyData
	{
		// Token: 0x17008888 RID: 34952
		// (get) Token: 0x06038F9C RID: 233372 RVA: 0x00D8B7A0 File Offset: 0x00D899A0
		// (set) Token: 0x06038F9D RID: 233373 RVA: 0x00D8B7A8 File Offset: 0x00D899A8
		public int MonsterId { get; set; }

		// Token: 0x17008889 RID: 34953
		// (get) Token: 0x06038F9E RID: 233374 RVA: 0x00D8B7B1 File Offset: 0x00D899B1
		// (set) Token: 0x06038F9F RID: 233375 RVA: 0x00D8B7B9 File Offset: 0x00D899B9
		public int CountNum { get; set; } = 1;

		// Token: 0x1700888A RID: 34954
		// (get) Token: 0x06038FA0 RID: 233376 RVA: 0x00D8B7C2 File Offset: 0x00D899C2
		// (set) Token: 0x06038FA1 RID: 233377 RVA: 0x00D8B7CA File Offset: 0x00D899CA
		public string Name { get; set; } = "";

		// Token: 0x1700888B RID: 34955
		// (get) Token: 0x06038FA2 RID: 233378 RVA: 0x00D8B7D3 File Offset: 0x00D899D3
		// (set) Token: 0x06038FA3 RID: 233379 RVA: 0x00D8B7DB File Offset: 0x00D899DB
		public string Desc { get; set; } = "";

		// Token: 0x1700888C RID: 34956
		// (get) Token: 0x06038FA4 RID: 233380 RVA: 0x00D8B7E4 File Offset: 0x00D899E4
		// (set) Token: 0x06038FA5 RID: 233381 RVA: 0x00D8B7EC File Offset: 0x00D899EC
		public string IconPath { get; set; } = "";

		// Token: 0x1700888D RID: 34957
		// (get) Token: 0x06038FA6 RID: 233382 RVA: 0x00D8B7F5 File Offset: 0x00D899F5
		// (set) Token: 0x06038FA7 RID: 233383 RVA: 0x00D8B7FD File Offset: 0x00D899FD
		public int RiskType { get; set; }

		// Token: 0x1700888E RID: 34958
		// (get) Token: 0x06038FA8 RID: 233384 RVA: 0x00D8B806 File Offset: 0x00D89A06
		// (set) Token: 0x06038FA9 RID: 233385 RVA: 0x00D8B80E File Offset: 0x00D89A0E
		public int BodyType { get; set; }

		// Token: 0x1700888F RID: 34959
		// (get) Token: 0x06038FAA RID: 233386 RVA: 0x00D8B817 File Offset: 0x00D89A17
		// (set) Token: 0x06038FAB RID: 233387 RVA: 0x00D8B81F File Offset: 0x00D89A1F
		public KurotatoMonsterRisk? RiskTypeConfig { get; set; }

		// Token: 0x17008890 RID: 34960
		// (get) Token: 0x06038FAC RID: 233388 RVA: 0x00D8B828 File Offset: 0x00D89A28
		// (set) Token: 0x06038FAD RID: 233389 RVA: 0x00D8B830 File Offset: 0x00D89A30
		public KurotatoMonsterBody? BodyTypeConfig { get; set; }

		// Token: 0x17008891 RID: 34961
		// (get) Token: 0x06038FAE RID: 233390 RVA: 0x00D8B839 File Offset: 0x00D89A39
		// (set) Token: 0x06038FAF RID: 233391 RVA: 0x00D8B841 File Offset: 0x00D89A41
		public List<KurotatoEnemyBasePropertyData> BasePropertyDataList { get; set; } = new List<KurotatoEnemyBasePropertyData>();

		// Token: 0x17008892 RID: 34962
		// (get) Token: 0x06038FB0 RID: 233392 RVA: 0x00D8B84A File Offset: 0x00D89A4A
		// (set) Token: 0x06038FB1 RID: 233393 RVA: 0x00D8B852 File Offset: 0x00D89A52
		public List<KurotatoEnemyCharacteristicData> CharacteristicDataList { get; set; } = new List<KurotatoEnemyCharacteristicData>();

		// Token: 0x06038FB2 RID: 233394 RVA: 0x00D8B85C File Offset: 0x00D89A5C
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

		// Token: 0x06038FB3 RID: 233395 RVA: 0x00D8BA6C File Offset: 0x00D89C6C
		public string GetQualityPathGrid()
		{
			return this.RiskTypeConfig.Value.GridQualityPath;
		}

		// Token: 0x06038FB4 RID: 233396 RVA: 0x00D8BA90 File Offset: 0x00D89C90
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

		// Token: 0x06038FB5 RID: 233397 RVA: 0x00D8BB84 File Offset: 0x00D89D84
		public string GetRiskTypeText()
		{
			if (this.RiskTypeConfig == null)
			{
				return "";
			}
			return this.RiskTypeConfig.Value.Name;
		}

		// Token: 0x06038FB6 RID: 233398 RVA: 0x00D8BBC0 File Offset: 0x00D89DC0
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
