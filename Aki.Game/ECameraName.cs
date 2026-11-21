using System;
using System.Runtime.CompilerServices;

// Token: 0x020018EC RID: 6380
[NullableContext(1)]
[Nullable(0)]
public readonly struct ECameraName : IEquatable<ECameraName>
{
	// Token: 0x0600FC7C RID: 64636 RVA: 0x0049C970 File Offset: 0x0049AB70
	private ECameraName(string value)
	{
		this._Value = value;
	}

	// Token: 0x0600FC7D RID: 64637 RVA: 0x0049C979 File Offset: 0x0049AB79
	public override string ToString()
	{
		return this._Value;
	}

	// Token: 0x0600FC7E RID: 64638 RVA: 0x0049C981 File Offset: 0x0049AB81
	public bool Equals(ECameraName other)
	{
		return this._Value == other._Value;
	}

	// Token: 0x0600FC7F RID: 64639 RVA: 0x0049C994 File Offset: 0x0049AB94
	public override bool Equals(object obj)
	{
		if (obj is ECameraName)
		{
			ECameraName other = (ECameraName)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x0600FC80 RID: 64640 RVA: 0x0049C9B9 File Offset: 0x0049ABB9
	public override int GetHashCode()
	{
		string value = this._Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x0600FC81 RID: 64641 RVA: 0x0049C9CC File Offset: 0x0049ABCC
	public static bool operator ==(ECameraName left, ECameraName right)
	{
		return left.Equals(right);
	}

	// Token: 0x0600FC82 RID: 64642 RVA: 0x0049C9D6 File Offset: 0x0049ABD6
	public static bool operator !=(ECameraName left, ECameraName right)
	{
		return !left.Equals(right);
	}

	// Token: 0x04008CB6 RID: 36022
	private readonly string _Value;

	// Token: 0x04008CB7 RID: 36023
	public static readonly ECameraName BlendCamera = new ECameraName("1001");

	// Token: 0x04008CB8 RID: 36024
	public static readonly ECameraName PhantomBaseCamera = new ECameraName("1025");
}
