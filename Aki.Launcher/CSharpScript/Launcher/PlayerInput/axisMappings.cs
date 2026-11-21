using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.PlayerInput
{
	// Token: 0x02000121 RID: 289
	[NullableContext(1)]
	[Nullable(0)]
	public static class axisMappings
	{
		// Token: 0x06000959 RID: 2393 RVA: 0x000440EC File Offset: 0x000422EC
		public static bool HasField(string fieldName)
		{
			return typeof(axisMappings).GetField(fieldName) != null;
		}

		// Token: 0x04000594 RID: 1428
		public const string 手柄右摇杆垂直方向 = "手柄右摇杆垂直方向";

		// Token: 0x04000595 RID: 1429
		public const string 手柄左摇杆垂直方向 = "手柄左摇杆垂直方向";
	}
}
