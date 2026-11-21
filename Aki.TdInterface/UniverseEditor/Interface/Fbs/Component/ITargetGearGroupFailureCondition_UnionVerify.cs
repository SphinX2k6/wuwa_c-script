using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006040 RID: 24640
	public static class ITargetGearGroupFailureCondition_UnionVerify
	{
		// Token: 0x06029987 RID: 170375 RVA: 0x005ADBFC File Offset: 0x005ABDFC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITargetGearGroupFailureConditionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFailureConditionArbitraryStateVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFailureConditionSequentialStateVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IFailureConditionHitTargetEntityVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
