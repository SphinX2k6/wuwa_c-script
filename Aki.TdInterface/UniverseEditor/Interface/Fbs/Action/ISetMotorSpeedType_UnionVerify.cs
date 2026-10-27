using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200702A RID: 28714
	public static class ISetMotorSpeedType_UnionVerify
	{
		// Token: 0x06032CB6 RID: 208054 RVA: 0x006DA278 File Offset: 0x006D8478
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
