using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006208 RID: 25096
	public static class IBlendAnimTargetBaseVerify
	{
		// Token: 0x0602B436 RID: 177206 RVA: 0x005F5B86 File Offset: 0x005F3D86
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
