using System;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006038 RID: 24632
	public class DollDeliveryInfo
	{
		// Token: 0x0603B235 RID: 242229 RVA: 0x010B8E5C File Offset: 0x010B705C
		public DollDeliveryInfo(int itemId, int lightIndex, bool isComplete, bool isLast)
		{
			this.ItemId = itemId;
			this.LightIndex = lightIndex;
			this.IsComplete = isComplete;
			this.IsLast = isLast;
		}

		// Token: 0x0401F1CF RID: 127439
		public int ItemId;

		// Token: 0x0401F1D0 RID: 127440
		public int LightIndex;

		// Token: 0x0401F1D1 RID: 127441
		public bool IsComplete;

		// Token: 0x0401F1D2 RID: 127442
		public bool IsLast;
	}
}
