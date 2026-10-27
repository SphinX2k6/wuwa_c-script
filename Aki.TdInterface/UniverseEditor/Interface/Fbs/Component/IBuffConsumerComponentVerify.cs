using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F30 RID: 20272
	public static class IBuffConsumerComponentVerify
	{
		// Token: 0x06020161 RID: 131425 RVA: 0x00476D04 File Offset: 0x00474F04
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 8UL, 8UL, false) && verifier.VerifyField(tablePos, 8, 8UL, 8UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
