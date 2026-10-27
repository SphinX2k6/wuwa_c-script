using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005035 RID: 20533
	public static class IConveyorBeltMoveVerify
	{
		// Token: 0x06020E5E RID: 134750 RVA: 0x0049306E File Offset: 0x0049126E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
