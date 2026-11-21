using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007904 RID: 30980
	public static class ISlashAndTowerGotoNextFloorVerify
	{
		// Token: 0x060368C3 RID: 223427 RVA: 0x0074D336 File Offset: 0x0074B536
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
