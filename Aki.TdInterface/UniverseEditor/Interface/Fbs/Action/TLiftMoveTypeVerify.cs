using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007709 RID: 30473
	public static class TLiftMoveTypeVerify
	{
		// Token: 0x0603767D RID: 226941 RVA: 0x00780D2C File Offset: 0x0077EF2C
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
