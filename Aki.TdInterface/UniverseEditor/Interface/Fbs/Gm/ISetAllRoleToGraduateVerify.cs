using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200468C RID: 18060
	public static class ISetAllRoleToGraduateVerify
	{
		// Token: 0x0601B6B4 RID: 112308 RVA: 0x003E53E2 File Offset: 0x003E35E2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
