using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007282 RID: 29314
	public static class ISystemFunction_UnionVerify
	{
		// Token: 0x06034024 RID: 213028 RVA: 0x006FE420 File Offset: 0x006FC620
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IBuyGoodsVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISystemFunctionVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
