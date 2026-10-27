using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x0200479B RID: 18331
	public static class IEntityConfigVerify
	{
		// Token: 0x0601C40C RID: 115724 RVA: 0x003FFFA5 File Offset: 0x003FE1A5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
