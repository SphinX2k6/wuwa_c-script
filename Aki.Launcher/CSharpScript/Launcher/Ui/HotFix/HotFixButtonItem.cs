using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000CB RID: 203
	public class HotFixButtonItem : LaunchComponentsAction
	{
		// Token: 0x060006AB RID: 1707 RVA: 0x00038414 File Offset: 0x00036614
		protected override void OnStart()
		{
			base.GetButton(0).OnClickCallBack.Bind(new Action(this.OnClickCallback));
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00038433 File Offset: 0x00036633
		protected override void OnBeforeDestroy()
		{
			if (this.Callback != null)
			{
				this.Callback = null;
			}
			base.GetButton(0).OnClickCallBack.Unbind();
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00038455 File Offset: 0x00036655
		[NullableContext(1)]
		public void BindClickCallback(Action callback)
		{
			this.Callback = callback;
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x0003845E File Offset: 0x0003665E
		private void OnClickCallback()
		{
			if (this.Callback != null)
			{
				this.Callback();
			}
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00038473 File Offset: 0x00036673
		[NullableContext(2)]
		public void SetLocalText(string tableId)
		{
			HotFixManager.SetLocalText(base.GetText(1), tableId, Array.Empty<string>());
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00038487 File Offset: 0x00036687
		public void SetEnableClick(bool state)
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(state);
		}

		// Token: 0x04000408 RID: 1032
		[Nullable(2)]
		public Action Callback = delegate()
		{
		};

		// Token: 0x02000362 RID: 866
		private class EComponents
		{
			// Token: 0x04001164 RID: 4452
			public const int Button = 0;

			// Token: 0x04001165 RID: 4453
			public const int Text = 1;

			// Token: 0x04001166 RID: 4454
			public const int Icon = 2;
		}
	}
}
