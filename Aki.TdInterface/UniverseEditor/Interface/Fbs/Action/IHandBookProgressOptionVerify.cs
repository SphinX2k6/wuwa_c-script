using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F67 RID: 28519
	public static class IHandBookProgressOptionVerify
	{
		// Token: 0x060315D1 RID: 202193 RVA: 0x006B1EEE File Offset: 0x006B00EE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
