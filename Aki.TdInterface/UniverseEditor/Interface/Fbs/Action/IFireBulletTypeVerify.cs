using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E41 RID: 28225
	public static class IFireBulletTypeVerify
	{
		// Token: 0x06030C14 RID: 199700 RVA: 0x0069E0EE File Offset: 0x0069C2EE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
