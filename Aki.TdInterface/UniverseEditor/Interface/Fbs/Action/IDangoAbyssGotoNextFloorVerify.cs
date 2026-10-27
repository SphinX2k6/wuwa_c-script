using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006530 RID: 25904
	public static class IDangoAbyssGotoNextFloorVerify
	{
		// Token: 0x0602CF0D RID: 184077 RVA: 0x0062BC6E File Offset: 0x00629E6E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
