using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007411 RID: 29713
	public static class IToggleMapMarkStateVerify
	{
		// Token: 0x06035FAC RID: 221100 RVA: 0x00758196 File Offset: 0x00756396
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
