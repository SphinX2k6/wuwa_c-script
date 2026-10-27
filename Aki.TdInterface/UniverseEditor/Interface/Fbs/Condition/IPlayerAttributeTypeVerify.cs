using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C87 RID: 19591
	public static class IPlayerAttributeTypeVerify
	{
		// Token: 0x0601F12E RID: 127278 RVA: 0x00457B96 File Offset: 0x00455D96
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
