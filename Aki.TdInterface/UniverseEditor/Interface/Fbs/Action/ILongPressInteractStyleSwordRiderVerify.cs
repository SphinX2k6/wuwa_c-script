using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007174 RID: 29044
	public static class ILongPressInteractStyleSwordRiderVerify
	{
		// Token: 0x060327A7 RID: 206759 RVA: 0x006D27DA File Offset: 0x006D09DA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
