using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007117 RID: 28951
	public static class ILiveParamConfigVerify
	{
		// Token: 0x060324B4 RID: 206004 RVA: 0x006CCFE6 File Offset: 0x006CB1E6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
