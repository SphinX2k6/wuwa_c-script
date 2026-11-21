using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075A8 RID: 30120
	public static class IReignsChangePlayerNameVerify
	{
		// Token: 0x06034D64 RID: 216420 RVA: 0x0071A651 File Offset: 0x00718851
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
