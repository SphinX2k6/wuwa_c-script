using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000383 RID: 899
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueSubModel : KscSubModelBase
{
	// Token: 0x060031D6 RID: 12758 RVA: 0x0011E5E8 File Offset: 0x0011C7E8
	public override string GetSkillDtPath()
	{
		return SurvivorsRogueSubModel.SkillDtPath;
	}

	// Token: 0x060031D7 RID: 12759 RVA: 0x0011E5EF File Offset: 0x0011C7EF
	public override string GetEntityDtPath()
	{
		return SurvivorsRogueSubModel.EntityDtPath;
	}

	// Token: 0x060031D8 RID: 12760 RVA: 0x0011E5F8 File Offset: 0x0011C7F8
	[NullableContext(2)]
	public ISurvivorsRogueCombatInfo GetEntity(long uid)
	{
		ISurvivorsRogueCombatInfo result;
		if (!this.AllEntities.TryGetValue(uid, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x060031D9 RID: 12761 RVA: 0x0011E618 File Offset: 0x0011C818
	public void GetAllEntities(List<ISurvivorsRogueCombatInfo> entities)
	{
		entities.Clear();
		foreach (ISurvivorsRogueCombatInfo item in this.AllEntities.Values)
		{
			entities.Add(item);
		}
	}

	// Token: 0x060031DA RID: 12762 RVA: 0x0011E678 File Offset: 0x0011C878
	[return: Nullable(2)]
	public string TryAddEntity(ISurvivorsRogueCombatInfo entityModel)
	{
		if (entityModel == null || !entityModel.IsValid())
		{
			return "实体数据无效";
		}
		int uid = entityModel.Uid;
		if (this.AllEntities.ContainsKey((long)uid))
		{
			return "实体数据已存在";
		}
		this.AllEntities[(long)uid] = entityModel;
		return null;
	}

	// Token: 0x060031DB RID: 12763 RVA: 0x0011E6C4 File Offset: 0x0011C8C4
	[NullableContext(2)]
	public ISurvivorsRogueCombatInfo RemoveEntity(int uid)
	{
		ISurvivorsRogueCombatInfo result;
		if (this.AllEntities.TryGetValue((long)uid, out result))
		{
			this.AllEntities.Remove((long)uid);
			return result;
		}
		return null;
	}

	// Token: 0x060031DC RID: 12764 RVA: 0x0011E6F3 File Offset: 0x0011C8F3
	protected override bool OnClear()
	{
		this.AllEntities.Clear();
		this.WeaponKscEntities.Clear();
		this.GoldNum = 0;
		this.KillComboStage = 0;
		return true;
	}

	// Token: 0x04002B74 RID: 11124
	public static readonly string SkillDtPath = "/Game/Aki/Data/SimpleCombat/2_7XingCunZhe/Player/DT_KscSkill.DT_KscSkill";

	// Token: 0x04002B75 RID: 11125
	public static readonly string EntityDtPath = "/Game/Aki/Data/SimpleCombat/2_7XingCunZhe/Player/DT_KscEntity.DT_KscEntity";

	// Token: 0x04002B76 RID: 11126
	public static readonly string BulletDtPath = "/Game/Aki/Data/SimpleCombat/2_7XingCunZhe/CDT_KuroBulletData_XCZ_New.CDT_KuroBulletData_XCZ_New";

	// Token: 0x04002B77 RID: 11127
	[Nullable(2)]
	public UDataTable BulletDataTable;

	// Token: 0x04002B78 RID: 11128
	private readonly Dictionary<long, ISurvivorsRogueCombatInfo> AllEntities = new Dictionary<long, ISurvivorsRogueCombatInfo>();

	// Token: 0x04002B79 RID: 11129
	public List<AKSC_Entity> WeaponKscEntities = new List<AKSC_Entity>();

	// Token: 0x04002B7A RID: 11130
	public int GoldNum;

	// Token: 0x04002B7B RID: 11131
	public int KillComboStage;
}
