using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B41 RID: 31553
	public static class ITargetVehicleVerify
	{
		// Token: 0x06038D30 RID: 232752 RVA: 0x007AF22A File Offset: 0x007AD42A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
