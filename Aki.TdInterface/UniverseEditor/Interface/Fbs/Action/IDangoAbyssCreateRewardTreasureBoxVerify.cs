using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B9B RID: 27547
	public static class IDangoAbyssCreateRewardTreasureBoxVerify
	{
		// Token: 0x0602F69E RID: 194206 RVA: 0x00678032 File Offset: 0x00676232
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
