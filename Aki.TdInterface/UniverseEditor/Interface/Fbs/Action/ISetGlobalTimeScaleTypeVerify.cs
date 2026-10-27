using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FFA RID: 28666
	public static class ISetGlobalTimeScaleTypeVerify
	{
		// Token: 0x06032B4F RID: 207695 RVA: 0x006D783A File Offset: 0x006D5A3A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
