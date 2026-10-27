using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F98 RID: 28568
	public static class ISetAlertValueTypeVerify
	{
		// Token: 0x060327D0 RID: 206800 RVA: 0x006D09CA File Offset: 0x006CEBCA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
