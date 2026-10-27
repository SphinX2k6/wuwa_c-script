using System;
using CSharpScript.Launcher.Update;
using CSharpScript.Launcher.Util;

namespace CSharpScript.Launcher
{
	// Token: 0x0200005F RID: 95
	public class LauncherProcedure
	{
		// Token: 0x0600029C RID: 668 RVA: 0x0000D61F File Offset: 0x0000B81F
		public static void Init()
		{
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000D621 File Offset: 0x0000B821
		public static void Destroy()
		{
			AppLinks.Instance.Destroy();
			LauncherAudio.Instance.Destroy();
			PakKeyUpdate.Instance.Destroy();
		}
	}
}
