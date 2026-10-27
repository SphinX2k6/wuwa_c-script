using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ADA RID: 23258
	public static class ITransportBoxElementalRangeVerify
	{
		// Token: 0x06027AAB RID: 162475 RVA: 0x00574C86 File Offset: 0x00572E86
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
