using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004635 RID: 17973
	public static class IAddAllRoleVerify
	{
		// Token: 0x0601B386 RID: 111494 RVA: 0x003E004A File Offset: 0x003DE24A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
