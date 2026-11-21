using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004543 RID: 17731
	public static class ISaveNewVerify
	{
		// Token: 0x06019AD3 RID: 105171 RVA: 0x003A7F06 File Offset: 0x003A6106
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
