using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AE7 RID: 19175
	public class IPlayFlowForGmT
	{
		// Token: 0x17008669 RID: 34409
		// (get) Token: 0x0601CE3C RID: 118332 RVA: 0x00411037 File Offset: 0x0040F237
		// (set) Token: 0x0601CE3D RID: 118333 RVA: 0x0041103F File Offset: 0x0040F23F
		public EGmCommand Type { get; set; }

		// Token: 0x1700866A RID: 34410
		// (get) Token: 0x0601CE3E RID: 118334 RVA: 0x00411048 File Offset: 0x0040F248
		// (set) Token: 0x0601CE3F RID: 118335 RVA: 0x00411050 File Offset: 0x0040F250
		public IPlayFlowT Flow { get; set; }

		// Token: 0x0601CE40 RID: 118336 RVA: 0x00411059 File Offset: 0x0040F259
		public IPlayFlowForGmT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.Flow = null;
		}
	}
}
