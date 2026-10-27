using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055EC RID: 21996
	public static class INavMeshSourceTypeBaseVerify
	{
		// Token: 0x060247E4 RID: 149476 RVA: 0x00509816 File Offset: 0x00507A16
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
