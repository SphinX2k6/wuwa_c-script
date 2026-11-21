using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02005FB0 RID: 24496
	public class FishingQteGameInfo
	{
		// Token: 0x0603ADB2 RID: 241074 RVA: 0x010A1F4C File Offset: 0x010A014C
		public void CreateRingInfo(EArrowDirection arrowDirection)
		{
			this.RingInfo = new FishingQteRingInfo(arrowDirection);
		}

		// Token: 0x0603ADB3 RID: 241075 RVA: 0x010A1F5A File Offset: 0x010A015A
		[NullableContext(1)]
		public FishingQteRingInfo GetRingInfo()
		{
			return this.RingInfo;
		}

		// Token: 0x0603ADB4 RID: 241076 RVA: 0x010A1F62 File Offset: 0x010A0162
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

		// Token: 0x0603ADB5 RID: 241077 RVA: 0x010A1F9C File Offset: 0x010A019C
		public void SetGameStage(EFishingQteStage stage)
		{
			this.GameStage = stage;
			EventSystem.Instance.Emit<EFishingQteStage>(EEventName.OnFishingQteStageUpdate, this.GameStage);
		}

		// Token: 0x0603ADB6 RID: 241078 RVA: 0x010A1FBB File Offset: 0x010A01BB
		public EFishingQteStage GetGameStage()
		{
			return this.GameStage;
		}

		// Token: 0x0603ADB7 RID: 241079 RVA: 0x010A1FC3 File Offset: 0x010A01C3
		public bool IsGamePause()
		{
			return this.GameStage != EFishingQteStage.OnGoing;
		}

		// Token: 0x0603ADB8 RID: 241080 RVA: 0x010A1FD1 File Offset: 0x010A01D1
		public bool IsGameEnd()
		{
			return this.GameStage >= EFishingQteStage.End;
		}

		// Token: 0x0401EF09 RID: 126729
		[Nullable(2)]
		private FishingQteRingInfo RingInfo;

		// Token: 0x0401EF0A RID: 126730
		private EFishingQteStage GameStage;

		// Token: 0x0401EF0B RID: 126731
		public float CurrentScore;

		// Token: 0x0401EF0C RID: 126732
		public int CurrentRound;

		// Token: 0x0401EF0D RID: 126733
		public int MaxRound;

		// Token: 0x0401EF0E RID: 126734
		public float CursorSpeed;

		// Token: 0x0401EF0F RID: 126735
		public float RingSpeed;

		// Token: 0x0401EF10 RID: 126736
		public float PerfectAppearRate;
	}
}
