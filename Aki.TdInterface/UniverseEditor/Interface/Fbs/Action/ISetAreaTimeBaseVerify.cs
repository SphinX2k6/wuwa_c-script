using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FA4 RID: 28580
	public static class ISetAreaTimeBaseVerify
	{
		// Token: 0x0603282A RID: 206890 RVA: 0x006D1266 File Offset: 0x006CF466
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
