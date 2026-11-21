using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E0E RID: 28174
	public static class IFadeBackgroundUiPrefabTypeVerify
	{
		// Token: 0x06030A42 RID: 199234 RVA: 0x0069A4BE File Offset: 0x006986BE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
