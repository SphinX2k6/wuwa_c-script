using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007943 RID: 31043
	public static class ISpecialCustomLoadingOptionVerify
	{
		// Token: 0x06036AD2 RID: 223954 RVA: 0x00750FD6 File Offset: 0x0074F1D6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
