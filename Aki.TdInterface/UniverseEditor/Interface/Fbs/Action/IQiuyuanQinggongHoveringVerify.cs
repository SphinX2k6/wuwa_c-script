using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DEE RID: 28142
	public static class IQiuyuanQinggongHoveringVerify
	{
		// Token: 0x06031B48 RID: 203592 RVA: 0x006BB12A File Offset: 0x006B932A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
