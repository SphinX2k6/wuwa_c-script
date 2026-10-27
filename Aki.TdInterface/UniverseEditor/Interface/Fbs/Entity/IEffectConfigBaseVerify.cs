using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004786 RID: 18310
	public static class IEffectConfigBaseVerify
	{
		// Token: 0x0601C322 RID: 115490 RVA: 0x003FE23E File Offset: 0x003FC43E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
