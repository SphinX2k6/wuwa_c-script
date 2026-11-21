using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007557 RID: 30039
	public static class IQiuyuanLongPressQinggongVerify
	{
		// Token: 0x06034AD8 RID: 215768 RVA: 0x00715F42 File Offset: 0x00714142
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
