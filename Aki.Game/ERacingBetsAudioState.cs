using System;
using System.Runtime.CompilerServices;

// Token: 0x020026E4 RID: 9956
[NullableContext(1)]
[Nullable(0)]
public readonly struct ERacingBetsAudioState : IEquatable<ERacingBetsAudioState>
{
	// Token: 0x060146F2 RID: 83698 RVA: 0x0052B8D4 File Offset: 0x00529AD4
	private ERacingBetsAudioState(string value)
	{
		this._Value = value;
	}

	// Token: 0x060146F3 RID: 83699 RVA: 0x0052B8DD File Offset: 0x00529ADD
	public override string ToString()
	{
		return this._Value;
	}

	// Token: 0x060146F4 RID: 83700 RVA: 0x0052B8E5 File Offset: 0x00529AE5
	public bool Equals(ERacingBetsAudioState other)
	{
		return this._Value == other._Value;
	}

	// Token: 0x060146F5 RID: 83701 RVA: 0x0052B8F8 File Offset: 0x00529AF8
	[NullableContext(2)]
	public override bool Equals(object obj)
	{
		if (obj is ERacingBetsAudioState)
		{
			ERacingBetsAudioState other = (ERacingBetsAudioState)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x060146F6 RID: 83702 RVA: 0x0052B91D File Offset: 0x00529B1D
	public override int GetHashCode()
	{
		string value = this._Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x060146F7 RID: 83703 RVA: 0x0052B930 File Offset: 0x00529B30
	public static bool operator ==(ERacingBetsAudioState left, ERacingBetsAudioState right)
	{
		return left.Equals(right);
	}

	// Token: 0x060146F8 RID: 83704 RVA: 0x0052B93A File Offset: 0x00529B3A
	public static bool operator !=(ERacingBetsAudioState left, ERacingBetsAudioState right)
	{
		return !left.Equals(right);
	}

	// Token: 0x0400998B RID: 39307
	private readonly string _Value;

	// Token: 0x0400998C RID: 39308
	public static readonly ERacingBetsAudioState None = new ERacingBetsAudioState("none");

	// Token: 0x0400998D RID: 39309
	public static readonly ERacingBetsAudioState RaceGroupStage = new ERacingBetsAudioState("race_groupstage");

	// Token: 0x0400998E RID: 39310
	public static readonly ERacingBetsAudioState RaceFinals = new ERacingBetsAudioState("race_finals");

	// Token: 0x0400998F RID: 39311
	public static readonly ERacingBetsAudioState RaceMatchPoint = new ERacingBetsAudioState("race_matchpoint");

	// Token: 0x04009990 RID: 39312
	public static readonly ERacingBetsAudioState Complete = new ERacingBetsAudioState("complete");
}
