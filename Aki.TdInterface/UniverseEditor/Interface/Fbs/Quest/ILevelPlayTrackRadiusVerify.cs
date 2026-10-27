using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F07 RID: 16135
	public static class ILevelPlayTrackRadiusVerify
	{
		// Token: 0x06016D7D RID: 93565 RVA: 0x0034B40E File Offset: 0x0034960E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
