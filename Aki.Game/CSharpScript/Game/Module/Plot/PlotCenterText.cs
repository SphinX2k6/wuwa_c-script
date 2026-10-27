using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FE6 RID: 20454
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotCenterText
	{
		// Token: 0x0603459C RID: 214428 RVA: 0x00C4D738 File Offset: 0x00C4B938
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

		// Token: 0x0603459D RID: 214429 RVA: 0x00C4D790 File Offset: 0x00C4B990
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

		// Token: 0x0401BD7B RID: 114043
		public string Text;

		// Token: 0x0401BD7C RID: 114044
		[Nullable(1)]
		public string AudioId;

		// Token: 0x0401BD7D RID: 114045
		public bool AutoClose;

		// Token: 0x0401BD7E RID: 114046
		public IUniversalTone UniversalTone;

		// Token: 0x0401BD7F RID: 114047
		public IPostAkEventType TalkAkEvent;

		// Token: 0x0401BD80 RID: 114048
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x0401BD81 RID: 114049
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public OneOf<ShowCenterText, IShowCenterTextParams>? Config;

		// Token: 0x0401BD82 RID: 114050
		public Action Callback;
	}
}
