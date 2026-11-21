using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F1F RID: 28447
	public static class IGameplayPose2InteractVerify
	{
		// Token: 0x060313AA RID: 201642 RVA: 0x006ABA7E File Offset: 0x006A9C7E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
