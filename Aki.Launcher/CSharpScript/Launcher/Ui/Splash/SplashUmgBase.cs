using System;

namespace CSharpScript.Launcher.Ui.Splash
{
	// Token: 0x020000C5 RID: 197
	public abstract class SplashUmgBase
	{
		// Token: 0x06000687 RID: 1671 RVA: 0x00037D56 File Offset: 0x00035F56
		public void Init()
		{
			this.OnCreateWidget();
			this.OnShow();
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00037D64 File Offset: 0x00035F64
		public void Destroy()
		{
			this.OnDestroy();
		}

		// Token: 0x06000689 RID: 1673
		protected abstract void OnCreateWidget();

		// Token: 0x0600068A RID: 1674
		protected abstract void OnShow();

		// Token: 0x0600068B RID: 1675
		protected abstract void OnDestroy();
	}
}
