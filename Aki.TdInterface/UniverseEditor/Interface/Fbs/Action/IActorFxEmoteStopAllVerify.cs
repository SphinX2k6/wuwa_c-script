using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060B8 RID: 24760
	public static class IActorFxEmoteStopAllVerify
	{
		// Token: 0x0602A46B RID: 173163 RVA: 0x005D3DDA File Offset: 0x005D1FDA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
