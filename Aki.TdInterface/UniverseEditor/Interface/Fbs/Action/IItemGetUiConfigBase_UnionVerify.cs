using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007072 RID: 28786
	public static class IItemGetUiConfigBase_UnionVerify
	{
		// Token: 0x06031EA0 RID: 204448 RVA: 0x006C1614 File Offset: 0x006BF814
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
