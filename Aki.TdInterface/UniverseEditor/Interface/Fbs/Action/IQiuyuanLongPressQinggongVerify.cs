using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DDC RID: 28124
	public static class IQiuyuanLongPressQinggongVerify
	{
		// Token: 0x06031ADC RID: 203484 RVA: 0x006BA85A File Offset: 0x006B8A5A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
