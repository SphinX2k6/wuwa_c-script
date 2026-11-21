using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C03 RID: 19459
	public static class IEntityConfigVerify
	{
		// Token: 0x0601DBE1 RID: 121825 RVA: 0x0042C241 File Offset: 0x0042A441
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
