using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000370 RID: 880
[NullableContext(1)]
[Nullable(0)]
public class PotatoSubModel : KscSubModelBase
{
	// Token: 0x06003118 RID: 12568 RVA: 0x0011C178 File Offset: 0x0011A378
	public override string GetSkillDtPath()
	{
		return string.Empty;
	}

	// Token: 0x06003119 RID: 12569 RVA: 0x0011C17F File Offset: 0x0011A37F
	public override string GetEntityDtPath()
	{
		return string.Empty;
	}

	// Token: 0x0600311A RID: 12570 RVA: 0x0011C188 File Offset: 0x0011A388
	[NullableContext(2)]
	public IPotatoCombatInfo GetEntity(long uid)
	{
		IPotatoCombatInfo result;
		if (!this.AllEntities.TryGetValue(uid, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x0600311B RID: 12571 RVA: 0x0011C1A8 File Offset: 0x0011A3A8
	public void GetAllEntities(List<IPotatoCombatInfo> entities)
	{
		entities.Clear();
		foreach (IPotatoCombatInfo item in this.AllEntities.Values)
		{
			entities.Add(item);
		}
	}

	// Token: 0x0600311C RID: 12572 RVA: 0x0011C208 File Offset: 0x0011A408
	[return: Nullable(2)]
	public string TryAddEntity(IPotatoCombatInfo entityModel)
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

	// Token: 0x0600311D RID: 12573 RVA: 0x0011C254 File Offset: 0x0011A454
	[NullableContext(2)]
	public IPotatoCombatInfo RemoveEntity(long uid)
	{
		IPotatoCombatInfo result;
		if (this.AllEntities.TryGetValue(uid, out result))
		{
			this.AllEntities.Remove(uid);
			return result;
		}
		return null;
	}

	// Token: 0x0600311E RID: 12574 RVA: 0x0011C284 File Offset: 0x0011A484
	protected override bool OnClear()
	{
		this.AllEntities.Clear();
		this.WeaponKscEntityMap.Clear();
		this.DamageMap.Clear();
		this.GoldNum = 0;
		this.PropertyUpperBoundMap.Clear();
		this.PropertyLowerBoundMap.Clear();
		return true;
	}

	// Token: 0x04002B2D RID: 11053
	public static readonly string HitContextTextDaPath = "/Game/Aki/Data/SimpleCombat/3_4Potato/KSC_DA_HitContextText_PTT.KSC_DA_HitContextText_PTT";

	// Token: 0x04002B2E RID: 11054
	public static readonly string BulletDtPath = "/Game/Aki/Data/SimpleCombat/3_4Potato/CDT_KuroBulletData_PTT.CDT_KuroBulletData_PTT";

	// Token: 0x04002B2F RID: 11055
	[Nullable(2)]
	public UDataTable BulletDataTable;

	// Token: 0x04002B30 RID: 11056
	private readonly Dictionary<long, IPotatoCombatInfo> AllEntities = new Dictionary<long, IPotatoCombatInfo>();

	// Token: 0x04002B31 RID: 11057
	public Dictionary<int, AKSC_Entity> WeaponKscEntityMap = new Dictionary<int, AKSC_Entity>();

	// Token: 0x04002B32 RID: 11058
	public Dictionary<long, int> DamageMap = new Dictionary<long, int>();

	// Token: 0x04002B33 RID: 11059
	public int GoldNum;

	// Token: 0x04002B34 RID: 11060
	public Dictionary<int, int> PropertyUpperBoundMap = new Dictionary<int, int>();

	// Token: 0x04002B35 RID: 11061
	public Dictionary<int, int> PropertyLowerBoundMap = new Dictionary<int, int>();
}
