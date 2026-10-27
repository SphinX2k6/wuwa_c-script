using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005164 RID: 20836
	public static class IEntityBatchTypeVerify
	{
		// Token: 0x06021A4D RID: 137805 RVA: 0x004AB47E File Offset: 0x004A967E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
