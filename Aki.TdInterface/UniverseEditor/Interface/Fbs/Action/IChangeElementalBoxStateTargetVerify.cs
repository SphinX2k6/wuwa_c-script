using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062DA RID: 25306
	public static class IChangeElementalBoxStateTargetVerify
	{
		// Token: 0x0602BBE2 RID: 179170 RVA: 0x00604C16 File Offset: 0x00602E16
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
