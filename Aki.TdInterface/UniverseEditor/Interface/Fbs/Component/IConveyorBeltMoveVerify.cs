using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005594 RID: 21908
	public static class IConveyorBeltMoveVerify
	{
		// Token: 0x06022D7E RID: 142718 RVA: 0x004CCABE File Offset: 0x004CACBE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
