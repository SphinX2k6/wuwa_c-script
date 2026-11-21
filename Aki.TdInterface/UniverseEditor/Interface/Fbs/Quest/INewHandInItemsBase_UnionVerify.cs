using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004393 RID: 17299
	public static class INewHandInItemsBase_UnionVerify
	{
		// Token: 0x0601873F RID: 100159 RVA: 0x0037C224 File Offset: 0x0037A424
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || INewHandInItemsProjectionMachineVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = INewHandInItemsBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
