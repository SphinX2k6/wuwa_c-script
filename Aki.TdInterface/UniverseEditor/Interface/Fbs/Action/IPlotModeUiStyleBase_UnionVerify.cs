using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D5B RID: 27995
	public static class IPlotModeUiStyleBase_UnionVerify
	{
		// Token: 0x060316DB RID: 202459 RVA: 0x006B3B60 File Offset: 0x006B1D60
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
