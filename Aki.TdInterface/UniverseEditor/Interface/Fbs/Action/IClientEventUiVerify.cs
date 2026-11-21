using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A25 RID: 27173
	public static class IClientEventUiVerify
	{
		// Token: 0x0602E9D2 RID: 190930 RVA: 0x0065B182 File Offset: 0x00659382
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
