using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02002EE0 RID: 12000
[NullableContext(1)]
[Nullable(0)]
public class DamageStatisticsData
{
	// Token: 0x06019A00 RID: 104960 RVA: 0x006A7E02 File Offset: 0x006A6002
	public DamageStatisticsData(int roleId, string roleName, string damageType, bool isHeal)
	{
		this.RoleId = roleId;
		this.RoleName = roleName;
		this.DamageType = damageType;
		this.IsHeal = isHeal;
	}

	// Token: 0x06019A01 RID: 104961 RVA: 0x006A7E34 File Offset: 0x006A6034
	public void AddDamageValue(int targetId, int damage)
	{
		TargetDamageStatistics targetDamageStatistics;
		if (!this.TargetTotalDamage.TryGetValue(targetId, out targetDamageStatistics))
		{
			targetDamageStatistics = new TargetDamageStatistics(targetId);
			if (!targetDamageStatistics.IsValid)
			{
				return;
			}
			this.TargetTotalDamage[targetId] = targetDamageStatistics;
		}
		targetDamageStatistics.AddDamageValue(damage);
	}

	// Token: 0x06019A02 RID: 104962 RVA: 0x006A7E75 File Offset: 0x006A6075
	public int GetTargetCount()
	{
		return this.TargetTotalDamage.Count;
	}

	// Token: 0x06019A03 RID: 104963 RVA: 0x006A7E84 File Offset: 0x006A6084
	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (TargetDamageStatistics targetDamageStatistics in this.TargetTotalDamage.Values)
		{
			stringBuilder.Append(targetDamageStatistics.ToString());
		}
		return StringUtils.Format("{0},{1},{2},{3}{4}\n", new string[]
		{
			this.RoleId.ToString(),
			this.RoleName,
			this.IsHeal ? "治疗" : "伤害",
			this.DamageType,
			stringBuilder.ToString()
		});
	}

	// Token: 0x0400BFEF RID: 49135
	private readonly Dictionary<int, TargetDamageStatistics> TargetTotalDamage = new Dictionary<int, TargetDamageStatistics>();

	// Token: 0x0400BFF0 RID: 49136
	public readonly int RoleId;

	// Token: 0x0400BFF1 RID: 49137
	public readonly string RoleName;

	// Token: 0x0400BFF2 RID: 49138
	public readonly string DamageType;

	// Token: 0x0400BFF3 RID: 49139
	public readonly bool IsHeal;
}
