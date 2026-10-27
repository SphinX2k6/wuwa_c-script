using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004319 RID: 17177
	public static class TSpecialGamePlayConfigVerify
	{
		// Token: 0x0601979E RID: 104350 RVA: 0x003A67EC File Offset: 0x003A49EC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IEavesdropGamePlayConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFirstPersonTurretGamePlayConfigVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFreezeOnSightGamePlayConfigVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IStalkingGamePlayConfigVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
