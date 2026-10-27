using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007237 RID: 29239
	public static class ISummonEntityType_UnionVerify
	{
		// Token: 0x06033DC3 RID: 212419 RVA: 0x006FA410 File Offset: 0x006F8610
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISummonVehicleVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISummonEntityTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
