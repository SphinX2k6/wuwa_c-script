using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B79 RID: 27513
	public static class IMowingTowerGotoNextFloorVerify
	{
		// Token: 0x06030508 RID: 197896 RVA: 0x00690862 File Offset: 0x0068EA62
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
