using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D30 RID: 15664
	public static class IBindCrossSceneSyncKillMonsterVerify
	{
		// Token: 0x06015A28 RID: 88616 RVA: 0x0031F815 File Offset: 0x0031DA15
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
