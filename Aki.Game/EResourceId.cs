using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D55 RID: 7509
[NullableContext(1)]
[Nullable(0)]
public readonly struct EResourceId : IEquatable<EResourceId>
{
	// Token: 0x06012947 RID: 76103 RVA: 0x0057BD89 File Offset: 0x00579F89
	private EResourceId(string value)
	{
		this._value = value;
	}

	// Token: 0x06012948 RID: 76104 RVA: 0x0057BD92 File Offset: 0x00579F92
	public override string ToString()
	{
		return this._value;
	}

	// Token: 0x06012949 RID: 76105 RVA: 0x0057BD9A File Offset: 0x00579F9A
	public bool Equals(EResourceId other)
	{
		return this._value == other._value;
	}

	// Token: 0x0601294A RID: 76106 RVA: 0x0057BDB0 File Offset: 0x00579FB0
	[NullableContext(2)]
	public override bool Equals(object obj)
	{
		if (obj is EResourceId)
		{
			EResourceId other = (EResourceId)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x0601294B RID: 76107 RVA: 0x0057BDD5 File Offset: 0x00579FD5
	public override int GetHashCode()
	{
		string value = this._value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x0601294C RID: 76108 RVA: 0x0057BDE8 File Offset: 0x00579FE8
	public static bool operator ==(EResourceId? left, EResourceId? right)
	{
		return left.Equals(right);
	}

	// Token: 0x0601294D RID: 76109 RVA: 0x0057BDFD File Offset: 0x00579FFD
	public static bool operator !=(EResourceId? left, EResourceId? right)
	{
		return !left.Equals(right);
	}

	// Token: 0x0601294E RID: 76110 RVA: 0x0057BE15 File Offset: 0x0057A015
	public static implicit operator string(EResourceId id)
	{
		return id.ToString();
	}

	// Token: 0x0400A19B RID: 41371
	private readonly string _value;

	// Token: 0x0400A19C RID: 41372
	public static readonly EResourceId PlanRole = new EResourceId("UiItem_PlanRole");

	// Token: 0x0400A19D RID: 41373
	public static readonly EResourceId PlanWeapon = new EResourceId("UiItem_PlanWeapon");

	// Token: 0x0400A19E RID: 41374
	public static readonly EResourceId PlanVision = new EResourceId("UiItem_PlanVision");

	// Token: 0x0400A19F RID: 41375
	public static readonly EResourceId PlanSkill = new EResourceId("UiItem_PlanRoleSkill");
}
