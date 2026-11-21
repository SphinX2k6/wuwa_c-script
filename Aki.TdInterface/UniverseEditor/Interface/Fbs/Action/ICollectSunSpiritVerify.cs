using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ABE RID: 27326
	public static class ICollectSunSpiritVerify
	{
		// Token: 0x0602EE79 RID: 192121 RVA: 0x00663CBA File Offset: 0x00661EBA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
