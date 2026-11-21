using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079C1 RID: 31169
	public static class IStopNewMoveWithSplineTypeVerify
	{
		// Token: 0x06036EAD RID: 224941 RVA: 0x0075801A File Offset: 0x0075621A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
