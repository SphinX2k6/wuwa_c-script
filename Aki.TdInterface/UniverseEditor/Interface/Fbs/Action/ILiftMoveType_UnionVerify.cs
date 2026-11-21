using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070C0 RID: 28864
	public static class ILiftMoveType_UnionVerify
	{
		// Token: 0x060321FC RID: 205308 RVA: 0x006C872C File Offset: 0x006C692C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ILiftMoveTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILiftMoveTypeDefaultVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILiftMoveTypeTeleportVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ILiftMoveTypeCustomSpeedVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ILiftMoveTypeCircularVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
