using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DAC RID: 28076
	public static class IPresentationTypeVerify
	{
		// Token: 0x0603198A RID: 203146 RVA: 0x006B8882 File Offset: 0x006B6A82
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
