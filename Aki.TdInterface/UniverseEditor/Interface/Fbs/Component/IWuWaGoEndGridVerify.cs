using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BA3 RID: 23459
	public static class IWuWaGoEndGridVerify
	{
		// Token: 0x060282B8 RID: 164536 RVA: 0x005854C8 File Offset: 0x005836C8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 2UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
