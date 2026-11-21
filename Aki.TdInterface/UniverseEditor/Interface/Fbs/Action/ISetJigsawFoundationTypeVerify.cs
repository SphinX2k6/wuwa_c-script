using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077D5 RID: 30677
	public static class ISetJigsawFoundationTypeVerify
	{
		// Token: 0x06035E38 RID: 220728 RVA: 0x007384D6 File Offset: 0x007366D6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
