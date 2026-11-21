using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200725A RID: 29274
	public static class IMotorParamsChangeConfig_UnionVerify
	{
		// Token: 0x0603300F RID: 208911 RVA: 0x006E2800 File Offset: 0x006E0A00
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IMotorParamsChangeConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMotorSpeedUpConfigVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMotorSpeedDownConfigVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
