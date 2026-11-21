using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049EE RID: 18926
	public static class IRollBlockHintStepBase_UnionVerify
	{
		// Token: 0x0601C5F7 RID: 116215 RVA: 0x004025A8 File Offset: 0x004007A8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IRollBlockHintStepBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRollBlockHintStepRollVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRollBlockHintStepJumpVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IRollBlockHintStepOperationVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
