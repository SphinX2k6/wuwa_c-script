using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004796 RID: 18326
	public static class TUseWeatherSwitchConditionVerify
	{
		// Token: 0x0601AFBA RID: 110522 RVA: 0x003D2FB4 File Offset: 0x003D11B4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IUseWeatherSwitchConditionSpecifiedWeatherVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IUseWeatherSwitchConditionAnyWeatherVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
