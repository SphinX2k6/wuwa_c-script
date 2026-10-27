using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E60 RID: 28256
	public static class IRemovePreloadResourceCharacterTypeVerify
	{
		// Token: 0x06031EE3 RID: 204515 RVA: 0x006C1596 File Offset: 0x006BF796
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
