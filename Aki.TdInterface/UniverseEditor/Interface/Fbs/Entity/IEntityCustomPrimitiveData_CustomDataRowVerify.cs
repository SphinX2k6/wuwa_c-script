using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C09 RID: 19465
	public static class IEntityCustomPrimitiveData_CustomDataRowVerify
	{
		// Token: 0x0601DC17 RID: 121879 RVA: 0x0042C891 File Offset: 0x0042AA91
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
