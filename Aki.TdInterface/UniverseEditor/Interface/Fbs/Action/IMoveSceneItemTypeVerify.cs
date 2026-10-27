using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B59 RID: 27481
	public static class IMoveSceneItemTypeVerify
	{
		// Token: 0x060303D2 RID: 197586 RVA: 0x0068DF7A File Offset: 0x0068C17A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
