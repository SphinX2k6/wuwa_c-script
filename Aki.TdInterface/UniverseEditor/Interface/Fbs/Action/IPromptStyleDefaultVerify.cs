using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200754E RID: 30030
	public static class IPromptStyleDefaultVerify
	{
		// Token: 0x06034A8E RID: 215694 RVA: 0x00715846 File Offset: 0x00713A46
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
