using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004334 RID: 17204
	public static class TUseWeatherSwitchConditionVerify
	{
		// Token: 0x0601982C RID: 104492 RVA: 0x003A758C File Offset: 0x003A578C
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
