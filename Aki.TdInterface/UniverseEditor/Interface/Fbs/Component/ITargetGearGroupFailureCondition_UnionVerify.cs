using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A33 RID: 23091
	public static class ITargetGearGroupFailureCondition_UnionVerify
	{
		// Token: 0x0602740F RID: 160783 RVA: 0x00566C38 File Offset: 0x00564E38
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
