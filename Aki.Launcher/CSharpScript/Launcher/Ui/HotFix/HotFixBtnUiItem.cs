using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000CD RID: 205
	public class HotFixBtnUiItem : LaunchComponentsAction
	{
		// Token: 0x060006C1 RID: 1729 RVA: 0x00039ECD File Offset: 0x000380CD
		protected override void OnStart()
		{
			base.GetButton(0).OnClickCallBack.Bind(new Action(this.OnClickCallback));
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00039EEC File Offset: 0x000380EC
		protected override void OnBeforeDestroy()
		{
			if (this.Callback != null)
			{
				this.Callback = null;
			}
			base.GetButton(0).OnClickCallBack.Unbind();
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00039F0E File Offset: 0x0003810E
		[NullableContext(1)]
		public void SetText([Nullable(2)] string tableId, params string[] args)
		{
			HotFixManager.SetLocalText(base.GetText(1), tableId, args);
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00039F1E File Offset: 0x0003811E
		[NullableContext(1)]
		public void BindClickCallback(Action callback)
		{
			this.Callback = callback;
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00039F27 File Offset: 0x00038127
		protected void OnClickCallback()
		{
			if (this.Callback != null)
			{
				this.Callback();
			}
		}

		// Token: 0x04000436 RID: 1078
		[Nullable(2)]
		public Action Callback;

		// Token: 0x0200036C RID: 876
		private static class EComponents
		{
			// Token: 0x040011C3 RID: 4547
			public const int Button = 0;

			// Token: 0x040011C4 RID: 4548
			public const int Text = 1;

			// Token: 0x040011C5 RID: 4549
			public const int RedDot = 2;
		}
	}
}
