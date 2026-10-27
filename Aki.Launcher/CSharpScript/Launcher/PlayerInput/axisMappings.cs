using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.PlayerInput
{
	// Token: 0x0200011D RID: 285
	[NullableContext(1)]
	[Nullable(0)]
	public static class axisMappings
	{
		// Token: 0x06000925 RID: 2341 RVA: 0x00041D24 File Offset: 0x0003FF24
		public static bool HasField(string fieldName)
		{
			return typeof(axisMappings).GetField(fieldName) != null;
		}

		// Token: 0x04000559 RID: 1369
		public const string 手柄右摇杆垂直方向 = "手柄右摇杆垂直方向";

		// Token: 0x0400055A RID: 1370
		public const string 手柄左摇杆垂直方向 = "手柄左摇杆垂直方向";
	}
}
