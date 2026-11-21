using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F13 RID: 28435
	public static class IGamepadShakeConfig_UnionVerify
	{
		// Token: 0x06031352 RID: 201554 RVA: 0x006AB04C File Offset: 0x006A924C
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
