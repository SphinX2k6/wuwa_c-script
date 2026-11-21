using System;
using System.Runtime.CompilerServices;

// Token: 0x02001EDE RID: 7902
public readonly struct ESdkPopUpViewType : IEquatable<ESdkPopUpViewType>
{
	// Token: 0x06013876 RID: 79990 RVA: 0x005B1787 File Offset: 0x005AF987
	private ESdkPopUpViewType(int value)
	{
		this._Value = value;
	}

	// Token: 0x06013877 RID: 79991 RVA: 0x005B1790 File Offset: 0x005AF990
	[NullableContext(1)]
	public override string ToString()
	{
		return this._Value.ToString();
	}

	// Token: 0x06013878 RID: 79992 RVA: 0x005B179D File Offset: 0x005AF99D
	public bool Equals(ESdkPopUpViewType other)
	{
		return this._Value == other._Value;
	}

	// Token: 0x06013879 RID: 79993 RVA: 0x005B17B0 File Offset: 0x005AF9B0
	[NullableContext(1)]
	public override bool Equals(object obj)
	{
		if (obj is ESdkPopUpViewType)
		{
			ESdkPopUpViewType other = (ESdkPopUpViewType)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x0601387A RID: 79994 RVA: 0x005B17D5 File Offset: 0x005AF9D5
	public override int GetHashCode()
	{
		return this._Value.GetHashCode();
	}

	// Token: 0x0601387B RID: 79995 RVA: 0x005B17E2 File Offset: 0x005AF9E2
	public static bool operator ==(ESdkPopUpViewType left, ESdkPopUpViewType right)
	{
		return left.Equals(right);
	}

	// Token: 0x0601387C RID: 79996 RVA: 0x005B17EC File Offset: 0x005AF9EC
	public static bool operator !=(ESdkPopUpViewType left, ESdkPopUpViewType right)
	{
		return !left.Equals(right);
	}

	// Token: 0x0400A6E8 RID: 42728
	private readonly int _Value;

	// Token: 0x0400A6E9 RID: 42729
	public static readonly ESdkPopUpViewType Creating = new ESdkPopUpViewType(0);

	// Token: 0x0400A6EA RID: 42730
	public static readonly ESdkPopUpViewType Login = new ESdkPopUpViewType(1);
}
