using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006509 RID: 25865
	public static class ICustomScreenLoadingTypeBase_UnionVerify
	{
		// Token: 0x0602CDE0 RID: 183776 RVA: 0x00629B48 File Offset: 0x00627D48
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICustomScreenLoadingCyberpunkVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICustomScreenLoadingTypeBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
