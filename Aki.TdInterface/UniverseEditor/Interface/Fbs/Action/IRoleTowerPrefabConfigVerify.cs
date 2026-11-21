using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007683 RID: 30339
	public static class IRoleTowerPrefabConfigVerify
	{
		// Token: 0x06035391 RID: 218001 RVA: 0x007247C6 File Offset: 0x007229C6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
