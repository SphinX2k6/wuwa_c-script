using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F97 RID: 16279
	public static class IPhotographTargetRolesOnSceneVerify
	{
		// Token: 0x06017411 RID: 95249 RVA: 0x0035A93E File Offset: 0x00358B3E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
