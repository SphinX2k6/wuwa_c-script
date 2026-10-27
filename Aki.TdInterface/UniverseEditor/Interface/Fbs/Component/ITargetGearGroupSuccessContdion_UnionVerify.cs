using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A39 RID: 23097
	public static class ITargetGearGroupSuccessContdion_UnionVerify
	{
		// Token: 0x06027433 RID: 160819 RVA: 0x00566F6C File Offset: 0x0056516C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITargetGearGroupSuccessContdionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISuccessConditionSameSpecificStateVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISuccessConditionSameArbitraryStateVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ISuccessConditionCountDownStateVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ISuccessConditionSpecificTargetStateVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
