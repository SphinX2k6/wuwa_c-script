using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006457 RID: 25687
	public static class IOutAreaBorderEffectTypeVerify
	{
		// Token: 0x0602BA79 RID: 178809 RVA: 0x005F128E File Offset: 0x005EF48E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
