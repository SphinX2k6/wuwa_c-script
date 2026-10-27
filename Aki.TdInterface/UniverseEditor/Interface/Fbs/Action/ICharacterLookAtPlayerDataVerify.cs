using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200634B RID: 25419
	public static class ICharacterLookAtPlayerDataVerify
	{
		// Token: 0x0602BF7F RID: 180095 RVA: 0x0060ADB6 File Offset: 0x00608FB6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
