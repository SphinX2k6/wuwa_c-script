using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061E4 RID: 25060
	public static class IBasePos2Verify
	{
		// Token: 0x0602B320 RID: 176928 RVA: 0x005F3FE6 File Offset: 0x005F21E6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
