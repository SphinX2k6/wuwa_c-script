using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045EE RID: 17902
	public static class ITakePhoto2TargetCameraDistanceConditionVerify
	{
		// Token: 0x0601A28A RID: 107146 RVA: 0x003B9D16 File Offset: 0x003B7F16
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
