using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200778E RID: 30606
	public static class TShowTalkCameraMotionVerify
	{
		// Token: 0x06037901 RID: 227585 RVA: 0x007848A0 File Offset: 0x00782AA0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IShowTalkCameraMotionTweenVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IShowTalkCameraMotionPresetVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
