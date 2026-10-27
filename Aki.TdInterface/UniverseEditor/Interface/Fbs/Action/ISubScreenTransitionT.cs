using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007221 RID: 29217
	public class ISubScreenTransitionT
	{
		// Token: 0x1700D8E5 RID: 55525
		// (get) Token: 0x06033D4A RID: 212298 RVA: 0x006F99B7 File Offset: 0x006F7BB7
		// (set) Token: 0x06033D4B RID: 212299 RVA: 0x006F99BF File Offset: 0x006F7BBF
		public float TransitionDuration { get; set; }

		// Token: 0x1700D8E6 RID: 55526
		// (get) Token: 0x06033D4C RID: 212300 RVA: 0x006F99C8 File Offset: 0x006F7BC8
		// (set) Token: 0x06033D4D RID: 212301 RVA: 0x006F99D0 File Offset: 0x006F7BD0
		public string TransitionCurve { get; set; }

		// Token: 0x06033D4E RID: 212302 RVA: 0x006F99D9 File Offset: 0x006F7BD9
		public ISubScreenTransitionT()
		{
			this.TransitionDuration = 0f;
			this.TransitionCurve = null;
		}
	}
}
