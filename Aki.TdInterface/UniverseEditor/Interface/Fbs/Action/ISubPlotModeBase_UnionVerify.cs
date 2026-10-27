using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071FB RID: 29179
	public static class ISubPlotModeBase_UnionVerify
	{
		// Token: 0x06033C11 RID: 211985 RVA: 0x006F7644 File Offset: 0x006F5844
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
