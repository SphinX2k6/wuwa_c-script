using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EFF RID: 28415
	public static class IRoleTowerPrefabConfigVerify
	{
		// Token: 0x06032351 RID: 205649 RVA: 0x006C8A92 File Offset: 0x006C6C92
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
