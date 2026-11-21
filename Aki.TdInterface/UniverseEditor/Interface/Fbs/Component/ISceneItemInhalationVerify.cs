using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ED3 RID: 24275
	public static class ISceneItemInhalationVerify
	{
		// Token: 0x06028B03 RID: 166659 RVA: 0x0058FC22 File Offset: 0x0058DE22
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
