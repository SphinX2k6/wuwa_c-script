using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077F3 RID: 30707
	public static class ISetMotorSpeedType_UnionVerify
	{
		// Token: 0x06035F1C RID: 220956 RVA: 0x00739EBC File Offset: 0x007380BC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISetMotorSpeedTargetSpeedVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISetMotorSpeedTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
