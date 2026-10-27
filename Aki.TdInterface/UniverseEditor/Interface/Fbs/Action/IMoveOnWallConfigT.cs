using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B4C RID: 27468
	public class IMoveOnWallConfigT
	{
		// Token: 0x1700CC1B RID: 52251
		// (get) Token: 0x06030375 RID: 197493 RVA: 0x0068D521 File Offset: 0x0068B721
		// (set) Token: 0x06030376 RID: 197494 RVA: 0x0068D529 File Offset: 0x0068B729
		public IVectorInfoT WallDetectDir { get; set; }

		// Token: 0x06030377 RID: 197495 RVA: 0x0068D532 File Offset: 0x0068B732
		public IMoveOnWallConfigT()
		{
			this.WallDetectDir = null;
		}
	}
}
