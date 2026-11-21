using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005180 RID: 20864
	public static class IPlayerAttributeTypeVerify
	{
		// Token: 0x06020D50 RID: 134480 RVA: 0x0048B6E6 File Offset: 0x004898E6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
