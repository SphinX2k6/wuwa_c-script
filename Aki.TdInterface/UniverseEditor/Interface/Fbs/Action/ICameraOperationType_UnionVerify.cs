using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006298 RID: 25240
	public static class ICameraOperationType_UnionVerify
	{
		// Token: 0x0602B9A4 RID: 178596 RVA: 0x006009D4 File Offset: 0x005FEBD4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICameraOperationTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEnableCameraOperationVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEnableSectionalCameraOperationVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IDisableCameraOperationVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
