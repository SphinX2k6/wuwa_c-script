using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D05 RID: 19717
	public static class ITrafficMatchTargetType_UnionVerify
	{
		// Token: 0x0601F4BF RID: 128191 RVA: 0x0045D9CC File Offset: 0x0045BBCC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITrafficMatchTargetByEntityLogicVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITrafficMatchTargetTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
