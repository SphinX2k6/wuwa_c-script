using System;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x02000245 RID: 581
	public class LaunchLanguageDefineConfig
	{
		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x00058F91 File Offset: 0x00057191
		public int LanguageType { get; }

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x00058F99 File Offset: 0x00057199
		public bool IsShow { get; }

		// Token: 0x06000ECB RID: 3787 RVA: 0x00058FA1 File Offset: 0x000571A1
		public LaunchLanguageDefineConfig(int languageType, bool isShow)
		{
			this.LanguageType = languageType;
			this.IsShow = isShow;
		}
	}
}
