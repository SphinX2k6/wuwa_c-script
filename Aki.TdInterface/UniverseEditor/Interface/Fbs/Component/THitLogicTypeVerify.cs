using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200625A RID: 25178
	public static class THitLogicTypeVerify
	{
		// Token: 0x0602ADA4 RID: 175524 RVA: 0x005D9B84 File Offset: 0x005D7D84
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
