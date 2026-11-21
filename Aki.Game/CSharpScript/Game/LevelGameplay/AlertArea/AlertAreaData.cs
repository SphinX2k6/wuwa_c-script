using System;

namespace CSharpScript.Game.LevelGamePlay.AlertArea
{
	// Token: 0x020060E3 RID: 24803
	public class AlertAreaData
	{
		// Token: 0x0603B786 RID: 243590 RVA: 0x010D58FB File Offset: 0x010D3AFB
		public AlertAreaData(float MinAlertValue, float MaxAlertValue)
		{
			this.MinAlertValue = MinAlertValue;
			this.MaxAlertValue = MaxAlertValue;
		}

		// Token: 0x0401F5B4 RID: 128436
		public float MinAlertValue;

		// Token: 0x0401F5B5 RID: 128437
		public float MaxAlertValue;

		// Token: 0x0401F5B6 RID: 128438
		public float AlertValue;

		// Token: 0x0401F5B7 RID: 128439
		public bool AlertUiEnabled;

		// Token: 0x0401F5B8 RID: 128440
		public bool AlertUiVisible;
	}
}
