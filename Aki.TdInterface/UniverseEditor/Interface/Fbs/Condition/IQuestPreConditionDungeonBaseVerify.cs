using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CA2 RID: 19618
	public static class IQuestPreConditionDungeonBaseVerify
	{
		// Token: 0x0601F1EC RID: 127468 RVA: 0x00458E02 File Offset: 0x00457002
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
