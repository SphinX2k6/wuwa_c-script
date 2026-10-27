using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F55 RID: 16213
	public static class INewHandInItemsBase_UnionVerify
	{
		// Token: 0x060170DD RID: 94429 RVA: 0x00352DB0 File Offset: 0x00350FB0
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
