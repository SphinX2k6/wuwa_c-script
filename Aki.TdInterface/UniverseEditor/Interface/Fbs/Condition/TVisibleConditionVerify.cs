using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D62 RID: 19810
	public static class TVisibleConditionVerify
	{
		// Token: 0x0601F6E3 RID: 128739 RVA: 0x00460DA8 File Offset: 0x0045EFA8
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
				result = ITargetEntityInvisibleVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ITimePeriodVerify.Verify(verifier, tablePos);
				break;
			case 7:
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
