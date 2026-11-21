using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051B0 RID: 20912
	public static class IRoleLevelTypeVerify
	{
		// Token: 0x06020EBE RID: 134846 RVA: 0x0048DCDE File Offset: 0x0048BEDE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
