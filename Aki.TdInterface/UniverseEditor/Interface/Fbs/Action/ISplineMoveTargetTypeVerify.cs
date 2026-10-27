using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007192 RID: 29074
	public static class ISplineMoveTargetTypeVerify
	{
		// Token: 0x060338C9 RID: 211145 RVA: 0x006F16A6 File Offset: 0x006EF8A6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
