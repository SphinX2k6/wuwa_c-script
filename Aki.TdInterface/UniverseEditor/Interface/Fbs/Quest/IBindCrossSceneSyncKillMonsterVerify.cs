using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004147 RID: 16711
	public static class IBindCrossSceneSyncKillMonsterVerify
	{
		// Token: 0x06016F60 RID: 94048 RVA: 0x00346A8D File Offset: 0x00344C8D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
