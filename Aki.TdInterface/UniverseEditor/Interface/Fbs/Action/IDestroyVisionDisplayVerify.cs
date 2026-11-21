using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C16 RID: 27670
	public static class IDestroyVisionDisplayVerify
	{
		// Token: 0x0602F9F6 RID: 195062 RVA: 0x0067D326 File Offset: 0x0067B526
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
