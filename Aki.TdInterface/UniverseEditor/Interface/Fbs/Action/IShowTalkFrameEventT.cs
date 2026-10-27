using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070FB RID: 28923
	public class IShowTalkFrameEventT
	{
		// Token: 0x1700D704 RID: 55044
		// (get) Token: 0x06033453 RID: 210003 RVA: 0x006E9B97 File Offset: 0x006E7D97
		// (set) Token: 0x06033454 RID: 210004 RVA: 0x006E9B9F File Offset: 0x006E7D9F
		public ISequenceFrameEventT FrameEvent { get; set; }

		// Token: 0x1700D705 RID: 55045
		// (get) Token: 0x06033455 RID: 210005 RVA: 0x006E9BA8 File Offset: 0x006E7DA8
		// (set) Token: 0x06033456 RID: 210006 RVA: 0x006E9BB0 File Offset: 0x006E7DB0
		public IShowTalkFrameEventPositionT Position { get; set; }

		// Token: 0x06033457 RID: 210007 RVA: 0x006E9BB9 File Offset: 0x006E7DB9
		public IShowTalkFrameEventT()
		{
			this.FrameEvent = null;
			this.Position = null;
		}
	}
}
