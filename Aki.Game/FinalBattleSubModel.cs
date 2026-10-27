using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000E75 RID: 3701
[NullableContext(1)]
[Nullable(0)]
public class FinalBattleSubModel : KscSubModelBase
{
	// Token: 0x06005A19 RID: 23065 RVA: 0x00106C62 File Offset: 0x00104E62
	public override string GetSkillDtPath()
	{
		return FinalBattleSubModel.SkillDtPath;
	}

	// Token: 0x06005A1A RID: 23066 RVA: 0x00106C69 File Offset: 0x00104E69
	public override string GetEntityDtPath()
	{
		return FinalBattleSubModel.EntityDtPath;
	}

	// Token: 0x06005A1B RID: 23067 RVA: 0x00106C70 File Offset: 0x00104E70
	public string GetBulletDtPath()
	{
		return FinalBattleSubModel.BulletDtPath;
	}

	// Token: 0x06005A1C RID: 23068 RVA: 0x00106C78 File Offset: 0x00104E78
	[NullableContext(2)]
	public IFinalBattleCombatInfo GetEntity(int uid)
	{
		IFinalBattleCombatInfo result;
		if (!this.AllEntities.TryGetValue(uid, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06005A1D RID: 23069 RVA: 0x00106C98 File Offset: 0x00104E98
	public void GetAllEntities(List<IFinalBattleCombatInfo> entities)
	{
		entities.Clear();
		foreach (IFinalBattleCombatInfo item in this.AllEntities.Values)
		{
			entities.Add(item);
		}
	}

	// Token: 0x06005A1E RID: 23070 RVA: 0x00106CF8 File Offset: 0x00104EF8
	[return: Nullable(2)]
	public string TryAddEntity(IFinalBattleCombatInfo entityModel)
	{
		if (entityModel == null || !entityModel.IsValid())
		{
			return "实体数据无效";
		}
		int uid = entityModel.Uid;
		if (this.AllEntities.ContainsKey(uid))
		{
			return "实体数据已存在";
		}
		this.AllEntities[uid] = entityModel;
		return null;
	}

	// Token: 0x06005A1F RID: 23071 RVA: 0x00106D40 File Offset: 0x00104F40
	[NullableContext(2)]
	public IFinalBattleCombatInfo RemoveEntity(int uid)
	{
		IFinalBattleCombatInfo result;
		if (this.AllEntities.TryGetValue(uid, out result))
		{
			this.AllEntities.Remove(uid);
			return result;
		}
		return null;
	}

	// Token: 0x06005A20 RID: 23072 RVA: 0x00106D6D File Offset: 0x00104F6D
	protected override bool OnClear()
	{
		this.AllEntities.Clear();
		this.BulletDataTable = null;
		return true;
	}

	// Token: 0x06005A21 RID: 23073 RVA: 0x00106D82 File Offset: 0x00104F82
	public override bool IsCreatureIdValid(int creatureId)
	{
		return this.AllEntities.ContainsKey(creatureId);
	}

	// Token: 0x04002928 RID: 10536
	public static readonly string SkillDtPath = "";

	// Token: 0x04002929 RID: 10537
	public static readonly string EntityDtPath = "";

	// Token: 0x0400292A RID: 10538
	public static readonly string BulletDtPath = "/Game/Aki/Data/SimpleCombat/3_5FinalBattle/DT_KuroBulletData_FinalBattle.DT_KuroBulletData_FinalBattle";

	// Token: 0x0400292B RID: 10539
	[Nullable(2)]
	public UDataTable BulletDataTable;

	// Token: 0x0400292C RID: 10540
	private readonly Dictionary<int, IFinalBattleCombatInfo> AllEntities = new Dictionary<int, IFinalBattleCombatInfo>();
}
