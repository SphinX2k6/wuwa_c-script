using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200708D RID: 28813
	public static class ILandSlideEndInteractVerify
	{
		// Token: 0x06031FC4 RID: 204740 RVA: 0x006C3ADA File Offset: 0x006C1CDA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
