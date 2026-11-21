using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005201 RID: 20993
	public static class ITrafficMatchTargetType_UnionVerify
	{
		// Token: 0x06021104 RID: 135428 RVA: 0x0049191C File Offset: 0x0048FB1C
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
