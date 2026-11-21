using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004C93 RID: 19603
	public static class IBuffDurationBaseVerify
	{
		// Token: 0x0601E0EF RID: 123119 RVA: 0x0043685A File Offset: 0x00434A5A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
