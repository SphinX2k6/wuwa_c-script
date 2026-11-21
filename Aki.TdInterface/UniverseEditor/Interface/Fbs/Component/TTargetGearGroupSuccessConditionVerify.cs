using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062ED RID: 25325
	public static class TTargetGearGroupSuccessConditionVerify
	{
		// Token: 0x0602B08A RID: 176266 RVA: 0x005DE0DC File Offset: 0x005DC2DC
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
