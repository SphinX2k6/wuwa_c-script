using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A57 RID: 31319
	public static class ISystemFunction_UnionVerify
	{
		// Token: 0x06037326 RID: 226086 RVA: 0x0075F780 File Offset: 0x0075D980
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IBuyGoodsVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISystemFunctionVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
