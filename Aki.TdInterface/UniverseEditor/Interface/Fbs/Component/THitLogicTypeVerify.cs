using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C35 RID: 23605
	public static class THitLogicTypeVerify
	{
		// Token: 0x06028796 RID: 165782 RVA: 0x0059196C File Offset: 0x0058FB6C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IHitLogicActionByHitTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IHitLogicChangeByPartHitVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IHitLogicChangeCountDownStateVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IHitLogicChangeLockStateVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IHitLogicChangeNextAndLockTargetStateVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IHitLogicChangeNextStateVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IHitLogicChangeTargetStateVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
