using System;
using System.Runtime.CompilerServices;

// Token: 0x02001BCF RID: 7119
[NullableContext(1)]
[Nullable(0)]
public readonly struct ERacingBetsAudioState : IEquatable<ERacingBetsAudioState>
{
	// Token: 0x06011BD4 RID: 72660 RVA: 0x0053A5F0 File Offset: 0x005387F0
	private ERacingBetsAudioState(string value)
	{
		this._Value = value;
	}

	// Token: 0x06011BD5 RID: 72661 RVA: 0x0053A5F9 File Offset: 0x005387F9
	public override string ToString()
	{
		return this._Value;
	}

	// Token: 0x06011BD6 RID: 72662 RVA: 0x0053A601 File Offset: 0x00538801
	public bool Equals(ERacingBetsAudioState other)
	{
		return this._Value == other._Value;
	}

	// Token: 0x06011BD7 RID: 72663 RVA: 0x0053A614 File Offset: 0x00538814
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

	// Token: 0x06011BD8 RID: 72664 RVA: 0x0053A639 File Offset: 0x00538839
	public override int GetHashCode()
	{
		string value = this._Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x06011BD9 RID: 72665 RVA: 0x0053A64C File Offset: 0x0053884C
	public static bool operator ==(ERacingBetsAudioState left, ERacingBetsAudioState right)
	{
		return left.Equals(right);
	}

	// Token: 0x06011BDA RID: 72666 RVA: 0x0053A656 File Offset: 0x00538856
	public static bool operator !=(ERacingBetsAudioState left, ERacingBetsAudioState right)
	{
		return !left.Equals(right);
	}

	// Token: 0x04009AE3 RID: 39651
	private readonly string _Value;

	// Token: 0x04009AE4 RID: 39652
	public static readonly ERacingBetsAudioState None = new ERacingBetsAudioState("none");

	// Token: 0x04009AE5 RID: 39653
	public static readonly ERacingBetsAudioState RaceGroupStage = new ERacingBetsAudioState("race_groupstage");

	// Token: 0x04009AE6 RID: 39654
	public static readonly ERacingBetsAudioState RaceFinals = new ERacingBetsAudioState("race_finals");

	// Token: 0x04009AE7 RID: 39655
	public static readonly ERacingBetsAudioState RaceMatchPoint = new ERacingBetsAudioState("race_matchpoint");

	// Token: 0x04009AE8 RID: 39656
	public static readonly ERacingBetsAudioState Complete = new ERacingBetsAudioState("complete");
}
