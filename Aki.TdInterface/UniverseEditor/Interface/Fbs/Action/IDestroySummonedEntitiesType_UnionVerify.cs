using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C10 RID: 27664
	public static class IDestroySummonedEntitiesType_UnionVerify
	{
		// Token: 0x0602F9CC RID: 195020 RVA: 0x0067CF6C File Offset: 0x0067B16C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IDestroySummonedVehicleVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDestroySummonedEntitiesTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
