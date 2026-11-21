using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041F5 RID: 16885
	public static class IDarkTideMechaAssemblyBossEventVerify
	{
		// Token: 0x060176F3 RID: 95987 RVA: 0x003591E6 File Offset: 0x003573E6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
