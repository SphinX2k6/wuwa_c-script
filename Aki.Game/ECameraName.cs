using System;
using System.Runtime.CompilerServices;

// Token: 0x02002407 RID: 9223
[NullableContext(1)]
[Nullable(0)]
public readonly struct ECameraName : IEquatable<ECameraName>
{
	// Token: 0x060127C6 RID: 75718 RVA: 0x0048F354 File Offset: 0x0048D554
	private ECameraName(string value)
	{
		this._Value = value;
	}

	// Token: 0x060127C7 RID: 75719 RVA: 0x0048F35D File Offset: 0x0048D55D
	public override string ToString()
	{
		return this._Value;
	}

	// Token: 0x060127C8 RID: 75720 RVA: 0x0048F365 File Offset: 0x0048D565
	public bool Equals(ECameraName other)
	{
		return this._Value == other._Value;
	}

	// Token: 0x060127C9 RID: 75721 RVA: 0x0048F378 File Offset: 0x0048D578
	public override bool Equals(object obj)
	{
		if (obj is ECameraName)
		{
			ECameraName other = (ECameraName)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x060127CA RID: 75722 RVA: 0x0048F39D File Offset: 0x0048D59D
	public override int GetHashCode()
	{
		string value = this._Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x060127CB RID: 75723 RVA: 0x0048F3B0 File Offset: 0x0048D5B0
	public static bool operator ==(ECameraName left, ECameraName right)
	{
		return left.Equals(right);
	}

	// Token: 0x060127CC RID: 75724 RVA: 0x0048F3BA File Offset: 0x0048D5BA
	public static bool operator !=(ECameraName left, ECameraName right)
	{
		return !left.Equals(right);
	}

	// Token: 0x04008B6F RID: 35695
	private readonly string _Value;

	// Token: 0x04008B70 RID: 35696
	public static readonly ECameraName BlendCamera = new ECameraName("1001");

	// Token: 0x04008B71 RID: 35697
	public static readonly ECameraName PhantomBaseCamera = new ECameraName("1025");
}
