using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065A8 RID: 26024
	public static class IDestroySummonedEntitiesType_UnionVerify
	{
		// Token: 0x0602D248 RID: 184904 RVA: 0x00630DA8 File Offset: 0x0062EFA8
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
