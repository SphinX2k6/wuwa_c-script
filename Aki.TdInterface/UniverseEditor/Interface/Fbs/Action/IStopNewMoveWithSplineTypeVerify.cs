using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071EC RID: 29164
	public static class IStopNewMoveWithSplineTypeVerify
	{
		// Token: 0x06033BAB RID: 211883 RVA: 0x006F6CBA File Offset: 0x006F4EBA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
