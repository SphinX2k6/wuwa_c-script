using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007075 RID: 28789
	public static class ISetSpineAnimationTypeVerify
	{
		// Token: 0x06032F97 RID: 208791 RVA: 0x006E03D6 File Offset: 0x006DE5D6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
