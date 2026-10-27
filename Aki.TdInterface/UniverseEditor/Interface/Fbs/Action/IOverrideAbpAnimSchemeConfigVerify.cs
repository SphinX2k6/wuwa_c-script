using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C53 RID: 27731
	public static class IOverrideAbpAnimSchemeConfigVerify
	{
		// Token: 0x06030DBA RID: 200122 RVA: 0x006A2F50 File Offset: 0x006A1150
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
