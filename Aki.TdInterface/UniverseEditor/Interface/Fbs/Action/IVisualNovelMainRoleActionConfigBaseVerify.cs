using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D81 RID: 32129
	public static class IVisualNovelMainRoleActionConfigBaseVerify
	{
		// Token: 0x06039FFD RID: 237565 RVA: 0x007D1BCE File Offset: 0x007CFDCE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
