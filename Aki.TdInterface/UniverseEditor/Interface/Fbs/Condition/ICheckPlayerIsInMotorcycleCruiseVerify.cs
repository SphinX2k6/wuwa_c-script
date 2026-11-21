using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FCD RID: 20429
	public static class ICheckPlayerIsInMotorcycleCruiseVerify
	{
		// Token: 0x0601FDAA RID: 130474 RVA: 0x0046C828 File Offset: 0x0046AA28
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
