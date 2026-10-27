using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200688A RID: 26762
	public static class IGetRewardByInteractVerify
	{
		// Token: 0x0602EAC5 RID: 191173 RVA: 0x0065D32E File Offset: 0x0065B52E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
