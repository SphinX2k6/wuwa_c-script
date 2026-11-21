using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007955 RID: 31061
	public static class ISplineMoveDriveModeVerify
	{
		// Token: 0x06036B3F RID: 224063 RVA: 0x00751B7E File Offset: 0x0074FD7E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
