using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050E0 RID: 20704
	public static class IDynamicEntityRewardTypeVerify
	{
		// Token: 0x06021546 RID: 136518 RVA: 0x004A0FA6 File Offset: 0x0049F1A6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
