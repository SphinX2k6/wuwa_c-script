using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200776A RID: 30570
	public static class TResetEntityConfigVerify
	{
		// Token: 0x06037863 RID: 227427 RVA: 0x00783AD4 File Offset: 0x00781CD4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IResetTeleControlEntityVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IJigsawItemEntityVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
