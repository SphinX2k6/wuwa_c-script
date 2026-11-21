using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A34 RID: 27188
	public static class IClientExecEntityPrefabOptionVerify
	{
		// Token: 0x0602EA34 RID: 191028 RVA: 0x0065BC4A File Offset: 0x00659E4A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
