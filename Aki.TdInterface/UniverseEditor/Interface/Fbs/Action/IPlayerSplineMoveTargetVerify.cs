using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D13 RID: 27923
	public static class IPlayerSplineMoveTargetVerify
	{
		// Token: 0x060313CF RID: 201679 RVA: 0x006ADAF6 File Offset: 0x006ABCF6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
