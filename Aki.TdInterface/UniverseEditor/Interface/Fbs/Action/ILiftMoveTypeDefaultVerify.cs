using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070BA RID: 28858
	public static class ILiftMoveTypeDefaultVerify
	{
		// Token: 0x060321C8 RID: 205256 RVA: 0x006C81C6 File Offset: 0x006C63C6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
