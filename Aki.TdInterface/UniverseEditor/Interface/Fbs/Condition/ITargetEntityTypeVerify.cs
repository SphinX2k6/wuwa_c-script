using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CF3 RID: 19699
	public static class ITargetEntityTypeVerify
	{
		// Token: 0x0601F441 RID: 128065 RVA: 0x0045CCF6 File Offset: 0x0045AEF6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
