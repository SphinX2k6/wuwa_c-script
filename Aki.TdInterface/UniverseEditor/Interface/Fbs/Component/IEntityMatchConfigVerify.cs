using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056FC RID: 22268
	public static class IEntityMatchConfigVerify
	{
		// Token: 0x06023BF8 RID: 146424 RVA: 0x004EA066 File Offset: 0x004E8266
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
