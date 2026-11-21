using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045E2 RID: 17890
	public static class ITakePhoto2SuccessCameraBehaviorBase_UnionVerify
	{
		// Token: 0x0601A21A RID: 107034 RVA: 0x003B9018 File Offset: 0x003B7218
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITakePhoto2SuccessCameraBehaviorBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITakePhoto2KeepCameraOpenVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITakePhoto2CloseCameraAfterFinishActionsVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
