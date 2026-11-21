using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200525E RID: 21086
	public static class TVisibleConditionVerify
	{
		// Token: 0x0602132E RID: 135982 RVA: 0x00494DB0 File Offset: 0x00492FB0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IClockVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICompareVarVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPreChildQuestVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IPreQuestVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ISeasonAndWeatherVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ITargetEntityInvisibleVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = ITimePeriodVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IWeatherVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
