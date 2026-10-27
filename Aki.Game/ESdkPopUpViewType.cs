using System;
using System.Runtime.CompilerServices;

// Token: 0x02002963 RID: 10595
public readonly struct ESdkPopUpViewType : IEquatable<ESdkPopUpViewType>
{
	// Token: 0x06015E72 RID: 89714 RVA: 0x00586783 File Offset: 0x00584983
	private ESdkPopUpViewType(int value)
	{
		this._Value = value;
	}

	// Token: 0x06015E73 RID: 89715 RVA: 0x0058678C File Offset: 0x0058498C
	[NullableContext(1)]
	public override string ToString()
	{
		return this._Value.ToString();
	}

	// Token: 0x06015E74 RID: 89716 RVA: 0x00586799 File Offset: 0x00584999
	public bool Equals(ESdkPopUpViewType other)
	{
		return this._Value == other._Value;
	}

	// Token: 0x06015E75 RID: 89717 RVA: 0x005867AC File Offset: 0x005849AC
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

	// Token: 0x06015E76 RID: 89718 RVA: 0x005867D1 File Offset: 0x005849D1
	public override int GetHashCode()
	{
		return this._Value.GetHashCode();
	}

	// Token: 0x06015E77 RID: 89719 RVA: 0x005867DE File Offset: 0x005849DE
	public static bool operator ==(ESdkPopUpViewType left, ESdkPopUpViewType right)
	{
		return left.Equals(right);
	}

	// Token: 0x06015E78 RID: 89720 RVA: 0x005867E8 File Offset: 0x005849E8
	public static bool operator !=(ESdkPopUpViewType left, ESdkPopUpViewType right)
	{
		return !left.Equals(right);
	}

	// Token: 0x0400A2FE RID: 41726
	private readonly int _Value;

	// Token: 0x0400A2FF RID: 41727
	public static readonly ESdkPopUpViewType Creating = new ESdkPopUpViewType(0);

	// Token: 0x0400A300 RID: 41728
	public static readonly ESdkPopUpViewType Login = new ESdkPopUpViewType(1);
}
