using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x020039F5 RID: 14837
	public static class EntityValueVerify
	{
		// Token: 0x06014108 RID: 82184 RVA: 0x002F02F2 File Offset: 0x002EE4F2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
