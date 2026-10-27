using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D24 RID: 15652
	public static class IAttributeToTargetVerify
	{
		// Token: 0x060159A2 RID: 88482 RVA: 0x0031E662 File Offset: 0x0031C862
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
