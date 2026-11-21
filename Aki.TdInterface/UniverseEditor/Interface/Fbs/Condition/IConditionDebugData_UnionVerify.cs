using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050D2 RID: 20690
	public static class IConditionDebugData_UnionVerify
	{
		// Token: 0x060207DC RID: 133084 RVA: 0x0047FAA8 File Offset: 0x0047DCA8
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
