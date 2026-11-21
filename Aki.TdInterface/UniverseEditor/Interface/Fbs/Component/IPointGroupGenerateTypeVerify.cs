using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D69 RID: 23913
	public static class IPointGroupGenerateTypeVerify
	{
		// Token: 0x06027CF6 RID: 163062 RVA: 0x005722E6 File Offset: 0x005704E6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
