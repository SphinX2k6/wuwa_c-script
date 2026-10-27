using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060F1 RID: 24817
	public static class IActorLookAtUnLockVerify
	{
		// Token: 0x0602A65B RID: 173659 RVA: 0x005D7732 File Offset: 0x005D5932
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
