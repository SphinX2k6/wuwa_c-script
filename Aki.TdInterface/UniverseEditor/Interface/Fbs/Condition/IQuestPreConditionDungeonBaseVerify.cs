using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200519B RID: 20891
	public static class IQuestPreConditionDungeonBaseVerify
	{
		// Token: 0x06020E0E RID: 134670 RVA: 0x0048C952 File Offset: 0x0048AB52
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
