using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047A1 RID: 18337
	public static class IEntityCustomPrimitiveData_CustomDataRowVerify
	{
		// Token: 0x0601C442 RID: 115778 RVA: 0x004005F5 File Offset: 0x003FE7F5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
