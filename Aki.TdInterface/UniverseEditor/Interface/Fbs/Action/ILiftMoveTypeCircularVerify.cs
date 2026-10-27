using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A04 RID: 27140
	public static class ILiftMoveTypeCircularVerify
	{
		// Token: 0x0602F7DA RID: 194522 RVA: 0x00677A2E File Offset: 0x00675C2E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
