using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069C2 RID: 27074
	public static class IItemGetUiConfigBase_UnionVerify
	{
		// Token: 0x0602F4E0 RID: 193760 RVA: 0x006712BC File Offset: 0x0066F4BC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IItemGetUiConfigSpecialQuestVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IItemGetUiConfigBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
