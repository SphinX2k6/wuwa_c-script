using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F4A RID: 32586
	public static class TMotorRadioDisableRangeVerify
	{
		// Token: 0x0603AC2A RID: 240682 RVA: 0x007E6710 File Offset: 0x007E4910
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IMotorRadioDisableByAbsoluteRangeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMotorRadioDisableByAreaIdVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMotorRadioDisableByRangeEntitiesVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
