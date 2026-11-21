using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051E6 RID: 20966
	public static class ITargetBuffContainer_UnionVerify
	{
		// Token: 0x06021044 RID: 135236 RVA: 0x00490630 File Offset: 0x0048E830
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IMonsterBuffContainerVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITargetBuffContainerVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
