using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000ECE RID: 3790
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueSubModel : KscSubModelBase
{
	// Token: 0x06005E3F RID: 24127 RVA: 0x00116930 File Offset: 0x00114B30
	public override string GetSkillDtPath()
	{
		return SurvivorsRogueSubModel.SkillDtPath;
	}

	// Token: 0x06005E40 RID: 24128 RVA: 0x00116937 File Offset: 0x00114B37
	public override string GetEntityDtPath()
	{
		return SurvivorsRogueSubModel.EntityDtPath;
	}

	// Token: 0x06005E41 RID: 24129 RVA: 0x00116940 File Offset: 0x00114B40
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

	// Token: 0x06005E42 RID: 24130 RVA: 0x00116960 File Offset: 0x00114B60
	public void GetAllEntities(List<ISurvivorsRogueCombatInfo> entities)
	{
		entities.Clear();
		foreach (ISurvivorsRogueCombatInfo item in this.AllEntities.Values)
		{
			entities.Add(item);
		}
	}

	// Token: 0x06005E43 RID: 24131 RVA: 0x001169C0 File Offset: 0x00114BC0
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

	// Token: 0x06005E44 RID: 24132 RVA: 0x00116A0C File Offset: 0x00114C0C
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

	// Token: 0x06005E45 RID: 24133 RVA: 0x00116A3B File Offset: 0x00114C3B
	protected override bool OnClear()
	{
		this.AllEntities.Clear();
		this.WeaponKscEntities.Clear();
		this.GoldNum = 0;
		this.KillComboStage = 0;
		return true;
	}

	// Token: 0x04002AD9 RID: 10969
	public static readonly string SkillDtPath = "/Game/Aki/Data/SimpleCombat/2_7XingCunZhe/Player/DT_KscSkill.DT_KscSkill";

	// Token: 0x04002ADA RID: 10970
	public static readonly string EntityDtPath = "/Game/Aki/Data/SimpleCombat/2_7XingCunZhe/Player/DT_KscEntity.DT_KscEntity";

	// Token: 0x04002ADB RID: 10971
	public static readonly string BulletDtPath = "/Game/Aki/Data/SimpleCombat/2_7XingCunZhe/CDT_KuroBulletData_XCZ_New.CDT_KuroBulletData_XCZ_New";

	// Token: 0x04002ADC RID: 10972
	[Nullable(2)]
	public UDataTable BulletDataTable;

	// Token: 0x04002ADD RID: 10973
	private readonly Dictionary<long, ISurvivorsRogueCombatInfo> AllEntities = new Dictionary<long, ISurvivorsRogueCombatInfo>();

	// Token: 0x04002ADE RID: 10974
	public List<AKSC_Entity> WeaponKscEntities = new List<AKSC_Entity>();

	// Token: 0x04002ADF RID: 10975
	public int GoldNum;

	// Token: 0x04002AE0 RID: 10976
	public int KillComboStage;
}
