using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FC6 RID: 32710
	public static class TShowTalkCameraMotionVerify
	{
		// Token: 0x0603AE7C RID: 241276 RVA: 0x007E9DA0 File Offset: 0x007E7FA0
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
