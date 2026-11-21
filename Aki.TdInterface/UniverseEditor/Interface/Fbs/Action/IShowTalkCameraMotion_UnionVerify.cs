using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078C5 RID: 30917
	public static class IShowTalkCameraMotion_UnionVerify
	{
		// Token: 0x060366E4 RID: 222948 RVA: 0x00749EF4 File Offset: 0x007480F4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IShowTalkCameraMotionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IShowTalkCameraMotionPresetVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IShowTalkCameraMotionTweenVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
