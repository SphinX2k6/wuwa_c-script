using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F36 RID: 20278
	public static class IBuildingBlockFoundationVerify
	{
		// Token: 0x06020196 RID: 131478 RVA: 0x004773C2 File Offset: 0x004755C2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
