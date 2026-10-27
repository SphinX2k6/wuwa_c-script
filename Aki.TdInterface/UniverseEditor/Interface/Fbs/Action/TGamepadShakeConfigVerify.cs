using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076DC RID: 30428
	public static class TGamepadShakeConfigVerify
	{
		// Token: 0x06037547 RID: 226631 RVA: 0x0077ECCC File Offset: 0x0077CECC
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
