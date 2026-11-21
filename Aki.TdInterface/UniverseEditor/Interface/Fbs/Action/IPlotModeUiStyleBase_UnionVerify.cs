using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074D6 RID: 29910
	public static class IPlotModeUiStyleBase_UnionVerify
	{
		// Token: 0x060346D7 RID: 214743 RVA: 0x0070F248 File Offset: 0x0070D448
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPlotModeUiStyleLevelDVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPlotModeUiStyleBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
