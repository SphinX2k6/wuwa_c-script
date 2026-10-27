using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068B4 RID: 26804
	public static class IGuestOperateUiAnimationTypeVerify
	{
		// Token: 0x0602EC09 RID: 191497 RVA: 0x0065F5CA File Offset: 0x0065D7CA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
