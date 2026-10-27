using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DA0 RID: 28064
	public static class IPreloadSubLevelsVerify
	{
		// Token: 0x0603193E RID: 203070 RVA: 0x006B80DF File Offset: 0x006B62DF
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfStrings(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
