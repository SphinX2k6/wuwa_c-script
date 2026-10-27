using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CBC RID: 23740
	public static class TTargetGearGroupSuccessConditionVerify
	{
		// Token: 0x06028A42 RID: 166466 RVA: 0x00595968 File Offset: 0x00593B68
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISuccessConditionCountDownStateVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISuccessConditionSameArbitraryStateVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISuccessConditionSameSpecificStateVerify.Verify(verifier, tablePos);
				break;
			case 4:
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
