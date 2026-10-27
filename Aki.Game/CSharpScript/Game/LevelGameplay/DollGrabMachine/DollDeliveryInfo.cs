using System;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006EB8 RID: 28344
	public class DollDeliveryInfo
	{
		// Token: 0x06045094 RID: 282772 RVA: 0x0110ED80 File Offset: 0x0110CF80
		public DollDeliveryInfo(int itemId, int lightIndex, bool isComplete, bool isLast)
		{
			this.ItemId = itemId;
			this.LightIndex = lightIndex;
			this.IsComplete = isComplete;
			this.IsLast = isLast;
		}

		// Token: 0x04023F1C RID: 147228
		public int ItemId;

		// Token: 0x04023F1D RID: 147229
		public int LightIndex;

		// Token: 0x04023F1E RID: 147230
		public bool IsComplete;

		// Token: 0x04023F1F RID: 147231
		public bool IsLast;
	}
}
