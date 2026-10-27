using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000CA RID: 202
	public class HotFixBtnUiItem : LaunchComponentsAction
	{
		// Token: 0x060006A5 RID: 1701 RVA: 0x0003839D File Offset: 0x0003659D
		protected override void OnStart()
		{
			base.GetButton(0).OnClickCallBack.Bind(new Action(this.OnClickCallback));
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x000383BC File Offset: 0x000365BC
		protected override void OnBeforeDestroy()
		{
			if (this.Callback != null)
			{
				this.Callback = null;
			}
			base.GetButton(0).OnClickCallBack.Unbind();
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x000383DE File Offset: 0x000365DE
		[NullableContext(1)]
		public void SetText([Nullable(2)] string tableId, params string[] args)
		{
			HotFixManager.SetLocalText(base.GetText(1), tableId, args);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x000383EE File Offset: 0x000365EE
		[NullableContext(1)]
		public void BindClickCallback(Action callback)
		{
			this.Callback = callback;
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x000383F7 File Offset: 0x000365F7
		protected void OnClickCallback()
		{
			if (this.Callback != null)
			{
				this.Callback();
			}
		}

		// Token: 0x04000407 RID: 1031
		[Nullable(2)]
		public Action Callback;

		// Token: 0x02000361 RID: 865
		private static class EComponents
		{
			// Token: 0x04001161 RID: 4449
			public const int Button = 0;

			// Token: 0x04001162 RID: 4450
			public const int Text = 1;

			// Token: 0x04001163 RID: 4451
			public const int RedDot = 2;
		}
	}
}
