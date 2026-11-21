using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007680 RID: 30336
	public static class IRoleTowerGotoNextFloorVerify
	{
		// Token: 0x0603537F RID: 217983 RVA: 0x0072465E File Offset: 0x0072285E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
