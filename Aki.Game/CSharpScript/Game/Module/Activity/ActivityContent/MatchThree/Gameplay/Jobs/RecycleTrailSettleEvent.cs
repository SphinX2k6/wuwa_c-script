using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02006515 RID: 25877
	public struct RecycleTrailSettleEvent
	{
		// Token: 0x06040EA7 RID: 265895 RVA: 0x00FBB759 File Offset: 0x00FB9959
		public RecycleTrailSettleEvent(int chargerCount, int hourglassCount, int turnGain)
		{
			this.ChargerCount = chargerCount;
			this.HourglassCount = hourglassCount;
			this.TurnGain = turnGain;
		}

		// Token: 0x04021DB7 RID: 138679
		public int ChargerCount;

		// Token: 0x04021DB8 RID: 138680
		public int HourglassCount;

		// Token: 0x04021DB9 RID: 138681
		public int TurnGain;
	}
}
