using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007450 RID: 29776
	public static class ITransitionPopupStyleVerify
	{
		// Token: 0x0603618C RID: 221580 RVA: 0x0075B512 File Offset: 0x00759712
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
