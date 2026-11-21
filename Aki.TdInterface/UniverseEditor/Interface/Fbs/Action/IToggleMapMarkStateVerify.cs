using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BFB RID: 31739
	public static class IToggleMapMarkStateVerify
	{
		// Token: 0x0603935F RID: 234335 RVA: 0x007BA90A File Offset: 0x007B8B0A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
