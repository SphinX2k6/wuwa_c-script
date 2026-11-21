using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BCB RID: 27595
	public static class IDefaultLookAtTypeVerify
	{
		// Token: 0x0602F80B RID: 194571 RVA: 0x0067A3C2 File Offset: 0x006785C2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
