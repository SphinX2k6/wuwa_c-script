using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068C3 RID: 26819
	public static class IHandInHandInitiatorTypeVerify
	{
		// Token: 0x0602EC7D RID: 191613 RVA: 0x006627CE File Offset: 0x006609CE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
