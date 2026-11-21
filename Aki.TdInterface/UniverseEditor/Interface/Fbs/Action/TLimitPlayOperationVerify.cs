using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F20 RID: 32544
	public static class TLimitPlayOperationVerify
	{
		// Token: 0x0603AB60 RID: 240480 RVA: 0x007E545C File Offset: 0x007E365C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ILimitPlayerActionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILimitPlayerBlockAllVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILimitPlayerCameraVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ILimitPlayerMouseVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ILimitPlayerMoveVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ILimitPlayerMoveNewVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = ILimitPlayerUIVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
