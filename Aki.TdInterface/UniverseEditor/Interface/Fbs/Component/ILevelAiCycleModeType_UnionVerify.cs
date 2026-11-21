using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A58 RID: 23128
	public static class ILevelAiCycleModeType_UnionVerify
	{
		// Token: 0x06025D47 RID: 154951 RVA: 0x0052F624 File Offset: 0x0052D824
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ILevelAiCycleLooplyVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ILevelAiCycleModeTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
