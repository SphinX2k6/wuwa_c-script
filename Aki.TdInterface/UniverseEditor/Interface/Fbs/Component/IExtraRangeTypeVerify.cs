using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005780 RID: 22400
	public static class IExtraRangeTypeVerify
	{
		// Token: 0x06024211 RID: 147985 RVA: 0x004F7CBA File Offset: 0x004F5EBA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
