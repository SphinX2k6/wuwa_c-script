using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A10 RID: 27152
	public static class ILiftMoveType_UnionVerify
	{
		// Token: 0x0602F83C RID: 194620 RVA: 0x006783D4 File Offset: 0x006765D4
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
