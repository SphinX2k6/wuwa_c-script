using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004171 RID: 16753
	public static class ICheckPlayerInputBaseVerify
	{
		// Token: 0x060170E2 RID: 94434 RVA: 0x00349896 File Offset: 0x00347A96
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
