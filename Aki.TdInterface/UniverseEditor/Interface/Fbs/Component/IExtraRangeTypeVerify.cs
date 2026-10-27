using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005218 RID: 21016
	public static class IExtraRangeTypeVerify
	{
		// Token: 0x0602227B RID: 139899 RVA: 0x004BD1F6 File Offset: 0x004BB3F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
