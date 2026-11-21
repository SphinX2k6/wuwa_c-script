using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FB0 RID: 16304
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotCenterText
	{
		// Token: 0x06029425 RID: 168997 RVA: 0x00B97780 File Offset: 0x00B95980
		public PlotCenterText()
		{
			this.Text = "";
			this.AudioId = "";
			this.AutoClose = false;
			this.UniversalTone = null;
			this.TalkAkEvent = null;
			this.TalkEndAkEvent = null;
			this.Config = null;
			this.Callback = null;
		}

		// Token: 0x06029426 RID: 168998 RVA: 0x00B977D8 File Offset: 0x00B959D8
		public void Clear()
		{
			this.Text = null;
			this.AudioId = "";
			this.AutoClose = false;
			this.UniversalTone = null;
			this.TalkAkEvent = null;
			this.Config = null;
			this.Callback = null;
		}

		// Token: 0x04016756 RID: 91990
		public string Text;

		// Token: 0x04016757 RID: 91991
		[Nullable(1)]
		public string AudioId;

		// Token: 0x04016758 RID: 91992
		public bool AutoClose;

		// Token: 0x04016759 RID: 91993
		public IUniversalTone UniversalTone;

		// Token: 0x0401675A RID: 91994
		public IPostAkEventType TalkAkEvent;

		// Token: 0x0401675B RID: 91995
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x0401675C RID: 91996
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public OneOf<ShowCenterText, IShowCenterTextParams>? Config;

		// Token: 0x0401675D RID: 91997
		public Action Callback;
	}
}
