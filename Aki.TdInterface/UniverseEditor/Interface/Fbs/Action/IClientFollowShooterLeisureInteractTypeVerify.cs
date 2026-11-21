using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A3D RID: 27197
	public static class IClientFollowShooterLeisureInteractTypeVerify
	{
		// Token: 0x0602EA6D RID: 191085 RVA: 0x0065C29A File Offset: 0x0065A49A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
