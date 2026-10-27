using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02002EDF RID: 11999
[NullableContext(1)]
[Nullable(0)]
public class TargetDamageStatistics
{
	// Token: 0x060199FD RID: 104957 RVA: 0x006A7C78 File Offset: 0x006A5E78
	public TargetDamageStatistics(int inTargetId)
	{
		this.TargetId = inTargetId;
		CreatureDataComponent component = EntitySystem.Instance.Get(this.TargetId).GetComponent<CreatureDataComponent>();
		EEntityType entityType = component.GetEntityType();
		this.IsMonster = (entityType == EEntityType.Monster);
		this.IsRole = (entityType == EEntityType.Player);
		this.ConfigId = 0;
		this.TargetName = "";
		if (this.IsMonster)
		{
			this.ConfigId = component.GetPbDataId();
			this.TargetName = PublicUtil.Instance.GetConfigTextByKey(component.GetEntityTidName() ?? "");
			return;
		}
		if (this.IsRole)
		{
			int id = component.Valid ? component.GetRoleId() : 0;
			int baseRoleId = RoleConfig.Instance.GetBaseRoleId(id);
			if (baseRoleId != 0)
			{
				this.ConfigId = baseRoleId;
				RoleInfo value = RoleConfig.Instance.GetRoleConfig(this.ConfigId).Value;
				this.TargetName = RoleConfig.Instance.GetRoleName(value.Name);
				return;
			}
			this.IsValid = false;
		}
	}

	// Token: 0x060199FE RID: 104958 RVA: 0x006A7D7A File Offset: 0x006A5F7A
	public void AddDamageValue(int damage)
	{
		this.DamageTotal += damage;
	}

	// Token: 0x060199FF RID: 104959 RVA: 0x006A7D8C File Offset: 0x006A5F8C
	public override string ToString()
	{
		return StringUtils.Format(",{0},{1},{2},{3},{4}", new string[]
		{
			this.IsMonster ? "怪物" : (this.IsRole ? "角色" : "出错？？"),
			this.TargetName,
			this.ConfigId.ToString(),
			this.TargetId.ToString(),
			this.DamageTotal.ToString()
		});
	}

	// Token: 0x0400BFE8 RID: 49128
	private int DamageTotal;

	// Token: 0x0400BFE9 RID: 49129
	private readonly bool IsMonster;

	// Token: 0x0400BFEA RID: 49130
	private readonly bool IsRole;

	// Token: 0x0400BFEB RID: 49131
	private readonly int ConfigId;

	// Token: 0x0400BFEC RID: 49132
	public readonly int TargetId;

	// Token: 0x0400BFED RID: 49133
	private readonly string TargetName;

	// Token: 0x0400BFEE RID: 49134
	public bool IsValid = true;
}
