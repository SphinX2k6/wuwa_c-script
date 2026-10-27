using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062C8 RID: 25288
	public static class IChangeActorStateVerify
	{
		// Token: 0x0602BB4C RID: 179020 RVA: 0x00603CC1 File Offset: 0x00601EC1
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
