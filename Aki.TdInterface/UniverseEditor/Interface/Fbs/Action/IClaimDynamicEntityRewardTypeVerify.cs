using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069E9 RID: 27113
	public static class IClaimDynamicEntityRewardTypeVerify
	{
		// Token: 0x0602E831 RID: 190513 RVA: 0x006583DE File Offset: 0x006565DE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
