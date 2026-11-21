using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005213 RID: 21011
	public static class IVisibleCondition_UnionVerify
	{
		// Token: 0x0602117C RID: 135548 RVA: 0x004923B4 File Offset: 0x004905B4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IVisibleConditionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IWeatherVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITimePeriodVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IPreQuestVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IPreChildQuestVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IClockVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = ICompareVarVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = ITargetEntityInvisibleVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = ISeasonAndWeatherVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
