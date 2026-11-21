using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E63 RID: 32355
	public static class TCameraOperationVerify
	{
		// Token: 0x0603A722 RID: 239394 RVA: 0x007DE6D4 File Offset: 0x007DC8D4
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
