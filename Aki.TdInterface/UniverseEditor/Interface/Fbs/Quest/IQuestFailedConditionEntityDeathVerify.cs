using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FDF RID: 16351
	public static class IQuestFailedConditionEntityDeathVerify
	{
		// Token: 0x06017884 RID: 96388 RVA: 0x00364EF1 File Offset: 0x003630F1
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
