using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005240 RID: 21056
	public static class TConditionDebugDataVerify
	{
		// Token: 0x0602129A RID: 135834 RVA: 0x00494054 File Offset: 0x00492254
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICondition2DebugDataVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IBaseAccessQuestDebugDataVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
