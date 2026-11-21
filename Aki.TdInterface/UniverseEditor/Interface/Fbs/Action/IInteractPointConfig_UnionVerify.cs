using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007054 RID: 28756
	public static class IInteractPointConfig_UnionVerify
	{
		// Token: 0x06031DD6 RID: 204246 RVA: 0x006C01E8 File Offset: 0x006BE3E8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISequenceUnlockPointsVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IInteractPointConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
