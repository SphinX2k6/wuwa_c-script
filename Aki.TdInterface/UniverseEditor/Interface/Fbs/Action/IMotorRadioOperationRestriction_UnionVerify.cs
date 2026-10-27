using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B2C RID: 27436
	public static class IMotorRadioOperationRestriction_UnionVerify
	{
		// Token: 0x0603027C RID: 197244 RVA: 0x0068B924 File Offset: 0x00689B24
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IMotorRadioOperationRestrictionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEnableAllMotorRadioOperationVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IDisableAllMotorRadioOperationVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
