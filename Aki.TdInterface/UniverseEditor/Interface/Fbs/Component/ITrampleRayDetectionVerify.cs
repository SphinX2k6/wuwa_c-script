using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ACE RID: 23246
	public static class ITrampleRayDetectionVerify
	{
		// Token: 0x06027A4D RID: 162381 RVA: 0x005741AA File Offset: 0x005723AA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
