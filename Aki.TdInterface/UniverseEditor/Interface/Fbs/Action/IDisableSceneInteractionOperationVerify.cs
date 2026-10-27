using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065F0 RID: 26096
	public static class IDisableSceneInteractionOperationVerify
	{
		// Token: 0x0602D4B6 RID: 185526 RVA: 0x006353B6 File Offset: 0x006335B6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
