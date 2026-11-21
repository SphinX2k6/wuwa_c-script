using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AA0 RID: 23200
	public static class ILookAtTargetPlayerVerify
	{
		// Token: 0x06026076 RID: 155766 RVA: 0x0053626E File Offset: 0x0053446E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
