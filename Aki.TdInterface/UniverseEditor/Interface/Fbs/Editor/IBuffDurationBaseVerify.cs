using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200482B RID: 18475
	public static class IBuffDurationBaseVerify
	{
		// Token: 0x0601C8F2 RID: 116978 RVA: 0x00409F0A File Offset: 0x0040810A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
