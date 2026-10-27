using System;
using System.Runtime.CompilerServices;

// Token: 0x020010FE RID: 4350
public class ArtemisQteGameInfo
{
	// Token: 0x06007153 RID: 29011 RVA: 0x00172501 File Offset: 0x00170701
	public void CreateRingInfo(EArrowDirection arrowDirection)
	{
		this.RingInfo = new ArtemisQteRingInfo(arrowDirection);
	}

	// Token: 0x06007154 RID: 29012 RVA: 0x0017250F File Offset: 0x0017070F
	[NullableContext(1)]
	public ArtemisQteRingInfo GetRingInfo()
	{
		return this.RingInfo;
	}

	// Token: 0x06007155 RID: 29013 RVA: 0x00172517 File Offset: 0x00170717
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

	// Token: 0x06007156 RID: 29014 RVA: 0x0017254D File Offset: 0x0017074D
	public void SetGameStage(EArtemisQteStage stage)
	{
		this.GameStage = stage;
	}

	// Token: 0x06007157 RID: 29015 RVA: 0x00172556 File Offset: 0x00170756
	public EArtemisQteStage GetGameStage()
	{
		return this.GameStage;
	}

	// Token: 0x06007158 RID: 29016 RVA: 0x0017255E File Offset: 0x0017075E
	public bool IsGamePause()
	{
		return this.GameStage != EArtemisQteStage.OnGoing;
	}

	// Token: 0x06007159 RID: 29017 RVA: 0x0017256C File Offset: 0x0017076C
	public bool IsGameEnd()
	{
		return this.GameStage >= EArtemisQteStage.End;
	}

	// Token: 0x04003491 RID: 13457
	[Nullable(2)]
	private ArtemisQteRingInfo RingInfo;

	// Token: 0x04003492 RID: 13458
	private EArtemisQteStage GameStage;

	// Token: 0x04003493 RID: 13459
	public int CurrentScore;

	// Token: 0x04003494 RID: 13460
	public int CurrentRound;

	// Token: 0x04003495 RID: 13461
	public int MaxRound;

	// Token: 0x04003496 RID: 13462
	public float CursorSpeed;

	// Token: 0x04003497 RID: 13463
	public float RingSpeed;

	// Token: 0x04003498 RID: 13464
	public float PerfectAppearRate;
}
