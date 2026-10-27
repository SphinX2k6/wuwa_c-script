using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005762 RID: 22370
	public static class IPointGroupGenerateTypeVerify
	{
		// Token: 0x060257D6 RID: 153558 RVA: 0x0052C15A File Offset: 0x0052A35A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
