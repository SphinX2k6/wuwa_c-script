using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064DF RID: 25823
	public static class IControlTrackingTypeVerify
	{
		// Token: 0x0602CCB7 RID: 183479 RVA: 0x00627BEA File Offset: 0x00625DEA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
