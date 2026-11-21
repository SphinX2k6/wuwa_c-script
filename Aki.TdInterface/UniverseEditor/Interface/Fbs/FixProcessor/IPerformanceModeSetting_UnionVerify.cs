using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004BD3 RID: 19411
	public static class IPerformanceModeSetting_UnionVerify
	{
		// Token: 0x0601DA29 RID: 121385 RVA: 0x00428CD0 File Offset: 0x00426ED0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IHighPerformanceModeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPerformanceModeSettingVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
