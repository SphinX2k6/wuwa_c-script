using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D36 RID: 15670
	public static class IBindingProgressType_UnionVerify
	{
		// Token: 0x06015A46 RID: 88646 RVA: 0x0031FA78 File Offset: 0x0031DC78
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPlayerHavingItemCountVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IBindingProgressTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
