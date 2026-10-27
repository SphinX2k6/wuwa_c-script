using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074FE RID: 29950
	public static class IVehicleControlType_UnionVerify
	{
		// Token: 0x06036756 RID: 223062 RVA: 0x00765E0C File Offset: 0x0076400C
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
