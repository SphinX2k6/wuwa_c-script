using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006708 RID: 26376
	public static class IActorFaceExpressionTypeVerify
	{
		// Token: 0x0602CAA6 RID: 182950 RVA: 0x0061C856 File Offset: 0x0061AA56
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
