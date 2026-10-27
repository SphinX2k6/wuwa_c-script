using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000EBB RID: 3771
[NullableContext(1)]
[Nullable(0)]
public class PotatoSubModel : KscSubModelBase
{
	// Token: 0x06005D81 RID: 23937 RVA: 0x00114498 File Offset: 0x00112698
	public override string GetSkillDtPath()
	{
		return string.Empty;
	}

	// Token: 0x06005D82 RID: 23938 RVA: 0x0011449F File Offset: 0x0011269F
	public override string GetEntityDtPath()
	{
		return string.Empty;
	}

	// Token: 0x06005D83 RID: 23939 RVA: 0x001144A8 File Offset: 0x001126A8
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

	// Token: 0x06005D84 RID: 23940 RVA: 0x001144C8 File Offset: 0x001126C8
	public void GetAllEntities(List<IPotatoCombatInfo> entities)
	{
		entities.Clear();
		foreach (IPotatoCombatInfo item in this.AllEntities.Values)
		{
			entities.Add(item);
		}
	}

	// Token: 0x06005D85 RID: 23941 RVA: 0x00114528 File Offset: 0x00112728
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

	// Token: 0x06005D86 RID: 23942 RVA: 0x00114574 File Offset: 0x00112774
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

	// Token: 0x06005D87 RID: 23943 RVA: 0x001145A4 File Offset: 0x001127A4
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

	// Token: 0x04002A92 RID: 10898
	public static readonly string HitContextTextDaPath = "/Game/Aki/Data/SimpleCombat/3_4Potato/KSC_DA_HitContextText_PTT.KSC_DA_HitContextText_PTT";

	// Token: 0x04002A93 RID: 10899
	public static readonly string BulletDtPath = "/Game/Aki/Data/SimpleCombat/3_4Potato/CDT_KuroBulletData_PTT.CDT_KuroBulletData_PTT";

	// Token: 0x04002A94 RID: 10900
	[Nullable(2)]
	public UDataTable BulletDataTable;

	// Token: 0x04002A95 RID: 10901
	private readonly Dictionary<long, IPotatoCombatInfo> AllEntities = new Dictionary<long, IPotatoCombatInfo>();

	// Token: 0x04002A96 RID: 10902
	public Dictionary<int, AKSC_Entity> WeaponKscEntityMap = new Dictionary<int, AKSC_Entity>();

	// Token: 0x04002A97 RID: 10903
	public Dictionary<long, int> DamageMap = new Dictionary<long, int>();

	// Token: 0x04002A98 RID: 10904
	public int GoldNum;

	// Token: 0x04002A99 RID: 10905
	public Dictionary<int, int> PropertyUpperBoundMap = new Dictionary<int, int>();

	// Token: 0x04002A9A RID: 10906
	public Dictionary<int, int> PropertyLowerBoundMap = new Dictionary<int, int>();
}
