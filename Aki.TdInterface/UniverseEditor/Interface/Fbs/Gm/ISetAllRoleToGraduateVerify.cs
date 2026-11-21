using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AF4 RID: 19188
	public static class ISetAllRoleToGraduateVerify
	{
		// Token: 0x0601CE89 RID: 118409 RVA: 0x0041167E File Offset: 0x0040F87E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
