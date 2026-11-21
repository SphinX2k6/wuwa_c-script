using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02005493 RID: 21651
	public struct RecycleTrailSettleEvent
	{
		// Token: 0x06035B6B RID: 220011 RVA: 0x00F02789 File Offset: 0x00F00989
		public RecycleTrailSettleEvent(int chargerCount, int hourglassCount, int turnGain)
		{
			this.ChargerCount = chargerCount;
			this.HourglassCount = hourglassCount;
			this.TurnGain = turnGain;
		}

		// Token: 0x0401C6E8 RID: 116456
		public int ChargerCount;

		// Token: 0x0401C6E9 RID: 116457
		public int HourglassCount;

		// Token: 0x0401C6EA RID: 116458
		public int TurnGain;
	}
}
