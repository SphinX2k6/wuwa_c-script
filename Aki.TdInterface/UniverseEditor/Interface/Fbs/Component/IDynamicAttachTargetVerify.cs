using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005639 RID: 22073
	public static class IDynamicAttachTargetVerify
	{
		// Token: 0x060233FA RID: 144378 RVA: 0x004D9992 File Offset: 0x004D7B92
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
