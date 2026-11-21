using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A0C RID: 31244
	public static class ISummonEntityType_UnionVerify
	{
		// Token: 0x060370C5 RID: 225477 RVA: 0x0075B770 File Offset: 0x00759970
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
