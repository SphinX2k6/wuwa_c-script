using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B58 RID: 19288
	public static class ICheckTargetType_UnionVerify
	{
		// Token: 0x0601E606 RID: 124422 RVA: 0x004416D0 File Offset: 0x0043F8D0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IAllPlayerTypeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICheckTargetTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
