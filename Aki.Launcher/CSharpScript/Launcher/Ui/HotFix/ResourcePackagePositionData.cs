using System;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000E8 RID: 232
	public class ResourcePackagePositionData
	{
		// Token: 0x040004A8 RID: 1192
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public int instanceId;

		// Token: 0x040004A9 RID: 1193
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public double x;

		// Token: 0x040004AA RID: 1194
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public double y;

		// Token: 0x040004AB RID: 1195
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public double z;
	}
}
