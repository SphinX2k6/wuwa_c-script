using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A81 RID: 19073
	public static class TRollBlockHintStepVerify
	{
		// Token: 0x0601CACD RID: 117453 RVA: 0x0040B634 File Offset: 0x00409834
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
