using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007138 RID: 28984
	public static class ISlashAndTowerGotoNextFloorVerify
	{
		// Token: 0x06033621 RID: 210465 RVA: 0x006ECD2A File Offset: 0x006EAF2A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
