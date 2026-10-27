using System;
using System.Runtime.CompilerServices;

// Token: 0x020027CC RID: 10188
[NullableContext(1)]
[Nullable(0)]
public readonly struct ERoleMuteAudioState : IEquatable<ERoleMuteAudioState>
{
	// Token: 0x06014F13 RID: 85779 RVA: 0x00550B96 File Offset: 0x0054ED96
	private ERoleMuteAudioState(string value)
	{
		this._value = value;
	}

	// Token: 0x06014F14 RID: 85780 RVA: 0x00550B9F File Offset: 0x0054ED9F
	public override string ToString()
	{
		return this._value;
	}

	// Token: 0x06014F15 RID: 85781 RVA: 0x00550BA7 File Offset: 0x0054EDA7
	public bool Equals(ERoleMuteAudioState other)
	{
		return this._value == other._value;
	}

	// Token: 0x06014F16 RID: 85782 RVA: 0x00550BBC File Offset: 0x0054EDBC
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

	// Token: 0x06014F17 RID: 85783 RVA: 0x00550BE1 File Offset: 0x0054EDE1
	public override int GetHashCode()
	{
		string value = this._value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x06014F18 RID: 85784 RVA: 0x00550BF4 File Offset: 0x0054EDF4
	public static bool operator ==(ERoleMuteAudioState? left, ERoleMuteAudioState? right)
	{
		return left.Equals(right);
	}

	// Token: 0x06014F19 RID: 85785 RVA: 0x00550C09 File Offset: 0x0054EE09
	public static bool operator !=(ERoleMuteAudioState? left, ERoleMuteAudioState? right)
	{
		return !left.Equals(right);
	}

	// Token: 0x06014F1A RID: 85786 RVA: 0x00550C21 File Offset: 0x0054EE21
	public static implicit operator string(ERoleMuteAudioState state)
	{
		return state.ToString();
	}

	// Token: 0x04009D71 RID: 40305
	private readonly string _value;

	// Token: 0x04009D72 RID: 40306
	public static readonly ERoleMuteAudioState None = new ERoleMuteAudioState("none");

	// Token: 0x04009D73 RID: 40307
	public static readonly ERoleMuteAudioState Mute = new ERoleMuteAudioState("mute");
}
