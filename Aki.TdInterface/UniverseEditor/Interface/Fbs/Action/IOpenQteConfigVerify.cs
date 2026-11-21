using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007384 RID: 29572
	public static class IOpenQteConfigVerify
	{
		// Token: 0x06033A22 RID: 211490 RVA: 0x006F5C9E File Offset: 0x006F3E9E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
