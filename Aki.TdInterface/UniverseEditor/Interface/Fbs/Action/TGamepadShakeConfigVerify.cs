using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EED RID: 32493
	public static class TGamepadShakeConfigVerify
	{
		// Token: 0x0603AA08 RID: 240136 RVA: 0x007E30DC File Offset: 0x007E12DC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAttenuatedGamepadShakeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IContinualGamepadShakeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMp4GamepadShakeVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IOnetimeGamepadShakeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
