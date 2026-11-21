using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007292 RID: 29330
	public class IMoveOnWallConfigT
	{
		// Token: 0x1700D700 RID: 55040
		// (get) Token: 0x060331CC RID: 209356 RVA: 0x006E5ADD File Offset: 0x006E3CDD
		// (set) Token: 0x060331CD RID: 209357 RVA: 0x006E5AE5 File Offset: 0x006E3CE5
		public IVectorInfoT WallDetectDir { get; set; }

		// Token: 0x060331CE RID: 209358 RVA: 0x006E5AEE File Offset: 0x006E3CEE
		public IMoveOnWallConfigT()
		{
			this.WallDetectDir = null;
		}
	}
}
