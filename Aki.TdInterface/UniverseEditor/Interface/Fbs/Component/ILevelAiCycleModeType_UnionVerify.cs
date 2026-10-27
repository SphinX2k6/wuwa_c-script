using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054D2 RID: 21714
	public static class ILevelAiCycleModeType_UnionVerify
	{
		// Token: 0x06023C8F RID: 146575 RVA: 0x004F25B0 File Offset: 0x004F07B0
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
