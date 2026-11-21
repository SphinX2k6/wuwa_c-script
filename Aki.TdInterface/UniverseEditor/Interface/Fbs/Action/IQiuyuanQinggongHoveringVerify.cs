using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007569 RID: 30057
	public static class IQiuyuanQinggongHoveringVerify
	{
		// Token: 0x06034B44 RID: 215876 RVA: 0x00716812 File Offset: 0x00714A12
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
