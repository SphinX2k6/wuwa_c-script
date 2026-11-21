using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000E9 RID: 233
	[NullableContext(2)]
	[Nullable(0)]
	public class HttpSubPackageResult
	{
		// Token: 0x040004AC RID: 1196
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public int code;

		// Token: 0x040004AD RID: 1197
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public long userId;

		// Token: 0x040004AE RID: 1198
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public List<int> needConfirmQuestIdSet;

		// Token: 0x040004AF RID: 1199
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public List<int> finishQuestIdSet;

		// Token: 0x040004B0 RID: 1200
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public List<int> currentBlockIdSet;

		// Token: 0x040004B1 RID: 1201
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public List<uint> mp4FinishQuestFlag;

		// Token: 0x040004B2 RID: 1202
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public int sex;

		// Token: 0x040004B3 RID: 1203
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ResourcePackagePositionData> positions;

		// Token: 0x040004B4 RID: 1204
		public int curRecallId;
	}
}
