using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079D0 RID: 31184
	public static class ISubPlotModeBase_UnionVerify
	{
		// Token: 0x06036F13 RID: 225043 RVA: 0x007589A4 File Offset: 0x00756BA4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISubPlotModePromptWithProfilePicVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISubPlotModeBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
