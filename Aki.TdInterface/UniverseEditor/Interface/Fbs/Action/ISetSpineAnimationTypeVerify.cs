using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007841 RID: 30785
	public static class ISetSpineAnimationTypeVerify
	{
		// Token: 0x06036238 RID: 221752 RVA: 0x0074098A File Offset: 0x0073EB8A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
