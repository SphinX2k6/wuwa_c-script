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
	// (get) Token: 0x06000074 RID: 116 RVA: 0x000055BC File Offset: 0x000037BC
	[CompilerGenerated]
	protected virtual Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(EAkMarkerCbType);
		}
	}

	// Token: 0x06000075 RID: 117 RVA: 0x000055C8 File Offset: 0x000037C8
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

	// Token: 0x06000076 RID: 118 RVA: 0x00005614 File Offset: 0x00003814
	[CompilerGenerated]
	protected virtual bool PrintMembers(StringBuilder builder)
	{
		return false;
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00005617 File Offset: 0x00003817
	[NullableContext(2)]
	[CompilerGenerated]
	public static bool operator !=(EAkMarkerCbType left, EAkMarkerCbType right)
	{
		return !(left == right);
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00005623 File Offset: 0x00003823
	[NullableContext(2)]
	[CompilerGenerated]
	public static bool operator ==(EAkMarkerCbType left, EAkMarkerCbType right)
	{
		return left == right || (left != null && left.Equals(right));
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00005637 File Offset: 0x00003837
	[CompilerGenerated]
	public override int GetHashCode()
	{
		return EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract);
	}

	// Token: 0x0600007A RID: 122 RVA: 0x00005649 File Offset: 0x00003849
	[NullableContext(2)]
	[CompilerGenerated]
	public override bool Equals(object obj)
	{
		return this.Equals(obj as EAkMarkerCbType);
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00005657 File Offset: 0x00003857
	[NullableContext(2)]
	[CompilerGenerated]
	public virtual bool Equals(EAkMarkerCbType other)
	{
		return this == other || (other != null && this.EqualityContract == other.EqualityContract);
	}

	// Token: 0x0600007D RID: 125 RVA: 0x0000567D File Offset: 0x0000387D
	[CompilerGenerated]
	protected EAkMarkerCbType(EAkMarkerCbType original)
	{
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00005685 File Offset: 0x00003885
	public EAkMarkerCbType()
	{
	}

	// Token: 0x0400006F RID: 111
	public const string SoundTrackEffect = "SoundTrackingEffectNotify";
}
