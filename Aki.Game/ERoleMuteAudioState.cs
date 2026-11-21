using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D47 RID: 7495
[NullableContext(1)]
[Nullable(0)]
public readonly struct ERoleMuteAudioState : IEquatable<ERoleMuteAudioState>
{
	// Token: 0x06012913 RID: 76051 RVA: 0x0057B908 File Offset: 0x00579B08
	private ERoleMuteAudioState(string value)
	{
		this._value = value;
	}

	// Token: 0x06012914 RID: 76052 RVA: 0x0057B911 File Offset: 0x00579B11
	public override string ToString()
	{
		return this._value;
	}

	// Token: 0x06012915 RID: 76053 RVA: 0x0057B919 File Offset: 0x00579B19
	public bool Equals(ERoleMuteAudioState other)
	{
		return this._value == other._value;
	}

	// Token: 0x06012916 RID: 76054 RVA: 0x0057B92C File Offset: 0x00579B2C
	[NullableContext(2)]
	public override bool Equals(object obj)
	{
		if (obj is ERoleMuteAudioState)
		{
			ERoleMuteAudioState other = (ERoleMuteAudioState)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x06012917 RID: 76055 RVA: 0x0057B951 File Offset: 0x00579B51
	public override int GetHashCode()
	{
		string value = this._value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x06012918 RID: 76056 RVA: 0x0057B964 File Offset: 0x00579B64
	public static bool operator ==(ERoleMuteAudioState? left, ERoleMuteAudioState? right)
	{
		return left.Equals(right);
	}

	// Token: 0x06012919 RID: 76057 RVA: 0x0057B979 File Offset: 0x00579B79
	public static bool operator !=(ERoleMuteAudioState? left, ERoleMuteAudioState? right)
	{
		return !left.Equals(right);
	}

	// Token: 0x0601291A RID: 76058 RVA: 0x0057B991 File Offset: 0x00579B91
	public static implicit operator string(ERoleMuteAudioState state)
	{
		return state.ToString();
	}

	// Token: 0x0400A15A RID: 41306
	private readonly string _value;

	// Token: 0x0400A15B RID: 41307
	public static readonly ERoleMuteAudioState None = new ERoleMuteAudioState("none");

	// Token: 0x0400A15C RID: 41308
	public static readonly ERoleMuteAudioState Mute = new ERoleMuteAudioState("mute");
}
