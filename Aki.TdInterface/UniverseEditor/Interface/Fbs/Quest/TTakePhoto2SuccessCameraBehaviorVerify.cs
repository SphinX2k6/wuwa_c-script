using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200477E RID: 18302
	public static class TTakePhoto2SuccessCameraBehaviorVerify
	{
		// Token: 0x0601AF42 RID: 110402 RVA: 0x003D2488 File Offset: 0x003D0688
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITakePhoto2KeepCameraOpenVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITakePhoto2CloseCameraAfterFinishActionsVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
