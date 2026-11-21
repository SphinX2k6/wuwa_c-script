using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02002433 RID: 9267
[NullableContext(1)]
[Nullable(0)]
public class DamageStatisticsData
{
	// Token: 0x060172FF RID: 94975 RVA: 0x006CDFA6 File Offset: 0x006CC1A6
	public DamageStatisticsData(int roleId, string roleName, string damageType, bool isHeal)
	{
		this.RoleId = roleId;
		this.RoleName = roleName;
		this.DamageType = damageType;
		this.IsHeal = isHeal;
	}

	// Token: 0x06017300 RID: 94976 RVA: 0x006CDFD8 File Offset: 0x006CC1D8
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

	// Token: 0x06017301 RID: 94977 RVA: 0x006CE019 File Offset: 0x006CC219
	public int GetTargetCount()
	{
		return this.TargetTotalDamage.Count;
	}

	// Token: 0x06017302 RID: 94978 RVA: 0x006CE028 File Offset: 0x006CC228
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

	// Token: 0x0400C38A RID: 50058
	private readonly Dictionary<int, TargetDamageStatistics> TargetTotalDamage = new Dictionary<int, TargetDamageStatistics>();

	// Token: 0x0400C38B RID: 50059
	public readonly int RoleId;

	// Token: 0x0400C38C RID: 50060
	public readonly string RoleName;

	// Token: 0x0400C38D RID: 50061
	public readonly string DamageType;

	// Token: 0x0400C38E RID: 50062
	public readonly bool IsHeal;
}
