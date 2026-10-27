using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007186 RID: 29062
	public static class ISplineMoveDriveModeVerify
	{
		// Token: 0x06033865 RID: 211045 RVA: 0x006F0BEE File Offset: 0x006EEDEE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
