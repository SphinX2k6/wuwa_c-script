using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060E7 RID: 24807
	public static class ITransportBoxElementalRangeVerify
	{
		// Token: 0x0602A037 RID: 172087 RVA: 0x005BC102 File Offset: 0x005BA302
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
