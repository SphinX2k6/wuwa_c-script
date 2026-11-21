using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F1D RID: 32541
	public static class TLiftMoveTypeVerify
	{
		// Token: 0x0603AB4A RID: 240458 RVA: 0x007E5238 File Offset: 0x007E3438
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ILiftMoveTypeCircularVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILiftMoveTypeCustomSpeedVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILiftMoveTypeDefaultVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ILiftMoveTypeTeleportVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
