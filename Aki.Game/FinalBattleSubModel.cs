using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200032A RID: 810
[NullableContext(1)]
[Nullable(0)]
public class FinalBattleSubModel : KscSubModelBase
{
	// Token: 0x06002DB0 RID: 11696 RVA: 0x0010E912 File Offset: 0x0010CB12
	public override string GetSkillDtPath()
	{
		return FinalBattleSubModel.SkillDtPath;
	}

	// Token: 0x06002DB1 RID: 11697 RVA: 0x0010E919 File Offset: 0x0010CB19
	public override string GetEntityDtPath()
	{
		return FinalBattleSubModel.EntityDtPath;
	}

	// Token: 0x06002DB2 RID: 11698 RVA: 0x0010E920 File Offset: 0x0010CB20
	public string GetBulletDtPath()
	{
		return FinalBattleSubModel.BulletDtPath;
	}

	// Token: 0x06002DB3 RID: 11699 RVA: 0x0010E928 File Offset: 0x0010CB28
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

	// Token: 0x06002DB4 RID: 11700 RVA: 0x0010E948 File Offset: 0x0010CB48
	public void GetAllEntities(List<IFinalBattleCombatInfo> entities)
	{
		entities.Clear();
		foreach (IFinalBattleCombatInfo item in this.AllEntities.Values)
		{
			entities.Add(item);
		}
	}

	// Token: 0x06002DB5 RID: 11701 RVA: 0x0010E9A8 File Offset: 0x0010CBA8
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

	// Token: 0x06002DB6 RID: 11702 RVA: 0x0010E9F0 File Offset: 0x0010CBF0
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

	// Token: 0x06002DB7 RID: 11703 RVA: 0x0010EA1D File Offset: 0x0010CC1D
	protected override bool OnClear()
	{
		this.AllEntities.Clear();
		this.BulletDataTable = null;
		return true;
	}

	// Token: 0x06002DB8 RID: 11704 RVA: 0x0010EA32 File Offset: 0x0010CC32
	public override bool IsCreatureIdValid(int creatureId)
	{
		return this.AllEntities.ContainsKey(creatureId);
	}

	// Token: 0x040029C3 RID: 10691
	public static readonly string SkillDtPath = "";

	// Token: 0x040029C4 RID: 10692
	public static readonly string EntityDtPath = "";

	// Token: 0x040029C5 RID: 10693
	public static readonly string BulletDtPath = "/Game/Aki/Data/SimpleCombat/3_5FinalBattle/DT_KuroBulletData_FinalBattle.DT_KuroBulletData_FinalBattle";

	// Token: 0x040029C6 RID: 10694
	[Nullable(2)]
	public UDataTable BulletDataTable;

	// Token: 0x040029C7 RID: 10695
	private readonly Dictionary<int, IFinalBattleCombatInfo> AllEntities = new Dictionary<int, IFinalBattleCombatInfo>();
}
