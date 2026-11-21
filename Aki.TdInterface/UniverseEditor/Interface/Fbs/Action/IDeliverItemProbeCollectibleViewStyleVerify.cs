using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BE0 RID: 27616
	public static class IDeliverItemProbeCollectibleViewStyleVerify
	{
		// Token: 0x0602F88B RID: 194699 RVA: 0x0067AF8E File Offset: 0x0067918E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
