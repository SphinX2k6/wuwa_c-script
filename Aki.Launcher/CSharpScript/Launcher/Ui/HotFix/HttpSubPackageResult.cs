using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000E6 RID: 230
	[NullableContext(2)]
	[Nullable(0)]
	public class HttpSubPackageResult
	{
		// Token: 0x0400047D RID: 1149
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public int code;

		// Token: 0x0400047E RID: 1150
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public long userId;

		// Token: 0x0400047F RID: 1151
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public List<int> needConfirmQuestIdSet;

		// Token: 0x04000480 RID: 1152
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public List<int> finishQuestIdSet;

		// Token: 0x04000481 RID: 1153
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public List<int> currentBlockIdSet;

		// Token: 0x04000482 RID: 1154
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public List<uint> mp4FinishQuestFlag;

		// Token: 0x04000483 RID: 1155
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public int sex;

		// Token: 0x04000484 RID: 1156
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ResourcePackagePositionData> positions;

		// Token: 0x04000485 RID: 1157
		public int curRecallId;
	}
}
