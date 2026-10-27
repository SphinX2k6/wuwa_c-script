using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02006E2F RID: 28207
	public class FishingQteGameInfo
	{
		// Token: 0x06044C24 RID: 281636 RVA: 0x010F787B File Offset: 0x010F5A7B
		public void CreateRingInfo(EArrowDirection arrowDirection)
		{
			this.RingInfo = new FishingQteRingInfo(arrowDirection);
		}

		// Token: 0x06044C25 RID: 281637 RVA: 0x010F7889 File Offset: 0x010F5A89
		[NullableContext(1)]
		public FishingQteRingInfo GetRingInfo()
		{
			return this.RingInfo;
		}

		// Token: 0x06044C26 RID: 281638 RVA: 0x010F7891 File Offset: 0x010F5A91
		public void Clear()
		{
			FishingQteRingInfo ringInfo = this.RingInfo;
			if (ringInfo != null)
			{
				ringInfo.Clear();
			}
			this.RingInfo = null;
			this.GameStage = EFishingQteStage.None;
			this.CurrentScore = 0f;
			this.CurrentRound = 0;
			this.MaxRound = 0;
		}

		// Token: 0x06044C27 RID: 281639 RVA: 0x010F78CB File Offset: 0x010F5ACB
		public void SetGameStage(EFishingQteStage stage)
		{
			this.GameStage = stage;
			EventSystem.Instance.Emit<EFishingQteStage>(EEventName.OnFishingQteStageUpdate, this.GameStage);
		}

		// Token: 0x06044C28 RID: 281640 RVA: 0x010F78EA File Offset: 0x010F5AEA
		public EFishingQteStage GetGameStage()
		{
			return this.GameStage;
		}

		// Token: 0x06044C29 RID: 281641 RVA: 0x010F78F2 File Offset: 0x010F5AF2
		public bool IsGamePause()
		{
			return this.GameStage != EFishingQteStage.OnGoing;
		}

		// Token: 0x06044C2A RID: 281642 RVA: 0x010F7900 File Offset: 0x010F5B00
		public bool IsGameEnd()
		{
			return this.GameStage >= EFishingQteStage.End;
		}

		// Token: 0x04023C54 RID: 146516
		[Nullable(2)]
		private FishingQteRingInfo RingInfo;

		// Token: 0x04023C55 RID: 146517
		private EFishingQteStage GameStage;

		// Token: 0x04023C56 RID: 146518
		public float CurrentScore;

		// Token: 0x04023C57 RID: 146519
		public int CurrentRound;

		// Token: 0x04023C58 RID: 146520
		public int MaxRound;

		// Token: 0x04023C59 RID: 146521
		public float CursorSpeed;

		// Token: 0x04023C5A RID: 146522
		public float RingSpeed;

		// Token: 0x04023C5B RID: 146523
		public float PerfectAppearRate;
	}
}
