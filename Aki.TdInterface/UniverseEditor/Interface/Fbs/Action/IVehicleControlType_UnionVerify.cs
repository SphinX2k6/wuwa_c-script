using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CF4 RID: 31988
	public static class IVehicleControlType_UnionVerify
	{
		// Token: 0x06039B6B RID: 236395 RVA: 0x007C905C File Offset: 0x007C725C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IVehicleControlTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IVehicleEnterPathMoveVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IVehicleExitPathMoveVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
