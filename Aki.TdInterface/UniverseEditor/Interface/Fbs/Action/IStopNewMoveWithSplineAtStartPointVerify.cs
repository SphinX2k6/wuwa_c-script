using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079BB RID: 31163
	public static class IStopNewMoveWithSplineAtStartPointVerify
	{
		// Token: 0x06036E85 RID: 224901 RVA: 0x00757CA2 File Offset: 0x00755EA2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
