using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077C3 RID: 30659
	public static class ISetGlobalTimeScaleTypeVerify
	{
		// Token: 0x06035DB5 RID: 220597 RVA: 0x0073747E File Offset: 0x0073567E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
