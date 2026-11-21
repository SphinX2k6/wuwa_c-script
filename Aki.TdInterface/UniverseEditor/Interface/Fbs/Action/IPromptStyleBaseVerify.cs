using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007542 RID: 30018
	public static class IPromptStyleBaseVerify
	{
		// Token: 0x06034A46 RID: 215622 RVA: 0x00715216 File Offset: 0x00713416
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
