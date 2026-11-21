using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006076 RID: 24694
	public static class IThrowMotionVerify
	{
		// Token: 0x06029BAC RID: 170924 RVA: 0x005B28E6 File Offset: 0x005B0AE6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
