using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CE1 RID: 19681
	public static class ITargetAttributeVerify
	{
		// Token: 0x0601F3D5 RID: 127957 RVA: 0x0045C37E File Offset: 0x0045A57E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
