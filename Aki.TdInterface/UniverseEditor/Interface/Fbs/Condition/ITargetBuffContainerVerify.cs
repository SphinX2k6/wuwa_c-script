using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051E3 RID: 20963
	public static class ITargetBuffContainerVerify
	{
		// Token: 0x06021038 RID: 135224 RVA: 0x00490542 File Offset: 0x0048E742
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
