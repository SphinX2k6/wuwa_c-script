using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004A9D RID: 19101
	public static class IAddAllRoleVerify
	{
		// Token: 0x0601CB5B RID: 117595 RVA: 0x0040C2E6 File Offset: 0x0040A4E6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
