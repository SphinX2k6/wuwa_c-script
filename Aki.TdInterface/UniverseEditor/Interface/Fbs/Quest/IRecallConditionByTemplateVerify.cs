using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004081 RID: 16513
	public static class IRecallConditionByTemplateVerify
	{
		// Token: 0x0601805A RID: 98394 RVA: 0x003772E0 File Offset: 0x003754E0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyVectorOfStrings(tablePos, 8, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
