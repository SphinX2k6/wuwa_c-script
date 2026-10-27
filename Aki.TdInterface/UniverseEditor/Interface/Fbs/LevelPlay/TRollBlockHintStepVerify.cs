using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004619 RID: 17945
	public static class TRollBlockHintStepVerify
	{
		// Token: 0x0601B2F8 RID: 111352 RVA: 0x003DF398 File Offset: 0x003DD598
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IRollBlockHintStepJumpVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRollBlockHintStepOperationVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRollBlockHintStepRollVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
