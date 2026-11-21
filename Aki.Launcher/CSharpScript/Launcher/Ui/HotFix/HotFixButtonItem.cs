using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000CE RID: 206
	public class HotFixButtonItem : LaunchComponentsAction
	{
		// Token: 0x060006C7 RID: 1735 RVA: 0x00039F44 File Offset: 0x00038144
		protected override void OnStart()
		{
			base.GetButton(0).OnClickCallBack.Bind(new Action(this.OnClickCallback));
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00039F63 File Offset: 0x00038163
		protected override void OnBeforeDestroy()
		{
			if (this.Callback != null)
			{
				this.Callback = null;
			}
			base.GetButton(0).OnClickCallBack.Unbind();
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00039F85 File Offset: 0x00038185
		[NullableContext(1)]
		public void BindClickCallback(Action callback)
		{
			this.Callback = callback;
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00039F8E File Offset: 0x0003818E
		private void OnClickCallback()
		{
			if (this.Callback != null)
			{
				this.Callback();
			}
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00039FA3 File Offset: 0x000381A3
		[NullableContext(2)]
		public void SetLocalText(string tableId)
		{
			HotFixManager.SetLocalText(base.GetText(1), tableId, Array.Empty<string>());
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00039FB7 File Offset: 0x000381B7
		public void SetEnableClick(bool state)
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(state);
		}

		// Token: 0x04000437 RID: 1079
		[Nullable(2)]
		public Action Callback = delegate()
		{
		};

		// Token: 0x0200036D RID: 877
		private class EComponents
		{
			// Token: 0x040011C6 RID: 4550
			public const int Button = 0;

			// Token: 0x040011C7 RID: 4551
			public const int Text = 1;

			// Token: 0x040011C8 RID: 4552
			public const int Icon = 2;
		}
	}
}
