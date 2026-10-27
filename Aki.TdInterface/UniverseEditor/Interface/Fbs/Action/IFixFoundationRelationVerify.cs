using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067D6 RID: 26582
	public static class IFixFoundationRelationVerify
	{
		// Token: 0x0602E469 RID: 189545 RVA: 0x00651A4E File Offset: 0x0064FC4E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
