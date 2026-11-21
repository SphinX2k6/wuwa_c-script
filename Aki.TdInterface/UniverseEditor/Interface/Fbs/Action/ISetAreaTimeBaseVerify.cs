using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200776A RID: 30570
	public static class ISetAreaTimeBaseVerify
	{
		// Token: 0x06035A7A RID: 219770 RVA: 0x00730C1E File Offset: 0x0072EE1E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
