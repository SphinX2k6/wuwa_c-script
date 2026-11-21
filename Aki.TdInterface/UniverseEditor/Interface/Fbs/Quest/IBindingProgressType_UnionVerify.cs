using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200414D RID: 16717
	public static class IBindingProgressType_UnionVerify
	{
		// Token: 0x06016F7E RID: 94078 RVA: 0x00346CF0 File Offset: 0x00344EF0
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
