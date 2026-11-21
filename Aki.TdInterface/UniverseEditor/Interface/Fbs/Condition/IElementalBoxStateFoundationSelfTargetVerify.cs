using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050ED RID: 20717
	public static class IElementalBoxStateFoundationSelfTargetVerify
	{
		// Token: 0x060208D8 RID: 133336 RVA: 0x004840B3 File Offset: 0x004822B3
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
