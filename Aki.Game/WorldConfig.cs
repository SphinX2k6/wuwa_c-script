using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.Fight.Struct;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

// Token: 0x02002873 RID: 10355
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class WorldConfig : ConfigBase
{
	// Token: 0x0601A41A RID: 107546 RVA: 0x00821D19 File Offset: 0x0081FF19
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0601A41B RID: 107547 RVA: 0x00821D1C File Offset: 0x0081FF1C
	public Aki.Config.LockOnConfig? GetLockOnConfig(int id)
	{
		return ConfigLockOnConfigById.GetConfig(id, true);
	}

	// Token: 0x0601A41C RID: 107548 RVA: 0x00821D28 File Offset: 0x0081FF28
	[NullableContext(2)]
	public UDataTable GetRoleCommonSkillInfo()
	{
		if (this.RoleCommonDataTable == null)
		{
			this.RoleCommonDataTable = ResourceSystem.Instance.GetLoadedAsset<UDataTable>("/Game/Aki/Data/Fight/DT_Common_Role_SkillInfo.DT_Common_Role_SkillInfo");
			this.RoleCommonDataTableRowNames = new List<string>();
			if (this.RoleCommonDataTable != null)
			{
				DataTableUtil.GetDataTableAllRowNamesFromTable(this.RoleCommonDataTable, this.RoleCommonDataTableRowNames);
			}
		}
		return this.RoleCommonDataTable;
	}

	// Token: 0x0601A41D RID: 107549 RVA: 0x00821D7C File Offset: 0x0081FF7C
	public List<string> GetRoleCommonSkillRowNames()
	{
		if (this.RoleCommonDataTableRowNames == null)
		{
			this.GetRoleCommonSkillInfo();
		}
		return this.RoleCommonDataTableRowNames;
	}

	// Token: 0x0601A41E RID: 107550 RVA: 0x00821D94 File Offset: 0x0081FF94
	[NullableContext(2)]
	public UDataTable GetMonsterCommonSkillInfo()
	{
		if (this.MonsterCommonDataTable == null)
		{
			this.MonsterCommonDataTable = ResourceSystem.Instance.GetLoadedAsset<UDataTable>("/Game/Aki/Data/Fight/DT_Common_Monster_SkillInfo.DT_Common_Monster_SkillInfo");
			this.MonsterCommonDataTableRowNames = new List<string>();
			if (this.MonsterCommonDataTable != null)
			{
				DataTableUtil.GetDataTableAllRowNamesFromTable(this.MonsterCommonDataTable, this.MonsterCommonDataTableRowNames);
			}
		}
		return this.MonsterCommonDataTable;
	}

	// Token: 0x0601A41F RID: 107551 RVA: 0x00821DE8 File Offset: 0x0081FFE8
	public List<string> GetMonsterCommonSkillRowNames()
	{
		if (this.MonsterCommonDataTableRowNames == null)
		{
			this.GetMonsterCommonSkillInfo();
		}
		return this.MonsterCommonDataTableRowNames;
	}

	// Token: 0x0601A420 RID: 107552 RVA: 0x00821E00 File Offset: 0x00820000
	[NullableContext(2)]
	public UDataTable GetVisionCommonSkillInfo()
	{
		if (this.VisionCommonDataTable == null)
		{
			this.VisionCommonDataTable = ResourceSystem.Instance.GetLoadedAsset<UDataTable>("/Game/Aki/Data/Fight/DT_Common_Vision_SkillInfo.DT_Common_Vision_SkillInfo");
			this.VisionCommonDataTableRowNames = new List<string>();
			if (this.VisionCommonDataTable != null)
			{
				DataTableUtil.GetDataTableAllRowNamesFromTable(this.VisionCommonDataTable, this.VisionCommonDataTableRowNames);
			}
		}
		return this.VisionCommonDataTable;
	}

	// Token: 0x0601A421 RID: 107553 RVA: 0x00821E54 File Offset: 0x00820054
	public List<string> GetVisionCommonSkillRowNames()
	{
		if (this.VisionCommonDataTableRowNames == null)
		{
			this.GetVisionCommonSkillInfo();
		}
		return this.VisionCommonDataTableRowNames;
	}

	// Token: 0x0601A422 RID: 107554 RVA: 0x00821E6B File Offset: 0x0082006B
	[NullableContext(2)]
	public UDataTable GetCaughtDataInfo()
	{
		if (this.CaughtDataTable == null)
		{
			this.CaughtDataTable = ResourceSystem.Instance.GetLoadedAsset<UDataTable>("/Game/Aki/Data/Fight/DT_CaughtInfo.DT_CaughtInfo");
		}
		return this.CaughtDataTable;
	}

	// Token: 0x0601A423 RID: 107555 RVA: 0x00821E90 File Offset: 0x00820090
	[NullableContext(2)]
	public UDataTable GetCommonBulletData()
	{
		if (this.BulletCommonDataTable == null)
		{
			this.BulletCommonDataTable = ResourceSystem.Instance.GetLoadedAsset<UDataTable>("/Game/Aki/Data/Fight/CDT_CommonBulletData.CDT_CommonBulletData");
		}
		return this.BulletCommonDataTable;
	}

	// Token: 0x0601A424 RID: 107556 RVA: 0x00821EB5 File Offset: 0x008200B5
	[NullableContext(2)]
	public UDataTable GetCommonHitEffectData()
	{
		if (this.HitEffectCommonDataTable == null)
		{
			this.HitEffectCommonDataTable = ResourceSystem.Instance.GetLoadedAsset<UDataTable>("/Game/Aki/Data/Fight/DT_CommonHitEffect.DT_CommonHitEffect");
		}
		return this.HitEffectCommonDataTable;
	}

	// Token: 0x0601A425 RID: 107557 RVA: 0x00821EDA File Offset: 0x008200DA
	[return: Nullable(2)]
	public SCharacterFightInfo GetCharacterFightInfo(string characterResourcePath)
	{
		if (this.CharacterFightInfoDataTable == null)
		{
			this.CharacterFightInfoDataTable = ResourceSystem.Instance.GetLoadedAsset<UDataTable>("/Game/Aki/Data/Fight/CDT_CharacterFightInfo.CDT_CharacterFightInfo");
		}
		return DataTableUtil.GetDataTableRow<SCharacterFightInfo>(this.CharacterFightInfoDataTable, characterResourcePath);
	}

	// Token: 0x0601A426 RID: 107558 RVA: 0x00821F08 File Offset: 0x00820108
	public void ClearCommonSkillData()
	{
		this.RoleCommonDataTable = null;
		this.RoleCommonDataTableRowNames = null;
		this.BulletCommonDataTable = null;
		this.HitEffectCommonDataTable = null;
		this.MonsterCommonDataTable = null;
		this.MonsterCommonDataTableRowNames = null;
		this.VisionCommonDataTable = null;
		this.VisionCommonDataTableRowNames = null;
		this.CaughtDataTable = null;
		this.CharacterFightInfoDataTable = null;
	}

	// Token: 0x0601A427 RID: 107559 RVA: 0x00821F5B File Offset: 0x0082015B
	public RoleInfo? GetRoleConfig(int roleId)
	{
		return RoleConfig.Instance.GetRoleConfig(roleId);
	}

	// Token: 0x0601A428 RID: 107560 RVA: 0x00821F68 File Offset: 0x00820168
	protected override bool OnClear()
	{
		this.ClearCommonSkillData();
		return true;
	}

	// Token: 0x0601A429 RID: 107561 RVA: 0x00821F74 File Offset: 0x00820174
	[NullableContext(2)]
	public UDataTable GetQteTagDataTable()
	{
		if (this.QteTagDataTable == null)
		{
			this.QteTagDataTable = ResourceSystem.Instance.GetLoadedAsset<UDataTable>("/Game/Aki/Data/Fight/DT_QteTag.DT_QteTag");
			this.QteTagDataMap = new Dictionary<int, string>();
			if (this.QteTagDataTable != null)
			{
				List<DataTableKeyRow<SQteTag>> list = new List<DataTableKeyRow<SQteTag>>();
				DataTableUtil.GetDataTableAllRowWithKeysFromTable<SQteTag>(this.QteTagDataTable, list);
				foreach (DataTableKeyRow<SQteTag> dataTableKeyRow in list)
				{
					if (dataTableKeyRow.Key != null && !(dataTableKeyRow.Value == null))
					{
						string key = dataTableKeyRow.Key;
						SQteTag value = dataTableKeyRow.Value;
						if (value.QteTag.TagName != FName.NAME_None)
						{
							if (this.QteTagDataMap.ContainsKey(value.QteTag.TagId()))
							{
								Log instance = Log.Instance;
								ELogModule module = ELogModule.Config;
								ELogAuthor author = ELogAuthor.HXY;
								string message = "DT_QteTag重复注册QTE标签";
								ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tag", value.QteTag.TagName.ToString());
								instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
							}
							else
							{
								this.QteTagDataMap.Add(value.QteTag.TagId(), key);
							}
						}
					}
				}
			}
		}
		return this.QteTagDataTable;
	}

	// Token: 0x0601A42A RID: 107562 RVA: 0x008220C8 File Offset: 0x008202C8
	public Dictionary<int, string> GetQteTagDataMap()
	{
		if (this.QteTagDataMap == null)
		{
			this.GetQteTagDataTable();
		}
		return this.QteTagDataMap;
	}

	// Token: 0x17002AFF RID: 11007
	// (get) Token: 0x0601A42B RID: 107563 RVA: 0x008220DF File Offset: 0x008202DF
	public static WorldConfig Instance
	{
		get
		{
			return WorldConfig._Instance;
		}
	}

	// Token: 0x0601A42C RID: 107564 RVA: 0x008220E6 File Offset: 0x008202E6
	public static WorldConfig GetOrCreateInstance()
	{
		if (WorldConfig._Instance == null)
		{
			WorldConfig.CreateInstance();
		}
		return WorldConfig._Instance;
	}

	// Token: 0x0601A42D RID: 107565 RVA: 0x008220FA File Offset: 0x008202FA
	public static bool CreateInstance()
	{
		if (WorldConfig._Instance != null)
		{
			return true;
		}
		WorldConfig._Instance = new WorldConfig();
		return true;
	}

	// Token: 0x0601A42E RID: 107566 RVA: 0x00822110 File Offset: 0x00820310
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601A42F RID: 107567 RVA: 0x00822112 File Offset: 0x00820312
	public static void ResetStaticDefaultValue()
	{
		WorldConfig._Instance = null;
	}

	// Token: 0x0601A430 RID: 107568 RVA: 0x0082211A File Offset: 0x0082031A
	static WorldConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WorldConfig.CreateStaticDefaultValue), new Action(WorldConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400E685 RID: 59013
	private const string ROLE_COMMON_SKILLINFO_PATH = "/Game/Aki/Data/Fight/DT_Common_Role_SkillInfo.DT_Common_Role_SkillInfo";

	// Token: 0x0400E686 RID: 59014
	private const string MONSTER_COMMON_SKILLINFO_PATH = "/Game/Aki/Data/Fight/DT_Common_Monster_SkillInfo.DT_Common_Monster_SkillInfo";

	// Token: 0x0400E687 RID: 59015
	private const string VISION_COMMON_SKILLINFO_PATH = "/Game/Aki/Data/Fight/DT_Common_Vision_SkillInfo.DT_Common_Vision_SkillInfo";

	// Token: 0x0400E688 RID: 59016
	private const string COMMON_BULLET_PATH = "/Game/Aki/Data/Fight/CDT_CommonBulletData.CDT_CommonBulletData";

	// Token: 0x0400E689 RID: 59017
	private const string COMMON_HIT_EFFECT_PATH = "/Game/Aki/Data/Fight/DT_CommonHitEffect.DT_CommonHitEffect";

	// Token: 0x0400E68A RID: 59018
	private const string CAUGHT_DATA_PATH = "/Game/Aki/Data/Fight/DT_CaughtInfo.DT_CaughtInfo";

	// Token: 0x0400E68B RID: 59019
	private const string CHARACTERFIGHTINFO_DATA_PATH = "/Game/Aki/Data/Fight/CDT_CharacterFightInfo.CDT_CharacterFightInfo";

	// Token: 0x0400E68C RID: 59020
	private const string QTE_TAG_DATA_PATH = "/Game/Aki/Data/Fight/DT_QteTag.DT_QteTag";

	// Token: 0x0400E68D RID: 59021
	[Nullable(2)]
	private UDataTable RoleCommonDataTable;

	// Token: 0x0400E68E RID: 59022
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<string> RoleCommonDataTableRowNames;

	// Token: 0x0400E68F RID: 59023
	[Nullable(2)]
	private UDataTable MonsterCommonDataTable;

	// Token: 0x0400E690 RID: 59024
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<string> MonsterCommonDataTableRowNames;

	// Token: 0x0400E691 RID: 59025
	[Nullable(2)]
	private UDataTable VisionCommonDataTable;

	// Token: 0x0400E692 RID: 59026
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<string> VisionCommonDataTableRowNames;

	// Token: 0x0400E693 RID: 59027
	[Nullable(2)]
	private UDataTable BulletCommonDataTable;

	// Token: 0x0400E694 RID: 59028
	[Nullable(2)]
	private UDataTable HitEffectCommonDataTable;

	// Token: 0x0400E695 RID: 59029
	[Nullable(2)]
	private UDataTable CaughtDataTable;

	// Token: 0x0400E696 RID: 59030
	[Nullable(2)]
	private UDataTable CharacterFightInfoDataTable;

	// Token: 0x0400E697 RID: 59031
	[Nullable(2)]
	private UDataTable QteTagDataTable;

	// Token: 0x0400E698 RID: 59032
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, string> QteTagDataMap;

	// Token: 0x0400E699 RID: 59033
	[Nullable(2)]
	private static WorldConfig _Instance;
}
