using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005134 RID: 20788
	public static class IElementalMatchBaseVerify
	{
		// Token: 0x0602187F RID: 137343 RVA: 0x004A7D86 File Offset: 0x004A5F86
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
