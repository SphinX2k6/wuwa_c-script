using System;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x02000240 RID: 576
	public class LaunchLanguageDefineConfig
	{
		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x0005644D File Offset: 0x0005464D
		public int LanguageType { get; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000E89 RID: 3721 RVA: 0x00056455 File Offset: 0x00054655
		public bool IsShow { get; }

		// Token: 0x06000E8A RID: 3722 RVA: 0x0005645D File Offset: 0x0005465D
		public LaunchLanguageDefineConfig(int languageType, bool isShow)
		{
			this.LanguageType = languageType;
			this.IsShow = isShow;
		}
	}
}
