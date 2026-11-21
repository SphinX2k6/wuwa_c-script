using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BC8 RID: 27592
	public static class IDeadeyeFollowShooterConfigVerify
	{
		// Token: 0x0602F7F9 RID: 194553 RVA: 0x0067A251 File Offset: 0x00678451
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
