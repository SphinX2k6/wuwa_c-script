using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C43 RID: 31811
	public static class ITransitionPopupStyleVerify
	{
		// Token: 0x06039575 RID: 234869 RVA: 0x007BE23E File Offset: 0x007BC43E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
