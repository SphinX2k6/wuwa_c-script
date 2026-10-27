using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B23 RID: 27427
	public static class IMotorParamsChangeConfig_UnionVerify
	{
		// Token: 0x0603023B RID: 197179 RVA: 0x0068B148 File Offset: 0x00689348
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
