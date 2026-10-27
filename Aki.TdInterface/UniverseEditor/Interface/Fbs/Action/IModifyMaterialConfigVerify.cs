using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AC0 RID: 27328
	public static class IModifyMaterialConfigVerify
	{
		// Token: 0x0602FE51 RID: 196177 RVA: 0x00683DDA File Offset: 0x00681FDA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
