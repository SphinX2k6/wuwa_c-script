using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200783D RID: 30781
	public class ISetSpineAnimationT
	{
		// Token: 0x1700E1D7 RID: 57815
		// (get) Token: 0x06036223 RID: 221731 RVA: 0x007407DD File Offset: 0x0073E9DD
		// (set) Token: 0x06036224 RID: 221732 RVA: 0x007407E5 File Offset: 0x0073E9E5
		public IPlaySpineAnimationT Config { get; set; }

		// Token: 0x06036225 RID: 221733 RVA: 0x007407EE File Offset: 0x0073E9EE
		public ISetSpineAnimationT()
		{
			this.Config = null;
		}
	}
}
