using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EFA RID: 24314
	public static class ISceneTextTypeBaseVerify
	{
		// Token: 0x06028CA5 RID: 167077 RVA: 0x005932DE File Offset: 0x005914DE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
