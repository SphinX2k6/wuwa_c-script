using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007967 RID: 31079
	public static class ISplineMoveTargetTypeVerify
	{
		// Token: 0x06036BC3 RID: 224195 RVA: 0x007528F2 File Offset: 0x00750AF2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
