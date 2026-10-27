using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.AdventureGuide.Views
{
	// Token: 0x02005ED8 RID: 24280
	[NullableContext(2)]
	[Nullable(0)]
	public class NewSoundDetectItemData
	{
		// Token: 0x040203C5 RID: 132037
		public SoundAreaDetectionRecord DetectRecordData;

		// Token: 0x040203C6 RID: 132038
		public List<int> TracingList;

		// Token: 0x040203C7 RID: 132039
		public int? NightMareParam = new int?(0);

		// Token: 0x040203C8 RID: 132040
		public int? JumpToGridId = new int?(0);

		// Token: 0x040203C9 RID: 132041
		public double? JumpToGridSquenceStartTimeSecond = new double?(0.0);
	}
}
