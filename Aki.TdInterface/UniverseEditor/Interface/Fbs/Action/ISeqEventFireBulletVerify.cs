using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F80 RID: 28544
	public static class ISeqEventFireBulletVerify
	{
		// Token: 0x060326E3 RID: 206563 RVA: 0x006CE963 File Offset: 0x006CCB63
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 8UL, 8UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
