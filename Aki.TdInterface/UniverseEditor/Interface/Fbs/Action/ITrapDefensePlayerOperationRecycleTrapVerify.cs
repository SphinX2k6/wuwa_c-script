using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007462 RID: 29794
	public static class ITrapDefensePlayerOperationRecycleTrapVerify
	{
		// Token: 0x06036215 RID: 221717 RVA: 0x0075C3BE File Offset: 0x0075A5BE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
