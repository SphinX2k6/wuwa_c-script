using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02000010 RID: 16
[NullableContext(1)]
[Nullable(0)]
public class EAkMarkerCbActionType : IEquatable<EAkMarkerCbActionType>
{
	// Token: 0x17000009 RID: 9
	// (get) Token: 0x0600007F RID: 127 RVA: 0x0000568D File Offset: 0x0000388D
	[CompilerGenerated]
	protected virtual Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(EAkMarkerCbActionType);
		}
	}

	// Token: 0x06000080 RID: 128 RVA: 0x0000569C File Offset: 0x0000389C
	[CompilerGenerated]
	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("EAkMarkerCbActionType");
		stringBuilder.Append(" { ");
		if (this.PrintMembers(stringBuilder))
		{
			stringBuilder.Append(' ');
		}
		stringBuilder.Append('}');
		return stringBuilder.ToString();
	}

	// Token: 0x06000081 RID: 129 RVA: 0x000056E8 File Offset: 0x000038E8
	[CompilerGenerated]
	protected virtual bool PrintMembers(StringBuilder builder)
	{
		return false;
	}

	// Token: 0x06000082 RID: 130 RVA: 0x000056EB File Offset: 0x000038EB
	[NullableContext(2)]
	[CompilerGenerated]
	public static bool operator !=(EAkMarkerCbActionType left, EAkMarkerCbActionType right)
	{
		return !(left == right);
	}

	// Token: 0x06000083 RID: 131 RVA: 0x000056F7 File Offset: 0x000038F7
	[NullableContext(2)]
	[CompilerGenerated]
	public static bool operator ==(EAkMarkerCbActionType left, EAkMarkerCbActionType right)
	{
		return left == right || (left != null && left.Equals(right));
	}

	// Token: 0x06000084 RID: 132 RVA: 0x0000570B File Offset: 0x0000390B
	[CompilerGenerated]
	public override int GetHashCode()
	{
		return EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract);
	}

	// Token: 0x06000085 RID: 133 RVA: 0x0000571D File Offset: 0x0000391D
	[NullableContext(2)]
	[CompilerGenerated]
	public override bool Equals(object obj)
	{
		return this.Equals(obj as EAkMarkerCbActionType);
	}

	// Token: 0x06000086 RID: 134 RVA: 0x0000572B File Offset: 0x0000392B
	[NullableContext(2)]
	[CompilerGenerated]
	public virtual bool Equals(EAkMarkerCbActionType other)
	{
		return this == other || (other != null && this.EqualityContract == other.EqualityContract);
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00005751 File Offset: 0x00003951
	[CompilerGenerated]
	protected EAkMarkerCbActionType(EAkMarkerCbActionType original)
	{
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00005759 File Offset: 0x00003959
	public EAkMarkerCbActionType()
	{
	}

	// Token: 0x04000070 RID: 112
	public const string Start = "Start";

	// Token: 0x04000071 RID: 113
	public const string End = "End";
}
