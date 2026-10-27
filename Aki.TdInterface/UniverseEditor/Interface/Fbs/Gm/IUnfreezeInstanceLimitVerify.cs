using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046CB RID: 18123
	public static class IUnfreezeInstanceLimitVerify
	{
		// Token: 0x0601B8DA RID: 112858 RVA: 0x003E8B96 File Offset: 0x003E6D96
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
