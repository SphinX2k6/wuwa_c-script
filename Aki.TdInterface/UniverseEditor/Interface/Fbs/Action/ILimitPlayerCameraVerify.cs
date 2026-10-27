using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A19 RID: 27161
	public static class ILimitPlayerCameraVerify
	{
		// Token: 0x0602F872 RID: 194674 RVA: 0x0067887A File Offset: 0x00676A7A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
