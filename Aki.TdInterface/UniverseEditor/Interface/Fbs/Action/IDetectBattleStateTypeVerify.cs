using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065B4 RID: 26036
	public static class IDetectBattleStateTypeVerify
	{
		// Token: 0x0602D296 RID: 184982 RVA: 0x00631452 File Offset: 0x0062F652
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
