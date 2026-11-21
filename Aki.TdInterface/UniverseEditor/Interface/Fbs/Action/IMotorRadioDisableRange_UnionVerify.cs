using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200726C RID: 29292
	public static class IMotorRadioDisableRange_UnionVerify
	{
		// Token: 0x060330AD RID: 209069 RVA: 0x006E3AD8 File Offset: 0x006E1CD8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IMotorRadioDisableRangeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMotorRadioDisableByAreaIdVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMotorRadioDisableByAbsoluteRangeVerify.Verify(verifier, tablePos);
				break;
			case 4:
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
