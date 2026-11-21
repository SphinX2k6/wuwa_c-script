using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077FC RID: 30716
	public static class ISetNpcGroupPerformTypeVerify
	{
		// Token: 0x06035F68 RID: 221032 RVA: 0x0073A80E File Offset: 0x00738A0E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
