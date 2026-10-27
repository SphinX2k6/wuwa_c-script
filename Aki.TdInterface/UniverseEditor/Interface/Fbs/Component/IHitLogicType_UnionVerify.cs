using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053A6 RID: 21414
	public static class IHitLogicType_UnionVerify
	{
		// Token: 0x06023133 RID: 143667 RVA: 0x004DB0B4 File Offset: 0x004D92B4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IHitLogicTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IHitLogicChangeNextStateVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IHitLogicChangeLockStateVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IHitLogicChangeCountDownStateVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IHitLogicChangeNextAndLockTargetStateVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IHitLogicChangeTargetStateVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IHitLogicChangeByPartHitVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IHitLogicActionByHitTypeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
