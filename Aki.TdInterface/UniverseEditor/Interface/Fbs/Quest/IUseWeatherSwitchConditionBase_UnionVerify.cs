using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200426A RID: 17002
	public static class IUseWeatherSwitchConditionBase_UnionVerify
	{
		// Token: 0x0601929C RID: 103068 RVA: 0x0039DD14 File Offset: 0x0039BF14
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IUseWeatherSwitchConditionBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IUseWeatherSwitchConditionSpecifiedWeatherVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IUseWeatherSwitchConditionAnyWeatherVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
