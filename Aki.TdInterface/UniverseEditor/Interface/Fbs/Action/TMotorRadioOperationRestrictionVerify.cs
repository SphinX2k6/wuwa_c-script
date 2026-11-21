using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F4D RID: 32589
	public static class TMotorRadioOperationRestrictionVerify
	{
		// Token: 0x0603AC3A RID: 240698 RVA: 0x007E6890 File Offset: 0x007E4A90
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IDisableAllMotorRadioOperationVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IDisableInRangeMotorRadioOperationVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEnableAllMotorRadioOperationVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IEnableInRangeMotorRadioOperationVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
