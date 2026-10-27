using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200652D RID: 25901
	public static class IDangoAbyssCreateRewardTreasureBoxVerify
	{
		// Token: 0x0602CF00 RID: 184064 RVA: 0x0062BB86 File Offset: 0x00629D86
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
