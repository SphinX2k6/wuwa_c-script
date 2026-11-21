using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.AdventureGuide.Views
{
	// Token: 0x02004EBF RID: 20159
	[NullableContext(2)]
	[Nullable(0)]
	public class NewSoundDetectItemData
	{
		// Token: 0x0401AE96 RID: 110230
		public SoundAreaDetectionRecord DetectRecordData;

		// Token: 0x0401AE97 RID: 110231
		public List<int> TracingList;

		// Token: 0x0401AE98 RID: 110232
		public int? NightMareParam = new int?(0);

		// Token: 0x0401AE99 RID: 110233
		public int? JumpToGridId = new int?(0);

		// Token: 0x0401AE9A RID: 110234
		public double? JumpToGridSquenceStartTimeSecond = new double?(0.0);
	}
}
