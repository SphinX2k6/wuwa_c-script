using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.Fight.Struct;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

// Token: 0x02003301 RID: 13057
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class WorldConfig : ConfigBase
{
	// Token: 0x0601C729 RID: 116521 RVA: 0x007FBBD1 File Offset: 0x007F9DD1
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0601C72A RID: 116522 RVA: 0x007FBBD4 File Offset: 0x007F9DD4
	public Aki.Config.LockOnConfig? GetLockOnConfig(int id)
	{
		return ConfigLockOnConfigById.GetConfig(id, true);
	}

	// Token: 0x0601C72B RID: 116523 RVA: 0x007FBBE0 File Offset: 0x007F9DE0
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

	// Token: 0x0601C72C RID: 116524 RVA: 0x007FBC34 File Offset: 0x007F9E34
	public List<string> GetRoleCommonSkillRowNames()
	{
		if (this.RoleCommonDataTableRowNames == null)
		{
			this.GetRoleCommonSkillInfo();
		}
		return this.RoleCommonDataTableRowNames;
	}

	// Token: 0x0601C72D RID: 116525 RVA: 0x007FBC4C File Offset: 0x007F9E4C
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

	// Token: 0x0601C72E RID: 116526 RVA: 0x007FBCA0 File Offset: 0x007F9EA0
	public List<string> GetMonsterCommonSkillRowNames()
	{
		if (this.MonsterCommonDataTableRowNames == null)
		{
			this.GetMonsterCommonSkillInfo();
		}
		return this.MonsterCommonDataTableRowNames;
	}

	// Token: 0x0601C72F RID: 116527 RVA: 0x007FBCB8 File Offset: 0x007F9EB8
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

	// Token: 0x0601C730 RID: 116528 RVA: 0x007FBD0C File Offset: 0x007F9F0C
	public List<string> GetVisionCommonSkillRowNames()
	{
		if (this.VisionCommonDataTableRowNames == null)
		{
			this.GetVisionCommonSkillInfo();
		}
		return this.VisionCommonDataTableRowNames;
	}

	// Token: 0x0601C731 RID: 116529 RVA: 0x007FBD23 File Offset: 0x007F9F23
	[NullableContext(2)]
	public UDataTable GetCaughtDataInfo()
	{
		if (this.CaughtDataTable == null)
		{
			this.CaughtDataTable = ResourceSystem.Instance.GetLoadedAsset<UDataTable>("/Game/Aki/Data/Fight/DT_CaughtInfo.DT_CaughtInfo");
		}
		return this.CaughtDataTable;
	}

	// Token: 0x0601C732 RID: 116530 RVA: 0x007FBD48 File Offset: 0x007F9F48
	[NullableContext(2)]
	public UDataTable GetCommonBulletData()
	{
		if (this.BulletCommonDataTable == null)
		{
			this.BulletCommonDataTable = ResourceSystem.Instance.GetLoadedAsset<UDataTable>("/Game/Aki/Data/Fight/CDT_CommonBulletData.CDT_CommonBulletData");
		}
		return this.BulletCommonDataTable;
	}

	// Token: 0x0601C733 RID: 116531 RVA: 0x007FBD6D File Offset: 0x007F9F6D
	[NullableContext(2)]
	public UDataTable GetCommonHitEffectData()
	{
		if (this.HitEffectCommonDataTable == null)
		{
			this.HitEffectCommonDataTable = ResourceSystem.Instance.GetLoadedAsset<UDataTable>("/Game/Aki/Data/Fight/DT_CommonHitEffect.DT_CommonHitEffect");
		}
		return this.HitEffectCommonDataTable;
	}

	// Token: 0x0601C734 RID: 116532 RVA: 0x007FBD92 File Offset: 0x007F9F92
	[return: Nullable(2)]
	public SCharacterFightInfo GetCharacterFightInfo(string characterResourcePath)
	{
		if (this.CharacterFightInfoDataTable == null)
		{
			this.CharacterFightInfoDataTable = ResourceSystem.Instance.GetLoadedAsset<UDataTable>("/Game/Aki/Data/Fight/CDT_CharacterFightInfo.CDT_CharacterFightInfo");
		}
		return DataTableUtil.GetDataTableRow<SCharacterFightInfo>(this.CharacterFightInfoDataTable, characterResourcePath);
	}

	// Token: 0x0601C735 RID: 116533 RVA: 0x007FBDBD File Offset: 0x007F9FBD
	public void ClearCommonSkillData()
	{
		this.RoleCommonDataTable = null;
		this.BulletCommonDataTable = null;
		this.MonsterCommonDataTable = null;
		this.VisionCommonDataTable = null;
		this.CaughtDataTable = null;
		this.CharacterFightInfoDataTable = null;
	}

	// Token: 0x0601C736 RID: 116534 RVA: 0x007FBDE9 File Offset: 0x007F9FE9
	public RoleInfo? GetRoleConfig(int roleId)
	{
		return RoleConfig.Instance.GetRoleConfig(roleId);
	}

	// Token: 0x0601C737 RID: 116535 RVA: 0x007FBDF6 File Offset: 0x007F9FF6
	protected override bool OnClear()
	{
		this.ClearCommonSkillData();
		return true;
	}

	// Token: 0x0601C738 RID: 116536 RVA: 0x007FBE00 File Offset: 0x007FA000
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

	// Token: 0x0601C739 RID: 116537 RVA: 0x007FBF54 File Offset: 0x007FA154
	public Dictionary<int, string> GetQteTagDataMap()
	{
		if (this.QteTagDataMap == null)
		{
			this.GetQteTagDataTable();
		}
		return this.QteTagDataMap;
	}

	// Token: 0x17002762 RID: 10082
	// (get) Token: 0x0601C73A RID: 116538 RVA: 0x007FBF6B File Offset: 0x007FA16B
	public static WorldConfig Instance
	{
		get
		{
			return WorldConfig._Instance;
		}
	}

	// Token: 0x0601C73B RID: 116539 RVA: 0x007FBF72 File Offset: 0x007FA172
	public static WorldConfig GetOrCreateInstance()
	{
		if (WorldConfig._Instance == null)
		{
			WorldConfig.CreateInstance();
		}
		return WorldConfig._Instance;
	}

	// Token: 0x0601C73C RID: 116540 RVA: 0x007FBF86 File Offset: 0x007FA186
	public static bool CreateInstance()
	{
		if (WorldConfig._Instance != null)
		{
			return true;
		}
		WorldConfig._Instance = new WorldConfig();
		return true;
	}

	// Token: 0x0601C73D RID: 116541 RVA: 0x007FBF9C File Offset: 0x007FA19C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601C73E RID: 116542 RVA: 0x007FBF9E File Offset: 0x007FA19E
	public static void ResetStaticDefaultValue()
	{
		WorldConfig._Instance = null;
	}

	// Token: 0x0601C73F RID: 116543 RVA: 0x007FBFA6 File Offset: 0x007FA1A6
	static WorldConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WorldConfig.CreateStaticDefaultValue), new Action(WorldConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400E1DA RID: 57818
	private const string ROLE_COMMON_SKILLINFO_PATH = "/Game/Aki/Data/Fight/DT_Common_Role_SkillInfo.DT_Common_Role_SkillInfo";

	// Token: 0x0400E1DB RID: 57819
	private const string MONSTER_COMMON_SKILLINFO_PATH = "/Game/Aki/Data/Fight/DT_Common_Monster_SkillInfo.DT_Common_Monster_SkillInfo";

	// Token: 0x0400E1DC RID: 57820
	private const string VISION_COMMON_SKILLINFO_PATH = "/Game/Aki/Data/Fight/DT_Common_Vision_SkillInfo.DT_Common_Vision_SkillInfo";

	// Token: 0x0400E1DD RID: 57821
	private const string COMMON_BULLET_PATH = "/Game/Aki/Data/Fight/CDT_CommonBulletData.CDT_CommonBulletData";

	// Token: 0x0400E1DE RID: 57822
	private const string COMMON_HIT_EFFECT_PATH = "/Game/Aki/Data/Fight/DT_CommonHitEffect.DT_CommonHitEffect";

	// Token: 0x0400E1DF RID: 57823
	private const string CAUGHT_DATA_PATH = "/Game/Aki/Data/Fight/DT_CaughtInfo.DT_CaughtInfo";

	// Token: 0x0400E1E0 RID: 57824
	private const string CHARACTERFIGHTINFO_DATA_PATH = "/Game/Aki/Data/Fight/CDT_CharacterFightInfo.CDT_CharacterFightInfo";

	// Token: 0x0400E1E1 RID: 57825
	private const string QTE_TAG_DATA_PATH = "/Game/Aki/Data/Fight/DT_QteTag.DT_QteTag";

	// Token: 0x0400E1E2 RID: 57826
	[Nullable(2)]
	private UDataTable RoleCommonDataTable;

	// Token: 0x0400E1E3 RID: 57827
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<string> RoleCommonDataTableRowNames;

	// Token: 0x0400E1E4 RID: 57828
	[Nullable(2)]
	private UDataTable MonsterCommonDataTable;

	// Token: 0x0400E1E5 RID: 57829
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<string> MonsterCommonDataTableRowNames;

	// Token: 0x0400E1E6 RID: 57830
	[Nullable(2)]
	private UDataTable VisionCommonDataTable;

	// Token: 0x0400E1E7 RID: 57831
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<string> VisionCommonDataTableRowNames;

	// Token: 0x0400E1E8 RID: 57832
	[Nullable(2)]
	private UDataTable BulletCommonDataTable;

	// Token: 0x0400E1E9 RID: 57833
	[Nullable(2)]
	private UDataTable HitEffectCommonDataTable;

	// Token: 0x0400E1EA RID: 57834
	[Nullable(2)]
	private UDataTable CaughtDataTable;

	// Token: 0x0400E1EB RID: 57835
	[Nullable(2)]
	private UDataTable CharacterFightInfoDataTable;

	// Token: 0x0400E1EC RID: 57836
	[Nullable(2)]
	private UDataTable QteTagDataTable;

	// Token: 0x0400E1ED RID: 57837
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, string> QteTagDataMap;

	// Token: 0x0400E1EE RID: 57838
	[Nullable(2)]
	private static WorldConfig _Instance;
}
