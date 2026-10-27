using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200770C RID: 30476
	public static class TLimitPlayOperationVerify
	{
		// Token: 0x06037693 RID: 226963 RVA: 0x00780F50 File Offset: 0x0077F150
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
