using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007770 RID: 30576
	public static class TResetPosTypeVerify
	{
		// Token: 0x0603787B RID: 227451 RVA: 0x00783CCC File Offset: 0x00781ECC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IResetPosByResetPointVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IResetPosByPosEntityVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
