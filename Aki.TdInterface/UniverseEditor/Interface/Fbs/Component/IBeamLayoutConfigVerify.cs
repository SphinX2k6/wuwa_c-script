using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F06 RID: 20230
	public static class IBeamLayoutConfigVerify
	{
		// Token: 0x0601FF93 RID: 130963 RVA: 0x0047329A File Offset: 0x0047149A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
