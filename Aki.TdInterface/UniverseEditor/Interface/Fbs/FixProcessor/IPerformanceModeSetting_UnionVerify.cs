using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x0200476B RID: 18283
	public static class IPerformanceModeSetting_UnionVerify
	{
		// Token: 0x0601C254 RID: 115284 RVA: 0x003FCA34 File Offset: 0x003FAC34
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
