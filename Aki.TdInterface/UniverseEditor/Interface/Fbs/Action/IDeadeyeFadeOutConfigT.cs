using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BC4 RID: 27588
	public class IDeadeyeFadeOutConfigT
	{
		// Token: 0x1700CA6E RID: 51822
		// (get) Token: 0x0602F7E2 RID: 194530 RVA: 0x0067A07E File Offset: 0x0067827E
		// (set) Token: 0x0602F7E3 RID: 194531 RVA: 0x0067A086 File Offset: 0x00678286
		public float TransitionTime { get; set; }

		// Token: 0x0602F7E4 RID: 194532 RVA: 0x0067A08F File Offset: 0x0067828F
		public IDeadeyeFadeOutConfigT()
		{
			this.TransitionTime = 0f;
		}
	}
}
