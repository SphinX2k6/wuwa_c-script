using System;

namespace CSharpScript.Launcher.Ui.Splash
{
	// Token: 0x020000C8 RID: 200
	public abstract class SplashUmgBase
	{
		// Token: 0x060006A3 RID: 1699 RVA: 0x00039886 File Offset: 0x00037A86
		public void Init()
		{
			this.OnCreateWidget();
			this.OnShow();
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00039894 File Offset: 0x00037A94
		public void Destroy()
		{
			this.OnDestroy();
		}

		// Token: 0x060006A5 RID: 1701
		protected abstract void OnCreateWidget();

		// Token: 0x060006A6 RID: 1702
		protected abstract void OnShow();

		// Token: 0x060006A7 RID: 1703
		protected abstract void OnDestroy();
	}
}
