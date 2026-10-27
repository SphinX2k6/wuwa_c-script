using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D07 RID: 27911
	public static class IPlayerNewSplineMoveTargetVerify
	{
		// Token: 0x06031383 RID: 201603 RVA: 0x006AD402 File Offset: 0x006AB602
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
