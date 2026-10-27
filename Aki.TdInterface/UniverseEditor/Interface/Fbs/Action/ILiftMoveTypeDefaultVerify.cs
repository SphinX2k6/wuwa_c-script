using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A0A RID: 27146
	public static class ILiftMoveTypeDefaultVerify
	{
		// Token: 0x0602F808 RID: 194568 RVA: 0x00677E6E File Offset: 0x0067606E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
