using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BE5 RID: 19429
	public static class IConditionDebugData_UnionVerify
	{
		// Token: 0x0601EBF6 RID: 125942 RVA: 0x0044C83C File Offset: 0x0044AA3C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IConditionDebugDataVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IBaseAccessQuestDebugDataVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICondition2DebugDataVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
