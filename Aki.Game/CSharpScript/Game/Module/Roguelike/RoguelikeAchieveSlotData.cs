using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D73 RID: 15731
	[NullableContext(2)]
	[Nullable(0)]
	public class RoguelikeAchieveSlotData
	{
		// Token: 0x060283E8 RID: 164840 RVA: 0x00B46232 File Offset: 0x00B44432
		public RoguelikeAchieveSlotData(int slotIndex, RogueArchiveInfoData archiveInfoData)
		{
			this.SlotIndex = slotIndex;
			this.ArchiveInfoData = archiveInfoData;
		}

		// Token: 0x04015E36 RID: 89654
		public int SlotIndex;

		// Token: 0x04015E37 RID: 89655
		public RogueArchiveInfoData ArchiveInfoData;
	}
}
