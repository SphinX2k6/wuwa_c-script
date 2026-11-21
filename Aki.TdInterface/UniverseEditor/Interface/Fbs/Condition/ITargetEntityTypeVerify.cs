using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051EF RID: 20975
	public static class ITargetEntityTypeVerify
	{
		// Token: 0x06021086 RID: 135302 RVA: 0x00490C46 File Offset: 0x0048EE46
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
