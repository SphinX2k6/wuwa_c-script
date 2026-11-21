using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005234 RID: 21044
	public static class TCheckJigsawInfoVerify
	{
		// Token: 0x06021248 RID: 135752 RVA: 0x004937E0 File Offset: 0x004919E0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICheckJigsawItemPlaceIndexVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICheckJigsawItemMoveVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
