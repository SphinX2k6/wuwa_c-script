using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CE4 RID: 19684
	public static class ITargetAttribute_UnionVerify
	{
		// Token: 0x0601F3E1 RID: 127969 RVA: 0x0045C46C File Offset: 0x0045A66C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPlayerAttributeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITargetAttributeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
