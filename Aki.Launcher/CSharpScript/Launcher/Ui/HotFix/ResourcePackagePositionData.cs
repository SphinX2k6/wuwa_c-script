using System;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000E5 RID: 229
	public class ResourcePackagePositionData
	{
		// Token: 0x04000479 RID: 1145
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public int instanceId;

		// Token: 0x0400047A RID: 1146
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public double x;

		// Token: 0x0400047B RID: 1147
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public double y;

		// Token: 0x0400047C RID: 1148
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
		public double z;
	}
}
