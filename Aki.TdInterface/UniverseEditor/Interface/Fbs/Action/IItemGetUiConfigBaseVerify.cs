using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200706F RID: 28783
	public static class IItemGetUiConfigBaseVerify
	{
		// Token: 0x06031E94 RID: 204436 RVA: 0x006C1526 File Offset: 0x006BF726
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
