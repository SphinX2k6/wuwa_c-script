using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006345 RID: 25413
	public static class ICharacterLookAtEmptyDataVerify
	{
		// Token: 0x0602BF57 RID: 180055 RVA: 0x0060AA3E File Offset: 0x00608C3E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
