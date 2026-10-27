using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007174 RID: 29044
	public static class ISpecialCustomLoadingOptionVerify
	{
		// Token: 0x060337F8 RID: 210936 RVA: 0x006F0046 File Offset: 0x006EE246
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
