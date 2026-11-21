using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046C6 RID: 18118
	public static class IUseWeatherSwitchConditionBase_UnionVerify
	{
		// Token: 0x0601AA08 RID: 109064 RVA: 0x003C93EC File Offset: 0x003C75EC
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
