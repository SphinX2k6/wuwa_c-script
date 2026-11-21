using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BF2 RID: 27634
	public static class IDestroyDynamicEntitiesType_UnionVerify
	{
		// Token: 0x0602F8EA RID: 194794 RVA: 0x0067B7D8 File Offset: 0x006799D8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IDestroyVisionDisplayVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDestroyDynamicEntitiesTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
