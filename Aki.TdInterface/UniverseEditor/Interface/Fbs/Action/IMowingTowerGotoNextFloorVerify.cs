using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072BF RID: 29375
	public static class IMowingTowerGotoNextFloorVerify
	{
		// Token: 0x06033360 RID: 209760 RVA: 0x006E8E82 File Offset: 0x006E7082
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
