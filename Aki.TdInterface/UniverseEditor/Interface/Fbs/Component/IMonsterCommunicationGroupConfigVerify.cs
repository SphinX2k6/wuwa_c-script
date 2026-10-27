using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005571 RID: 21873
	public static class IMonsterCommunicationGroupConfigVerify
	{
		// Token: 0x060242EE RID: 148206 RVA: 0x004FF38E File Offset: 0x004FD58E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
