using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A01 RID: 27137
	public static class ILiftMoveTypeVerify
	{
		// Token: 0x0602F7C8 RID: 194504 RVA: 0x006778B6 File Offset: 0x00675AB6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
