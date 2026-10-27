using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D44 RID: 19780
	public static class TConditionDebugDataVerify
	{
		// Token: 0x0601F651 RID: 128593 RVA: 0x00460080 File Offset: 0x0045E280
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
