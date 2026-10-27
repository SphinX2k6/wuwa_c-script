using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053A3 RID: 21411
	public static class IHitLogicTypeVerify
	{
		// Token: 0x0602311B RID: 143643 RVA: 0x004DAE8E File Offset: 0x004D908E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
