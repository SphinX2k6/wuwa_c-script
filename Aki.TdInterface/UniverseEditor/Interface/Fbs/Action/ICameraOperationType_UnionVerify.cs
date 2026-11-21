using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006909 RID: 26889
	public static class ICameraOperationType_UnionVerify
	{
		// Token: 0x0602E105 RID: 188677 RVA: 0x0064B7DC File Offset: 0x006499DC
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
