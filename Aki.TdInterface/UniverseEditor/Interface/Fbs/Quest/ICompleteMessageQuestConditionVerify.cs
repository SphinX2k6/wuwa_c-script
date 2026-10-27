using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DAB RID: 15787
	public static class ICompleteMessageQuestConditionVerify
	{
		// Token: 0x06015F3D RID: 89917 RVA: 0x0032B892 File Offset: 0x00329A92
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
