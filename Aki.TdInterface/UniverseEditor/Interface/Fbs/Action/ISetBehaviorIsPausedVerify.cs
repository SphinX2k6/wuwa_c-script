using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007794 RID: 30612
	public static class ISetBehaviorIsPausedVerify
	{
		// Token: 0x06035BBD RID: 220093 RVA: 0x00733126 File Offset: 0x00731326
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
