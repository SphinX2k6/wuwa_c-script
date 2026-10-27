using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007655 RID: 30293
	public static class TCameraOperationVerify
	{
		// Token: 0x0603727D RID: 225917 RVA: 0x0077A5D8 File Offset: 0x007787D8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IDisableCameraOperationVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEnableCameraOperationVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEnableSectionalCameraOperationVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
