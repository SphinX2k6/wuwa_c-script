using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200709C RID: 28828
	public static class ISettlementDungeonVerify
	{
		// Token: 0x060330BA RID: 209082 RVA: 0x006E28AA File Offset: 0x006E0AAA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
