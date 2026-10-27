using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x0200000F RID: 15
[NullableContext(1)]
[Nullable(0)]
public class EAkMarkerCbType : IEquatable<EAkMarkerCbType>
{
	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000074 RID: 116 RVA: 0x000058C0 File Offset: 0x00003AC0
	[CompilerGenerated]
	protected virtual Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(EAkMarkerCbType);
		}
	}

	// Token: 0x06000075 RID: 117 RVA: 0x000058CC File Offset: 0x00003ACC
	[CompilerGenerated]
	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("EAkMarkerCbType");
		stringBuilder.Append(" { ");
		if (this.PrintMembers(stringBuilder))
		{
			stringBuilder.Append(' ');
		}
		stringBuilder.Append('}');
		return stringBuilder.ToString();
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00005918 File Offset: 0x00003B18
	[CompilerGenerated]
	protected virtual bool PrintMembers(StringBuilder builder)
	{
		return false;
	}

	// Token: 0x06000077 RID: 119 RVA: 0x0000591B File Offset: 0x00003B1B
	[NullableContext(2)]
	[CompilerGenerated]
	public static bool operator !=(EAkMarkerCbType left, EAkMarkerCbType right)
	{
		return !(left == right);
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00005927 File Offset: 0x00003B27
	[NullableContext(2)]
	[CompilerGenerated]
	public static bool operator ==(EAkMarkerCbType left, EAkMarkerCbType right)
	{
		return left == right || (left != null && left.Equals(right));
	}

	// Token: 0x06000079 RID: 121 RVA: 0x0000593B File Offset: 0x00003B3B
	[CompilerGenerated]
	public override int GetHashCode()
	{
		return EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract);
	}

	// Token: 0x0600007A RID: 122 RVA: 0x0000594D File Offset: 0x00003B4D
	[NullableContext(2)]
	[CompilerGenerated]
	public override bool Equals(object obj)
	{
		return this.Equals(obj as EAkMarkerCbType);
	}

	// Token: 0x0600007B RID: 123 RVA: 0x0000595B File Offset: 0x00003B5B
	[NullableContext(2)]
	[CompilerGenerated]
	public virtual bool Equals(EAkMarkerCbType other)
	{
		return this == other || (other != null && this.EqualityContract == other.EqualityContract);
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00005981 File Offset: 0x00003B81
	[CompilerGenerated]
	protected EAkMarkerCbType(EAkMarkerCbType original)
	{
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00005989 File Offset: 0x00003B89
	public EAkMarkerCbType()
	{
	}

	// Token: 0x0400006F RID: 111
	public const string SoundTrackEffect = "SoundTrackingEffectNotify";
}
