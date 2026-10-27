using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004969 RID: 18793
	public static class IAllPlayerTypeVerify
	{
		// Token: 0x0601D4A1 RID: 119969 RVA: 0x00421C8E File Offset: 0x0041FE8E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
