using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006632 RID: 26162
	public static class IElementalBoxTargetPosTypeBaseVerify
	{
		// Token: 0x0602D6F0 RID: 186096 RVA: 0x00639506 File Offset: 0x00637706
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
