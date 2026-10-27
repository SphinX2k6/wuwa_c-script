using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050AC RID: 20652
	public class IDollGrabStageAudioStateT
	{
		// Token: 0x17009617 RID: 38423
		// (get) Token: 0x060212DD RID: 135901 RVA: 0x0049C2AA File Offset: 0x0049A4AA
		// (set) Token: 0x060212DE RID: 135902 RVA: 0x0049C2B2 File Offset: 0x0049A4B2
		public string Group { get; set; }

		// Token: 0x17009618 RID: 38424
		// (get) Token: 0x060212DF RID: 135903 RVA: 0x0049C2BB File Offset: 0x0049A4BB
		// (set) Token: 0x060212E0 RID: 135904 RVA: 0x0049C2C3 File Offset: 0x0049A4C3
		public string State { get; set; }

		// Token: 0x060212E1 RID: 135905 RVA: 0x0049C2CC File Offset: 0x0049A4CC
		public IDollGrabStageAudioStateT()
		{
			this.Group = null;
			this.State = null;
		}
	}
}
