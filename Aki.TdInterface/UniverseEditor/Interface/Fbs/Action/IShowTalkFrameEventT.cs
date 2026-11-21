using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078C7 RID: 30919
	public class IShowTalkFrameEventT
	{
		// Token: 0x1700E2E7 RID: 58087
		// (get) Token: 0x060366F5 RID: 222965 RVA: 0x0074A1A3 File Offset: 0x007483A3
		// (set) Token: 0x060366F6 RID: 222966 RVA: 0x0074A1AB File Offset: 0x007483AB
		public ISequenceFrameEventT FrameEvent { get; set; }

		// Token: 0x1700E2E8 RID: 58088
		// (get) Token: 0x060366F7 RID: 222967 RVA: 0x0074A1B4 File Offset: 0x007483B4
		// (set) Token: 0x060366F8 RID: 222968 RVA: 0x0074A1BC File Offset: 0x007483BC
		public IShowTalkFrameEventPositionT Position { get; set; }

		// Token: 0x060366F9 RID: 222969 RVA: 0x0074A1C5 File Offset: 0x007483C5
		public IShowTalkFrameEventT()
		{
			this.FrameEvent = null;
			this.Position = null;
		}
	}
}
