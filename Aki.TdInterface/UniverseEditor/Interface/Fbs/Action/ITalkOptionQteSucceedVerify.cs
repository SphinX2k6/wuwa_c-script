using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B23 RID: 31523
	public static class ITalkOptionQteSucceedVerify
	{
		// Token: 0x06038C2C RID: 232492 RVA: 0x007AD27E File Offset: 0x007AB47E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
