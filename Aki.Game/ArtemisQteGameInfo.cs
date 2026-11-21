using System;
using System.Runtime.CompilerServices;

// Token: 0x020005B2 RID: 1458
public class ArtemisQteGameInfo
{
	// Token: 0x060044E9 RID: 17641 RVA: 0x0017AEBD File Offset: 0x001790BD
	public void CreateRingInfo(EArrowDirection arrowDirection)
	{
		this.RingInfo = new ArtemisQteRingInfo(arrowDirection);
	}

	// Token: 0x060044EA RID: 17642 RVA: 0x0017AECB File Offset: 0x001790CB
	[NullableContext(1)]
	public ArtemisQteRingInfo GetRingInfo()
	{
		return this.RingInfo;
	}

	// Token: 0x060044EB RID: 17643 RVA: 0x0017AED3 File Offset: 0x001790D3
	public void Clear()
	{
		ArtemisQteRingInfo ringInfo = this.RingInfo;
		if (ringInfo != null)
		{
			ringInfo.Clear();
		}
		this.RingInfo = null;
		this.GameStage = EArtemisQteStage.None;
		this.CurrentScore = 0;
		this.CurrentRound = 0;
		this.MaxRound = 0;
	}

	// Token: 0x060044EC RID: 17644 RVA: 0x0017AF09 File Offset: 0x00179109
	public void SetGameStage(EArtemisQteStage stage)
	{
		this.GameStage = stage;
	}

	// Token: 0x060044ED RID: 17645 RVA: 0x0017AF12 File Offset: 0x00179112
	public EArtemisQteStage GetGameStage()
	{
		return this.GameStage;
	}

	// Token: 0x060044EE RID: 17646 RVA: 0x0017AF1A File Offset: 0x0017911A
	public bool IsGamePause()
	{
		return this.GameStage != EArtemisQteStage.OnGoing;
	}

	// Token: 0x060044EF RID: 17647 RVA: 0x0017AF28 File Offset: 0x00179128
	public bool IsGameEnd()
	{
		return this.GameStage >= EArtemisQteStage.End;
	}

	// Token: 0x0400352A RID: 13610
	[Nullable(2)]
	private ArtemisQteRingInfo RingInfo;

	// Token: 0x0400352B RID: 13611
	private EArtemisQteStage GameStage;

	// Token: 0x0400352C RID: 13612
	public int CurrentScore;

	// Token: 0x0400352D RID: 13613
	public int CurrentRound;

	// Token: 0x0400352E RID: 13614
	public int MaxRound;

	// Token: 0x0400352F RID: 13615
	public float CursorSpeed;

	// Token: 0x04003530 RID: 13616
	public float RingSpeed;

	// Token: 0x04003531 RID: 13617
	public float PerfectAppearRate;
}
