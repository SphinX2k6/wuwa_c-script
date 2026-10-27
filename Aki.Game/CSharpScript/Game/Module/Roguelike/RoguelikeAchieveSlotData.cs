using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DAA RID: 19882
	[NullableContext(2)]
	[Nullable(0)]
	public class RoguelikeAchieveSlotData
	{
		// Token: 0x0603357B RID: 210299 RVA: 0x00BFCD00 File Offset: 0x00BFAF00
		public RoguelikeAchieveSlotData(int slotIndex, RogueArchiveInfoData archiveInfoData)
		{
			this.SlotIndex = slotIndex;
			this.ArchiveInfoData = archiveInfoData;
		}

		// Token: 0x0401B463 RID: 111715
		public int SlotIndex;

		// Token: 0x0401B464 RID: 111716
		public RogueArchiveInfoData ArchiveInfoData;
	}
}
