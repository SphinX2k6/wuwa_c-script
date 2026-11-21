using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056CC RID: 22220
	public static class IEntityBatchType_UnionVerify
	{
		// Token: 0x060239AD RID: 145837 RVA: 0x004E54F8 File Offset: 0x004E36F8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IEntityListBatchVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IEntityBatchTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
