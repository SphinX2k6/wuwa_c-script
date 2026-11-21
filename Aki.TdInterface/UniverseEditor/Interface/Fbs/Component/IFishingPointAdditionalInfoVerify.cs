using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057CB RID: 22475
	public static class IFishingPointAdditionalInfoVerify
	{
		// Token: 0x0602448A RID: 148618 RVA: 0x004FC59E File Offset: 0x004FA79E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
