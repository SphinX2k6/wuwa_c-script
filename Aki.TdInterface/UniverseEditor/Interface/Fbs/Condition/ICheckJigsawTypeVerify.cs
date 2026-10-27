using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AB9 RID: 19129
	public static class ICheckJigsawTypeVerify
	{
		// Token: 0x0601E07B RID: 123003 RVA: 0x00436F0E File Offset: 0x0043510E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
