using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004586 RID: 17798
	public static class IRollBlockHintStepBase_UnionVerify
	{
		// Token: 0x0601AE22 RID: 110114 RVA: 0x003D630C File Offset: 0x003D450C
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
