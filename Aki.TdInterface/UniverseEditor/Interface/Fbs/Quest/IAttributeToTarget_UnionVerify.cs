using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D27 RID: 15655
	public static class IAttributeToTarget_UnionVerify
	{
		// Token: 0x060159AE RID: 88494 RVA: 0x0031E750 File Offset: 0x0031C950
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IHealthAttributeToTargetVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IAttributeToTargetVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
