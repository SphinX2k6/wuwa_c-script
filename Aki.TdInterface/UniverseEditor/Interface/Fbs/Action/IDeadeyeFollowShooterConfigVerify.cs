using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006557 RID: 25943
	public static class IDeadeyeFollowShooterConfigVerify
	{
		// Token: 0x0602D03D RID: 184381 RVA: 0x0062DA8D File Offset: 0x0062BC8D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
