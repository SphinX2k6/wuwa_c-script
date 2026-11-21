using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070DB RID: 28891
	public static class ILimitPlayerOption_UnionVerify
	{
		// Token: 0x060322C5 RID: 205509 RVA: 0x006C9BE8 File Offset: 0x006C7DE8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ILimitPlayerOptionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILimitPlayerMoveVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILimitPlayerActionVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ILimitPlayerCameraVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ILimitPlayerMouseVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ILimitPlayerMoveNewVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = ILimitPlayerUIVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = ILimitPlayerBlockAllVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
