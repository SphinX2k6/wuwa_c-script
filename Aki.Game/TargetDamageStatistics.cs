using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02002432 RID: 9266
[NullableContext(1)]
[Nullable(0)]
public class TargetDamageStatistics
{
	// Token: 0x060172FC RID: 94972 RVA: 0x006CDE1C File Offset: 0x006CC01C
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

	// Token: 0x060172FD RID: 94973 RVA: 0x006CDF1E File Offset: 0x006CC11E
	public void AddDamageValue(int damage)
	{
		this.DamageTotal += damage;
	}

	// Token: 0x060172FE RID: 94974 RVA: 0x006CDF30 File Offset: 0x006CC130
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

	// Token: 0x0400C383 RID: 50051
	private int DamageTotal;

	// Token: 0x0400C384 RID: 50052
	private readonly bool IsMonster;

	// Token: 0x0400C385 RID: 50053
	private readonly bool IsRole;

	// Token: 0x0400C386 RID: 50054
	private readonly int ConfigId;

	// Token: 0x0400C387 RID: 50055
	public readonly int TargetId;

	// Token: 0x0400C388 RID: 50056
	private readonly string TargetName;

	// Token: 0x0400C389 RID: 50057
	public bool IsValid = true;
}
