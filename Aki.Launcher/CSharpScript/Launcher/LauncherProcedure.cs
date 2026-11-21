using System;
using CSharpScript.Launcher.Update;
using CSharpScript.Launcher.Util;

namespace CSharpScript.Launcher
{
	// Token: 0x0200005F RID: 95
	public class LauncherProcedure
	{
		// Token: 0x0600029D RID: 669 RVA: 0x0000D93F File Offset: 0x0000BB3F
		public static void Init()
		{
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000D941 File Offset: 0x0000BB41
		public static void Destroy()
		{
			AppLinks.Instance.Destroy();
			LauncherAudio.Instance.Destroy();
			PakKeyUpdate.Instance.Destroy();
		}
	}
}
