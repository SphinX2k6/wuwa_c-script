using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060C4 RID: 24772
	public static class IActorFxEmoteTypeVerify
	{
		// Token: 0x0602A4B9 RID: 173241 RVA: 0x005D4552 File Offset: 0x005D2752
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
