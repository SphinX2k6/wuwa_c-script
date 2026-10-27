using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043C1 RID: 17345
	public static class IRefSourceVerify
	{
		// Token: 0x06019DCF RID: 105935 RVA: 0x003B3BA6 File Offset: 0x003B1DA6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
