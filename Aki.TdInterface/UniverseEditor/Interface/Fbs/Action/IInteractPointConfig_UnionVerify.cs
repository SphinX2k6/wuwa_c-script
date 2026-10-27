using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069A1 RID: 27041
	public static class IInteractPointConfig_UnionVerify
	{
		// Token: 0x0602F3FA RID: 193530 RVA: 0x0066FAE4 File Offset: 0x0066DCE4
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
