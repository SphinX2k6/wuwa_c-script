using System;

namespace CSharpScript.Game.LevelGamePlay.AlertArea
{
	// Token: 0x02006F62 RID: 28514
	public class AlertAreaData
	{
		// Token: 0x060455D8 RID: 284120 RVA: 0x0112BB1B File Offset: 0x01129D1B
		public AlertAreaData(float MinAlertValue, float MaxAlertValue)
		{
			this.MinAlertValue = MinAlertValue;
			this.MaxAlertValue = MaxAlertValue;
		}

		// Token: 0x040242FF RID: 148223
		public float MinAlertValue;

		// Token: 0x04024300 RID: 148224
		public float MaxAlertValue;

		// Token: 0x04024301 RID: 148225
		public float AlertValue;

		// Token: 0x04024302 RID: 148226
		public bool AlertUiEnabled;

		// Token: 0x04024303 RID: 148227
		public bool AlertUiVisible;
	}
}
