using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004547 RID: 17735
	public static class IRewardConfigVerify
	{
		// Token: 0x0601AAFE RID: 109310 RVA: 0x003CE7B8 File Offset: 0x003CC9B8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
