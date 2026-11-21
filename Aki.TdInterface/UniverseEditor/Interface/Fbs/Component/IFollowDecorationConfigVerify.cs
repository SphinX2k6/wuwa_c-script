using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057FB RID: 22523
	public static class IFollowDecorationConfigVerify
	{
		// Token: 0x060246CB RID: 149195 RVA: 0x005015D6 File Offset: 0x004FF7D6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
