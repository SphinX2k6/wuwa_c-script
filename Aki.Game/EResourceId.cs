using System;
using System.Runtime.CompilerServices;

// Token: 0x020027DA RID: 10202
[NullableContext(1)]
[Nullable(0)]
public readonly struct EResourceId : IEquatable<EResourceId>
{
	// Token: 0x06014F47 RID: 85831 RVA: 0x00551019 File Offset: 0x0054F219
	private EResourceId(string value)
	{
		this._value = value;
	}

	// Token: 0x06014F48 RID: 85832 RVA: 0x00551022 File Offset: 0x0054F222
	public override string ToString()
	{
		return this._value;
	}

	// Token: 0x06014F49 RID: 85833 RVA: 0x0055102A File Offset: 0x0054F22A
	public bool Equals(EResourceId other)
	{
		return this._value == other._value;
	}

	// Token: 0x06014F4A RID: 85834 RVA: 0x00551040 File Offset: 0x0054F240
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

	// Token: 0x06014F4B RID: 85835 RVA: 0x00551065 File Offset: 0x0054F265
	public override int GetHashCode()
	{
		string value = this._value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x06014F4C RID: 85836 RVA: 0x00551078 File Offset: 0x0054F278
	public static bool operator ==(EResourceId? left, EResourceId? right)
	{
		return left.Equals(right);
	}

	// Token: 0x06014F4D RID: 85837 RVA: 0x0055108D File Offset: 0x0054F28D
	public static bool operator !=(EResourceId? left, EResourceId? right)
	{
		return !left.Equals(right);
	}

	// Token: 0x06014F4E RID: 85838 RVA: 0x005510A5 File Offset: 0x0054F2A5
	public static implicit operator string(EResourceId id)
	{
		return id.ToString();
	}

	// Token: 0x04009DB2 RID: 40370
	private readonly string _value;

	// Token: 0x04009DB3 RID: 40371
	public static readonly EResourceId PlanRole = new EResourceId("UiItem_PlanRole");

	// Token: 0x04009DB4 RID: 40372
	public static readonly EResourceId PlanWeapon = new EResourceId("UiItem_PlanWeapon");

	// Token: 0x04009DB5 RID: 40373
	public static readonly EResourceId PlanVision = new EResourceId("UiItem_PlanVision");

	// Token: 0x04009DB6 RID: 40374
	public static readonly EResourceId PlanSkill = new EResourceId("UiItem_PlanRoleSkill");
}
