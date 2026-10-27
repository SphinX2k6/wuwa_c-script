using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A52 RID: 27218
	public static class ILongPressInteractStyleSwordRiderVerify
	{
		// Token: 0x0602FA81 RID: 195201 RVA: 0x0067C71A File Offset: 0x0067A91A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
