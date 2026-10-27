using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062D7 RID: 25303
	public static class IChangeElementalBoxStatePlayerTargetVerify
	{
		// Token: 0x0602BBD0 RID: 179152 RVA: 0x00604A9E File Offset: 0x00602C9E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
