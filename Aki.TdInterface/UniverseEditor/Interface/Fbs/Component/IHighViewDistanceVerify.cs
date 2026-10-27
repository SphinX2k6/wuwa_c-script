using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200536A RID: 21354
	public static class IHighViewDistanceVerify
	{
		// Token: 0x06022F19 RID: 143129 RVA: 0x004D6BE6 File Offset: 0x004D4DE6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
