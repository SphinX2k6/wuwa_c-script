using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000EA RID: 234
	[NullableContext(2)]
	[Nullable(0)]
	public class SubPackageHttpData
	{
		// Token: 0x040004B5 RID: 1205
		public long UserId;

		// Token: 0x040004B6 RID: 1206
		public List<int> NeedConfirmQuestIdSet;

		// Token: 0x040004B7 RID: 1207
		public List<int> FinishQuestIdSet;

		// Token: 0x040004B8 RID: 1208
		public List<int> CurrentBlockIdSet;

		// Token: 0x040004B9 RID: 1209
		public List<uint> Mp4FinishQuestFlag;

		// Token: 0x040004BA RID: 1210
		public int Sex;

		// Token: 0x040004BB RID: 1211
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ResourcePackagePositionData> Positions;

		// Token: 0x040004BC RID: 1212
		public int CurRecallId;
	}
}
