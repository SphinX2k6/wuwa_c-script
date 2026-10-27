using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070F9 RID: 28921
	public static class IShowTalkCameraMotion_UnionVerify
	{
		// Token: 0x06033442 RID: 209986 RVA: 0x006E98E8 File Offset: 0x006E7AE8
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
