using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007272 RID: 29298
	public static class IMotorRadioOperationRestriction_UnionVerify
	{
		// Token: 0x060330D1 RID: 209105 RVA: 0x006E3E0C File Offset: 0x006E200C
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
			case 4:
				result = IEnableInRangeMotorRadioOperationVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IDisableInRangeMotorRadioOperationVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
