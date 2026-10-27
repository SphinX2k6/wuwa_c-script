using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000E7 RID: 231
	[NullableContext(2)]
	[Nullable(0)]
	public class SubPackageHttpData
	{
		// Token: 0x04000486 RID: 1158
		public long UserId;

		// Token: 0x04000487 RID: 1159
		public List<int> NeedConfirmQuestIdSet;

		// Token: 0x04000488 RID: 1160
		public List<int> FinishQuestIdSet;

		// Token: 0x04000489 RID: 1161
		public List<int> CurrentBlockIdSet;

		// Token: 0x0400048A RID: 1162
		public List<uint> Mp4FinishQuestFlag;

		// Token: 0x0400048B RID: 1163
		public int Sex;

		// Token: 0x0400048C RID: 1164
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ResourcePackagePositionData> Positions;

		// Token: 0x0400048D RID: 1165
		public int CurRecallId;
	}
}
