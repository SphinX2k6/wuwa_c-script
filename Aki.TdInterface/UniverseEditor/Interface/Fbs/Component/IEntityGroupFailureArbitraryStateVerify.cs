using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056E4 RID: 22244
	public static class IEntityGroupFailureArbitraryStateVerify
	{
		// Token: 0x06023B1C RID: 146204 RVA: 0x004E86A7 File Offset: 0x004E68A7
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
