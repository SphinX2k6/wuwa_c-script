using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200513A RID: 20794
	public static class IElementalRangeTypeBaseVerify
	{
		// Token: 0x060218A1 RID: 137377 RVA: 0x004A808A File Offset: 0x004A628A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
