using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CEF RID: 27887
	public static class IPlayerBlendAnimTargetVerify
	{
		// Token: 0x060312CC RID: 201420 RVA: 0x006AC03E File Offset: 0x006AA23E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
