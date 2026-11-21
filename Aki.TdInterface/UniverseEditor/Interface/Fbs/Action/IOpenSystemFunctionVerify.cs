using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073AB RID: 29611
	public static class IOpenSystemFunctionVerify
	{
		// Token: 0x06033C82 RID: 212098 RVA: 0x006FC1FE File Offset: 0x006FA3FE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
