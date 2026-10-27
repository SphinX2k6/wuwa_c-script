using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040AB RID: 16555
	public static class IRhythmSpaceshipConditionStepBase_UnionVerify
	{
		// Token: 0x060181D2 RID: 98770 RVA: 0x0037A0C4 File Offset: 0x003782C4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IRhythmSpaceshipConditionStepInteractVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IRhythmSpaceshipConditionStepBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
