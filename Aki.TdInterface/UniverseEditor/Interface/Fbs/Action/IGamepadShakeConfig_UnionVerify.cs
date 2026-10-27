using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006872 RID: 26738
	public static class IGamepadShakeConfig_UnionVerify
	{
		// Token: 0x0602EA18 RID: 191000 RVA: 0x0065BFCC File Offset: 0x0065A1CC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IGamepadShakeConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IOnetimeGamepadShakeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IContinualGamepadShakeVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IAttenuatedGamepadShakeVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IMp4GamepadShakeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
