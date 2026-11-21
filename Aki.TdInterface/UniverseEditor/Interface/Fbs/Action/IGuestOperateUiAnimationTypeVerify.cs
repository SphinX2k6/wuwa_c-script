using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F55 RID: 28501
	public static class IGuestOperateUiAnimationTypeVerify
	{
		// Token: 0x06031543 RID: 202051 RVA: 0x006AE64A File Offset: 0x006AC84A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
