using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005167 RID: 20839
	public static class IEntityBatchType_UnionVerify
	{
		// Token: 0x06021A59 RID: 137817 RVA: 0x004AB56C File Offset: 0x004A976C
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
