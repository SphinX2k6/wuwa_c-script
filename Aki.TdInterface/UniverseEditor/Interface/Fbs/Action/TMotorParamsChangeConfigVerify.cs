using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F47 RID: 32583
	public static class TMotorParamsChangeConfigVerify
	{
		// Token: 0x0603AC1C RID: 240668 RVA: 0x007E65DC File Offset: 0x007E47DC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IMotorSpeedUpConfigVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IMotorSpeedDownConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
