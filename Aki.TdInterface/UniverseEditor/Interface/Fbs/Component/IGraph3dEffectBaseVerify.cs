using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005311 RID: 21265
	public static class IGraph3dEffectBaseVerify
	{
		// Token: 0x06022BD7 RID: 142295 RVA: 0x004D0362 File Offset: 0x004CE562
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
